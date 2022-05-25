create database Biletarnica0
use Biletarnica0

create table korisnik(
id int primary key identity(1,1),
ime nvarchar(50) not null,
prezime nvarchar(50) not null,
email nvarchar(50) not null,
pass nvarchar(100) not null
)
drop table koncert
create table koncert(
	id int primary key identity(1,1),
	izvodjac nvarchar(50),
	lokacija nvarchar(30),
	dan date,
	vreme time
)

create table mesta
(
	id int primary key identity(1,1),
	naziv nvarchar(50),
	cena int not null,
	slobodnih int
)
drop table rezervacija
create table rezervacija
(
	id int identity(1,1) primary key,
	korisnikID int foreign key references korisnik(id),
	koncertID int foreign key references koncert(id),
	mestaID int foreign key references mesta(id),
)



insert into mesta values
('parter', 4000, 10000),
('fanpit', 7000, 5000),
('sedenje', 3500, 15000),
('loza', 12000, 100)

insert into koncert values
('Metallica', 'Marakana', '2022-06-20', '18:30'),
('Black Sabbath', 'Arena', '2022-09-12', '20:00'),
('Goblini', 'Sajam', '2022-09-27', '17:00'),
('Iron Maiden', 'Arena', '2022-05-24','19:30')

insert into Korisnik values
('Stanoje', 'Petrovic', 'stan.petrovic@gmail.com', '1234'), 
('Milica', 'Lazetic', 'abvgd@yahoo.com', '5555'),
('Jovana', 'Milic', 'lalalala@gmail.com', 'zebra'),
('Neda', 'Kovacevic', 'nedak@gmail.com', '0000')

go
create view Pogled
as
select koncert.izvodjac as izvodjac,  koncert.lokacija as lokacija, koncert.dan as dan, convert(varchar(5), koncert.vreme) as Vreme
from koncert 
go

drop database Biletarnica0
select * from koncert