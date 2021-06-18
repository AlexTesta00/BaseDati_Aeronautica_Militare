-- Operazione 1
-- INSERT INTO militare(MatricolaMilitare,Nome,Cognome,Grado,Email,Telefono,CodiceFiscale,StatoFamiliare,Tipo,Stormo,GruppoDiVolo)
-- VALUES ('vdclwxdsglxfuie7cl4n','Alex','Testa','Maresciallo','alex.testa@studio.unibo.it','3477603310','TSTLXA00P19H294I','Celibe','Pilota',20,20)

-- Operazione 2
-- INSERT INTO patente(CodiceAeromobile,MatricolaMilitare,DataDiRilascio)
-- VALUES('x02mqpf1hj','vdclwxdsglxfuie7cl4n','2020-01-01')

-- Operazione 3
-- INSERT INTO idoneita_medica(CodiceIdoneità,StatoMentale,CondizioniGenerali,DataDiScadenza,MatricolaMilitare)
-- VALUES ('aef03n677i',true,true,'2022-01-01idoneita_medica','vdclwxdsglxfuie7cl4n')

-- Operazione 4
-- INSERT INTO militare(MatricolaMilitare,Nome,Cognome,Grado,Email,Telefono,CodiceFiscale,StatoFamiliare,Tipo,Stormo,GruppoDiVolo)
-- VALUES ('b9mrmol76jttzh69mvwq','Marco','Corbelli','Maresciallo','marco.corbelli@studio.unibo.it','3662648727','CRBMRC00M22H294W','Celibe','Pilota',NULL,NULL)

-- Operazione 5
-- INSERT INTO aeromobile(CodiceAeromobile,Nome,Costruttore,FunzionePrimaria,QuotaOperativa,VelocitàMassima,Autonomia,SpintaMassima,CapienzaSerbatoio,Motore,Peso,LunghezzaPistaDiAtterraggio,NumeroMembri,Dimensioni)
-- VALUES ('x02mqpf1hj','F-16 Falco','LMTAS','Caccia multiruolo',18.000,2.05,4.000,13.140,3.200,'Propaeromobile',8.627,1.5,1,'Lunghezza : 15,03 m,Altezza : 5,09 m')

-- Operazione 6
-- INSERT INTO manutenzione(CodiceAeromobile,MatricolaMilitare,Data,StatoDelVelivolo)
-- VALUES('x02mqpf1hj','b9mrmol76jttzh69mvwq','2021-06-17',true)

-- Operaizone 7
-- INSERT INTO volo(CodiceVolo,Partenza,Arrivo,Data,DurataComplessiva,MatricolaMilitare,CodiceAeromobile,Nome)
-- VALUES ('otgd4voefj',18.00,19.00,'2021-06-17',60,'vdclwxdsglxfuie7cl4n','x02mqpf1hj','Volo libero')



-- Altro

-- Inserisco un aeroporto
-- INSERT INTO aeroporto(CodiceAeroporto,LunghezzaPista)
-- VALUES('RMI',3.340)

-- Inserisco una missione
-- INSERT INTO Missione(Nome,Descrizione,Emergenza,Tipo,CodiceAeroporto,AeroportoDiPartenza,AeroportoDiArrivo)
-- VALUES('Volo libero','Il pilota dovrà effetture un volo ricognitivo',false,'Addestramento','RMI','RMI','RMI')