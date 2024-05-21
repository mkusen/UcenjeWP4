use master;
go
drop database if exists zupanije;
go
create database zupanije collate Croatian_CI_AS;
go
use zupanije;

create table zupanija(
sifra int not null primary key identity (1,1),
naziv varchar(50),
zupan int
);

create table zupan(
sifra int not null primary key identity (1,1),
ime varchar (50),
prezime varchar(50)
);

create table opcina (
sifra int not null primary key identity (1,1),
zupanija int not null,
naziv_opcina varchar (50)
);

create table mjesto (
sifra int not null primary key identity (1,1),
opcina int not null,
naziv_mjesto varchar(50)
);

alter table zupanija add foreign key (zupan) references zupan(sifra);
alter table opcina add foreign key (zupanija) references zupanija (sifra);
alter table mjesto add foreign key (opcina) references opcina (sifra);
