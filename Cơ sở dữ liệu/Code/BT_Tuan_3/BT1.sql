--1. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update bản ghi để chỉ cho phép nhập giá trị trong khoảng từ 0 đến 10
CREATE TRIGGER Input_Diem on Diem for Insert, Update as
begin 
	declare @toan float, @ly float, @hoa float, @van float
	select @toan = Toan, @ly = Ly, @hoa = Hoa, @van = Van from inserted
	if((@toan not between 0 and 10) or (@ly not between 0 and 10) or (@hoa not between 0 and 10) or (@van not between 0 and 10)) 
		rollback transaction 
end
--2. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động cập nhật điểm trung bình của học sinh khi thêm mới hay cập nhật bảng điểm
--Điểm trung bình= ((Toán +Văn)*2+Lý+Hóa)/6
CREATE TRIGGER DTB_Diem on Diem for Insert, Update as
begin 
	declare @toan float, @ly float, @hoa float, @van float, @mahs nvarchar(5)
	select @mahs = MAHS, @toan = Toan, @ly = Ly, @hoa = Hoa, @van = Van from inserted
	update diem set DTB = round(((@toan + @van) * 2  + @hoa + @ly)/6, 2) where MAHS = @mahs
end
--3. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại học sinh, cách thức xếp loại như sau
-- Nếu Điểm trung bình>=5 là lên lớp, ngược lại là lưu ban
CREATE TRIGGER XL_Diem on Diem for Insert, Update as
begin 
	declare  @toan float, @ly float, @hoa float, @van float,@dtb float, @mahs nvarchar(5)
	select @mahs = MAHS, @toan = Toan, @ly = Ly, @hoa = Hoa, @van = Van from inserted
	update diem set DTB = round(((@toan + @van) * 2  + @hoa + @ly)/6, 2) where MAHS = @mahs
	select @dtb = DTB from Diem where MAHS = @mahs
	if(@dtb >= 5) 
	begin
		update diem set XEPLOAI = N'Lên Lớp' where MAHS = @mahs
	end
	else begin update diem set XEPLOAI = N'Lưu Ban' where MAHS = @mahs end
end
--4. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại học sinh, cách thức xếp loại như sau
--- Xét điểm thấp nhất (DTN) của các 4 môn
--- Nếu DTB>=5 và DTN>=4 là “Lên Lớp”, ngược lại là lưu ban
CREATE TRIGGER XL2_Diem on Diem for Insert, Update as
begin 
	declare  @dtb float, @mahs nvarchar(5), @dnn float
	select @dtb = DTB, @dnn = dnn, @mahs = MAHS from inserted
	if(@dtb >= 5 and @dnn >= 4) 
	begin
		update diem set XEPLOAI = N'Lên Lớp' where MAHS = @mahs
	end
	else begin update diem set XEPLOAI = N'Lưu Ban' where MAHS = @mahs end
end
--5. Viết một trigger xóa tự động bản ghi về điểm học sinh khi xóa dữ liệu học sinh đó trong DSHS
CREATE TRIGGER Xoa_Diem on DSHS for Delete as
begin 
	declare @mahs int
	select @mahs = MAHS from deleted
	delete from Diem where @mahs = MAHS
end
select * from DIEM
delete from DSHS where MAHS = N'00001'
select * from DIEM
--6. Viết nội thủ tục (Stored Procedure) cập nhật phần ghi chú là “Chuyển trường từ ngày 5/9/2016” cho học sinh có mã nhập vào trong bảng danh sách học sinh.
CREATE PROCEDURE ChuyenTruong @mahs nvarchar(5)
AS
begin
	update DSHS set GHICHU = N'Chuyển trường từ ngày 5/9/2016' where MAHS = @mahs
End

exec ChuyenTruong '00008'
select * from Diem
--7. Tạo View báo cáo Kết thúc năm học gồm các thông tin: Mã học sinh, Họ và tên, Ngày sinh, Giới tính, Điểm Toán, Lý, Hóa, Văn, Điểm Trung bình, Xếp loại
create View BaoCao as
	select DSHS.MAHS, HO + '' + TEN as 'HoTen', NGAYSINH, CASE WHEN Nu=1 then N'Nữ' else N'Nam' end as 'GIOITINH', TOAN, LY, HOA, VAN, DTB, DIEM.XEPLOAI
	from DSHS inner join Diem on DSHS.MAHS = Diem.MAHS
select * from BaoCao
--8. Tạo trường điểm thấp nhất trong bảng Điểm, tạo thủ tục cập nhật điểm thấp nhất cho trường này của tất cả các bản ghi đã có (dùng con trỏ)
ALTER TABLE Diem
ADD dnn float;
CREATE PROCEDURE DTN 
AS
begin
	Declare hs cursor for select mahs from DSHS
		Open hs
		Declare @mahs nvarchar(5), @dnn float,  @ly float, @hoa float, @van float
		Fetch next from hs into @mahs
		While (@@fetch_status = 0)
			begin
		
			select @dnn = TOAN, @ly = LY, @hoa = HOA, @van = VAN from diem where MAHS=@mahs
			if @dnn > @van
				set @dnn = @van
			if @dnn > @ly
				set @dnn = @ly
			if @dnn > @hoa
				set @dnn = @hoa
			update Diem set dnn=@dnn where MAHS=@mahs
			Fetch next from hs into @mahs
			end
		Close hs; Deallocate hs
End
exec DTN
select * from diem
--9. Tạo trigger cập nhật điểm thấp nhất mỗi khi insert, update một bản ghi vào bảng điểm.
create trigger DNN on Diem for Insert,Update as
begin
	declare @toan float, @ly float, @hoa float, @van float, @mahs nvarchar(5)
	select @mahs = MAHS, @toan = Toan, @ly = Ly, @hoa = Hoa, @van = Van from inserted
	update diem set dnn = thapnhat
	from (select mahs,
	(case
	when @toan<=@ly and @toan<=@hoa and @toan<=@van then @toan
	when @ly<@toan and @ly<@hoa and @ly<@van then @ly
	when @hoa<@toan and @hoa<@ly and @hoa<@van then @hoa
	else @van
	end) as thapnhat from DIEM where MAHS = @mahs
	) bangA
	where Diem.MAHS=bangA.mahs 
end 
--10. Tạo View danh sách HOC SINH XUAT SAC bao gồm các học sinh có DTB>=8.5 và DTN>=8 với các trường: Lop, Mahs, Hoten, Namsinh (năm sinh), Nu, Toan, Ly, Hoa, Van, DTN, DTB (không dùng trường thấp nhất đã làm ở câu 7)
create view HS_XuatXac as
	select MALOP, DSHS.MAHS, HO + '' + TEN as 'HoTen', YEAR(NGAYSINH) as 'NamSinh', CASE WHEN Nu=1 then N'Nữ' else N'Nam' end as 'GIOITINH', TOAN, LY, HOA, VAN, case
	when TOAN<=LY and TOAN<=HOA and TOAN<=VAN then TOAN
	when LY<TOAN and LY<HOA and LY<VAN then LY
	when HOA<TOAN and HOA<LY and HOA<VAN then HOA
	else VAN
	end as DTN, round(((TOAN + VAN) * 2 + LY + HOA)/6, 2) as DTB
	from DSHS inner join DIEM on DSHS.MAHS = DIEm.MAHS
	select * from HS_XuatXac
--11. Tạo View danh sách HOC SINH DAT THU KHOA KY THI bao gồm các học sinh xuất sắc có DTB lớn nhất với các trường: Lop, Mahs, Hoten, Namsinh, Nu, Toan, Ly, Hoa, Van, DTB
create view ThuKhoa as
	select  MALOP, DSHS.MAHS, HO + '' + TEN as 'HoTen', YEAR(NGAYSINH) as 'NamSinh', CASE WHEN Nu=1 then N'Nữ' else N'Nam' end as 'GIOITINH', TOAN, LY, HOA, VAN, round(((TOAN + VAN) * 2 + LY + HOA)/6, 2) as DTB
	from DSHS inner join DIEM on DSHS.MAHS = DIEM.MAHS
	where DIEM.MAHS = all(select Top 1 MAHS from DIEM order by round(((TOAN + VAN) * 2 + LY + HOA)/6, 2) desc)
select * from ThuKhoa