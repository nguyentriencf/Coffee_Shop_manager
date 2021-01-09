create database coffee_management
go

use coffee_management
go


-- Table
-- DrinkCategory
-- Drink 
-- Account
-- Bill
-- BillInfo

create table [Table]
(
	IdTable nchar(100) primary key,
	NameTable nvarchar(100) not null,
	StatusTable nvarchar(100) not null  default N'Trống'-- trống || có người
)
go

create table Account
(	
	DisplayName nvarchar(100) not null,
	UserName nvarchar(100) primary key,
	[Password] nvarchar(1000) not null,
	AccountType int not null default 0
)
go

create table Category
(
	IdCate nchar(100) primary key,
	NameCate nvarchar(100) not null,
)
go

create table DrAndFo
(
	IdDrAndFo nchar(100) primary key,
	NameDrAndFo nvarchar(100) not null,	
	Price float not null default 0,
	Idcate nchar(100) references Category(IdCate)
)
go

create table Bill 
(
	IdBi nchar(100) primary key,
	DateCheckIn date not null default getdate(),
	DateCheckOut date not null,	
	StatusBill int not null default 0,
	IdTable nchar(100) references [Table](IdTable),
)
go

create Table BillInfo
(
	IdBiInFo nchar(100) primary key,		
	Quantity int not null default 0,
	IdDrAndFo nchar(100) references DrAndFo(IdDrAndFo),
	IdBi nchar(100) references Bill(IdBi),
)
-- sinh mã tự động

-- xoá Function
IF object_id(N'SinhMa', N'TF') IS NOT NULL
    DROP FUNCTION SinhMa
GO


-- sinh mã cho table độc lập
create function SinhMa(@nameTable nchar(100))  returns char(5)
As
Begin
	declare @MaxMa char(5) --- để lấy mã @nameTable lớn nhất
	declare @NewMa varchar(5) ----
	declare @stt	int --- nếu trong bảng @nameTable chưa có dữ liệu thì gắn số thứ tự cho @nameTable
	declare @i	int	
	declare @sokyso	int

if(@nameTable ='[Table]')
	if exists(select * from [Table])---Nếu bảng @nameTable có dữ liệu
	 begin
		--Lấy mã @nameTable lớn nhất hiện có
		select @MaxMa = max(IdTable) 
		from [Table]
		--Trích phần ký số của mã lớn nhất và chuyển thành số 
		set @stt=convert(int, right(@MaxMa,3)) + 1 --Số thứ tự của mã @nameTable mới
	 end
	else--Nếu bảng @nameTable đang rỗng (nghĩa là chưa mã @nameTable nào được lưu trữ trong CSDL.
	 set @stt= 1 -- Số thứ tự của @nameTable trong trường hợp chưa có data nào trong CSDL
	--Kiểm tra và bổ sung chữ số 0 để đủ 3 ký số trong mã .
	set @sokyso = len(convert(varchar(3), @stt))
	set @NewMa='MB'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMa = @NewMa + '0'
			set @i = @i + 1
		end	
	set @NewMa = @NewMa + convert(varchar(3), @stt) 
if(@nameTable ='Category')
	if exists(select * from [Account])
		 begin
		select @MaxMa = max(IdCate) 
		from Category

		set @stt=convert(int, right(@MaxMa,3)) + 1 
	 end
	else
	 set @stt= 1 
	set @sokyso = len(convert(varchar(3), @stt))
	set @NewMa='LN'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMa = @NewMa + '0'
			set @i = @i + 1
		end	
	set @NewMa = @NewMa + convert(varchar(3), @stt) 

if(@nameTable ='Bill')
	if exists(select * from Bill)
		 begin
		select @MaxMa = max(IdBi) 
		from Bill

		set @stt=convert(int, right(@MaxMa,3)) + 1 
	 end
	else
	 set @stt= 1 
	set @sokyso = len(convert(varchar(3), @stt))
	set @NewMa='HD'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMa = @NewMa + '0'
			set @i = @i + 1
		end	
	set @NewMa = @NewMa + convert(varchar(3), @stt) 
if(@nameTable ='BillInfo')
	if exists(select * from [BillInfo])
		 begin
		select @MaxMa = max(IdBiInFo) 
		from BillInfo

		set @stt=convert(int, right(@MaxMa,3)) + 1 
	 end
	else
	 set @stt= 1 
	set @sokyso = len(convert(varchar(3), @stt))
	set @NewMa='MB'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMa = @NewMa + '0'
			set @i = @i + 1
		end	
	set @NewMa = @NewMa + convert(varchar(3), @stt) 
return @NewMa

End
go



-- sinh mã có tham chiếu
create function SinhMaNuoc(@nameTable nchar(100))  returns char(5)
As
Begin
	declare @MaxMa char(5) --- để lấy mã @nameTable lớn nhất
	declare @NewMa varchar(5) ----
	declare @stt	int --- nếu trong bảng @nameTable chưa có dữ liệu thì gắn số thứ tự cho @nameTable
	declare @i	int	
	declare @sokyso	int

if(@nameTable ='DrAndFo')
	if exists(select * from [DrAndFo])
		 begin
		select @MaxMa = max(IdDrAndFo) 
		from DrAndFo

		set @stt=convert(int, right(@MaxMa,3)) + 1 
	 end
	else
	 set @stt= 1 
	set @sokyso = len(convert(varchar(3), @stt))
	set @NewMa='MN'
	set @i = 0
	while @i < 3 -@sokyso
		begin
			set @NewMa = @NewMa + '0'
			set @i = @i + 1
		end	
	set @NewMa = @NewMa + convert(varchar(3), @stt) 

return @NewMa

End
print dbo.SinhMaNuoc('DrAndFo')

select * from [Table]

insert into [Table] values ('011', N'Bàn 1', 0)

select * from [Table]
delete [Table] where IdTable = 011