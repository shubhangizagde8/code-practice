create Database CustomerDb;

use  CustomerDb;

create table Customer(id int primary key,
                      Password varchar(100)Not null,
                      Name varchar(200) NOT NULL,
					  Gender varchar(200)NOT NULL,);

create table Product(id int primary key,
                      Name varchar(100)Not null);

select *from Customer;
select *from Product;