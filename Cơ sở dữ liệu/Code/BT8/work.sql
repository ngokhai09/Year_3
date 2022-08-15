--1. Tạo hàm đầu vào là chức vụ đầu ra là những nhân viên cùng chức vụ đó
create function Find(@tenCV nvarchar(3)) returns table as
	return(
		select tNhanVien.MaNV, HO + ' ' + Ten as TenNV, iif(phai = 1, N'Nữ', N'Nam') as GioiTinh, NTNS, NgayBD, MaPB, ChucVu
		from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV 
		where ChucVu = @tenCV
	)
select * from Find(N'NV')
--2. Tạo báo cáo bảng Phụ cấp, trợ cấp cho nhân viên gồm có các trường sau:
--MaNV, Ho, Ten, ChucVu, ThamNien, Luong, TroCap, PhuCapTN.
--Trong đó:
--ThâmNiên là số năm làm việc của nhân niên trong công ty, được tính dựa và ngày bắt đầu
--làm việc (NgayBD).
--Lương là hệ số lương (HSLuong) nhân 250000.
--TrợCấp là 150000 cho các nhân viên có ngày sinh trước ngày 30/4/75.
--PhụCấpTN (phụ cấp thâm niên): chỉ được tính cho các nhân viên có thâm niên không dưới 5
--năm, và cứ mỗi năm thâm niên sau 5 năm được tính 50000 (ví dụ: ThamNien=5 có
--PhuCapTN=50000, 6 năm – 100000, 7 năm – 150000, 8 năm – 200000 v.v…)
select tNhanVien.MaNV,Ho,Ten,NTNS,ChucVu,year(getdate())-year(NgayBD) as ThamNien,HSLuong*250000 as Luong,
case 
when year(NTNS)<=1975 and month(NTNS)<=4 and day(NTNS)<30 then 1500000 else 0
end as TroCap,
case 
when year(getdate())-year(NgayBD)=5 then 50000
when year(getdate())-year(NgayBD)>5 then (year(getdate())-year(NgayBD)-5)*50000
end as PhuCapTN into PHUCAPTROCAP
from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV
select * from PHUCAPTROCAP
--3. Tạo hàm với đầu vào là năm, đầu ra là số nhân viên sinh vào năm đó
create function cnt(@year int) returns int as
begin
	declare @cnt int
	select @cnt = count(MaNV) from tNhanVien where Year(NTNS) = @year
	return @cnt
end
print dbo.cnt(1966)
--4. Tạo hàm với đầu vào là số thâm niên đầu ra là danh sách nhân viên có thâm niên đó
create function ThamNien(@tl int) returns table as return(
select MaNV, HO+' '+TEN as HoTen, iif(Phai = 'False', N'Nam', N'Nữ')as Phai, NTNS,
DATEDIFF(Year, NgayBD, GetDate()) as ThamLien, MaPB, HINH, GHICHU
from tNhanVien where @tl =DATEDIFF(Year, NgayBD, GetDate())
)
select * from ThamNien(31)
--5. Tạo hàm đưa ra thông tin về nhân viên được tăng lương của ngày hôm nay (giả sử 3 năm lên lương 1 lần)
create function nv() returns table as
return(
	select * from tNhanVien where datediff(Year, NgayBD, GETDATE())%3 = 0 and Month(NgayBD) = Month(GETDATE()) and Day(NgayBD) = Day(GETDATE())
)
select * from nv()
--6. Tạo thủ tục nhập đồng thời nhân viên và chi tiết nhân viên (dùng transaction).
create procedure Nhap @manv nvarchar(10), @ho nvarchar(30), @ten nvarchar(20),@phai bit, @ntns date, @ngaybd date,@mapb nvarchar(5), @hinh image,@ghichu nvarchar(MAX), @chucvu nvarchar(5), @hsluong int, @md nvarchar(6)
as
BEGIN
	BEGIN TRAN;
		BEGIN TRY
			insert into tNhanVien values (@manv, @ho, @ten, @phai,
			@ntns,@ngaybd,@mapb, @hinh, @ghichu)
			INSERT INTO tChiTietNhanVien values(@manv, @chucvu, @hsluong, @md,
			DATEDIFF(YEAR,@ngaybd,GETDATE()))
			COMMIT TRAN;
		END TRY
	BEGIN CATCH
		PRINT 'Error: ' + ERROR_MESSAGE();
		ROLLBACK TRAN;
	END CATCH;
END;
select * from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV where tNhanVien.MaNV = '061'
exec Nhap '061', N'Ngô Văn', N'Khải', 1, '2001-09-22', '2018-05-02','VP', null,'Hello','NV',11, 'C1'
select * from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV where tNhanVien.MaNV = '061'
--7. Thêm trường ThamNien vào bảng chi tiết nhân viên. Tạo thủ tục tính thâm niên cho nhân viên và cập nhật vào trường ThamNien. (ThamNien=năm hiện tại – năm vào).
alter table tChiTietNhanVien add ThamNien int
create procedure Tinh_ThamNien as begin
	update tChiTietNhanVien set ThamNien = datediff(YEAR,NgayBD, GETDATE()) from tChiTietNhanVien inner join tNhanVien on tChiTietNhanVien.MaNV = tNhanVien.MaNV
end
exec Tinh_ThamNien
select * from tChiTietNhanVien
--8. Tạo thủ tục tính nhân viên mỗi phòng ban, số nhân viên nam, số nhân viên nữ với mã phòng ban là tham số đầu vào.
create procedure cnt2 @maPB nvarchar(2), @slnv int out, @slnam int out, @slnu int out as
begin
	select @slnv = count(MaNV) from tNhanVien where @maPB = MaPB
	select @slnam = count(MaNV) from tNhanVien where phai = 0 and @maPB = MaPB
	select @slnu = count(MaNV) from tNhanVien where phai = 1 and @maPB = MaPB
end
declare @nv int, @nam int, @nu int
exec cnt2 N'VP', @nv out, @nam out, @nu out
print @nv
print @nam
print @nu