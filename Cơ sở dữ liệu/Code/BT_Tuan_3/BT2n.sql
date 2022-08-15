--1. Tạo View gồm các field sau: MaDK, LoaiKH, TenKH,NgaySinh, Phai, DiaChi, DienThoai, SoPhong, LoaiPhong, NgayVao, SoNgayO. Trong đó Số Ngày ở = Ngày Ra – Ngày Vao
CREATE VIEW Info as
	select tChiTietKH.MaDK, LoaiKH,TenKH, NgaySinh, CASE WHEN Phai = 1 then N'Nữ' else N'Nam' end as GIOITINH, DiaChi, DienThoai, LoaiPhong, NgayVao, DATEDIFF(DAY, NgayVao, NgayRa) as SoNgayO
	from tChiTietKH inner join tDangKy on tDangKy.MaDK = tChiTietKH.MaDK
select * from Info
--2. Viết hàm có mã nhập vào là ngày vào trong năm 1999 và thông tin đưa ra như câu 1
create function Info_ver2(@ngay int, @thang int) 
	returns table
		as return(
		select tChiTietKH.MaDK, LoaiKH,TenKH, NgaySinh, CASE WHEN Phai = 1 then N'Nữ' else N'Nam' end as GIOITINH, DiaChi, DienThoai, LoaiPhong, NgayVao, DATEDIFF(DAY, NgayVao, NgayRa) as SoNgayO
		from tChiTietKH inner join tDangKy on tDangKy.MaDK = tChiTietKH.MaDK
		where Day(NgayVao) = @ngay and MONTH(NgayVao) = @thang and Year(NgayVao) = 1999
	)
select * from Info_ver2(1,7)
--3. Viết truy vấn tạo bảng doanh thu (tDoanhThu) gồm các trường
create table tDoanhThu(
	MaDK nvarchar(3) primary key,
	LoaiPhong nvarchar(1),
	SoNgayO int,
	ThucThu float
)
--4. Tạo Trigger tính tiền và điền tự động vào bảng tDoanhThu như sau:
--Các trường lấy thông tin từ các bảng và các thông tin sau:
--Trong đó:
--(a) Số Ngày Ở= Ngày Ra – Ngày Vào
--(b) ThucThu: Tính theo yêu cầu sau:
--Nếu Số Ngày ở <10 Thành tiền = Đơn Giá * Số ngày ở
--Nếu 10 <=Số Ngày ở <30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.95 (Giảm5%)
--Nếu Số ngày ở >= 30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.9 (Giảm10%)
alter trigger sol on tDangKy for Insert, Update, Delete as
begin
	declare @madk_insert nvarchar(3), @madk_delete nvarchar(3), @SoNgayO int, @loaiphong nvarchar(2), @DonGia int, @ThucThu float
	select @madk_insert = MaDK, @SoNgayO = DATEDIFF(DAY, NgayVao, NgayRa), @loaiphong = LoaiPhong, @loaiphong = LoaiPhong from inserted;
	select @DonGia = DonGia from tLoaiPhong where LoaiPhong = @loaiphong
	select @thucthu = case when @SoNgayO < 10 then (@DonGia *  @SoNgayO) when @SoNgayO between 10 and 30 then (@DonGia * @SoNgayO*0.95) else (@DonGia * @SoNgayO*0.9) end
	select @madk_delete = MaDK from deleted;
	if exists(Select MaDK from tDoanhThu where MaDK = @madk_insert) and (@madk_delete is not null)
	begin
		update tDoanhThu set SoNgayO = @SoNgayO, Thucthu = @ThucThu, LoaiPhong = @loaiphong
		where MaDK = @madk_insert
	end
	if (@madk_insert is not null) and not exists(Select MaDK from tDoanhThu where MaDK = @madk_insert) 
	begin
		insert into tDoanhThu values (@madk_insert, @loaiphong, @SoNgayO, @ThucThu)
	end
	if exists(select MaDK from tDoanhThu where MaDK = @madk_delete) and (@madk_insert is null)
	begin

		delete from tDoanhThu where MaDK = @madk_delete
	end
end
