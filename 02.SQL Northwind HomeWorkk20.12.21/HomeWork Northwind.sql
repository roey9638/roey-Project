-- Home work Norhwind site -- https://www.w3resource.com/mysql-exercises/northwind/products-table-exercises/

-- 1
select ProductName, QuantityPerUnit
from Products
where Discontinued = 'False'
go

-- 2
select ProductID, ProductName
from Products
order by ProductID
go

-- 3
select ProductID, ProductName
from Products
where Discontinued = 'true'
order by ProductName
go

-- 4
select ProductName, UnitPrice 
from Products 
order by UnitPrice desc
go

-- 5
select ProductID, ProductName, UnitPrice
from Products
where UnitPrice<20 AND Discontinued = 'False'
order by ProductID
go

-- 6
select ProductName, UnitPrice
from Products
where UnitPrice >= 15 And UnitPrice <= 25 and Discontinued = 'False'
order by ProductName
go

-- 7
select distinct ProductName, UnitPrice
from Products
where UnitPrice > (select avg(UnitPrice) from Products) -- קצת לא הבנתי
order by ProductName
go

-- 8
select distinct top 20 ProductName, UnitPrice
from Products
order by UnitPrice desc
go

-- 9
select count(ProductName)
from Products
group by Discontinued
go

-- 10
select ProductName,  UnitsOnOrder , UnitsInStock
from Products
where Discontinued = 'False' and UnitsInStock < UnitsOnOrder
go

