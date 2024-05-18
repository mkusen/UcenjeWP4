drop database if exists ticktacktoe;
go
create database ticktacktoe;
go
use ticktacktoe;
go

-- tablica igraci, lozinka koristi hashbyte (md5)
create table players (
id int not null primary key identity (1,1),
user_ varchar(20),
pass char(32)
);

--tablica igra
create table game(
id int not null primary key identity (1,1),
start_up datetime,
duration int
);

--tablica rezultata
create table match_result(
id int not null primary key identity (1,1),
player_1_id int not null,
player_2_id int not null,
game_id int not null,
winner int not null
);