/*
1. In a database, a view is the result set of a stored query on the data. Benefit is users can query just as they would in a persistent database collection object. 
2. yes
3. A stored procedure is a subroutine. You can automate some tables or log some data when called
4. A view is a virtual table where as stored procedure is a function that uses parameters
5. Stored procedures can have input and output parameters and cannot use select, where, having and can use try catch block and can return multiple values
6. yes
7. No, we can only use functions 
8. A special kind of stored procedure. DML, DDL, or logon Trigger
9. DML runs when user trys to modify data, DDL runs when using create, alter, drop, and logon runs when a user logs on
10. Triggers run automatically when an event happens
*/

use Northwind
--1. 
begin tran
insert into Region values (5, 'Middle Earth')
insert into Territories values('00000', 'Gondor', 5)
insert into Employees values('King', 'Aragorn', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)
insert into EmployeeTerritories values(10, '00000')
rollback tran
go

--2.
update Territories set TerritoryDescription = 'Arnor' where TerritoryDescription = 'Gondor'

--3
delete EmployeeTerritories where EmployeeID = 10
delete Territories where TerritoryID = '00000'
delete Region where RegionID = 5

--4
create view view_product_order_quantity_yuan as
	select ProductName, sum(Quantity) as 'OrderedQuantity'
	from [Order Details] od
	join Products p on od.ProductID = p.ProductID
	group by ProductName;

select * from view_product_order_quantity_yuan

--5
create procedure sp_product_order_quantity_yuan
	@productID int,
	@totalQuantity int output
as
	select @totalQuantity = sum(Quantity)
	from [Order Details] od
	join Products p on od.ProductID = p.ProductID
	where od.ProductID = @productID
	group by ProductName

--6.
create procedure sp_product_order_city_yuan
	@productName varchar(30),
	@city varchar(30) output,
	@totalQuantity varchar(30) output
as
	select ShipCity, totalQuantity from (
	select o.ShipCity, sum(od.Quantity) as totalQuantity, rank() over (order by sum(od.Quantity) desc) as rank
	from Orders o
	join [Order Details] od on o.OrderID = od.OrderID
	join Products p on od.ProductID = p.ProductID
	where p.ProductName = @productName
	group by o.ShipCity) dt
	where dt.rank <= 5

--7
create procedure sp_move_employees_yuan
	if exists(select *
				from EmployeeTerritories et
				join Territories t on et.TerritoryID = t.TerritoryID
				where t.TerritoryDescription = 'Tory' )
		insert into Territories values ('00000', 'Stevens Point', 3)
		update EmployeeTerritories
		set TerritoryID = '00000'
		where EmployeeID = (select et.EmployeeID
				from EmployeeTerritories et
				join Territories t on et.TerritoryID = t.TerritoryID
				where t.TerritoryDescription = 'Tory')

--8
create trigger employeeLimit
on EmployeeTerritories
after insert
as
begin
declare @counter int
select @counter = count(1) from EmployeeTerritories where TerritoryID = '00000'
if @counter > 100 (
	update EmployeeTerritories
	set TerritoryID = '48084'
		where EmployeeID = (select et.EmployeeID
				from EmployeeTerritories et
				join Territories t on et.TerritoryID = t.TerritoryID
				where t.TerritoryDescription = 'Stevens Point') )
end

--9
create table people_yuan(
	id int,
	name varchar(30),
	city int )

insert into people_yuan values(1, 'Aaron Rodgers', 2)
insert into people_yuan values(2, 'Russell Wilson', 1)
insert into people_yuan values(3, 'Jody Nelson', 2)

create table city_yuan(
	id int,
	city varchar(30) )

insert into city_yuan values(1, 'Seattle')
insert into city_yuan values(2, 'Green Bay')

select * from people_yuan
select * from city_yuan

delete from city_yuan where city = 'Green Bay'
update people_yuan
set city = 4
where city = 1
insert into city_yuan values(4, 'Madison')

create view Packers_yuan as
	select name
	from people_yuan
	where city = 4

drop table city_yuan
drop table people_yuan
drop view Packers_yuan

--10
create procedure sp_birthday_employees_yuan as
	select * into birthday_employees_yuan
	from Employees
	where month(BirthDate) = 2

	drop table birthday_employees_yuan

--11
create procedure sp_yuan_1
	select c.City, count(o.OrderID)
	from Customers c
	join Orders o on c.CustomerID = o.CustomerID
	group by c.City
	having count(o.OrderID) <= 1

create procedure sp_yuan_2
	select *
	from (select c.City, count(o.OrderID)
	from Customers c
	join Orders o on c.CustomerID = o.CustomerID
	group by c.City
	having count(o.OrderID) <= 1)

/*
12. Use a checksum table to compare the results
14. select [First Name] + ' ' [Last Name] + ' ' + [Middle Name] as 'Full Name'
	from Names
15. select top 1 student, max(Marks)
	from Students
	where Sex = 'F'
16. output would be:
	Student	Marks
	Li		90