-- Guia N°A
-- Bryan Josué Alberto Elena

CREATE DATABASE BD_AE210567_P4
GO

USE BD_AE210567_P4
GO

CREATE TABLE Participantes
(Codigo varchar(25) primary key,
 Nombres varchar(25),
 Apellidos varchar(25),
 Edad int
)
GO

insert into Participantes values (1,'Alba','Castro',26)
insert into Participantes values (2,'Mario','Abarca',25)
insert into Participantes values (3,'Alberto','Granados',30)
insert into Participantes values (4,'Itzel','Martincez',28)
GO

select * from Participantes