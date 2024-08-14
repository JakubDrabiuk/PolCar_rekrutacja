
create table Priorytet 
(
	PriID int identity (0,1) not null,
	Pri_Nazwa nvarchar (500) null,
	Pri_Opis nvarchar (500) null
	PRIMARY KEY(PriId)
)
GO

create table PracownikRola 
(
	PraRID int identity (1,1) not null,
	PraR_Nazwa nvarchar (500) null,
	PraR_Opis nvarchar (500) null
	PRIMARY KEY(PraRID)
)
GO



create table Pracownik 
(
	PraID int identity (1,1) not null,
	Pra_Nazwa nvarchar (500) null,
	Pra_PraRID INT   not null,
	Pra_Szef int null
	PRIMARY KEY(PraID),
	FOREIGN KEY(Pra_PraRID) REFERENCES PracownikRola (PraRID)
)
GO

create table ZadaniaStatus 
(
	ZadStID  int identity (1,1) not null,
	ZadSt_Nazwa nvarchar (500) null,
	ZadSt_Opis nvarchar (500) null
	PRIMARY KEY(ZadStID)
)
GO


create table Zadania 
(
	ZadID int identity (1,1) not null,
	Zad_Naglowek nvarchar (500) null,
	Zad_Opis nvarchar (500) null,
	Zad_Priorytet int not null,
	Zad_Status int  null,
	Zad_pracownik int not null,
	Zad_Data date not null
	PRIMARY KEY(ZadID),
	FOREIGN KEY(Zad_pracownik) REFERENCES Pracownik (PraID),
	FOREIGN KEY(Zad_Priorytet) REFERENCES Priorytet (PriID),
	FOREIGN KEY(Zad_Status) REFERENCES ZadaniaStatus (ZadStID)
)
GO