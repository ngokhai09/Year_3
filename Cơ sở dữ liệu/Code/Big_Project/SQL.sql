--View
--1.Tạo view hiển thị doanh số bán hàng từng tháng của năm 2021
create view DoanhThu as
	select
	ISNULL(sum(case Month(NgayBan) when 1 then (SoLuong * GiaNiemYet) end), 0) as Thang1,
	ISNULL(sum(case Month(NgayBan) when 2 then (SoLuong * GiaNiemYet) end), 0) as Thang2,
	ISNULL(sum(case Month(NgayBan) when 3 then (SoLuong * GiaNiemYet) end), 0) as Thang3,
	ISNULL(sum(case Month(NgayBan) when 4 then (SoLuong * GiaNiemYet) end), 0) as Thang4,
	ISNULL(sum(case Month(NgayBan) when 5 then (SoLuong * GiaNiemYet) end), 0) as Thang5,
	ISNULL(sum(case Month(NgayBan) when 6 then (SoLuong * GiaNiemYet) end), 0) as Thang6,
	ISNULL(sum(case Month(NgayBan) when 7 then (SoLuong * GiaNiemYet) end), 0) as Thang7,
	ISNULL(sum(case Month(NgayBan) when 8 then (SoLuong * GiaNiemYet) end), 0) as Thang8,
	ISNULL(sum(case Month(NgayBan) when 9 then (SoLuong * GiaNiemYet) end), 0) as Thang9,
	ISNULL(sum(case Month(NgayBan) when 10 then (SoLuong * GiaNiemYet) end), 0) as Thang10,
	ISNULL(sum(case Month(NgayBan) when 11 then (SoLuong * GiaNiemYet) end), 0) as Thang11,
	ISNULL(sum(case Month(NgayBan) when 12 then (SoLuong * GiaNiemYet) end), 0) as Thang12
	from HOADON inner join CHITIETHOADON on HOADON.MaHoaDon = CHITIETHOADON.MaHoaDon inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa
	where YEAR(NgayBan) = 2021
select * from DoanhTHu
--2. Tạo view hiển thị doanh số bán hàng của từng nhân viên
create view DoanhSo as
	select NHANVIEN.MaNV, Ten, Sum(SoLuong * GiaNiemYet) as DoanhSo
	from NHANVIEN inner join HOADON on NHANVIEN.MaNV = HOADON.MaNV inner join CHITIETHOADON on CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon inner join HANGHOA on HANGHOA.MaHangHoa = CHITIETHOADON.MaHangHoa
	group by NHANVIEN.MaNV, Ten
select * from DoanhSo
--3. Tạo view hiển thị MaNV, TeenNV, CHức vụ, Lương theo tháng,(Lương = 3000000 * hsl) 
create view Luong as
	select NHANVIEN.MaNV, Ten, (HSL * 3000000) as Luong
	from NHANVIEN inner join CT_CHUCVU on NHANVIEN.MaNV = CT_CHUCVU.MaNV inner join CHUCVU on CHUCVU.MaCV = CT_CHUCVU.MaCV
	where NgayKetThuc is null or NgayKetThuc < GETDATE()

select * from Luong
--4. tạo view hiển thị Mã hàng hóa, tên mặt hàng, số lượng mặt hàng đã bán
create view ThongKe as
	select HANGHOA.MaHangHoa, TenHang, Sum(SoLuong) as DaBan
	from HANGHOA inner join CHITIETHOADON on HANGHOA.MaHangHoa = CHITIETHOADON.MaHangHoa
	group by HANGHOA.MaHangHoa, TenHang
select * from ThongKe
--5. tạo view hiển thị thông tin các hóa đơn trong tháng 10 năm 2021
create view DanhSachHoaDon as 
	select * from HOADON where Year(NgayBan) = 2021 and Month(NgayBan) = 10
--6. tạo view hiển thị Mã nv, tên nv, quê quán ở Hà nội
create view DanhSachNhanVien
	select MaNV, Ten, DiaChi
	from NHANVIEN where DiaChi like N'%Hà Nội%'
--7. tạo view hiển thị khách hàng vip
create view VIP as
 select MaKH, HoTen, TenLoai
 from KHACHHANG inner join LOAIKHACHHANG on KHACHHANG.MaLoaiKH = LOAIKHACHHANG.MaLoaiKH
 where TenLoai = N'VIP'
--8.Tạo view hiển thị danh sách mặt hàng của nhà cung cấp 'Công ty CocaCola'
create view DanhSachHangHoa as
	select HANGHOA.MaHangHoa, TenHang, TenNCC
	from HANGHOA inner join CT_PHIEUNHAPHANG on HANGHOA.MaHangHoa = CT_PHIEUNHAPHANG.MaHangHoa inner join PHIEUNHAPHANG on CT_PHIEUNHAPHANG.MaPhieu = PHIEUNHAPHANG.MaPhieu inner join NHACUNGCAP on NHACUNGCAP.MaNCC = PHIEUNHAPHANG.MaNCC
	where TenNCC = N'Công ty CocaCola'
--Trigger
--1. Viết một Trigger gắn với bảng CHITIETHOADON dựa trên sự kiện Insert, Update để tự động cập nhật ThanhTien
create trigger ThanhTienCTHD on CHITIETHOADON for insert, update as
begin 
	declare @MaHoaDon nvarchar(20)
	select @MaHoaDon = MaHoaDon from inserted
	update CHITIETHOADON set ThanhTien = (SoLuong * GiaNiemYet) from CHITIETHOADON inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa
	where MaHoaDon = @MaHoaDon
end
--2. Tạo trigger tự động cập nhật tổng tiền của Hóa đơn khi insert, update, delete CHITIETHOADON
create trigger TongtienHD on CHITIETHOADON for insert, update, delete as
begin
	declare @maHD_in nvarchar(20), @maHD_del nvarchar(20)
	select @maHD_in = MaHoaDon from inserted
	select @maHD_del = MaHoaDon from deleted
	if @maHD_in is not null
	begin
		update HOADON set TongTien = (select Sum(SoLuong * GiaNiemYet) as ThanhTien from CHITIETHOADON inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa where MaHoaDon = @maHD_in group by MaHoaDon)
		where MaHoaDon = @maHD_in
	end
	if @maHD_del is not null
	begin
		if not exists (select MaHoaDon from CHITIETHOADON where MaHoaDon = @maHD_del)
		begin
			delete from HOADON where MaHoaDon = @maHD_del
		end
		else begin
			update HOADON set TongTien = (select Sum(SoLuong * GiaNiemYet) as ThanhTien from CHITIETHOADON inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa where MaHoaDon = @maHD_del group by MaHoaDon)
		where MaHoaDon = @maHD_del
		end
	end
end
--3. Tạo trigger tự động xóa CHITIETHOADON khi delete 1 HÓA đơn
alter trigger DelChiTietHoaDon on HOADON instead of delete as
begin
	declare @mahd nvarchar(20)
	select @mahd = MaHoaDon from deleted
	delete from CHITIETHOADON where MaHoaDon = @mahd
	delete from HOADON where MaHoaDon = @mahd
end

--4. tạo trigger tự động xóa hóa đơn khi xóa khách hàng
create trigger DelKhachHang on KHACHHANG instead of delete as
begin
	declare @makh nvarchar(20)
	select @makh = MaKH from deleted
	delete from HOADON where MaKH = @makh
	delete from KHACHHANG where MaKH = @makh
end
--5. thêm trường DonGiaBan vào bảng chitiethoadon, cập nhật trường này mỗi khi insert dữ liệu
alter table CHITIETHOADON add DonGiaBan money
create trigger AddDonGiaBan on CHITIETHOADON for insert as
begin
	declare @maCTHD nvarchar(20)
	select @maCTHD = MaCTHD from inserted
	if @maCTHD is not null
	begin
		update CHITIETHOADON set DonGiaBan = (select GiaNiemYet from HANGHOA inner join CHITIETHOADON on HANGHOA.MaHangHoa = CHITIETHOADON.MaHangHoa where @maCTHD = MaCTHD) where @maCTHD = MaCTHD
	end
end		
--6. Thêm trường số lượng tồn kho vào bảng hàng hóa. cập nhật trường này mỗi khi insert, update , delete ChiTietHoaDon
alter table HANGHOA add SLTon int
alter trigger SLTon1 on CHITIETHOADON for insert, update, delete as
begin
	declare @maHH_in nvarchar(20),@maHH_del nvarchar(20), @sl_in int, @sl_del int
	select @maHH_in = MaHangHoa, @sl_in = SoLuong from inserted
	select @maHH_del = MaHangHoa, @sl_del = SoLuong from deleted
	update HANGHOA set SLTon = isnull(SLTon, 0) - (isnull(@sl_in, 0) - isnull(@sl_del,0)) where MaHangHoa = @maHH_in or MaHangHoa = @maHH_del
end
--7. Thêm trường số lượng tồn kho vào bảng hàng hóa. cập nhật trường này mỗi khi insert, update , delete CT_PhieuNhap
create trigger SLTon2 on CT_PHIEUNHAPHANG for insert, update, delete as
begin
	declare @maHH_in nvarchar(20),@maHH_del nvarchar(20), @sl_in int, @sl_del int
	select @maHH_in = MaHangHoa, @sl_in = SoLuong from inserted
	select @maHH_del = MaHangHoa, @sl_del = SoLuong from deleted
	update HANGHOA set SLTon = isnull(SLTon, 0) + (isnull(@sl_in, 0) - isnull(@sl_del,0)) where MaHangHoa = @maHH_in or MaHangHoa = @maHH_del
end

--Procedure
--1. Tạo thủ tục xóa hóa đơn mà không có chi tiết hóa đơn
create procedure DelHoaDon as
begin
	delete from HOADON where MaHoaDon not in (select distinct MaHoaDon from CHITIETHOADON)
end

--2. Tạo thủ tục thăng chức lên quản lý cho nhân viên đã làm việc từ ngày 01/09/2020 đổ về trước
create procedure ThangChuc as
begin
	update CT_ChucVu set MaCV = (select MaCV from CHUCVU where TenCV = N'Quản Lý')
end
--3.Tạo thủ tục có đầu vào là số hóa đơn, đầu ra là số tiền cần thanh toán
create procedure TongTienThanhToan @maHD nvarchar(20), @TongTien money out as
begin
	select @TongTien = Sum(SoLuong * GiaNiemYet) from CHITIETHOADON inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa where MaHoaDon = @maHD group by MaHoaDon
end
--4.Tạo thủ tục với đầu vào là ngày, đầu ra là số lượng hóa đơn, doanh thu của ngày đó
create procedure DoanhThu @ngay datetime, @SLHoaDon int out, @DoanhThu money out as
begin
	select @SLHoaDon = Count(HOADON.MaHoaDon), @DoanhThu = Sum(SoLuong * GiaNiemYet) from CHITIETHOADON inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa inner join HOADON on CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon
	where NgayBan = @ngay 
	group by HOADON.MaHoaDon
end
--5.Tạo thủ tục cập nhật tổng tiền , và điểm tích lũyđã tiêu với mỗi khách hàng
create procedure UpdateKhachHang as
begin
	update KHACHHANG set TongTienDaTieu = Tien from		
											(select MaKH, Sum(SoLuong * GiaNiemYet) as Tien 
											from CHITIETHOADON inner join HANGHOA on CHITIETHOADON.MaHangHoa = HANGHOA.MaHangHoa inner join HOADON on CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon 
											group by MaKH)bangA 
	where bangA.MaKH = KHACHHANG.MaKH
end
--6.Tạo thủ tục đầu vào là nhà cung cấp đầu ra là số lượng mặt hàng của nhà cc đó
create procedure SLMatHang @MaNCC nvarchar(20), @SL int out as
begin
	select count(MaHangHoa) from NHACUNGCAP inner join PHIEUNHAPHANG on NHACUNGCAP.MaNCC = PHIEUNHAPHANG.MaNCC inner join CT_PHIEUNHAPHANG on PHIEUNHAPHANG.MaPhieu = CT_PHIEUNHAPHANG.MaPhieu
	group by NHACUNGCAP.MaNCC
end

