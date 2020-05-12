use monkey
go
Create table Access 
(
Entity varchar(50),
Pass varchar(50) not null,
primary key(Entity)
)

insert into Access 
values
('Admin', 'BigestMonkey'),
('Employee', 'BigMonkey'),
('Bank', 'SmallMonkey'),
('Company', 'SmallestMonkey')