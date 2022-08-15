--Declare @x int, @s int
--set @s = 2 set @x = 3
--while(@x < 11)
--	Begin 
--		set @s = @x * @s
--		set @x = @x + 1;
--	end
--	print @s
select * from Diem

--ALTER TABLE Diem
--ADD dnn float;
--Declare hs cursor for select mahs from DSHS
--Open hs
--Declare @mahs nvarchar(5), @dnn float,  @ly float, @hoa float, @van float
--Fetch next from hs into @mahs
--While (@@fetch_status = 0)
--	begin
		
--		select @dnn = TOAN, @ly = LY, @hoa = HOA, @van = VAN from diem where MAHS=@mahs
--		if @dnn > @van
--			set @dnn = @van
--		if @dnn > @ly
--			set @dnn = @ly
--		if @dnn > @hoa
--			set @dnn = @hoa
--		update Diem set dnn=@dnn where MAHS=@mahs
--		Fetch next from hs into @mahs
--	end
--Close hs; Deallocate hs

update diem set dnn= thapnhat
from (select mahs,
(case
when toan<=ly and toan<=hoa and toan<=van then toan
when ly<toan and ly<hoa and ly<van then ly
when hoa<toan and hoa<ly and hoa<van then hoa
else van
end) as thapnhat from DIEM
) bangA
where Diem.MAHS=bangA.mahs 

select * from dshs


CREATE PROCEDURE SySo @malop nvarchar(4), @ss int output
AS
begin
select @ss=Count(MAHS) from DSHS where MALOP=@malop group by MALOP
End

--Gọi thủ tục:
declare @tb float
exec SySo '10A2', @tb output
print @tb