insert into players (user_, pass) values ('Petar', 'pass'), ('Martin', 'pass');
insert into game (start_up, duration) values ('2024-5-18', 67), ('2024-5-18', 89);

select * from match_result;

insert into match_result (player_1_id, player_2_id, game_id, winner) values (1, 2, 1, 1), (1, 2, 2, 2);



select user_ from match_result as mr inner join players as p on p.id=mr.winner where mr.winner=2;
