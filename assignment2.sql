/*
1. A result set is the output of a query
2. UNION removes duplicate records (where all columns in the results are the same), UNION ALL does not.
3. Union, Intersect, Except
4. Union joins columns on top of each other, Join joins columns side by side
5. Inner join joins on the intersecting data, full join includes that and non-intersecting data
6. Left join is a form of outer join
7. Cross join is used to generate a paired combination of each row of the first table with each row of the second table
8. A HAVING clause is like a WHERE clause, but applies only to groups as a whole 
9. Yes
*/

use AdventureWorks2019
--1
select count(1)
from Production.Product;

--2
select count([ProductSubcategoryID])
from Production.Product;

--3
select ProductSubcategoryID, count([ProductSubcategoryID]) as CountedProducts
from Production.Product
group by ProductSubcategoryID;

--4
select count(1)
from Production.Product
where ProductSubcategoryID is null;

--5
select *
from Production.Product;

--6
select ProductID, sum(Quantity) as TheSum
from Production.ProductInventory
where LocationID = 40
group by ProductID
having sum(Quantity) < 100;

--7
select Shelf, ProductID, sum(Quantity) as TheSum
from Production.ProductInventory 
where LocationID = 40
group by ProductID, Shelf
having sum(Quantity) < 100;

--8
select avg(Quantity)
from Production.ProductInventory
where LocationID = 10;

--9
select ProductID, Shelf, avg(Quantity)
from Production.ProductInventory
group by ProductID, Shelf;

--10
select ProductID, Shelf, avg(Quantity)
from Production.ProductInventory
where Shelf != 'N/A'
group by ProductID, Shelf;

--11
select Color, Class, count(1) as TheCount, avg(ListPrice) as TheAvg
from Production.Product
where Color is not null and Class is not null
group by Color, Class;

--12
select c.Name as Country, s.Name as Province
from Person.CountryRegion as c
join Person.StateProvince as s
	on c.CountryRegionCode = s.CountryRegionCode;

--13
select c.Name as Country, s.Name as Province
from Person.CountryRegion as c
join Person.StateProvince as s
	on c.CountryRegionCode = s.CountryRegionCode
where c.Name = 'Germany' or c.Name = 'Canada'
order by c.Name;

use Northwind;
--14
select od.ProductID
from dbo.[Order Details] as od
join dbo.Orders as o
	on od.OrderID = o.OrderID
where datediff(year, o.OrderDate, getdate()) <=25;

--15
select top 5 o.ShipPostalCode as 'Zip Code', sum(od.Quantity) as Quantity
from dbo.[Order Details] od
join dbo.Orders o
	on o.OrderID = od.OrderID
group by o.ShipPostalCode
order by Quantity desc;

--16
select top 5 o.ShipPostalCode as 'Zip Code', sum(od.Quantity) as Quantity
from dbo.[Order Details] od
join dbo.Orders o
	on o.OrderID = od.OrderID
where datediff(year, o.OrderDate, getdate()) <= 20
group by o.ShipPostalCode
order by Quantity desc;

--17
select City, count(1) as Customers
from dbo.Customers
group by City;

--18
select City, count(1) as Customers
from dbo.Customers
group by City
having count(1) > 10;

--19
select c.ContactName, o.OrderDate
from dbo.Customers c
join dbo.Orders o
	on c.CustomerID = o.CustomerID
where o.OrderDate > '1998-01-01 00:00:00.000';

--20
select c.ContactName, o.OrderDate
from dbo.Customers c
join dbo.Orders o
	on c.CustomerID = o.CustomerID
order by o.OrderDate desc;

--21
select c.ContactName, sum(od.Quantity) as Quantity
from dbo.Customers c
join dbo.Orders o
	on c.CustomerID = o.CustomerID
join dbo.[Order Details] od
	on o.OrderID = od.OrderID
group by c.ContactName
order by c.ContactName;

--22
select c.CustomerID, sum(od.Quantity) as Quantity
from dbo.Customers c
join dbo.Orders o
	on c.CustomerID = o.CustomerID
join dbo.[Order Details] od
	on o.OrderID = od.OrderID
group by c.CustomerID
having sum(od.Quantity) > 100;

--23
select distinct s.CompanyName as 'Supplier Company Name', sh.CompanyName as 'Shipping Company Name'
from dbo.Suppliers as s
join dbo.Products as p
	on s.SupplierID = p.SupplierID
join dbo.[Order Details] as od
	on p.ProductID = od.ProductID
join dbo.Orders as o
	on od.OrderID = o.OrderID
join dbo.Shippers as sh
	on o.ShipVia = sh.ShipperID

--24
select o.OrderDate, p.ProductName
from dbo.Orders as o
join dbo.[Order Details] as od 
	on o.OrderID=od.OrderID
join dbo.Products as p 
	on p.ProductID=od.ProductID

--25
select e1.FirstName, e1.LastName, e2.FirstName, e2.LastName
from dbo.Employees as e1
join dbo.Employees as e2
	on e1.Title = e2.Title
where e1.EmployeeID != e2.EmployeeID

--26
select e1.EmployeeID as managerID, count(1) as Employees
from dbo.Employees as e1
join dbo.Employees as e2
	on e1.EmployeeID = e2.ReportsTo
group by e1.EmployeeID
having count(1) > 2

--27
select City, ContactName, 'Customers' as Type
from dbo.Customers
union
select City, ContactName, 'Suppliers' as Type
from dbo.Suppliers

/*
#28
select f1.t1, f2.t2
from t1
join t2
	on f1.t1 = f2.t2

result
[ 2 ] [ 2 ]
[ 3 ] [ 3 ]

#29
select f1.t1, f2.t2
from t1
left join t2
	on f1.t1 = f2.t2

result
[ 1 ] [ null ]
[ 2 ] [ 2 ]
[ 3 ] [ 3 ]
*/