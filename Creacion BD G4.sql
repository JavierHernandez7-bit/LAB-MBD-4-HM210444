CREATE DATABASE BD2_HM210444
GO
USE BD2_HM210444
GO

CREATE TABLE Participantes
(Codigo varchar (25) primary key,
Nombres varchar(25),
Apellidos varchar(25),
Edad int)
GO
INSERT INTO Participantes values(1,'Alba','Castro',26)
INSERT INTO Participantes values(2,'Mario','Abarca',25)
INSERT INTO Participantes values(3,'Alberto','Granados',30)
INSERT INTO Participantes values(4,'Itzel','Martinez',28)
GO