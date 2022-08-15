/*Kịch bản 2
Tạo login A, B , C
Tạo user userA, userB, userC tương ứng với login A, B, C
Gán quyền select, update cho userA trên bảng NhaCungCap của CSDL QLBanHang,
A có quyền trao quyền này cho người khác
Đăng nhập A để kiểm tra
Từ A, Trao quyền select cho userB trên bảng NhaCungCap của CSDL QLBanHang
Đăng nhập B để kiểm tra
Từ B, Trao quyền select cho userC trên bảng NhaCungCap của CSDL QLBanHang
Kiểm tra*/
exec sp_addlogin A, 123
exec sp_addlogin B, 123
exec sp_addlogin C, 123
 
exec sp_adduser A, userA
exec sp_adduser B, userB
exec sp_adduser C, userC

grant select, update on HOCVIEN to userA with grant option
grant select  on HOCVIEN to userB with grant option
grant select  on HOCVIEN to userC with grant option