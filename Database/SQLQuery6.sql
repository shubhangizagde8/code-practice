use ECommerceDB1;

select *from TblCategory;

select *from TblLogin;

select *from TblProduct;

insert into TblCategory values('t-shirt');
insert into TblCategory values('Bags');
insert into TblCategory values('Mobile');


insert into TblLogin values('shivam@gmail.com','zagade',10);

insert into TblLogin values('shivam1@gmail.com','zagade',1);

ALTER TABLE TblProduct
ADD FOREIGN KEY (CatId) REFERENCES TblCategory(ID);

insert into TblProduct values('Niiky T-shirt ','mens tshirt',1 ,'t1.jpg',500,450,21);
insert into TblProduct values('Niiky T-shirt ','mens tshirt',1 ,'t2.jpg',500,450,21);
insert into TblProduct values('Niiky T-shirt ','mens tshirt',1 ,'t3.jpg',500,450,21);
insert into TblProduct values('Niiky T-shirt ','mens tshirt',1 ,'t4.jpg',500,450,21);

insert into TblProduct values('samsung','Smart phone',3,'m1.jpg',15000,14500,21);
insert into TblProduct values(' Galaxy ','Smart phone',3 ,'m2.jpg',25100,24150,21);
insert into TblProduct values('Vivo','Smart phone',3 ,'m3.jpg',34000,33000,21);


insert into TblProduct values('samsung','Smart phone',2,'b1.jpg',5000,4500,21);
insert into TblProduct values(' Galaxy ','Smart phone',2 ,'b2.jpg',5100,4150,21);
insert into TblProduct values('Vivo','Smart phone',2,'b3.jpg',4000,3000,21);

update  TblProduct set ProductImage = 'b5.jpg' where Id=10;
update  TblProduct set ProductImage = 'm4.jpg' where Id=8;