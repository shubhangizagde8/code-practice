Create database SampleDb1;

create table empolyee (id int,name varchar(200),adress varchar(200),salary int);

insert into empolyee values(1,'Vikash ','mumbai',100000);
insert into empolyee values(2,'shubhangi ','pune',21000);
insert into empolyee values(3,'pallavi ','satara',350000);
insert into empolyee values(4,'arjun ','latur',800000);
insert into empolyee values(5,'shivam','baglore',430000);

select * from empolyee ;

truncate table empolyee ;

select * from empolyee  where id=1;

select * from empolyee where id in (1,2,3);
select * from empolyee  where id not in (1,3,5);

select max(salary) from empolyee 
select min(salary) from empolyee 
select AVG(salary) from empolyee 
select count(*) from empolyee 

select  * from empolyee  where name like 'V%'


create table department (did int,dname varchar(200));

insert into department values(1,'developer');
insert into department values(2,'testing');
insert into department values(3,'desining');
insert into department values(4,'UI');
insert into department values(5,'Analysis');

select * from  department;

