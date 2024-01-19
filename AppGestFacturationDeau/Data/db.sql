use master
go

CREATE DATABASE db_facture_eau
GO

USE db_facture_eau
GO

IF (OBJECT_ID('Utilisateur') IS NULL)
BEGIN
	CREATE TABLE Utilisateur
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		LoginUtil NVARCHAR(99) NOT NULL UNIQUE,
		[Mot de passe] NVARCHAR(99) NOT NULL
	)
END
ELSE
	PRINT 'la table Utilisateur deja exists'
GO

IF (OBJECT_ID('Adherent') IS NULL)
BEGIN
	CREATE TABLE Adherent
	(
		Id INT NOT NULL IDENTITY PRIMARY KEY,
		CIN NVARCHAR(20) NOT NULL,
		Nom NVARCHAR(99) NOT NULL,
		Prenom NVARCHAR(99) NOT NULL,
		[Date Inscription] DATE 
	)
END
ELSE
	PRINT 'la table Adherent deja exists'
GO

IF (OBJECT_ID('Compteur') IS NULL)
BEGIN
CREATE TABLE Compteur
(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	IdAdherent INT NOT NULL REFERENCES Adherent(Id)
)
END
ELSE
	PRINT 'la table Compteur est deja exists'
GO


IF (OBJECT_ID('Consomation') IS NULL)
BEGIN
CREATE TABLE Consomation
(
	IdCompteur INT NOT NULL REFERENCES Compteur(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	[Date debut] DATE NOT NULL,
	[Date fin] DATE NOT NULL,
	Ancienne INT NOT NULL,
	Nouvelle INT NOT NULL ,
	Perenete MONEY NOT NULL DEFAULT(0),
	CONSTRAINT pk_consomation PRIMARY KEY (IdCompteur,[Date debut],[Date fin]),
	CONSTRAINT chk_verification CHECK (Nouvelle>= Ancienne)
)
END
ELSE
	PRINT 'la table Consomation est deja exists'
GO

IF (OBJECT_ID('Tranche') IS NULL)
BEGIN
CREATE TABLE Tranche
(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Libelle NVARCHAR(99) NOT NULL CHECK(Libelle IN(N'الشطر الاول',N'الشطر الثاني',N'الشطر الثالث')),
	Prix MONEY
)
END
ELSE
	PRINT 'la table Tranche est deja exists'
GO

IF (OBJECT_ID('Facture') IS NULL)
BEGIN
CREATE TABLE Facture
(
	IdF INT NOT NULL PRIMARY KEY IDENTITY,
	IdC INT NOT NULL REFERENCES Compteur(Id) ON DELETE CASCADE ON UPDATE CASCADE,
	Prix MONEY NOT NULL,
	DateFac DATE NOT NULL DEFAULT GETDATE(),
	DateFin AS DATEADD(DAY, 14, DateFac),
	Paye NVARCHAR (6) NOT NULL CHECK (Paye IN(N'لا', N'نعم')) DEFAULT N'لا'
)
END
ELSE
	PRINT 'la table facture est deja exists'
GO


IF (OBJECT_ID('Taxe') IS NULL)
BEGIN
CREATE TABLE Taxe
(
	IdT INT NOT NULL PRIMARY KEY IDENTITY,	
	Prix MONEY NOT NULL,
)
END
ELSE
	PRINT 'la table Taxe est deja exists'
GO

---------------------------------------------------------------------------------------------------------------------
insert into taxe values(10)
go


insert into Utilisateur values('Admin1','Aa123')
go

insert into Utilisateur values('Admin2','Aa123')
go

INSERT INTO Adherent VALUES('151184419','Griefen','Doreen',null),
							('P13620',N'محب',N'الحسين',null),
							('P84915',N'جملاوي',N'عمر',null),
							('P36697',N'محب',N'لحسن',null),
							('PA15298',N'لعبوب',N'الحسين',null),
							('P93738',N'بوسلام',N'الحسين',null),
							('P94107',N'لعبوب',N'زنبة',null),
							('P85048',N'جائز',N'علي',null),
							('P11792',N'رحيم',N'لحسن',null),
							('PA13924',N'رحيم',N'مصطفى',null),
							('PA5313',N'رحيم',N'محمد',null),
							('P35842',N'بلحو',N'ابراهيم',null),
							('P39743',N'شفيق',N'عمر',null),
							('PA41890',N'شعيبي',N'الخير',null),
							('P802389',N'أيت اعدي',N'الحسين',null),
							('P80800',N'أيت اعدي',N'امبارك',null),
							('P909',N'بالحسين',N'الخير',null),
							('PA13757',N'حسناوي',N'محمد',null),
							('P84793',N'دوربي',N'محمد',null),
							('P38455',N'ناصرالدين',N'محمد',null),
							('P82138',N'لحواط',N'الحسين',null), 
							('U89870',N'أيت خندوش',N'سعيد',null),
							('PA43259',N'عديموش',N'زنبة',null),   
							('P8788',N'الداودي',N'حسن',null),   
							('P13534',N'الداودي',N'محمد',null),    
							('P80771',N'بالحسين',N'كلتومة',null),   
							('P12637',N'بوعزيزي',N'لحسن',null),    
							('P81586',N'بن سعيد',N'عمر',null),    
							('PA33675',N'الناصري',N'عبد الرحمان',null),    
							('PA72956',N'أزوراغ',N'السعيد',null),    
							('P82340',N'صابر',N'ابراهيم',null),       
							('P21856',N'صابر',N'لحسن',null),       
							('P39173',N'الزهراوي',N'الحسين',null),
							('PA24539',N'عبد الياسين',N'احمد',null),
							('P13527',N'صادر',N'موحي',null),
							('P21746',N'مسعودي',N'الحسين',null),
							('P84883',N'صادر',N'لحسن',null),
							('P81090',N'الإمام',N'زايد',null),
							('PA1007',N'الزوراغي',N'محمد',null),
							('PA35613',N'البوعزيزي',N'محمد',null),
							('P86312',N'مسعودي',N'محمد',null),
							('P82018',N'مسعودي',N'عدي',null),
							('P13276',N'الناصري',N'زايد',null),
							('P13614',N'أعلى',N'محمد',null),
							('P38379',N'لحواد',N'موحي',null),
							('PA13712',N'بن عبد الله ',N'ألخير',null),
							('',N'بولماني ',N'الحسين',null),   
							('P89386',N'امحضار ',N'حمو',null),   
							('P93246',N'صبري ',N'حسن',null),    
							('P93659',N'قاموش ',N'محمد بن علي ',null),      
							('P85621',N'براوي ',N'بوعزي ',null),          
							('PA37472',N'قاموش ',N'ابراهيم ',null),         
							('PA29846',N'قاموش ',N'حميد ',null),         
							('P35167',N'قاموش ',N'عمر ',null),         
							('P12248',N'قاموش ',N'محمد الحاج ',null), 
							('PA16678',N'الصوفي ',N'لحسن ',null),  
							('P87410',N'علاوي ',N'كلتومة ',null),   
							('P37886',N'جبراوي ',N'امبارك ',null),  
							('PA13057',N'أختار ',N'راشيد ',null),  
							('PA25723',N'المقدم ',N'رقية ',null),   
							('P83081',N'حانوني ',N'العربي ',null),   
							('PA31515',N'بنداود ',N'محمد ',null),    
							('A52015',N'ماشاء الله ',N'موحي حسو ',null), 
							('PA14929',N'جبراوي',N'حسن',null),  
							('P7324',N'جبراوي',N' إيشو',null), 
							('P33175',N'السعدي',N' علي',null),  
							('PA16734',N'المقدم',N' يوسف',null),  
							('PA20274',N'المقدم',N' علي',null),   
							('P85803',N'المقدم',N' عدي',null),   
							('P86774',N'جبراوي',N'بامو',null),   
							('P9701',N'المقدم',N' محمد',null),   
							('A45081',N'المقدم',N' عبد القادر',null),
							('PZ810260',N'ماشاء الله',N'محمد',null),
							('P83948',N'المقدم',N'موحي أعسو',null),
							('PA109340',N'ماشاء الله',N'العربي',null),
							('P40257',N'المقدم',N'الحسين',null),
							('P4832',N'الزياني',N'الحسين',null), 
							('AB150456',N'ماشاء الله',N'عيسي',null),
							('P8520',N'ماشاء الله',N'احمد',null), 
							('AD42291',N'النعيم',N'السعدية',null), 
							('P83193',N'جبراوي',N'عبد الكريم ',null), 
							('P22274',N'أختار',N'محمد ',null),  
							('P85806',N'أحنين',N'مهدي ',null),  
							('P83081',N'حانوني',N'العربي ',null), 
							('PA39738',N'شراف',N'رقية ',null),  
							('A258697',N'مناج',N'فاطمة ',null),  
							('PA31515',N'بنداود',N'محمد ',null),   
							('P82479',N'الطاهري',N'محمد ',null),   
							('P80098',N'أغريس',N'بناصر ',null),    
							('P9086',N'جعواني',N'محمد ',null),    
							('P82640',N'جعواني',N'احمد ',null),   
							('PA5210',N'حنوني',N'محمد ',null),     
							('PA1655',N'أمحضر',N'لحسن ',null),     
							('AB630',N'ماشاء الله ',N'علي ',null),      
							('P14415',N'ميكاني',N'محمد ',null),      
							('PA19034',N'أمزوز',N'صفية ',null),       
							('PA4832',N'الزياني',N'الحسين ',null),      
							('P81088',N'ماحو',N'محمد ',null),       
							('P13835',N'عسري',N'عدي ',null),     
							('PA89734',N'العثماني',N'امبارك ',null), 
							('PA47621',N'العثماني',N'امحمد ',null),  
							('P7788',N'أبو زيد',N'محمد ',null),   
							('P93797',N'قاموش',N'مهدي ',null),    
							('P91369',N'بن علي',N'محمد ',null),   
							('PA11421',N'بلخير',N'محمد ',null),   
							('PA23652',N'ويسكان',N'محمد بن داني ',null),
							('PA22139',N'ماحلي',N'جديكة',null), 
							('PA22139',N'ماحلي',N'جديكة',null),
							('PA20297',N'أعبي',N'محمد',null), 
							('A78566',N'ويسكان',N'محمد',null),   
							('PA45350',N'قاموش',N'امحمد',null),    
							('P801915',N'أعبي',N'احمد',null),      
							('PA62079',N'المقدم',N'لطيفة',null),   
							('PA24674',N'أشربن',N'فاطمة',null),    
							('P8611',N'أيت عقي',N'علي',null),  
							('PA69274',N'شفيقي',N'جمال',null),    
							('PA70977',N'عديموش',N'علي',null),    
							('P12685',N'بوسلام',N'لحسن',null),
							('PA16478',N'محب',N'حكة',null),  
							('P7788',N'بوزيد',N'محمد',null),     
							('P38408',N'لحواد',N'زايد',null),     
							('P19042',N'قاموش',N'الحسين',null),     
							('P7577',N'الزياني',N'لحسن',null),     
							('P80847',N'الزياني',N'حمو',null), 
							('P86774',N'جبراوي',N'بامو',null),  
							('P85803',N'المقدم',N'عدي',null),       
							('P13504',N'براوي',N'امحمد',null),      
							('P40661',N'اختار',N'الحسين',null),      
							('PA20800',N'جملاوي',N'امحمد',null),      
							('P85114',N'محييب',N'محمد',null),  
							('PA3967',N'امحضار',N'سعيد',null),        
							('P22274',N'اختار',N'محمد',null),        
							('P85806',N'احنين',N'مهدي',null),        
							('UA28613',N'اخويا',N'احساين',null),        
							('P85722',N'جملاوي',N'عبد القادر',null),         
							('P802401',N'براوي',N'لحسن',null),  
							('P8447',N'المقدم',N'براهيم',null),
							('PA47896',N'عبد الياسين',N'علي',null),         
							('PA16460',N'ابحري',N'محمد',null),         
							('PA106301',N'محلي',N'عبد المجيد',null),         
							('PA47896',N'الزوراغي',N'حسن',null),          
							('PA48083',N'جبراوي',N'جمال',null),          
							('PA25903',N'جبراوي',N'احمد',null),          
							('AB342654',N'جبراوي',N'نزيه',null),          
							('P90296',N'جبراوي',N'محمد',null),          
							('U89870',N'ايت خندوش',N'سعيد',null),          
							('P10997',N'ناصر الدين',N'امحمد',null)
GO

DECLARE @I int
select @I = 1 
while @I <= 147
begin
	insert into Compteur values(@I)
	select @I = @I + 1
end
GO

----------------
INSERT INTO Consomation(IdCompteur,[Date debut],[Date fin],Ancienne,Nouvelle) VALUES (1,'04-01-2019','04-30-2019',2751,2751),
							(2,'04-01-2019','04-30-2019',1207,1218),
							(3,'04-01-2019','04-30-2019',736,738),
							(4,'04-01-2019','04-30-2019',2290,2290),
							(5,'04-01-2019','04-30-2019',2960,2970),
							(6,'04-01-2019','04-30-2019',101,109),
							(7,'04-01-2019','04-30-2019',1757,1757),
							(8,'04-01-2019','04-30-2019',1680,1680),
							(9,'04-01-2019','04-30-2019',1072,1073),
							(10,'04-01-2019','04-30-2019',441,441),
							(11,'04-01-2019','04-30-2019',2279,2279),
							(12,'04-01-2019','04-30-2019',1059,1059),
							(13,'04-01-2019','04-30-2019',54,54),
							(14,'04-01-2019','04-30-2019',2592,2596),
							(15,'04-01-2019','04-30-2019',220,228),
							(16,'04-01-2019','04-30-2019',1211,1211),
							(17,'04-01-2019','04-30-2019',49,65),
							(18,'04-01-2019','04-30-2019',675,678),
							(19,'04-01-2019','04-30-2019',3308,3312),
							(20,'04-01-2019','04-30-2019',2204,2213),
							(21,'04-01-2019','04-30-2019',574,574),
							(22,'04-01-2019','04-30-2019',2025,2043),
							(23,'04-01-2019','04-30-2019',131,139),
							(24,'04-01-2019','04-30-2019',736,736),
							(25,'04-01-2019','04-30-2019',3575,3607),
							(26,'04-01-2019','04-30-2019',1172,1174),
							(27,'04-01-2019','04-30-2019',1405,1418),
							(28,'04-01-2019','04-30-2019',612,613),
							(29,'04-01-2019','04-30-2019',425,425),
							(30,'04-01-2019','04-30-2019',2264,2276),
							(31,'04-01-2019','04-30-2019',1423,1423),
							(32,'04-01-2019','04-30-2019',885,885),
							(33,'04-01-2019','04-30-2019',1307,1315),
							(34,'04-01-2019','04-30-2019',567,575),
							(35,'04-01-2019','04-30-2019',1899,1905),
							(36,'04-01-2019','04-30-2019',1832,1842),
							(37,'04-01-2019','04-30-2019',2152,2162),
							(38,'04-01-2019','04-30-2019',353,353),
							(39,'04-01-2019','04-30-2019',8,9),
							(40,'04-01-2019','04-30-2019',1653,1667),
							(41,'04-01-2019','04-30-2019',911,917),
							(42,'04-01-2019','04-30-2019',1692,1704),
							(43,'04-01-2019','04-30-2019',1016,1022),
							(44,'04-01-2019','04-30-2019',729,740),
							(45,'04-01-2019','04-30-2019',3589,3608),
							(46,'04-01-2019','04-30-2019',1002,1009),
							(47,'04-01-2019','04-30-2019',83,83),
							(48,'04-01-2019','04-30-2019',381,385),
							(49,'04-01-2019','04-30-2019',1298,1302),
							(50,'04-01-2019','04-30-2019',2907,2921),
							(51,'04-01-2019','04-30-2019',923,938),
							(52,'04-01-2019','04-30-2019',2427,2442),
							(53,'04-01-2019','04-30-2019',1366,1371),
							(54,'04-01-2019','04-30-2019',263,263),
							(55,'04-01-2019','04-30-2019',831,831),
							(56,'04-01-2019','04-30-2019',1743,1752),
							(57,'04-01-2019','04-30-2019',321,321),
							(58,'04-01-2019','04-30-2019',45,48),
							(59,'04-01-2019','04-30-2019',3270,3278),
							(60,'04-01-2019','04-30-2019',771,774),
							(61,'04-01-2019','04-30-2019',625,630),
							(62,'04-01-2019','04-30-2019',373,375),
							(63,'04-01-2019','04-30-2019',945,953),
							(64,'04-01-2019','04-30-2019',4548,4549),
							(65,'04-01-2019','04-30-2019',20,28),
							(66,'04-01-2019','04-30-2019',2253,2266),
							(67,'04-01-2019','04-30-2019',2042,2043),
							(68,'04-01-2019','04-30-2019',4158,4179),
							(69,'04-01-2019','04-30-2019',1513,1522),
							(70,'04-01-2019','04-30-2019',1320,1326),
							(71,'04-01-2019','04-30-2019',1875,1897),
							(72,'04-01-2019','04-30-2019',304,310),
							(73,'04-01-2019','04-30-2019',190,190),
							(74,'04-01-2019','04-30-2019',2163,2175),
							(75,'04-01-2019','04-30-2019',2445,2458),
							(76,'04-01-2019','04-30-2019',898,904),
							(77,'04-01-2019','04-30-2019',1260,1265),
							(78,'04-01-2019','04-30-2019',1128,1132),
							(79,'04-01-2019','04-30-2019',2947,2947),
							(80,'04-01-2019','04-30-2019',40,40),
							(81,'04-01-2019','04-30-2019',637,637),
							(82,'04-01-2019','04-30-2019',32,37),
							(83,'04-01-2019','04-30-2019',2954,2972),
							(84,'04-01-2019','04-30-2019',1865,1872),
							(85,'04-01-2019','04-30-2019',582,582),
							(86,'04-01-2019','04-30-2019',925,926),
							(87,'04-01-2019','04-30-2019',1308,1312),
							(88,'04-01-2019','04-30-2019',1950,1953),
							(89,'04-01-2019','04-30-2019',1793,1808),
							(90,'04-01-2019','04-30-2019',2099,2109),
							(91,'04-01-2019','04-30-2019',2062,2071),
							(92,'04-01-2019','04-30-2019',2217,2228),
							(93,'04-01-2019','04-30-2019',741,744),
							(94,'04-01-2019','04-30-2019',793,793),
							(95,'04-01-2019','04-30-2019',2548,2567942),
							(96,'04-01-2019','04-30-2019',606,613),
							(97,'04-01-2019','04-30-2019',2577,2592),
							(98,'04-01-2019','04-30-2019',853,867),
							(99,'04-01-2019','04-30-2019',547,551),
							(100,'04-01-2019','04-30-2019',1259,1260),
							(101,'04-01-2019','04-30-2019',822,828),
							(102,'04-01-2019','04-30-2019',561,561),
							(103,'04-01-2019','04-30-2019',369,374),
							(104,'04-01-2019','04-30-2019',411,411),
							(105,'04-01-2019','04-30-2019',4417,4449),
							(106,'04-01-2019','04-30-2019',1057,1062),
							(107,'04-01-2019','04-30-2019',1317,1364),
							(108,'04-01-2019','04-30-2019',877,879),
							(109,'04-01-2019','04-30-2019',1217,1226),
							(110,'04-01-2019','04-30-2019',2332,2355),
							(111,'04-01-2019','04-30-2019',3313,3319),
							(112,'04-01-2019','04-30-2019',2652,2654),
							(113,'04-01-2019','04-30-2019',825,825),
							(114,'04-01-2019','04-30-2019',834,836),
							(115,'04-01-2019','04-30-2019',684,730),
							(116,'04-01-2019','04-30-2019',1911,1924),
							(117,'04-01-2019','04-30-2019',3227,3236),
							(118,'04-01-2019','04-30-2019',3149,3149),
							(119,'04-01-2019','04-30-2019',1142,1146),
							(120,'04-01-2019','04-30-2019',22,22),
							(121,'04-01-2019','04-30-2019',1320,1320),
							(122,'04-01-2019','04-30-2019',588,592),
							(123,'04-01-2019','04-30-2019',704,705),
							(124,'04-01-2019','04-30-2019',61,61),
							(125,'04-01-2019','04-30-2019',897,906),
							(126,'04-01-2019','04-30-2019',668,670),
							(127,'04-01-2019','04-30-2019',0,0),
							(128,'04-01-2019','04-30-2019',357,359),
							(129,'04-01-2019','04-30-2019',252,256),
							(130,'04-01-2019','04-30-2019',127,127),
							(131,'04-01-2019','04-30-2019',125,127),
							(132,'04-01-2019','04-30-2019',0,0),
							(133,'04-01-2019','04-30-2019',6,6),
							(134,'04-01-2019','04-30-2019',407,410),
							(135,'04-01-2019','04-30-2019',42,42),
							(136,'04-01-2019','04-30-2019',169,169),
							(137,'04-01-2019','04-30-2019',290,294),
							(138,'04-01-2019','04-30-2019',0,0),
							(139,'04-01-2019','04-30-2019',0,0),
							(140,'04-01-2019','04-30-2019',243,270),
							(141,'04-01-2019','04-30-2019',60,60),
							(142,'04-01-2019','04-30-2019',152,161),
							(143,'04-01-2019','04-30-2019',237,244),
							(144,'04-01-2019','04-30-2019',52,52),
							(145,'04-01-2019','04-30-2019',71,71),
							(146,'04-01-2019','04-30-2019',72,78),
							(147,'04-01-2019','04-30-2019',139,147)
GO

INSERT INTO Tranche VALUES(N'الشطر الاول',1.5),(N'الشطر الثاني',3),(N'الشطر الثالث',5)
GO

----------------------------
select * from Adherent
select * from Compteur
select * from Tranche
select * from Consomation
select * from Facture
select * from Taxe
GO

-----------------------------

CREATE PROC Ps_Taxe_Cry
AS
BEGIN
	SELECT Prix FROM Taxe
	RETURN 0
END
GO

Ps_Taxe_Cry
GO

CREATE PROC PS_Paye_Cry
(
	@MoisFac INT,
	@IdC INT
)
AS
BEGIN
	SELECT DISTINCT c.Id, a.Nom, a.Prenom, DATEPART(MONTH, cn.[Date debut]) AS 'Mois', f.Prix, cn.Perenete
									FROM Adherent AS a 
									INNER JOIN Compteur AS c ON a.Id = c.IdAdherent 
									INNER JOIN Consomation AS cn ON c.Id = cn.IdCompteur
									INNER JOIN Facture AS f ON c.Id = f.IdC
									where c.Id = @IdC and DATEPART(MONTH, cn.[Date debut]) = @MoisFac AND DATEPART(MONTH, f.DateFac) = @MoisFac

	RETURN 0
END
GO

PS_Paye_Cry 3, 1
GO

CREATE FUNCTION CALCUL_CONSOM 
(
	@CONS INT
) 
RETURNS @TAB TABLE(
			QTE_1 INT , QTE_2 INT,QTE_3 INT
		)
AS
	BEGIN
		DECLARE @Q1 INT , @Q2 INT, @Q3 INT
		SET @Q1 = 0
		SET @Q2 = 0
		SET @Q3 = 0
		
		IF @CONS > 25
		BEGIN
			SET @Q1 = 15
			set @Q2 = 10
			SET @CONS = @CONS - @Q1 - @Q2
			set @Q3 = @CONS
		END
		ELSE
		BEGIN
			IF @CONS > 15
			BEGIN
				SET @Q1 = 15
				SET @CONS = @CONS - 15
				SET @Q2 = @CONS
			END
			ELSE
			BEGIN
				SET @Q1 = @CONS
			END
		END
		INSERT INTO @TAB VALUES(@Q1,@Q2,@Q3)

		RETURN 
	END
GO  

SELECT * FROM  dbo.CALCUL_CONSOM(27)
GO


CREATE FUNCTION PRIX_TRANCHE ()
RETURNS @TAB TABLE  (TR_1 MONEY,TR_2 MONEY,TR_3 MONEY)
AS
	BEGIN
		DECLARE @PR1 MONEY
		DECLARE @PR2 MONEY
		DECLARE @PR3 MONEY

		SELECT @PR1 = Prix FROM Tranche WHERE Id = 1
		SELECT @PR2 = Prix FROM Tranche WHERE Id = 2
		SELECT @PR3 = Prix FROM Tranche WHERE Id = 3

		INSERT INTO @TAB VALUES(@PR1, @PR2, @PR3)
		RETURN
	END
GO

select * from dbo.PRIX_TRANCHE()
GO

CREATE PROC Ps_Qte_Cry
(
	@Mois INT
)
AS
BEGIN


	declare @tab table 
				(
					q1 int,
					q2 int,
					q3 int
				)
	DECLARE CURS CURSOR
	LOCAL 
	STATIC
	FORWARD_ONLY
	READ_ONLY
	FOR SELECT distinct  cn.Ancienne, cn.Nouvelle , (cn.Nouvelle - cn.Ancienne) as 'qte' 
									FROM Adherent AS a 
									INNER JOIN Compteur AS c ON a.Id = c.IdAdherent 
									INNER JOIN Consomation AS cn ON c.Id = cn.IdCompteur
									INNER JOIN Facture AS f ON c.Id = f.IdC
									WHERE DATEPART(MONTH, f.DateFac) = @Mois AND DATEPART(MONTH, cn.[Date debut]) = @Mois AND DATEPART(MONTH, cn.[Date fin]) = @Mois
	DECLARE @ANC INT, @NOU INT, @QTE INT
	OPEN CURS
		FETCH NEXT FROM CURS INTO @ANC, @NOU, @QTE 
		WHILE @@FETCH_STATUS = 0
			BEGIN
				insert into @tab  select QTE_1,QTE_2,QTE_3 from dbo.CALCUL_CONSOM(@QTE) 
				FETCH NEXT FROM CURS INTO @ANC, @NOU, @QTE 
			END
		CLOSE CURS
		DEALLOCATE CURS	
	
		SELECT Distinct cn.Ancienne, cn.Nouvelle ,c.Id, a.Nom, a.Prenom, DATEPART(MONTH, cn.[Date debut]) AS N'Mois', f.Prix, f.DateFac, f.DateFin , (cn.Nouvelle - cn.Ancienne) as 'qte', t.q1, t.q2, t.q3
								FROM Adherent AS a 
								INNER JOIN Compteur AS c ON a.Id = c.IdAdherent 
								INNER JOIN Consomation AS cn ON c.Id = cn.IdCompteur
								INNER JOIN Facture AS f ON c.Id = f.IdC
								inner join @tab as t on (t.q1+ t.q2+ t.q3) =  (cn.Nouvelle - cn.Ancienne)
								WHERE DATEPART(MONTH, f.DateFac) = @Mois AND DATEPART(MONTH, cn.[Date debut]) = @Mois AND DATEPART(MONTH, cn.[Date fin]) = @Mois
								
	RETURN 0
END
GO

Ps_Qte_Cry 5
GO
