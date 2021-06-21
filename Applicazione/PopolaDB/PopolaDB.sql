/*
INSERT INTO militare(MatricolaMilitare,Nome,Cognome,Grado,Email,Telefono,CodiceFiscale,StatoFamiliare,Tipo,Stormo,GruppoDiVolo)
VALUES ('vdclwxdsglxfuie7cl4n','Alex','Testa','Maresciallo','alex.testa@studio.unibo.it','+393477603310','TSTLXA00P19H294I','Celibe','Pilota',20,20),
	   ('r4lc7vk1ss19h7rxhlkb','Marco','Corbelli','Maresciallo','marco.corbelli@studio.unibo.it','+393663648727','CRBMRC00M22H294W','Celibe','Specialista',null,null),
	   ('dkjnbsze47ytln8wyl8f','Manuel','Andru','Tenente','manu.andru@studio.unibo.it','+393333596990','NDRMNL00C24H294R','Sposato','Pilota',40,40),
	   ('hyw7rctz1kujgdptlcva','Massimo','Dichio','Tenente','massimo.dic@studio.unibo.it','+393936017794','DCHMSM00H13H294O','Celibe','Specialista',null,null),
	   ('fcahzvntjcf1xhvea1xw','Mattia','Marocchi','Maresciallo','mattia.maroc@studio.unibo.it','+393336496490','MRCMTT01H27H294X','Sposato','Pilota',20,20),
	   ('6ci7jp2feyxb0w0oe6tx','Carmine','Testa','Capitano','carmine.testa@studio.unibo.it','+393475708823','TSTCMN61L25G964A','Sposato','Specialista',null,null)
*/


/*
INSERT INTO idoneita_medica(CodiceIdoneità,StatoMentale,CondizioniGenerali,DataDiScadenza,MatricolaMilitare)
VALUES ('aef03n677i',1,1,'2021-03-01','vdclwxdsglxfuie7cl4n'),
	   ('ph4p6kzhrg',1,1,'2021-02-10','dkjnbsze47ytln8wyl8f'),
	   ('xwkk1th89j',1,1,'2021-05-10','fcahzvntjcf1xhvea1xw')
*/

/*
INSERT INTO aeromobile(CodiceAeromobile,Nome,Costruttore,FunzionePrimaria,QuotaOperativa,VelocitàMassima,Autonomia,SpintaMassima,CapienzaSerbatoio,Motore,Peso,LunghezzaPistaDiAtterraggio,NumeroMembri,Dimensioni)
VALUES ('x02mqpf1hj','F-16 Falco','LMTAS','Caccia multiruolo',18.000,2.50,4.000,13.140,3.200,'Prop',8.627,1.5,1,'Lunghezza : 15,03 m,Altezza : 5,09 m'),
	   ('8zru4czeg8','F-15C','Douglas','Superiorità aerea',20.000,2.50,3.900,10.800,3.900,'Prop',12.975,1.0,1,'Lunghezza : 19,43 m,Altezza : 5,63 m'),
	   ('bebbjl9eey','MiG-29S','MAPO','Superiorità aerea',18.000,2.30,2.900,8.300,3.200,'Prop',10.900,2.0,2,'Lunghezza : 17,32 m,Altezza : 4,73 m');
	   */
/*
INSERT INTO patente(CodiceAeromobile,MatricolaMilitare,DataDiRilascio)
VALUES('x02mqpf1hj','vdclwxdsglxfuie7cl4n','2020-01-01'),
	  ('x02mqpf1hj','6ci7jp2feyxb0w0oe6tx','2020-03-10'),
	  ('8zru4czeg8','dkjnbsze47ytln8wyl8f','2020-01-01'),
	  ('8zru4czeg8','r4lc7vk1ss19h7rxhlkb','2020-05-27'),
	  ('bebbjl9eey','hyw7rctz1kujgdptlcva','2020-04-13'),
	  ('bebbjl9eey','fcahzvntjcf1xhvea1xw','1997-04-13'),
	  ('x02mqpf1hj','6ci7jp2feyxb0w0oe6tx','2020-02-15');
*/

/*
INSERT INTO manutenzione(CodiceAeromobile,MatricolaMilitare,Data,StatoDelVelivolo)
VALUES('x02mqpf1hj','6ci7jp2feyxb0w0oe6tx','2021-06-17',1),
	  ('8zru4czeg8','r4lc7vk1ss19h7rxhlkb','2021-06-20',1),
	  ('bebbjl9eey','hyw7rctz1kujgdptlcva','2021-06-22',1);
*/

/*
INSERT INTO aeroporto(CodiceAeroporto,LunghezzaPista)
VALUES('RMI',3.340),
	  ('FCO',3.500),
	  ('MXP',1.000),
	  ('NAP',2.000),
      ('PES',3.500);
*/

/*
INSERT INTO Missione(Nome,Descrizione,Emergenza,Tipo,CodiceAeroporto,AeroportoDiPartenza,AeroportoDiArrivo)
VALUES ('Volo libero','Il pilota dovrà effetture un volo ricognitivo',0,'Addestramento','RMI','RMI','RMI'),
	   ('Volo corto','Il pilota dovrà effetture un volo a corto raggio',0,'Reale','FCO','FCO','RMI'),
	   ('Scramble','Scramble in contatto con un aeromobile non identificato',0,'Addestramento','NAP','NAP','NAP'),
       ('Emergenza','Il pilota dovrà effetture un atterraggio di emergenza',1,'Realistico','NAP','NAP','PES');
*/

/*
INSERT INTO volo(CodiceVolo,Partenza,Arrivo,Data,DurataComplessiva,MatricolaMilitare,CodiceAeromobile,Nome)
VALUES ('otgd4voefj',18.00,19.00,'2021-06-17',60,'vdclwxdsglxfuie7cl4n','x02mqpf1hj','Volo libero'),
	   ('a86l5tap2d',17.00,19.00,'2021-05-27',120,'dkjnbsze47ytln8wyl8f','8zru4czeg8','Volo corto'),
	   ('5dcfv2vxho',15.30,16.00,'2021-05-10',30,'fcahzvntjcf1xhvea1xw','bebbjl9eey','Scramble'),
       ('zevo56prot',20.00,21.00,'2021-06-21',60,'vdclwxdsglxfuie7cl4n','x02mqpf1hj','Emergenza');
*/
