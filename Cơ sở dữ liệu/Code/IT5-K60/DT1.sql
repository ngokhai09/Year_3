--Câu 2: (2 điểm) Tạo thủ tục có đầu vào là mã câu lạc bộ, đầu ra là số bàn thắng của câu lạc bộ
alter procedure cau2 @maclb char(20), @SBT int out as
begin
	select @SBT = Count(GhiBanID)
	from TRANDAU_GHIBAN where CauLacBoID = @maclb 
end
declare @sbt int
exec cau2 '112', @sbt out
print @sbt
--Câu 3: (1.5 điểm) Tạo hàm đưa ra danh sách các cầu thủ đã ghi bàn gồm hai trường mã cầu thủ và số bàn thắng cho câu lạc bộ với mã câu lạc bộ được người dùng đưa vào
create function cau3(@maclb varchar(20)) returns table as return(
	select Cauthuid, count(GhiBanID) as SoBanThang
	from TRANDAU_GHIBAN where CauLacBoID = @maclb and VaoLuoiNha is null
	group by CauThuID
)

select * from cau3('112')
--Câu 4: (2 điểm) Thêm các trường Số bàn ghi vào bảng cầu thủ. Tạo Trigger cập nhật tự động cho các trường này với những bàn ghi vào lưới đội bạn.
alter table CauThu add SBT int
alter trigger cau4 on TranDau_GhiBan for insert, update, delete as
begin
	declare @sl_in int, @sl_del int, @maCT_in varchar(20), @maCT_del varchar(20), @ghiban varchar(20)
	select @ghiban = GhiBanID ,@sl_in = iif(VaoLuoiNha is null, 1, 0), @maCT_in = CauThuID from inserted
	select @sl_del = iif(VaoLuoiNha is null, 1, 0), @maCT_del = CauThuID from deleted
	if @maCT_in is not null and @maCT_del is null
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) + @sl_in where CauThuID = @maCT_in
	end
	if @maCT_del is not null and exists (select * from TRANDAU_GHIBAN where GhiBanID = @ghiban)
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) + @sl_in - @sl_del where CauThuID = @maCT_in
	end
	if @maCT_del is not null and @maCT_in is null
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) - @sl_del where CauThuID = @maCT_del
	end

end
insert into TranDau_GhiBan values( '1111','71', '112', '27','1100', NULL)
update TRANDAU_GHIBAN set VaoLuoiNha = NULL where GhiBanID = '1111'
delete from TranDau_GhiBan where GhiBanID = '1111'
select * from CAUTHU where CauThuID = '1100'
--Câu 5: (1.5 điểm) Tạo View gồm các thông tin sau: Mã Câu lạc bộ, Tên CLB, Tên cầu thủ, Tên Sân, Ngày Thi đấu, Thời điểm ghi bàn, bàn ghi lưới nhà với tên câu lạc bộ là Manchester United
create view cau5 as

	select CAULACBO.CauLacBoID, TenCLB, HoVaTen, Tensan,NgayThiDau ,ThoiDiemGhiBan,VaoLuoiNha
	from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID inner join TRANDAU_GHIBAN on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
			inner join TRANDAU on TRANDAU.TranDauID = TRANDAU_GHIBAN.TranDauID inner join SANVANDONG on SANVANDONG.SanVanDongID = TRANDAU.SanVanDongID
	where TenCLB = 'Manchester United'

--Câu 6: (1 điểm) Tạo login có tên là tên của anh/chị và gán quyền select trên View ở câu 5.
exec sp_addlogin NgoVanKhai, 123

exec sp_adduser NgoVanKhai 

grant select on cau5 to NgoVanKhai
--Câu 7: (1 điểm) Đưa tên những cầu thủ ghi nhiều bàn thắng nhất và nhì của câu lạc bộ Manchester United mà không có bàn ghi vào lưới nhà.
select Cauthu.CauThuID, HoVaTen, Count(GhiBanID) as SBT into #temp
from CAUTHU inner join TRANDAU_GHIBAN on CAUTHU.CauThuID = TRANDAU_GHIBAN.CauThuID inner join CAULACBO on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID
where TenCLB = 'Manchester United' and VaoLuoiNha is null
group by Cauthu.CauThuID, HoVaTen

select CauThuID, HoVaTen, SBT into #top1 from #temp
where SBT = all(Select top 1 SBT from #temp order by Sbt desc)

select top 1 CauThuID, HoVaTen, SBT into #top2 from #temp
where SBT != all(Select top 1 SBT from #temp order by Sbt desc)
order by SBT desc

select * from #top1

select * from #temp
where SBT = all(Select SBT from #top2)