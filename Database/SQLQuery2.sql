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


select * from empolyee emp FULL OUTER JOIN department dep on emp.id=dep.did;

select * from empolyee emp LEFT OUTER JOIN department dep on emp.id=dep.did;


create table student1(id int primary key, rn int,name varchar(200),sirname varchar(200),gender varchar(200),classid int);
insert into student1 values(1,20,'Vijay ','shinde','male',03);
insert into student1 values(2,23,'ram ','shinde','male',02);
insert into student1 values(3,21,'sham ','shinde','male',01);
insert into student1 values(4,26,'raj ','shinde','male',02);
insert into student1 values(6,28,'shubhangi ','zagade','female',03);
insert into student1 values(5,29,'radhika ','shinde','female',01);

select * from student1 ;

create table student1_class (id int primary key,classname varchar(200));
insert into student1_class values(01,'ten');
insert into student1_class values(02,'nine');
insert into student1_class values(03,'eight');
insert into student1_class values(04,'seven');
insert into student1_class values(05,'six');

select * from student1_class ;

select emp.name, dep.classname from student1  as emp inner join student1_class as dep on emp.id=dep.id;

select rn,CONCAT(name,' ',sirname) as FullName,gender,sc.classname from student1 s
inner join student1_class sc on sc.id=s.id


 CREATE FUNCTION  fName (@ID int)
returns varchar(200)  AS 
Begin
 return (select  CONCAT( name ,' ',sirname) as FullName from student1 where id=@ID);
End

select * from student1
select dbo.fName(6) ;

CREATE FUNCTION  fullName10 (@cd int)
returns int  AS 
Begin

 return (select concat(' ', id) as eid from student1 where id=@cd);
End

select gender,rn ,classid as Unique_id from student1 ;
 select dbo.fullName10 (3) ;




 create proc AddEmployee1(@Id int,@Name varchar(200),@adress varchar(300), @salary int)
As 
Begin

insert into empolyee values(@Id,@Name,@adress,@salary);
END


exec dbo.AddEmployee1 7,'ravu','baramati',28748;


select * from empolyee where id=7;