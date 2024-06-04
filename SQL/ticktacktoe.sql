use master;
go
drop database if exists ticktacktoe;
go
create database ticktacktoe;
go
use ticktacktoe;
go

-- tablica igraci, lozinka koristi hashbyte (md5)
create table players (
id int not null primary key identity (1,1),
user_ varchar(20) not null,
pass char(32) not null
);

--tablica igra
create table games(
id int not null primary key identity (1,1),
start_up datetime not null,
duration int not null,
winner int not null
);

--tablica rezultata
create table match_result(
id int not null primary key identity (1,1),
player_1_id int not null,
player_2_id int not null,
game_id int not null

foreign key (player_1_id) references players (id),
foreign key (player_2_id) references players (id),
foreign key (game_id) references games (id)
);