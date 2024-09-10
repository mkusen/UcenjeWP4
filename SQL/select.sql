select * from smjerovi;

-- filtriranje po kolonama
-- * označava sve kolone
-- naziv kolone, konstanta, izraz

select *, 
naziv as smjer,  -- kolona
cijena, 
12 as sati,  -- konstanta
getdate() as datum -- izraz
from smjerovi;



-- filtriranje redova

-- where radi operatorima:
-- = uzima točnu vrijednost
-- operatori usporedbe: < > <= >= !=
select * from polaznici where sifra!=10;

-- logički operatori
-- and, or i not

select * from polaznici where
sifra=10 or prezime='Filipović';

select ime, prezime from polaznici where
sifra>5 and sifra<10;

select sifra,ime, prezime from polaznici where
not (sifra>5 and sifra<10) or
(sifra>6 and sifra<7);

-- ostali operatori
-- like, in, between, is null, is not null

select * from polaznici
where ime like 'C%';

-- Ispiši sve ženske polaznice s najmanjom greškom
select * from polaznici
where ime like '%A';

-- google način rada
select * from polaznici
where ime like '%an%' or prezime like '%an%';

select * from polaznici where
sifra in (2,6,3,4);

select * from polaznici where
sifra between 2 and 6;

select * from smjerovi
where izvodiseod between '2024-01-01' and '2024-12-31';

select * from smjerovi;
-- želim vidjeti sve smjerove koji nemaju definirano trajanje

select * from smjerovi 
where trajanje is null;

select * from smjerovi 
where trajanje is not null;

-- Baza svaštara
select top 10 * from Kupci;

select * from kupci where ime='Tomislav'
and prezime='Jakopec';

select * from Mjesta where sifra=2763;
select * from Opcine where sifra=1384;
select * from Zupanije where sifra=18;


select top 1 percent * from Kupci;


--slaganje podataka

select top 0.1 percent * from Kupci
order by prezime;

select top 0.01 percent sifra, 
concat(upper(left(ime,1)),substring(lower(ime),2,len(ime))) as ime, prezime from Kupci
order by prezime desc, ime asc;


select * from artikli;
update artikli set cijena=cijena/7.5345;

-- idete u svatove i imate budžet od 150 do 200 €,
-- koji artikli su Vam na raspolaganju. Složiti ih od 
-- najsukpljeg prema najjeftinijem

select * from artikli
where cijena between 150 and 200
and jedinicaMjere in ('KOM') order by 
cijena desc;
