--1. Tạo thủ tục chèn là các thông tin hóa đơn và chi tiết hóa đơn (giả sử chỉ tiết hóa đơn được
--lấy từ một bảng tạm), hãy đảm bảo việc cập nhật là đồng thời thành công hoặc không thành công (transaction)
create table #temp(
	MaHD nvarchar(5),
	MaSP tinyint,
	SoLuong tinyint,
	GiaBan money)
CREATE PROC NhapHD @MaHD nvarchar(5), @MaKH nvarchar(10), @MaNV int, @NgayLap datetime, @NgayGiao datetime
as
BEGIN
	 BEGIN TRAN;
		BEGIN TRY
			insert into tblHoaDon(MaHD, MaKH, MaNV, NgayLapHD, NgayGiaoHang) values (@MaHD, @MaKH, @MaNV, @NgayLap, @NgayGiao)
			INSERT INTO tblchitiethoadon(MaHD, MaSP, SoLuong, GiaBan) select MaHD, MaSP, SoLuong, GiaBan from #temp where MaHD=@MaHD
			COMMIT TRAN;
		END TRY
	BEGIN CATCH
		PRINT 'Error: ' + ERROR_MESSAGE();
		ROLLBACK TRAN;
	END CATCH;
	delete from #temp where MaHD=@MaHD
END;

select * from tblChiTietHoaDon
select * from tblKhachHang
select * from #temp
INSERT INTO #temp(MaHD, MaSP, SoLuong, GiaBan) values ('10144',1,30,30), ('10144',2,50,60), ('10144',3,60,70), ('10144',4,70,50)

exec NhapHD '10144','AGROMAS', 2, '2021-08-11', '2021-08-13'

select * from tblhoadon where MaHD='10144'
select * from tblChiTietHoaDon where MaHD='10144'
--2. Tạo thủ tục có đầu vào là số hóa đơn, đầu ra là số tiền cần thanh toán
create procedure TongTien @MaHD nvarchar(5), @tongtien money out as
begin
	select @tongtien = Sum(GiaBan * SoLuong) from tblChiTietHoaDon group by MaHD having MaHD = @MaHD
end

declare @tongtien money
exec TongTien N'10144', @tongtien out
print @tongtien
--3. Tạo view QUA TANG gồm có các field sau:
--MaHD, MaKH, NgayLapHD, TenSp, Soluong, Giaban, ThanhTien, Giamgia, Quatang.
--Trong đó: ThànhTiền là Số lượng nhân giá bán. Giảmgiá là 10% của ThànhTiền nếu thành  tiền của sản phẩm không dưới 500 và Soluong sản phẩm bán phải từ 35 trở lên. 
--Quà tặng được tính như sau: nếu thành tiền ít hơn 1000 thì không được vé nào, từ 1000 đến <2000 được 1 vé ca nhạc, 
--từ 2000 đến <3000 được 2 vé ca nhạc, v.v… (ví dụ: nếu thànhtiền = 4000 thì Quà tặng là 4 vé ca nhạc). Sắp xếp theo MaHD theo thứ tự tăng dần.
alter view QuaTang as
	select top 10000 tblHoaDon.MaHD, MaKH, NgayLapHD, TenSP, SoLuong, SoLuong * GiaBan as ThanhTien,
		 iif(SoLuong * GiaBan >= 500 and SoLuong >= 35 , 0.1 * (SoLuong*GiaBan), 0)  as GiamGia, 
			cast((SoLuong * GiaBan)/1000 as int) as QuaTang
	from tblChiTietHoaDon inner join tblHoaDon on tblChiTietHoaDon.MaHD = tblHoaDon.MaHD inner join tblSanPham on tblSanPham.MaSP = tblChiTietHoaDon.MaSP
	order by tblChiTietHoaDon.MaHD asc
select * from QuaTang;
--4. Thêm trường TongSLBan (tổng số lượng bán) và bảng sản phẩm. Tạo trigger cập nhật dữ liệu tổng số sản phẩm đã bán cho trường này mỗi khi thêm, sửa, xóa một chi tiết hóa đơn.
alter table tblSanPham add TongSLBan int
create trigger SLBan on tblChiTietHoaDon for insert, update,delete as
begin
	update tblSanPham set TongSLBan = isnull(TongSLBan, 0) + (select SoLuong from inserted where MaSP = tblSanPham.MaSP) from inserted where tblSanPham.MaSP =  inserted.MaSP
	update tblSanPham set TongSLBan = isnull(TongSLBan, 0) - (select SoLuong from deleted where MaSP = tblSanPham.MaSP) from deleted where tblSanPham.MaSP =  deleted.MaSP 
end
select * from tblChiTietHoaDon where masp=5
select * from tblSanPham where masp=5
delete from tblChiTietHoaDon where masp=5 and MaHD='10150'
INSERT INTO tblChiTietHoaDon(MaHD, MaSP, SoLuong, GiaBan) values ('10150',5,15,10)

--5. Lập view tính doanh thu theo tháng của năm 2021
create view DoanhThu as
	select
	ISNULL(sum(case Month(NgayLapHD) when 1 then (SoLuong * GiaBan) end), 0) as Thang1,
	ISNULL(sum(case Month(NgayLapHD) when 2 then (SoLuong * GiaBan) end), 0) as Thang2,
	ISNULL(sum(case Month(NgayLapHD) when 3 then (SoLuong * GiaBan) end), 0) as Thang3,
	ISNULL(sum(case Month(NgayLapHD) when 4 then (SoLuong * GiaBan) end), 0) as Thang4,
	ISNULL(sum(case Month(NgayLapHD) when 5 then (SoLuong * GiaBan) end), 0) as Thang5,
	ISNULL(sum(case Month(NgayLapHD) when 6 then (SoLuong * GiaBan) end), 0) as Thang6,
	ISNULL(sum(case Month(NgayLapHD) when 7 then (SoLuong * GiaBan) end), 0) as Thang7,
	ISNULL(sum(case Month(NgayLapHD) when 8 then (SoLuong * GiaBan) end), 0) as Thang8,
	ISNULL(sum(case Month(NgayLapHD) when 9 then (SoLuong * GiaBan) end), 0) as Thang9,
	ISNULL(sum(case Month(NgayLapHD) when 10 then (SoLuong * GiaBan) end), 0) as Thang10,
	ISNULL(sum(case Month(NgayLapHD) when 11 then (SoLuong * GiaBan) end), 0) as Thang11,
	ISNULL(sum(case Month(NgayLapHD) when 12 then (SoLuong * GiaBan) end), 0) as Thang12
	from tblHoaDon inner join tblChiTietHoaDon on tblHoaDon.MaHD = tblChiTietHoaDon.MaHD
	where YEAR(NgayLapHD) = 2021
select * from DoanhTHu
--6. Tạo thủ tục với đầu vào là ngày, đầu ra là số lượng hóa đơn, doanh thu của ngày đó
create procedure Xuat @ngay datetime, @sl int out, @doanhthu money out as
begin
	select @sl =  count(distinct tblHoaDon.MaHD), @doanhthu = Sum(SoLuong * GiaBan)
	from tblChiTietHoaDon inner join tblHoaDon on tblChiTietHoaDon.MaHD = tblHoaDon.MaHD
	where NgayLapHD = @ngay
	group by tblHoaDon.MaHD
end
declare @sl int, @doanhthu money
exec Xuat '1997-02-05', @sl out, @doanhthu out
print @sl
print @doanhthu
--7. Tạo hàm có đầu vào là mã hóa đơn, đầu ra là thông tin toàn bộ hóa đơn như chi tiết hóa đơn, thành tiền
alter function HoaDon(@MaHD nvarchar(5)) returns table as return(
	select *, (SoLuong * GiaBan) as ThanhTien from tblChiTietHoaDon  where MaHD = @MaHD
)
select * from HoaDon(N'10144')
--8. Tạo hàm có đầu vào là tỉnh, đầu ra là số nhân viên của tỉnh đó
alter function TP(@tinh nvarchar(20)) returns int as 
begin
	declare @sl int
	select @sl = count(MaNV) from tblNhanVien where DiaChi like N'%' + @tinh + '%'
	return @sl
end

print dbo.TP(N'Q5')
--9. Tạo thủ tục xóa các hóa đơn mà không có chi tiết hóa đơn
create procedure Xoa as 
begin
	delete from tblHoaDon where MaHD not in (select distinct MaHD from tblChiTietHoaDon)
end
exec Xoa
--10. Thêm trường TriGiaHD (trị giá hóa đơn) vào bảng Hóa đơn. Tạo trigger cập nhật dữ liệu cho trường này mỗi khi thêm, sửa, xóa một chi tiết hóa đơn.
alter table tblHoaDon add TriGiaHD money
alter trigger Up on tblChiTietHoaDon for insert, update, delete as
begin
	declare @mahd_insert nvarchar(5), @mahd_delete nvarchar(5)
	select @mahd_insert = MaHD from inserted
	select @mahd_delete = MaHD from deleted
	if @mahd_insert is not null
	begin
		update tblHoaDon set TriGiaHD = (select Sum(SoLuong * GiaBan) from tblChiTietHoaDon where MaHD = @mahd_insert group by MaHD) where MaHD = @mahd_insert
	end
	if(@mahd_delete is not null)
	begin
		if not exists(select MaHD from tblChiTietHoaDon where MaHD = @mahd_delete)
		begin
			delete from tblHoaDon where MaHD = @mahd_delete
		end
		else
		begin
			update tblHoaDon set TriGiaHD = (select Sum(SoLuong * GiaBan) from tblChiTietHoaDon where MaHD = @mahd_delete group by MaHD) where MaHD = @mahd_delete
		end
	end
end
select * from tblHoaDon where MaHD = '10144'
delete from tblChiTietHoaDon where MaHD = '10144'
select * from tblHoaDon where MaHD = '10144'