--3.Tạo hàm có đầu vào là mã câu lạc bộ, đầu ra là danh sách các cầu thủ của câu lạc bộ
create function cau_3(@maclb varchar(20)) returns table return(
	select CauThuID, HoVaTen, ViTri, QuocTich, SoAo
	from CAUTHU where CauLacBoID = @maclb
)
select * from cau_3('112')
--4.Thêm các trường Số trận đấu vào câu lạc bộ. Tạo Trigger cập nhật tự động cho trường này
alter table CauLacBo add SoTran int
create trigger cau_4 on TranDau for insert, update, delete as
begin
	
end
--7. Do người dùng nhập nhầm nên Bảng Câu lạc bộ có hai câu lạc bộ Manchester United với hai mã khác nhau. 
--Một mã câu lạc bộ được sử dụng ở tất cả các bảng còn lại, một mã câu lạc bộ không được sử dụng ở bảng nào. Hãy tạo thủ tục xóa bản ghi không được sử dụng.
select distinct CAULACBO.CauLacBoID into #temp
from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID inner join TRANDAU_GHIBAN on CAUTHU.CauLacBoID = TRANDAU_GHIBAN.TranDauID 
				inner join TRANDAU on TRANDAU.TranDauID = TRANDAU_GHIBAN.TranDauID
where TenCLB = 'Manchester United'
delete from CAULACBO where CauLacBoID != any (select CauLacBoID from #temp) and TenCLB = 'Manchester United'

