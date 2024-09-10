--use edunovawp4;

select * from smjerovi where sifra=1;

select * from grupe;

select a.naziv as smjer, b.naziv as grupa, *
from smjerovi a inner join grupe b
on a.sifra=b.smjer
where b.naziv like '%4%';


select a.naziv as smjer, b.naziv as grupa, *
from smjerovi a left join grupe b
on a.sifra=b.smjer
where b.smjer is null;


select a.naziv as smjer, b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra=b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on c.polaznik=d.sifra;


select a.naziv as smjer, 
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra=b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on c.polaznik=d.sifra
where b.naziv='WP5';


--use svastara;

-- Izlistaj sve nazive općina u 
-- Osječko baranjskoj županiji

select b.naziv
from zupanije a inner join opcine b
on a.sifra=b.zupanija
where a.naziv like '%zadar%';

-- Izlistati sve nazive mjesta u OBŽ
select b.naziv as opcina, c.naziv as mjesto
from zupanije a inner join opcine b
on a.sifra=b.zupanija
inner join mjesta c on b.sifra=c.opcina
where a.naziv like '%baranj%'
order by 1,2;

-- ispisati sve nazive općina s brojem mjesta
-- u opčinama u OBŽ
select b.naziv as opcina, count(b.naziv) as mjesta
from zupanije a inner join opcine b
on a.sifra=b.zupanija
inner join mjesta c on b.sifra=c.opcina
where a.naziv like '%baranj%'
group by b.naziv
having count(b.naziv)>10
order by 2 desc;

-- izlistajte jedinstvena imena kupaca
select distinct ime from kupci order by 1;

-- koje ime se najčešće koristi
select prezime, count(sifra)
from kupci group by prezime order by 2 desc;

select top 10 mjesto from kupci;
-- iz kojih mjesta dolaze koji kupci (ne postoji vanjski ključ ali se podaci mogu spojiti)
select b.naziv, a.ime, a.prezime
from kupci a inner join mjesta b
on a.mjesto=b.sifra

update kupci set mjesto=9999999
where sifra=15156;

select top 10 * from kupci;


-- traženje igle u plastu sijena
select count(*) from artikli;
-- 52601

select distinct artikl from artiklinaprimci;
-- 52599

-- podupit
select * from artikli 
where sifra not in (
select distinct artikl from artiklinaprimci
);

-- obriši ih
delete from artikli where sifra in (90661,79102);

-- alternativa bez navođenja vrijednosti
delete from artikli where sifra
not in (select distinct artikl from artiklinaprimci);




-- baza knjiznica

use knjiznica;
-- Koje je sve knjige objavio August Šenoa
select a.naslov
from katalog a inner join autor b
on a.autor=b.sifra
where b.ime='August' and b.prezime='Šenoa';

-- DZ:
-- Izlistajte sve naslove knjiga
-- koje su izdane u Osijeku

-- Koliko izdavača su Društva s ograničenom odgovornošću?
select  naziv from izdavac
where naziv like '%d.o.o.%'
or naziv like '%doo%'
or naziv like '%d.o.o%';

-- unesite sebe kao autora
insert into autor (sifra,ime,prezime,datumrodenja) values
(4,'Tomislav','Jakopec','1980-12-07');

select top 10 * from autor;

-- koji su autori rođeni u vašoj godini rođenja?
select * from autor where
datumrodenja between '1980-01-01' and '1980-12-31';


-- Ispišite ime i prezime autora koji su 
-- izdali knjige u Zagrebu
select a.ime, a.prezime
from autor a inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv='Zagreb';

-- koji autori nisu izdali niti jednu knjigu?
select a.ime, a.prezime, b.naslov
from autor a left join katalog b on a.sifra=b.autor
where b.naslov is null;

-- obriši ih

delete a
from autor a left join katalog b on a.sifra=b.autor
where b.naslov is null;

-- svim autorima koji su 
-- objavili knjigu u mjestu koje ima slovo a
-- imenu dodajte Plemeniti. 
-- Npr ako se zvao Mirko, sada će se zvati Plemeniti Mirko
select * from autor;
select concat('Plemeniti ',a.ime), c.naziv
from autor a inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv like '%a%';

update a 
set a.ime=concat('Plemeniti ',a.ime)
from autor a
inner join katalog b on a.sifra=b.autor
inner join mjesto c on b.mjesto=c.sifra
where c.naziv like '%a%';


-- koliko ima autora u bazi
select count(*) from autor;



-- baza svaštara
-- Idete u svatove i planirate kupiti poklon
-- u rasponu 1000 - 1100 eura, koliko artikala možete kupiti?

select count(*) from artikli
where cijena between 1000 and 1100;

-- Izlistati sva mjesta u općini Čepin
select b.*
from opcine a inner join mjesta b
on a.sifra = b.opcina
where a.naziv='Čepin';

-- postavite Beketincima poštanski broj 31431
update mjesta set postanskiBroj='31431' where sifra=1945;

-- Izlistajte imena i prezimena svih kupaca iz mjesta Livana
select b.ime, b.prezime
from mjesta a inner join kupci b
on b.mjesto = a.sifra
where a.naziv='Osijek';

-- koliko je bilo primki u 2017
select top 1 * from primke where 
datum between '2017-01-01' and '2017-12-31';

-- Što smo sve zaprimili na primci 14778/2017
select c.kratkinaziv, b.kolicina, b.cijena,
b.kolicina * b.cijena as iznos
from primke a 
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
where a.rednibroj='14778/2017'
order by 4 desc;


-- ovo je istovjetno gornjem upitu
select artikli.kratkinaziv, artiklinaprimci.kolicina, artiklinaprimci.cijena,
artiklinaprimci.kolicina * artiklinaprimci.cijena as iznos
from primke 
inner join artiklinaprimci on primke.sifra=artiklinaprimci.primka
inner join artikli on artiklinaprimci.artikl = artikli.sifra
where primke.rednibroj='14778/2017'
order by 4 desc;


-- zanima me ukupni iznos na toj primci

select sum(b.kolicina * b.cijena) as ukupniIznos
from primke a 
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
where a.rednibroj='14778/2017';

-- koliki su iznosi na svim primkama u sijećnju 2017. godine
select a.rednibroj, sum(b.kolicina * b.cijena) as ukupniIznos
from primke a 
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
where a.datum between '2017-01-01' and '2017-01-31'
group by a.rednibroj
order by 2 desc;


-- dovucite naziv dobavljača u upit

select a.rednibroj, d.naziv,
sum(b.kolicina * b.cijena) as ukupniIznos,
avg(b.kolicina * b.cijena) as prosjek,
min(b.kolicina * b.cijena) as minimalno,
max(b.kolicina * b.cijena) as maksimalno
from primke a 
inner join artiklinaprimci b on a.sifra=b.primka
inner join artikli c on b.artikl = c.sifra
inner join dobavljaci d on a.dobavljac=d.sifra
where a.datum between '2017-01-01' and '2017-12-31'
group by a.rednibroj, d.naziv
having sum(b.kolicina * b.cijena)>7000000
order by 3 desc;


