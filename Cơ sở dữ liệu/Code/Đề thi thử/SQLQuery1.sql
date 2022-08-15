-- Thủ tục đầu vào là này hóa đơn, đầu ra là số mặt hàng bán trong ngày đó
alter procedure HD @ngay datetime, @slg int out as
begin
	select @slg = count(distinct masp)
	from Hoadon inner join ChiTietHD on Hoadon.MaHD = ChiTietHD.MaHD
	group by Ngayban
	having @ngay = Ngayban
end


declare @sl int
exec HD '2015-03-16', @sl out
print @sl
-- Tạo hàm đầu vào là mã khách hàng, năm, đầu ra là danh sách các hóa đơn khác hàng mua trong năm
create function DSHD(@maKH nvarchar(5), @nam int) returns table as
return(
	select MaKH, HoaDon.MaHD, Ngayban, Sum(SlBan * GiaSP) as TongTien
	from HoaDon inner join ChiTietHD on Hoadon.MaHD = ChiTietHD.MaHD inner join SanPham on ChiTietHD.MaSP = SanPham.MaSP
	where MaKH = @maKH and YEAR(NgayBan) = @nam
	group by MaKH,Hoadon.MaHD, Hoadon.MaHD, Ngayban	
)
select * from DSHD(N'0002', 2015)
-- Tạo view thống kê hàng tồn dựa trên số lượng nhập và bán trong 2015
create view ThongKe as
	select SanPham.MaSP, TenSP, Sum(SLN) as SoLuongNhap, Sum(SlBan) as SoLuongBan, Sum(SLN - SlBan) as Ton
	from SanPham inner join ChiTietHD on SanPham.MaSP = ChiTietHD.MaSP inner join ChiTietHDN on SanPham.MaSP = ChiTietHDN.MaSP
	group by SanPham.MaSP, TenSp

select * from ThongKe
-- Thêm các trường Số lượng hàng mua vào Hóa đơn. Tạo Trigger cập nhật tự động cho trường này. (tính tổng số lượng bán của toàn bộ hàng trong mỗi hóa đơn)
alter table HoaDon add SLMua int

create trigger SL on ChiTietHD for insert, update, delete as
begin
	declare @mahd_in nvarchar(5), @mahd_del nvarchar(5), @sl_in int, @sl_del int
	select @mahd_in = MaHD from inserted
	select @mahd_del = MaHD from inserted
	
end

-- Tạo hai login A và B, gán quyền Select, Insert, Update cho A trên bảng Hóa đơn và chi tiết hóa đơn, cho phép A được phép gán những quyền này cho người khác A gán quyền cho B, hãy đăng nhập dưới tài khoản B để kiểm tra
exec sp_addlogin A, 123
exec sp_addlogin B, 123

exec sp_adduser A, A
exec sp_adduser B, B

grant select, insert, update on HoaDon to A with grant option
grant select, insert, update on ChitietHD to A  with grant option