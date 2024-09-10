select * from smjerovi
where sifra=1;

-- Promjeniti smjer Web programiranje u C# programiranje
-- update jednog reda, jedna kolona
update smjerovi set naziv='C# programiranje'
where sifra=1;

-- Promijeniti cijenu i verificiran smjera čšćđž ČŠĆĐŽ
-- update jednog reda, više kolona
update smjerovi set 
cijena=1999.98, verificiran=0
where sifra=3;


-- svim smjerovima čija je šifra veća od 1 postavi datum
-- izvođenja na 01. veljače 2024
update smjerovi set
izvodiseod='2024-02-01'
where sifra>1;


-- svim smjerovima koji imaju trajanje null
-- postaviti trajanje na 100
update smjerovi set
trajanje=100
where trajanje is null;


-- postaviti cijenu web dizajna na 1000 eura
update smjerovi set cijena=1000
where naziv='Web dizajn'; -- OVO NIJE DOBRA PRAKSA
-- trebali smo iči s where sifra=2

-- svim smjerovima smanjiti cijenu za 10%
update smjerovi set cijena = cijena * 0.9;

-- svim smjerovima povećajte cijena za 200 €
update smjerovi set cijena = cijena + 200;

-- uvećajte cijena smjerova za PDV
update smjerovi set cijena = cijena * 1.25;


select * from polaznici;

-- Polazniku Igoru Brzici postaviti slučajni OIB
update polaznici set oib='06804238410'
where sifra=4;

