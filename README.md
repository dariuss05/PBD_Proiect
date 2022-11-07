## PBD_Proiect

### Baza de date Students:   
Tabel: **conturi**   
username: varchar(50) (allowing nulls -> verified in source code tho')   
password: varchar(50) (--||--)   

Tabel: **students**   
nrLegim: bigint PK   
nume: varchar(15)   
prenume: varchar(20)   
medie_generala: float (allowing nulls -> checked)   
medie_an1: float (allowing nulls -> checked)   
medie_an2: float (allowing nulls -> checked)   
medie_an3: float (allowing nulls -> checked)   
   
Tabel: **note**   
nrLegim: bigint PK FK nrLegim     
disciplina: varchar(20)   
an_studiu: int   
nr_prezentare: int   
data_prezentare: date   
nota_obtinuta: float   
