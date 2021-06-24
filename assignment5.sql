/*
1. An object is any SQL Server resource, such as a SQL Server lock or Windows process
2. An index is an on-disk structure associated with a table or view that speeds retrieval of rows from the table or view. Index speeds up retrieval of data but takes additional disk space
3. Clustered Index, non-clustered index
4. yes, under the unique constraint
5. No, because the data rows can only be stored in one order
6. yes, yes
7. no
8. Database Normalization is a process of organizing data to minimize redundancy (data duplication), which in turn ensures data consistency. Normalization has a series of steps called “Forms”, the more steps you take the more normalized your tables are.
9. Denormalization is a database optimization technique in which we add redundant data to one or more tables. This can help us avoid costly joins in a relational database.
10. Using constraints
11. data type, default, null, primary key, unique, foreign key, check
12. primary key cannot be null, unique can only have one null value
13. references another table
14. yes
15. no, yes
16. yes
17. Transaction is a single recoverable unit of work. read uncommitted, read committed, repeatable read, serrializable

*/
use master
--1
Create table customer(
cust_id int,  
iname varchar (50)) 

create table order(
order_id int,
cust_id int,
amount money,
order_date smalldatetime)

select c.iname, count(o.cust_id)
from customer c
join order o
on c.cust_id = o.cust_id
where datepart(year, o.order_date) = 2002

--2
Create table person (
id int, 
firstname varchar(100), 
lastname varchar(100)) 

select *
from person
where lastname like 'a%'

--3
Create table person(
person_id int primary key, 
manager_id int null, 
name varchar(100)not null) 

select p1.name, count(p2.manager_id)
from person p1
join person p2
on p1.person_id = p2.manager_id

--4. DDL statements, DML statements, logon events, and system events

--5
create table company(
	companyID int,
	companyName varchar(30),
	record varchar(30) unique,

	primary key(companyID) )

create table division(
	divisionID int,
	companyID int,
	divisionName varchar(30),
	location varchar(30)

	primary key(divisionID)
	foreign key(companyID) references company(companyID) )

create table contract(
	suite_mail_drop varchar(30),
	divisionID int

	primary key(suite_mail_drop)
	foreign key(divisionID) references divison(divisionID) )
	



