insert into players (user_, pass) values ('Petar', 'pass'), ('Martin', 'pass');
insert into game (start_up, duration, winner) values ('2024-5-18', 67, 1), ('2024-5-18', 89, 2);

select * from players;
select * from game;

select * from match_result;

insert into match_result (player_1_id, player_2_id, game_id) values (1, 2, 1), (1, 2, 2);



select user_ from match_result as mr inner join players as p on p.id=mr.winner where mr.winner=2;

select user_ from match_result as mr inner join players as p on p.id=mr.winner inner join game as g on g.id= where mr.winner=2;
