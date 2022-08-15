--1.Tạo hàm lấy danh sách nhân viên theo quê quán
create function DsNhanVien(@Que nvarchar(max)) 
	returns table
as
	return(
		select MaNV, HoTen from NHANVIEN 
		where QueQuan like N'%' + @Que + N'%'
		)
select * from DsNhanVien(N'Hà Nội')
select * from NHANVIEN
--2.Tạo hàm lấy danh sách hóa đơn theo nhân viên và ngày (ngày/tháng/năm)
create function DsHoaDon(@MaNV nvarchar(max), @Ngay datetime) 
	returns table
as
	return(
			select * from HOADON
			where MaNV = @MaNV and NgayLap = @Ngay
		)
create function DSNVTN(@MNV nvarchar(50), @ngay datetime)
returns  table
as 
    return (
        select MaHD, MaNV, NgayLap
        from HOADON
        where    MaNV = @MNV    and NgayLap = @ngay
        )
select *from DSNVTN('0001','20150318')
select *from HOADON
select * from DsHoaDon('0004', '2015-04-02')
select * from HOADON
--3.Tạo hàm tính tổng tiền của từng hóa đơn với mã hóa đơn là tham số đầu vào
create function TongTien(@MaHD nvarchar(50))
	returns int
as
begin
	declare @TongTien int
	select @TongTien = sum(CT_HOADON.SL * HANGHOA.GiaBan)
	from CT_HOADON inner join HANGHOA on HANGHOA.MaHH = CT_HOADON.MaHH
	where HANGHOA.MaHH = @MaHD
	group by HANGHOA.MaHH
	return @TongTien
end



select dbo.TongTien('0002')
select * from HOADON
--4.Tạo hàm lấy danh sách nhà cung cấp theo mã hàng
create function DsNCC(@MaHH nvarchar(50)) 
	returns table
as
	return(
			select NHACUNGCAP.MaNCC, TenNCC 
			from PHIEUNHAP inner join CT_PHIEUNHAP on PHIEUNHAP.MaPN = CT_PHIEUNHAP.MaPN inner join NHACUNGCAP on PHIEUNHAP.MaNCC = NHACUNGCAP.MaNCC
			where @MaHH = MaHH
		)
select * from DsNCC(N'0001')
select * from HANGHOA
--5.Tạo hàm lấy danh sách các mặt hàng theo mã nhà cung cấp
create function DsMatHang(@MaNCC nvarchar(50)) 
	returns table
as
	return(
			select HANGHOA.MaHH, TenHH
			from PHIEUNHAP inner join CT_PHIEUNHAP on PHIEUNHAP.MaPN = CT_PHIEUNHAP.MaPN inner join HANGHOA on CT_PHIEUNHAP.MaHH = HANGHOA.MaHH
			where @MaNCC = MaNCC
		)
select * from DsMatHang(N'0004')
select * from HOADON
--6.Cho danh sách các khách hàng ở một quận nào đó
create function DsKhachHang(@DiaChi nvarchar(max)) 
	returns table
as
	return(
		select MaKH, TenKH from KHACHHANG 
		where DiaChi like N'%' + @DiaChi + N'%'
		)
select * from DsKhachHang(N'Cầu Giấy')
select * from KHACHHANG