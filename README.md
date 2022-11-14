## PBD_Proiect

### Baza de date Students:   
Tabel: **conturi**   
username: varchar(50) (allowing nulls -> verified in source code tho')   
password: varchar(50) (--||--)   

Tabel: **student**   
nrLegim: bigint PK   
nume: varchar(15)   
prenume: varchar(20)   
medie_generala: float (allowing nulls -> checked)   
medie_an1: float (allowing nulls -> checked)   
medie_an2: float (allowing nulls -> checked)   
medie_an3: float (allowing nulls -> checked)   
   
Tabel: **note**   
nrLegim: bigint FK student(nrLegim)    
disciplina: varchar(20) (allowing nulls -> checked)      
an_studiu: int (allowing nulls -> checked)     
nr_prezentare: int (allowing nulls -> checked)     
data_prezentare: date (allowing nulls -> checked)   
nota_obtinuta: float (allowing nulls -> checked)   
