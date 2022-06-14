create database SampleDb;

 use SampleDb;

 create table Tblsample(id int primary key identity(1,1), Text varchar(200));

 select * from Tblsample;

 create table employee (id int primary key identity(1,1),name varchar(200),adress varchar(200),salary int);

insert into employee values('Vikash ','mumbai',100000);
insert into employee values('shubhangi ','pune',21000);
insert into employee values('pallavi ','satara',350000);
insert into employee values('arjun ','latur',800000);
insert into employee values('shivam','baglore',430000);

select * from employee ;
