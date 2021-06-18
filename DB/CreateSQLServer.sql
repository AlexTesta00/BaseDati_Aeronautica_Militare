-- *********************************************
-- * SQL MySQL generation                      
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator date: Dec  4 2018              
-- * Generation date: Thu Jun 17 10:23:07 2021 
-- * LUN file: Z:\home\alextesta\Scrivania\BasiDiDati.lun 
-- * Schema: LogicalSchema/1 
-- ********************************************* 



-- Tables Section
-- _____________ 

create table AEROMOBILE (
     CodiceAeromobile varchar(10) not null,
     Nome varchar(10) not null,
     Costruttore varchar(10) not null,
     FunzionePrimaria varchar(20) not null,
     QuotaOperativa float(5) not null,
     VelocitàMassima float(5) not null,
     Autonomia float(4) not null,
     SpintaMassima float(5) not null,
     CapienzaSerbatoio float(5) not null,
     Motore varchar(10) not null,
     Peso float(4) not null,
     LunghezzaPistaDiAtterraggio float(5) not null,
     NumeroMembri integer not null,
     Dimensioni varchar(50) not null,
     constraint IDAEROMOBILE_ID primary key (CodiceAeromobile));

create table ARMAMENTO (
     CodiceAeromobile varchar(10) not null,
     CodiceArmamento varchar(10) not null,
     NumeroMissili integer not null,
     NumeroMunizioni integer not null,
     constraint IDARMAMENTO primary key (CodiceAeromobile, CodiceArmamento),
     constraint FKCompone_ID unique (CodiceAeromobile));

create table MISSIONE (
     Nome varchar(50) not null,
     Descrizione varchar(200) not null,
     Emergenza bit,
     Tipo varchar(30) not null,
     CodiceAeroporto varchar(4) not null,
     AeroportoDiPartenza varchar(4) not null,
     AeroportoDiArrivo varchar(4) not null,
     constraint IDMISSIONE_ID primary key (Nome));

create table AEROPORTO (
     CodiceAeroporto varchar(4) not null,
     LunghezzaPista float(5) not null,
     constraint IDAEROPORTO primary key (CodiceAeroporto));

create table IDONEITA_MEDICA (
     CodiceIdoneità varchar(10) not null,
     StatoMentale bit not null,
     CondizioniGenerali bit not null,
     DataDiScadenza date not null,
     MatricolaMilitare varchar(20) not null,
     constraint IDIDONEITA_MEDICA primary key (CodiceIdoneità));

create table MANUTENZIONE (
     CodiceAeromobile varchar(10) not null,
     MatricolaMilitare varchar(20) not null,
     Data date not null,
     StatoDelVelivolo bit not null,
     constraint CodiceManutenzione primary key (MatricolaMilitare, CodiceAeromobile, Data));

create table MILITARE (
     MatricolaMilitare varchar(20) not null,
     Nome varchar(10) not null,
     Cognome varchar(10) not null,
     Grado varchar(20) not null,
     Email varchar(30) not null,
     Telefono varchar(13) not null,
     CodiceFiscale varchar(16) not null,
     StatoFamiliare varchar(10) not null,
     Tipo varchar(12) not null,
     Stormo integer,
     GruppoDiVolo integer,
     constraint IDMilitare_ID primary key (MatricolaMilitare));

create table PATENTE (
     CodiceAeromobile varchar(10) not null,
     MatricolaMilitare varchar(20) not null,
     DataDiRilascio date not null,
     constraint CodicePatente primary key (MatricolaMilitare, CodiceAeromobile, DataDiRilascio));

create table VOLO (
     CodiceVolo varchar(10) not null,
     Partenza float(4) not null,
     Arrivo float(4) not null,
     Data date not null,
     DurataComplessiva integer not null,
     MatricolaMilitare varchar(20) not null,
     CodiceAeromobile varchar(10) not null,
     Nome varchar(50) not null,
     constraint IDVOLO primary key (CodiceVolo));


-- Constraints Section
-- ___________________ 

-- Not implemented
-- alter table AEROMOBILE add constraint IDAEROMOBILE_CHK
--     check(exists(select * from MANUTENZIONE
--                  where MANUTENZIONE.Cod.Aeromobile = Cod.Aeromobile)); 

alter table ARMAMENTO add constraint FKCompone_FK
     foreign key (CodiceAeromobile)
     references AEROMOBILE (CodiceAeromobile);

-- Not implemented
-- alter table MISSIONE add constraint IDMISSIONE_CHK
--     check(exists(select * from VOLO
--                  where VOLO.Nome = Nome)); 

alter table MISSIONE add constraint FKPartenza
     foreign key (AeroportoDiPartenza)
     references AEROPORTO (CodiceAeroporto);

alter table MISSIONE add constraint FKArrivo
     foreign key (AeroportoDiArrivo)
     references AEROPORTO (CodiceAeroporto);

alter table IDONEITA_MEDICA add constraint FKConsegue
     foreign key (MatricolaMilitare)
     references MILITARE (MatricolaMilitare);

alter table MANUTENZIONE add constraint FKEffettua
     foreign key (MatricolaMilitare)
     references MILITARE (MatricolaMilitare);

alter table MANUTENZIONE add constraint FKAcquisisce
     foreign key (CodiceAeromobile)
     references AEROMOBILE (CodiceAeromobile);

-- Not implemented
-- alter table MILITARE add constraint IDMilitare_CHK
--     check(exists(select * from PATENTE
--                  where PATENTE.MatricolaMilitare = MatricolaMilitare)); 

alter table PATENTE add constraint FKAbilita
     foreign key (MatricolaMilitare)
     references MILITARE (MatricolaMilitare);

alter table PATENTE add constraint FKSpecifica
     foreign key (CodiceAeromobile)
     references AEROMOBILE (CodiceAeromobile);

alter table VOLO add constraint FKCompie
     foreign key (MatricolaMilitare)
     references MILITARE (MatricolaMilitare);

alter table VOLO add constraint FKUtilizzando
     foreign key (CodiceAeromobile)
     references AEROMOBILE (CodiceAeromobile);

alter table VOLO add constraint FKSpecializza
     foreign key (Nome)
     references MISSIONE (Nome);


-- Index Section
-- _____________ 