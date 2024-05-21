use master;
drop database if exists zupanije;

insert into zupan(ime, prezime) values ('Pero','Perić'),('Miro', 'Mirić'), 
('Đuro','Đurić');	

select * from zupan;

insert into zupanija (naziv, zupan) values ('Istarska', 1), ('Zagrebačka', 2), 
('Međimurska', 3);

select * from zupanija;

insert into opcina (zupanija, naziv_opcina) values (1, 'porečka'), (1, 'vrsarska'),
(2, 'rudeška'), (2 , 'maksimirska'), (3,'čakovečka'),(3, 'lendavska');

select * from opcina where zupanija=1;

insert into mjesto (opcina, naziv_mjesto) values (1,'Poreč'), (2,'Vrsar'),(3,'Rudeš')
,(4,'Maksimir'),(5,'Čakovac'),(6,'Lendava'),(1,'Umag'),(2,'Funtana')
,(3,'NK'),(4,'Dinamo'),(5,'Šenkovac'),(6,'Sv.Martin');

select * from mjesto where opcina=1;

update mjesto set opcina=6 where id=12;

select naziv_mjesto, naziv_opcina, naziv, ime, prezime from mjesto as m inner join opcina as o on m.opcina=o.sifra
inner join zupanija as z on z.sifra=o.zupanija inner join zupan as zu on z.sifra=zu.sifra where z.naziv='Istarska';


--insert into players (user_, pass) values ('Petar', 'pass'), ('Martin', 'pass');
--insert into games (start_up, duration, winner) values ('2024-5-18', 67, 1), ('2024-5-18', 89, 2);

--select * from players;
--select * from games;

--select * from match_result;

--insert into match_result (player_1_id, player_2_id, game_id) values (1, 2, 1), (1, 2, 2);



--select user_ from match_result as mr inner join players as p on p.id=mr.winner where mr.winner=2;

--select user_ from match_result as mr inner join players as p on p.id=mr.winner inner join game as g on g.id= where mr.winner=2;
