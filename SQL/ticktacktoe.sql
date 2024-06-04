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


--podaci
insert into players (user_,pass)
values ('mku', 'pass'), ('pku', 'pass'),
('iku', 'pass'), ('jku', 'pass'),
('dku', 'pass'), ('djku', 'pass'),
('kku', 'pass'), ('vku', 'pass');

insert into games (start_up ,duration, winner)
values ('2024-06-04', 10, 1), 
('2024-06-04', 11, 2),
('2024-06-04', 12, 3),
('2024-06-04', 13, 4),
('2024-06-04', 14, 5),
('2024-06-04', 15, 6),
('2024-06-04', 16, 7),
('2024-06-04', 17, 8);

insert into match_result (player_1_id ,player_2_id , game_id)
values (1, 2, 1), 
(3, 4, 2),
(5, 6, 3),
(7, 8, 4),
(1, 8, 5),
(2, 7, 6),
(3, 6, 7),
(4, 5, 8);


