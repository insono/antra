use AdventureWorks2019;
-- Andrew Yuan SEP June 2021

-- 1.
select ProductID, Name, Color, ListPrice
from Production.Product;

-- 2.
select ProductID, Name, Color, ListPrice
from Production.Product
where ListPrice = 0;

-- 3.
select ProductID, Name, Color, ListPrice
from Production.Product
where Color is null;

-- 4.
select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not null;

-- 5.
select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not null and ListPrice > 0;

-- 6.
select Name + ': ' + Color as 'Name and color'
from Production.Product
where color is not null;

-- 7.
select top 6 'NAME: ' + Name + ' -- COLOR: ' + Color as 'Name And Color'
from Production.Product
where Color is not null;

-- 1.
select ProductID, Name
from Production.Product
where ProductID >= 400 and ProductID <= 500;

-- 2.
select ProductID, Name, Color
from Production.Product
where Color = 'blue' or Color = 'black';

-- 3.
select ProductID, Name, Color, ListPrice
from Production.Product
where Name like 's%';

-- 4.
select name, ListPrice
from Production.Product
where Name like 's%'
order by Name;

-- 1.
select Name, ListPrice
from Production.Product
where name like '[a s]%'
order by name;

-- 1.
select Name
from Production.Product
where name like 'spo[^k]%'
order by Name;

-- 1.
select distinct Color
from Production.Product
order by Color desc;

-- 1.
select distinct ProductSubcategoryID, Color
from Production.Product
where ProductSubcategoryID is not null and Color is not null
order by ProductSubcategoryID, Color;

-- 2.
SELECT ProductSubCategoryID
, LEFT([Name],35) AS [Name]
, Color, ListPrice
FROM Production.Product
WHERE Color IN ('Red','Black')
OR ListPrice BETWEEN 1000 AND 2000
AND ProductSubCategoryID = 1
ORDER BY ProductID;

--3.
SELECT ProductSubCategoryID
, LEFT([Name],35) AS [Name]
, Color, ListPrice
FROM Production.Product
WHERE (Color IN ('Red','Black')
AND ProductSubCategoryID = 1
OR ListPrice BETWEEN 1000 AND 2000)
and ProductSubcategoryID <= 14
ORDER BY ProductSubcategoryID desc;
