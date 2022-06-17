create database CustomerDb1;
use CustomerDb1;

create table Customer (id int primary key ,  CustomerCode varchar(200) NOT NULL,CustomerName varchar(200)NOT NULL,CustomerAmount int NOT NULL);



create table Supplier (id int primary key , SupplierCode varchar(200) NOT NULL,SupplierName varchar(200) NOT NULL,SupplierAmount int NOT NULL);

select * from Customer;

drop table Customer;