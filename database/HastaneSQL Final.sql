create database Hastane
use Hastane

create table KullaniciTuru
(
TurID int primary key identity(1,1),
[Kullanici Turu] nvarchar(50)
)

insert  into KullaniciTuru([Kullanici Turu]) --TurID identity olduðu için Insert Kapalý
values
('Admin'), 
('Doktor'),
('Sekreter'),
('VIP');

create table Bolumler
(
BolumID int primary key identity(1,1),
[Bolum Adý] nvarchar(60) 
)

insert into Bolumler([Bolum Adý])
values('Aðýz ve Diþ Saðlýðý'),
('Beslenme ve Diyetetik'),
('Çocuk Hastalýklarý'),
('Dahiliye'),
('Dermatoloji'),
('Enfeksiyon Hastalýklarý'),
('Göz Hastalýklarý'),
('Kadýn Hastalýklarý ve Doðum'),
('Kalp ve Damar Cerrahisi'),
('Kulak Burun Boðaz (KBB)'),
('Ortopedi'),
('Ruh ve Sinir Hastalýklarý'),
('Üroloji'),
('Bilgi Ýþlem'),
('Hasta Kayýt');

create table KullaniciBilgileri
(
PersonelID int primary key identity(1,1),
[Kullanici Turu] int, -- TurID Foreign Key KullaniciTuru(TurID)
Bolumu int, --BolumID Foreign Key Bolumler(BolumID)
KulAdi nvarchar(50) unique,
Sifre nvarchar(50),
Ad nvarchar(50),
Soyad nvarchar(50),
TCKimlikNo nvarchar(11) unique,
Telefon nvarchar(11),
)

insert into KullaniciBilgileri([Kullanici Turu],Bolumu,KulAdi,Sifre,Ad,Soyad,TCKimlikNo,Telefon)
values
(1,14,'admin','admin','Burak','ALKAN','12312312312','05555555555'),
(2,2,'deneme','deneme','Doktor','Beslenme','12345678901','05051231525')



create table HastaBilgileri
(
HastaID int primary key identity(1,1),
TCKimlikNo nvarchar(11) unique,
Ad nvarchar(50),
Soyad nvarchar(50),
[Doðum Tarihi] date,
[Doðum Yeri] nvarchar(50),
Cinsiyet nvarchar(50),
[Medeni Hal] nvarchar(50),
[Kan Grubu] nvarchar(50),
Alerji nvarchar(50),
[Hasta Giriþ] date,
[Hasta Çýkýþ] date,
Adres nvarchar(150),
Telefon nvarchar(11),
Bolumu int,--Foreign Key Bolumler(BolumID)
Doktor int--Foreign Key KullaniciBilgileri(PersonelID)
)

insert into HastaBilgileri
values
('13245678901','Deneme','Deneme','01.01.2024','Ýstanbul','Erkek','Bekar','A Rh+','Yok','03.05.2024','04.05.2024','Ýstanbul','05071234564',2,2)


CREATE TABLE Islemler
(
    IslemID int PRIMARY KEY IDENTITY(1,1),
    HastaID int, --HastaID HastaBilgileri(HastaID)
    Bolumu int, --BolumID Foreign Key Bolumler(BolumID)
    Doktor int,--PersonelID Foreign Key KullaniciBilgileri(PersonelID)
    Teshis nvarchar(50),
    HastaDurum nvarchar(50),
	Tutar nvarchar(50),
    Sonuc nvarchar(50),
    OdemeDurumu nvarchar(50)
)

create table Tahliller
(
TahlilID int primary key identity(1,1),
[Tahlil Adý] nvarchar(50),
Ucret int
)
insert into Tahliller([Tahlil Adý],Ucret)
values
('MR',3000),
('Röntgen',3000),
('Ýdrar',1000),
('Kan',1000),
('Ultrason',2000),
('Endoskopi',2500)

create table GirisKayitlari (
    GirisID int primary key identity,
	KullaniciTuru int , --Foreign Key TurID KullaniciTuru(TurID)
    KullaniciAdi nvarchar(50),
    GirisTarihi datetime,
    Basarili BIT
)

alter table KullaniciBilgileri
add constraint KullaniciTurConstraint foreign key ([Kullanici Turu]) references KullaniciTuru(TurID)

alter table KullaniciBilgileri
add constraint KullaniciBolumConstraint foreign key (Bolumu) references Bolumler(BolumID);

alter table Islemler
add constraint IslemlerHastaIDConstraint foreign key (HastaID) references HastaBilgileri(HastaID)

alter table Islemler
add constraint IslemlerBolumIDConstraint foreign key (Bolumu) references Bolumler(BolumID)

alter table Islemler
add constraint IslemlerDoktorConstraint FOREIGN KEY (Doktor) REFERENCES KullaniciBilgileri(PersonelID)

alter table GirisKayitlari
add constraint GirisKayitTurConstraint foreign key (KullaniciTuru) references KullaniciTuru(TurID)

alter table HastaBilgileri
add constraint HastaBolumConstraint foreign key (Bolumu) references Bolumler(BolumID)

alter table HastaBilgileri
add constraint HastaDoktorConstraint foreign key (Doktor) references KullaniciBilgileri(PersonelID)