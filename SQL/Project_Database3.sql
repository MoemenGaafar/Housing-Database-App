-------------Database creation-------------

create database Monkey
Go

use Monkey;

------------Table Creation-----------------

create table Administrator 
(
Username varchar(50) not null,
Password varchar(50) not null,
primary key (username)
)

create table HighAdministrator 
(
HUsername varchar(50),
primary key (HUsername), 
foreign key (HUsername) references Administrator,
)

Create table Access 
(
Entity varchar(50),
Pass varchar(50) not null,
primary key(Entity)
)

create table Citizen
(
NationalID	int, 
Password varchar(50) not null,
FirstName	varchar(50) not null,
LastName varchar(50) not null,
BirthDate date, 	
Salary	int, 
Sex char(1), /*F, M: female, male */
CurentCity varchar(50), 
OwnsCurrent bit, /* 0, 1: no, yes */
CurrentAccommPrice int, 
primary key (NationalID), 
)

create table Dependents
(
Name varchar(50), 
EID int, 
BirthDate date,	
Salary int Default 0,  	
Relationship char(1), /* P, S, C, O: Parent, Spouse, Child, Other */ 
primary key (Name, EID), 
foreign key (EID) references Citizen on delete Cascade on update Cascade,
)

create table Bank 
(
Name varchar(50),
Password varchar(50) not null, 
TranFees tinyint not null, 
primary key (Name),
)

create table Company 
(
CID int identity,
Password varchar(50) not null,  
Name varchar(50), 
NoCompleteProj int, 
NoCurrentProj int,
Rating tinyint, 
AvgProjectCost int, 
primary key (CID), 
)

create table Employee
(
NationalID	int, 
Password varchar(50) not null,
FirstName	varchar(50) not null,
LastName varchar(50) not null,
Sex char(1), /*F, M: female, male */
EType char(1), /* M, P, H: Manager, Projects, Housing */
StartDate date,
NoCompleteProj int,
NoCurrentProj int,  
primary key (NationalID),
)

create table Manager
(
MID int,
primary key (MID), 
foreign key (MID) references Employee,
)

create table Project
(
ID int identity, 
City varchar(50),
MEmployeeID int not null, 
PEmployeeID int not null,
PricePRoom int, 
PStatus	char(1) not null Default 'P', /*P, S, L, F: Posted, Started, Launched, All units sold */ 
CompanyID int, 
StartingDate date,	
LaunchingDate date,
primary key (ID), 
foreign Key (CompanyID) references Company, 
foreign key (MEmployeeID) references Manager on update Cascade,
foreign key (PEmployeeID) references Employee on update Cascade,
)

create table HousingEmployee
(
EID int, 
PID int, 
primary key (EID, PID), 
foreign key (EID) references Employee on delete Cascade on update Cascade,
foreign key (PID) references Project on delete Cascade,
)

create table Unit
(
ProjectID int,
ID int,  
UStatus bit Default '0', /*0, 1: Not sold, sold */
NoRooms tinyint, 
PaymentEndDate date, 
primary key (ProjectID, ID), 
foreign key (ProjectID) references Project on delete cascade,
)

create table ComTransaction 
(
TID bigint, 
BankName varchar(50),
EmployeeID int not null, 
CompanyID int not null, 
Amount int not null, 
primary key (TID, BankName),
foreign key (BankName) references Bank on delete Cascade on update Cascade,
foreign key (EmployeeID) references Employee on delete Cascade on update Cascade, 
foreign key (CompanyID) references Company on delete cascade, 
)

create Table CitTransaction
(
TID bigint, 
BankName varchar(50),
EmployeeID int not null, 
CitizenID int not null, 
ProjectID int not null,
UnitID int not null, 
Amount int not null, 
primary key (TID, BankName),
foreign key (BankName) references Bank on delete Cascade on update Cascade,
foreign key (EmployeeID) references Employee on delete No Action on update No Action, 
foreign key (CitizenID) references Citizen on delete Cascade on update Cascade, 
foreign key (ProjectID, UnitID) references Unit (ProjectID, ID) on delete Cascade, 
)

create table ComApplication
(
ProjectID int not null, 	
CompanyID  int not null,	
BiddingPrice int not null, 	
AStatus char(1) not null Default 'W', /* W, A, D, R: Waiting, Accepted, Done, Rejected*/
primary key (ProjectID, CompanyID), 
foreign key (ProjectID) references Project on delete Cascade, 
foreign key (CompanyID) references Company on delete Cascade,
)

create table CitApplication
(
ProjectID int not null,
UnitID int not null, 	
CitizenID  int not null,	
AStatus char(1) not null Default 'W', /* W, A, D, R: Waiting, Accepted, Done, Rejected*/
primary key (ProjectID, UnitID, CitizenID), 
foreign key (ProjectID) references Project on delete Cascade, 
foreign key (CitizenID) references Citizen on delete Cascade on update Cascade,
foreign key (ProjectID, UnitID) references Unit (ProjectID, ID) on delete No Action, 
)

---------------Inserting values into tables----------------
insert into Administrator
values
('Alaa', 'Monkey'), 
('Beshoy', 'Monkey'), 
('Moemen', 'Monkey')

insert into HighAdministrator
values 
('Beshoy')

insert into Access 
values
('Admin', 'BiggestMonkey'),
('Employee', 'BigMonkey'),
('Bank', 'SmallMonkey'),
('Company', 'SmallestMonkey')
 
insert into Citizen
values 
(11111111, 'Mama', 'Freddie', 'Mercury', '1946-09-05', 2000, 'M', 'Luxor', 0, 60), 
(22222222, 'Ice', 'Elsa', 'Arendal', '1980-12-25', 1500, 'F', 'Sharm El-Shiekh', 1, 10000),
(33333333, 'GOD', 'Hercules', 'Zues', '1970-02-27', 5000, 'M', 'Giza', 1, 50000), 
(44444444, 'Jahanam', 'Abu', 'Jahl', '1965-01-01', 900, 'M', 'Faiyum', '1', 45000),
(55555555, 'Victorious', 'Ariana', 'Grande', '1993-06-26', 1000, 'F', 'Cairo', 0, 100), 
(66666666, 'Prince', 'Cinderella', 'Glass', '1990-11-10', 2500, 'F', 'Beni Suef', 0, 200), 
(77777777, 'Money', 'Donald', 'Trump', '1946-06-14', 800, 'M', 'Alexandria', 0, 30), 
(88888888, 'Donkey', 'Goha', 'Ears', '1970-05-03', 900, 'M', 'Munufia', 1, 3000),
(99999999, 'Baby', 'Monica', 'Geller', '1969-03-03', 2000, 'F', 'Cairo', 0, 500), 
(10101010, 'King', 'Simba', 'Mufasa', '1970-08-08', 1000, 'M', 'Port Said', 0, 200), 
(01010101, 'Numbers', 'Hypatia', 'Alexander', '1950-06-27', 0, 'F', 'Alexandria', 1, 10000), 
(12121212, 'England', 'Mary', 'Bloody', '1976-12-13', 800, 'F', 'Luxor', 1, 20000), 
(13131313, 'YouDead', 'Osama', 'BinLaden', '1957-03-10', 2000, 'M', 'Sinai', 1, 10000), 
(14141414, 'KillTheMamluks', 'Muhammad', 'Ali', '1949-03-10', 3000, 'M', 'Beni Suef', 1, 7000), 
(15151515, 'Miley', 'Hannah', 'Montana', '1999-11-23', 2000, 'F', 'Faiyum', 0, 80), 
(16161616, 'HerMajesty', 'Elizabeth', 'Windsor', '1926-04-21', 4000, 'F', 'Sharm El-Shiekh', 1, 3000), 
(17171717, 'Sis<3', 'Tutankhamun', 'Eighteenth', '1990-01-24', 1000, 'M', 'Giza', 1, 10000), 
(18181818, 'Batman', 'Bruce', 'Wayne', '1980-08-17', 2000, 'M', 'Cairo', 0, 200), 
(19191919, 'NotBruce', 'Caitlyn', 'Jenner', '1949-10-28', 3000, 'F', 'Alexandria', 1, 5000), 
(20202020, 'JustAnArtist', 'Adolf', 'Hitler', '1918-11-11', 2000, 'M', 'Munufia', 0, 50)


insert into Dependents
values
('Jim', 11111111, '1940-12-07', 1000, 'S'), 
('Anna', 22222222, '1982-08-07', 5000, 'O'), 
('Megara', 33333333, '1970-02-03', 3000, 'S'),
('Joan', 55555555, '1968-06-11', 700, 'P'), 
('Ivanka', 77777777, '1980-07-10', 2000, 'C'), 
('Donald', 77777777, '1990-06-01', 500, 'C'), 
('Donkey', 88888888, '1992-02-04', 0, 'C'), 
('Chnadler', 99999999, '1969-01-09', 2000, 'S'), 
('Joey', 99999999, '1969-02-10', 2, 'S'),
('Anksenamum', 17171717, '1990-01-24', 1000, 'S'),
('Robbin', 18181818, '1992-02-04', 900, 'C'),
('Kris', 19191919, '1955-10-05', 1000, 'S'), 
('Kim', 19191919, '2010-03-04', 2000, 'C'), 
('Kylie', 19191919, '2010-03-04', 2000, 'C'), 
('Kourtney', 19191919, '2010-03-04', 2000, 'C'), 
('Khloe', 19191919, '2010-03-04', 2000, 'C'), 
('Kendall', 19191919, '2010-03-04', 2000, 'C'), 
('Robert', 19191919, '2010-03-04', 2000, 'C')

insert into Dependents(Name, EID, BirthDate, Relationship)
values
('Olaf', 22222222, '2016-11-11', 'C'),
('Jahl', 44444444, '1999-09-06', 'C'), 
('Mouse', 66666666, '2011-09-09', 'C'), 
('Dog', 66666666, '2010-09-11', 'C'), 
('Pumpkin', 66666666, '2010-09-11', 'C'), 
('Melania', 77777777, '1981-07-10', 'S'), 
('Timon', 10101010, '2000-03-05', 'C'), 
('Pumbaa', 10101010, '2001-05-03', 'C'), 
('Wife1', 14141414, '2000-12-09', 'S'), 
('Wife2', 14141414, '2002-10-14', 'S'), 
('Wife3', 14141414, '1998-08-12', 'S'), 
('Wife4', 14141414, '2005-03-10', 'S'), 
('Philip', 16161616, '1921-06-10', 'S'),
('Charles', 16161616, '1948-11-14', 'C'),
('Diana', 16161616, '1961-06-01', 'O')

insert into Bank 
values
('CIB', '1', 35), 
('Banque Misr', '2', 30), 
('Al-Ahli', '3', 40), 
('HSBC', '4', 40), 
('The United Bank', '5', 30), 
('Central Bank', '6', 35), 
('ABC Bank', '7', 40), 
('Bank Audi', '8', 50), 
('Banque du Caire', '9', 35), 
('Bank of Alexandria', '10', 40), 
('Blom Bank', '11', 30),
('Suez Canal Bank', '12', 40), 
('QNB Alahli', '13', 35),
('Faisal Bank', '14', 40), 
('AlBaraka Bank', '15', 35), 
('Agricultral Bank of Egypt', '16', 40),  
('Abu Dhabi Bank', '17', 30), 
('Housing and Development Bank', '18', 35), 
('Union National Bank', '19', 40),
('Credit Agricole Egypt', '20', 35)

Set Identity_Insert Company On  
insert into Company(CID, Password, Name, NoCompleteProj, NoCurrentProj)
values 
(1, '1', 'Armani', 0, 1),
(2, '2', 'Fendi', 0, 0),
(3, '3', 'Burbery', 0, 0),
(4, '4', 'Versace', 0, 1),
(5, '5', 'Raulph Lauren', 0, 0),
(6, '6', 'Chanel',0, 0),
(7, '7', 'Prada',0, 2),
(10, '10', 'Louis Vuitton',0, 0),
(11, '11', 'Boss',0, 0),
(12, '12', 'Polo',0, 0),
(13, '13', 'Lacoste',0, 0),
(14, '14', 'Dior',0, 0),
(17, '17', 'Valentino',0, 1),
(19, '19', 'D&G',0, 0),
(20, '20', 'Cartier', 0, 1)

insert into Company(CID, Password, Name, NoCompleteProj, NoCurrentProj, Rating, AvgProjectCost)
values 
(8, '8', 'Hermes',1, 0, 87, 5000000), 
(9, '9', 'Gucci',1, 0, 95, 5200000),
(15, '15', 'Givenchy',2, 0, 78, 6000000),
(16, '16', 'Celine',1, 1, 95, 4000000),
(18, '18', 'YvesSaintLaurent', 1, 2, 97, 5000000)

Set Identity_Insert Company Off


insert into Employee
values
(35071391, '1', 'Michel', 'Scott', 'M', 'M', '2019-05-14', 2, 18), 
(16975583, '2', 'Dwight', 'Schrute', 'M', 'P', '2019-06-11', 1, 3),
(84488390, '3', 'Jim', 'Halpert', 'M', 'P', '2014-08-06', 2, 4),
(46676013, '4', 'Pam', 'Beesly', 'F', 'P', '2014-08-14', 2, 2),
(74122567, '5', 'Creed', 'Bratton', 'M', 'P', '2014-11-13', 1, 5),
(91143555, '6', 'Jan', 'Levinson', 'F', 'H', '2015-01-12', 1, 1),
(59898818, '7', 'Erin', 'Hannon', 'F', 'H', '2015-07-30', 1, 1),
(06462455, '8', 'Angela', 'Martin', 'F', 'H', '2015-08-06', 1, 1),
(45876323, '9', 'Kevin', 'Malone', 'M', 'H', '2016-04-21', 1, 1), 
(60377055, '10', 'Andy', 'Bernard', 'M', 'H', '2016-05-09', 0, 1),
(67470629, '11', 'Toby', 'Flenderson', 'M', 'H', '2016-07-14', 0, 1),
(46885434, '12', 'Ryan', 'Howard', 'M', 'H', '2016-10-27', 0, 1),
(41478062, '13', 'Stanley', 'Hudson', 'M', 'H', '2016-11-25', 0, 1),
(86919921, '14', 'Nellie', 'Bertram', 'F', 'H', '2016-11-25', 0, 1),
(02163151, '15', 'Karen', 'Fleppilli', 'F', 'H', '2016-11-25', 0, 1),
(18136173, '16', 'Holly', 'Flax', 'F', 'H', '2016-12-06', 0, 1),
(89037654, '17', 'Kelly', 'Kapoor', 'F', 'H', '2016-12-19', 0, 1),
(00992315, '18', 'Gabe', 'Lewis', 'M', 'H', '2017-07-28', 0, 1),
(01271361, '19', 'Meredith', 'Palmer', 'F', 'H', '2017-11-08', 0, 1),
(54605256, '20', 'Darryl', 'Philbin', 'M', 'H', '2017-11-08', 0, 1)

 insert into Manager
 values
 (35071391)
 
 insert into Project
 values
 ('Cairo', 35071391, 16975583, 1000, 'F', 8, '2015-01-01', '2018-01-01'),
 ('Alexandria', 35071391, 84488390, 900, 'F', 15, '2015-01-01', '2018-01-01'),
 ('Cairo', 35071391, 84488390, 900, 'L', 9, '2015-05-01', '2019-01-01'),
 ('Cairo', 35071391, 46676013, 700, 'L', 15, '2015-05-01', '2019-01-01'),
 ('New Capital', 35071391, 46676013, 1000, 'L', 16, '2015-05-01', '2019-01-01'),
 ('New Capital', 35071391, 74122567, 800, 'L', 18, '2015-05-01', '2019-01-01')

 insert into Project(City, MEmployeeID, PEmployeeID, PricePRoom, PStatus, CompanyID, StartingDate)
 values
 ('New Capital', 35071391, 16975583, 1000, 'S', 16, '2016-01-01'), 
 ('New Capital', 35071391, 16975583, 1000, 'S', 18, '2016-01-01'),
 ('New Capital', 35071391, 84488390, 1000, 'S', 18, '2016-01-01'),
 ('Alexandria', 35071391, 84488390, 1000, 'S', 1, '2016-01-01'),
 ('Alexandria', 35071391, 46676013, 900, 'S', 4, '2016-01-01'),
 ('Cairo', 35071391, 46676013, 1000, 'S', 7, '2016-01-01'),
 ('Cairo', 35071391, 74122567, 900, 'S', 7, '2016-01-01'),
 ('Cairo', 35071391, 74122567, 800, 'S', 17, '2016-01-01'),
 ('New Capital', 35071391, 74122567, 700, 'S', 20, '2016-01-01')

 
 insert into Project(City, MEmployeeID, PEmployeeID, PricePRoom, PStatus)
 values
 ('Luxor', 35071391, 16975583, 1000, 'P'),
 ('Munufia', 35071391, 84488390, 900, 'P'),
 ('Luxor', 35071391, 84488390, 900, 'P'),
 ('New Capital', 35071391, 74122567, 1000, 'P'),
 ('Giza', 35071391, 74122567, 900, 'P')

 

 insert into HousingEmployee
 values
(91143555, 1), 
(59898818, 1),
(06462455, 2),
(45876323, 2), 
(91143555, 3),
(59898818, 3),
(06462455, 3),
(45876323, 3), 
(60377055, 4),
(67470629, 4),
(46885434, 4),
(41478062, 5),
(86919921, 5),
(02163151, 5),
(18136173, 5),
(89037654, 6),
(00992315, 6),
(01271361, 6),
(54605256, 6)

insert into Unit
values 
(1, 1, 1, 3, '2019-08-15'), 
(1, 2, 1, 4, '2019-09-20'),
(1, 3, 1, 4, '2019-11-13'),
(1, 4, 1, 5, '2019-01-28'),
(2, 1, 1, 3, '2020-02-05'),
(2, 2, 1, 3, '2020-03-26'),
(2, 3, 1, 3, '2020-04-03'),
(2, 4, 1, 4, '2020-08-02'),
(3, 1, 1, 3, '2020-02-21'),
(4, 2, 1, 4, '2020-05-23'),
(5, 5, 1, 3, '2020-08-28'),
(5, 6, 1, 5, '2020-08-30'),
(6, 1, 1, 5, '2020-12-17'), 
(6, 5, 1, 5, '2020-12-20'),
(6, 6, 1, 5, '2020-12-24')


insert into Unit(ProjectID, ID, UStatus, NoRooms)
values
(3, 2, 0, 5),
(3, 3, 0, 4),
(3, 4, 0, 3),
(3, 5, 0, 4),
(3, 6, 0, 5),
(3, 7, 0, 3),
(4, 1, 0, 3),
(4, 3, 0, 5),
(4, 4, 0, 3),
(5, 1, 0, 3),
(5, 2, 0, 4),
(5, 3, 0, 5),
(5, 4, 0, 3),
(6, 2, 0, 5),
(6, 3, 0, 5),
(6, 4, 0, 5)


insert into ComTransaction
values 
(052389829039182, 'CIB', 16975583, 16, 2000000),  
(851415212193554, 'CIB', 16975583, 16, 300000),
(275915458810480, 'CIB', 46676013, 4, 1000000),
(436456856530735, 'Banque du Caire', 74122567, 20, 200000), 
(302415949251605, 'Abu Dhabi Bank', 84488390, 1, 500000),
(639962592814317, 'Banque du Caire', 74122567, 20, 1000000),
(996202765584482, 'QNB Alahli', 74122567, 17, 2000000),
(766754823610613, 'Agricultral Bank of Egypt', 16975583, 18, 900000),
(790092854949595, 'Bank of Alexandria', 46676013, 7, 700000), 
(809766259474045, 'Bank of Alexandria', 46676013, 7, 250000),
(178650639412980, 'Agricultral Bank of Egypt', 84488390, 18, 4000000),
(843309251003420, 'Banque du Caire', 74122567, 20, 800000),
(466706803746824, 'Agricultral Bank of Egypt', 84488390, 18, 2000000),
(245026155898264, 'QNB Alahli', 74122567, 17, 300000), 
(813706966630753, 'Bank of Alexandria', 46676013, 7, 1000000),
(256816031166130, 'Abu Dhabi Bank', 84488390, 1, 200000),
(879544667355263, 'QNB Alahli', 74122567, 17, 200000), 
(084377371619095, 'QNB Alahli', 74122567, 17, 3000000), 
(988292921060231, 'CIB', 46676013, 4, 900000), 
(463349347592619, 'Abu Dhabi Bank', 84488390, 1, 800000)

insert into CitTransaction
values 
(895977687526709, 'Central Bank', 91143555, 11111111, 1, 1, 3000),
(532549026536484, 'Central Bank', 59898818, 12121212, 1, 2, 4000),
(979250921069462, 'Central Bank', 06462455, 18181818, 2, 1, 2700),
(122366439191647, 'ABC Bank', 45876323, 88888888, 2, 3, 2700),
(876655728053877, 'ABC Bank', 60377055, 13131313, 4, 2, 2700),
(414030616134239, 'ABC Bank', 06462455, 17171717, 2, 2, 2700), 
(066261554995701, 'ABC Bank', 91143555, 19191919, 1, 4, 5000), 
(368971287392649, 'Banque du Caire', 45876323, 22222222, 2, 4, 3600), 
(629863341573619, 'AlBaraka Bank', 91143555, 33333333, 1, 3, 2000),
(129863341589619, 'AlBaraka Bank', 91143555, 33333333, 1, 3, 2000),
(706202186475579, 'Faisal Bank', 02163151, 44444444, 5, 5, 1000),
(331916833293374, 'AlBaraka Bank', 02163151, 44444444, 5, 5, 500),
(036576816910296, 'Faisal Bank', 02163151, 44444444, 5, 5, 500),
(857793233874497, 'Banque du Caire', 02163151, 44444444, 5, 5, 500), 
(405896866424625, 'QNB Alahli', 18136173, 14141414, 5, 6, 1000),
(933680833808808, 'AlBaraka Bank', 18136173, 14141414, 5, 6, 1000),
(171871428620590, 'Faisal Bank', 89037654, 99999999, 6, 1, 1000), 
(747605198016119, 'QNB Alahli', 89037654, 99999999, 6, 1, 1000),
(268994311099442, 'Banque du Caire', 00992315, 16161616, 6, 6, 4000),
(389208118011286, 'Faisal Bank', 01271361, 10101010, 6, 5, 2000),
(019151925398014, 'QNB Alahli', 54605256, 01010101, 3, 1, 2700)

insert into ComApplication
values 
(1, 8, 4000000, 'D'), 
(2, 15, 5000000, 'D'), 
(3, 9, 4500000, 'D'), 
(4, 15, 5000000, 'D'), 
(5, 16, 4500000, 'D'), 
(6, 18, 5000000, 'D'), 
(7, 16, 4500000, 'D'),
(8, 18, 5000000, 'D'),
(9, 18, 5500000, 'D'),
(10, 1, 4500000, 'D'),
(11, 4, 4500000, 'D'),
(12, 7, 5000000, 'D'),
(13, 7, 3500000, 'D'),
(14, 17, 4900000, 'D'),
(15, 20, 4000000, 'D'),
(16, 2, 5000000, 'W'),
(16, 3, 4000000, 'A'),
(16, 8, 4500000, 'W'),
(16, 1, 9000000, 'W'),
(20, 1, 5000000, 'W')

insert into CitApplication
values
(1, 1, 11111111, 'D'), 
(1, 2, 12121212, 'D'),
(1, 3, 33333333, 'D'),
(1, 4, 19191919, 'D'),
(2, 1, 18181818, 'D'),
(2, 2, 17171717, 'D'),
(2, 3, 88888888, 'D'),
(2, 4, 22222222, 'D'),
(3, 1, 01010101, 'D'), 
(4, 2, 13131313, 'D'),
(5, 5, 44444444, 'D'),
(5, 6, 14141414, 'D'),
(6, 1, 99999999, 'D'),
(6, 5, 10101010, 'D'),
(6, 6, 16161616, 'D'),
(3, 2, 77777777, 'R'),
(1, 1, 55555555, 'W'),
(3, 2, 66666666, 'A'),
(1, 2, 77777777, 'R'),
(1, 4, 77777777, 'R')

----------------- That's all ------------------
 





