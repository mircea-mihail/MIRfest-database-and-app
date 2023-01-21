--drop table Contine
--drop table Canta_la
--drop table Instrumente
--drop table Artisti
--drop table Piese
--drop table Trupe
--drop table Manageri
--drop table Echipament
--drop table Scene
--drop table Ingineri_de_sunet

create table Instrumente(
    cod_produs varchar(20),    --pk
    tip varchar(50) not null,
    marca varchar(50), 
    model varchar(50),
    
    constraint pk_instrumente primary key(cod_produs),
);

create table Artisti(
    id_artist int,        --pk    
    nume varchar(50), 
    prenume varchar(50),
	
    constraint pk_artisti primary key(id_artist)
);

create table Canta_la(
    cod_produs varchar(20),    --pk, fk
    id_artist int,        --pk, fk    
    
    constraint pk_canta_la primary key(cod_produs, id_artist), 
    constraint fk_canta_la_cod_produs foreign key(cod_produs) references Instrumente(cod_produs) on delete cascade, 
    constraint fk_canta_la_id_artist foreign key(id_artist) references Artisti(id_artist) on delete cascade
);

create table Manageri(
    id_manager int,       --pk
    nume varchar(50) not null, 
    prenume varchar(50) not null,
    email varchar(100),    
    nr_telefon varchar(100) not null,
	
    constraint pk_Manageri primary key(id_manager),
);

create table Scene(
    index_scena tinyint,    --pk
    nume varchar(50),
    metri_patrati smallint,
    acoperita_sau_nu tinyint, 
    
    constraint pk_scene primary key(index_scena)
);

create table Trupe(
    id_trupa int,         --pk
    id_manager int,       --fk
    index_scena tinyint,      --fk
    nume varchar(50) not null,
    gen_muzical varchar(50),
    email varchar(100),
    
    constraint pk_trupe primary key(id_trupa),
    constraint fk_trupe_manager foreign key(id_manager) references Manageri(id_manager) on delete set null,
    constraint fk_trupe_scene foreign key(index_scena) references Scene(index_scena) on delete set null, 

);

create table Piese(
    id_piesa int,         --pk
    id_trupa int,         --fk
    titlu varchar(50) not null,
    compozitor varchar(100), 
    durata varchar(50) not null,
    gen_muzical varchar(50),
    
    constraint pk_piese primary key(id_piesa),
    constraint fk_piese_trupe foreign key(id_trupa) references Trupe(id_trupa) on delete cascade
);

create table Ingineri_de_sunet(
    id_inginer int,     --pk
    nume varchar(50) not null, 
    prenume varchar(50) ,
    ani_experienta smallint, 
    senior_sau_junior tinyint,
    
    constraint pk_ingineri_de_sunet primary key(id_inginer)
);


create table Echipament(
    cod_produs varchar(20),  --pk
    index_scena tinyint,    --fk 
    id_inginer int,     --fk 
    rol varchar(50) not null,
    marca varchar(50),
    pret int,
    
    constraint pk_echipament primary key(cod_produs),
    constraint fk_echipament_scene foreign key(index_scena) references Scene(index_scena) on delete set null,
    constraint fk_echipament_ingineri_de_sunet foreign key(id_inginer) references Ingineri_de_sunet(id_inginer) on delete set null,
);

create table Contine(
    id_artist int,        --pk, fk    
    id_trupa int,         --pk, fk

    constraint pk_contine primary key(id_trupa, id_artist),
    constraint fk_contine_artisti foreign key(id_artist) references Artisti(id_artist) on delete cascade,
    constraint fk_contine_trupe foreign key(id_trupa) references Trupe(id_trupa) on delete cascade
);
  




----------------------------------INSERARE IN TABELE--------------------------

-------instrumente------------

--cod_produs, tip, marca, model
insert into Instrumente
values(1,'chitara' ,'Ibanez' , 'premium')

insert into Instrumente
values(2,'chitara' ,'Jackson' , 'soloist')

insert into Instrumente
values(3,'tobe' ,'Tama' , 'star')

insert into Instrumente
values(4,'bas' ,'Fender' , 'bassbreaker')

insert into Instrumente
values(5,'bas' ,'Ibanez' , 'slappist')

insert into Instrumente
values(6,'clape' ,'Yamaha' , 'rsh')



-------artisti------------

--id_artist, nume, prenume, ani_in_trupa
insert into Artisti
values(1,'Ionescu' ,'Mircea-Mihail');

insert into Artisti
values(2,'Ionescu' ,'Andrei');

insert into Artisti
values(3,'Hammet' ,'Kirk');

insert into Artisti
values(4,'Hetflield' ,'James');

insert into Artisti
values(5,'Trujilo' ,'Robert');

insert into Artisti
values(6,'Ulrich' ,'Lars');

insert into Artisti
values(7,'Grigore' ,'Costin' );

insert into Artisti
values(8,'Andrei' ,'Brihac');

insert into Artisti
values(9,'Proulx' ,'Emmanuelle' );

insert into Artisti
values(10,'Dragos' ,'Chiriac');



-------canta la------------
--cod_produs, id_artist

insert into Canta_la
values(1 , 4);

insert into Canta_la
values(2 , 6);

insert into Canta_la
values(3 , 1);

insert into Canta_la
values(4 , 2);

insert into Canta_la
values(5 , 5);

insert into Canta_la
values(6 , 3);




-------manageri------------


--id_manager, nume, prenume, email, nr_telefon
insert into Manageri
values(1, 'Ionel', 'Ioan', 'ionelioan@gmail.com', '0733456877');

insert into Manageri
values(2, 'Cezar', 'Iulian', 'imparatulromei@gmail.com', '0758624589');

insert into Manageri
values(3, 'Pompei', 'Magnus', 'cezarwasbetter@yahoo.com', '0765849521');

insert into Manageri
values(4, 'Churchill', 'Winston', 'ww2ez4me@gmail.com', '0765231489');

insert into Manageri
values(5, 'Snow', 'John', 'nuscapdezid@yahoo.com', '0755254447');

insert into Manageri
values(6, 'Jaime', 'Lannister', 'ilovemysister@gmail.com', '0755565554');



-------scene------------

--index_scena, nume, metri_patrati, acoperita_sau_nu
insert into Scene
values(1,'Mortii' , 50, 0);

insert into Scene
values(2,'Oboselii' ,20 , 0);

insert into Scene
values(3,'Disperarii' ,30 , 0);

insert into Scene
values(4, 'MIR', 100, 1);




--id_trupa id_manager index_scena nume gen_muzical email
-------trupe------------

insert into Trupe
values(1, null, null, 'Anthrax', 'Thrash Metal', 'anthrax@gmail.com');

insert into Trupe
values(2,1 ,1 , 'Metallica' , 'Thrash Metal', 'metallica@gmail.com');

insert into Trupe
values(3,2 ,1 , 'Men I Trust' , 'Indine Rock', 'menitrustofficial@gmail.com');

insert into Trupe
values(4,3 ,2 , 'Warbringer' , 'Thrash Metal', 'warbringer@gmail.com');

insert into Trupe
values(5,5 ,2 , 'PreaTarziu' , 'Black Metal', 'preatarziu@gmail.com');

insert into Trupe
values(6,null ,3 , 'PreaDevreme' , 'Indie Rock', 'preadevreme@gmail.com');


-------piese------------

--id_piesa, id_trupa, titlu, compozitor, durata, gen_muzical
insert into Piese
values(1, 6,'Stalpi de curent' ,'Costin Grigore' , '4 min 20 sec', 'indie rock')

insert into Piese
values(2, 6,'sari!' ,'Andrei Brihac' ,'3 min 10 sec', 'indie rock')

insert into Piese
values(3,5 ,'pumni in burta' ,'Andrei Brihac' ,'3 min 50 sec' , 'black metal')

insert into Piese
values(4, 5,'incendiu' ,'Ionescu Mircea' , '5 min 25 sec', 'speed black metal')

insert into Piese
values(5, 4,'Remain Violent' , null ,'3 min 34 sec' , 'thrash metal')

insert into Piese
values(6, 3,'Show Me How' ,'Proulx Emmanuelle' ,'3 min 28 sec' , 'indie rock')

insert into Piese
values(7, 2,'Jump in the fire' ,'Dave Mustaine' ,'2 min 54 sec' , 'thrash metal')

insert into Piese
values(8, 3,'Seven' ,'Proulx Emmanuelle' ,'4 min 1 sec' , 'indie')

insert into Piese
values(9, 4,'Firepower Kills' , null ,'3 min 32 sec' , 'speed metal')



-------ingineri------------

--id_ingineri, nume, prenume, ani_experienta, senior_sau_nu
insert into Ingineri_de_sunet
values(1,'Ioan' ,'Marius' ,10 ,1 );

insert into Ingineri_de_sunet
values(2,'Vasile' ,'Silviu' ,30 ,1 );

insert into Ingineri_de_sunet
values(3,'Silviu' ,'Faiar' ,1 ,0 );

insert into Ingineri_de_sunet
values(4,'Ionescu' ,'Mircea' ,7 ,0 );

insert into Ingineri_de_sunet
values(5,'Corneliu' ,'Laurentiu' ,6 ,0 );

insert into Ingineri_de_sunet
values(6,'Lucius' ,'Vorenus' ,4 ,0 );





-------echipament------------

--cod_produs, index_scena, id_inginer, rol, marca, pret
insert into Echipament
values(1, 1, 3, 'amplificare', 'Marshall', 8000);

insert into Echipament
values(2, 1, 4, 'inregistrare', 'shure' , 1000);

insert into Echipament
values(3, 2, 5, 'amplificare', 'Fender' , 10000);

insert into Echipament
values(4, 2, 5, 'inregistrare', 'Senheiser', 2000);

insert into Echipament
values(5, null, null, 'proptire', 'mic-stands', 500);

insert into Echipament
values(6, null , null, 'inregistrare', 'shure', 7500);

insert into Echipament
values(9, 4, 3, 'amplificare', 'Marshall', 6000);

insert into Echipament
values(10, 4, 4, 'inregistrare', 'shure' , 3000);

insert into Echipament
values(7, 4, 5, 'amplificare', 'Fender' , 11000);

insert into Echipament
values(8, 1, 5, 'inregistrare', 'Senheiser', 2200);

insert into Echipament
values(11, 3, 2, 'amplificare', 'Fender' , 7000);

insert into Echipament
values(12, 3, 3, 'inregistrare', 'Senheiser', 1500);



-------contine------------
--id_artist, id_trupa
insert into Contine
values(1 , 6);

insert into Contine
values(7 , 6);

insert into Contine
values(8 , 6);

insert into Contine
values(1 , 5);

insert into Contine
values(7 , 5);

insert into Contine
values(8 , 5);

insert into Contine
values(2 ,6 );

insert into Contine
values(3 , 2);

insert into Contine
values(4 , 2);

insert into Contine
values(5, 2);

insert into Contine
values(6 , 2);

insert into Contine
values(9 , 3);

insert into Contine
values(10 , 3);

insert into Contine
values(3 , 4);

insert into Contine
values(1 , 4);

insert into Contine
values(6 , 4);

insert into Contine
values(5 , 4);


