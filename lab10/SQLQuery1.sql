use master

drop database Univer1;



create table Student (
ID int identity(1, 1) primary key,
Email nvarchar(20),
Password nvarchar(20),
Firstname nvarchar(20),
Secondname nvarchar(20),
Age int,
Specialization nvarchar(20),
Course int,
Image nvarchar(50)
)

create table Worker (
IDStudent1 int foreign key
	references Student(ID),
IDStudent2 int foreign key
	references Student(ID)
)

