/*
Module 7
Using DML to Modify Data
---------------------------------------------------------------------
						-Adding Data to Tables
						-Modifying and Removing Data
						-Generating Automatic Column Value
---------------------------------------------------------------------
*) Adding Data to Tables
-----------------------------
		Using INSERT to Add Data
		Using INSERT with Data Providers
		Using SELECT INTO
		using Output
*/
--Using INSERT to Add Data
Create database TestDB
go 
use TestDB
go
Create table Students(ID int Primary Key Identity,
                      Name nvarchar(50)Not Null,
					  Course nvarchar(30),
					  [Level] int)
go
Insert into Students(Name,Course,level)values ('Retaj','SQL Query',1);
 
Insert into Students values ('Mariam','SQL Query',1);

Insert into Students values ('Osama',1); --Error

Insert into Students(Name , Level) values ('Osama',1); 
select * from students 
--Add multi Rows 
Insert into Students values ('Tammer','SQL Query',1),
                            ('Ahmed','SQL Query',1),
							('Ramy','SQL Query',1)

-- test 
select @@ROWCOUNT
-- Insert Partial Data
-- -------------------

select * from Students 
---------------------------------------------------------------------------------------------
--INSERT ... SELECT to insert rows from another table:
use Northwind
go
Create table EmployeesShortTable (ID int primary key identity,
                                  Fname nvarchar(50) ,
								  Lastname nvarchar(50) ,
								  Country nvarchar(50))
go
insert into EmployeesShortTable select firstname ,lastname ,Country from Employees

select * from Employees
select * from EmployeesShortTable

--------------------------------------------------
--TVF table Value Function
------------

truncate table EmployeesShortTable
select * from EmployeesShortTable
go
Create function Fn_selectEmployees()
returns table
as
return select firstname ,lastname ,Country from Employees
go
insert into EmployeesShortTable select * from Fn_selectEmployees() 
select * from EmployeesShortTable
--------------------------------------------------
--INSERT ... EXEC
------------------ 
truncate table EmployeesShortTable
select * from EmployeesShortTable

go
Create Proc sp_Insert
as
begin 
   select firstname ,lastname ,Country from Employees
end
go

insert into EmployeesShortTable exec sp_insert

select * from EmployeesShortTable

-----------------------------------------------------------------
--Using SELECT INTO
/*
*)The new table is based on query column structure
     - Uses column names, data types, and null settings
     - Does not copy constraints or indexes
*/
select * from Employees Where EmployeeID >5

select EmployeeID ,FirstName ,LastName ,BirthDate into emps
from Employees Where EmployeeID >5
-------------------------------------------------------------------
--Use the OUTPUT keyword with INSERT Or Delete with Select 

--1
SELECT * INTO NewOrderDetails 
FROM [Order Details] WHERE ProductID = 70		
--2
select * from NewOrderDetails

truncate table NewOrderDetails


--Just one 
--Insert
INSERT into NewOrderDetails 
OUTPUT INSERTED.*
SELECT * FROM [Order Details] where ProductID =50

select * from NewOrderDetails

-- Delete 
DELETE FROM NewOrderDetails 		
OUTPUT DELETED.*
WHERE UnitPrice >15 

select * from NewOrderDetails
--------------------------------------------------------------------------------------------------------
-- Truncate Table
-- --------------
--TRUNCATE TABLE is functionally the same to the DELETE statement without a WHERE clause
--TRUNCATE TABLE Statement Deletes All Rows in a Table
--TRUNCATE TABLE has the following advantages:-
------------------------------------------------
/*
1-Faster than delete Statement

2-Removes all rows from a table without logging the individual row deletions,
  (nonlogged method of deleting all rows in a table)

3-can not put a where clause 

4-The DELETE statement removes rows one at a time and records an entry in the transaction log
  for each deleted row.TRUNCATE TABLE removes the data by deallocating the data pages used to 
  store the table

5-after a DELETE statement is executed, the table can still contain empty pages
  with TRUNCATE zero pages are left in the table

6-TRUNCATE TABLE removes all rows from a table, 
  but the table structure and its columns, constraints, indexes, and so on remain(Use Drop table)

7- You cannot use TRUNCATE TABLE on tables that are referenced by a FOREIGN KEY constraint
*/
Truncate Table table2
--================================================================================================================================
--=================================================
--Lesson 2: Modifying and Removing Data
--=================================================		
					--Using UPDATE to Modify Data
					--Using MERGE to Modify Data
/*
--Using UPDATE to Modify Data
------------------------------
UPDATE changes all rows in a table or view
Unless rows are filtered with a WHERE clause or constrained with a JOIN clause
Column values are changed with the SET clause 
*/

--One Row 
UPDATE Products
   SET   unitprice = (unitprice * 1.04)
WHERE   Productid =  1

--More than One Row 
UPDATE Products
   SET   unitprice = (unitprice * 1.04)
WHERE   categoryid =  1 AND discontinued = 0

--Using 
-- assignment operators *=
UPDATE Products
   SET     unitprice *= 1.04 
			 -- Using compound
			 -- assignment operators 
WHERE   categoryid =  1 AND discontinued = 0;

------------------------------------------------
--join
select count(OrderID),e.employeeId
FROM   Orders AS o INNER JOIN Employees AS e
ON 	e.employeeID = O.employeeID 
group by e.employeeId
having count(orderId)> 100;
--------------------------------------------------------------------------------------------------
--Updating Data in One Table Based on a Join to Another
 --Join 
select p.ProductName ,od.Quantity
FROM Products AS P INNER JOIN  [Order Details] AS od
ON 	p .ProductID =  od.ProductID AND od.Quantity > 100;

UPDATE Products  -- Notice use of Alias to make reading better 
	   SET ProductName += ' ?' 
FROM Products AS P INNER JOIN  [Order Details] AS od
ON 	p .ProductID =  od.ProductID AND od.Quantity > 100;
-------------------------------------------------------------------------------------------------- 
--Using Join & SubQuery 
UPDATE employees   -- Notice use of Alias to make reading better 
	SET FirstName += 'p' 
FROM   Orders AS o INNER JOIN Employees AS e
ON 	e.employeeID = O.employeeID 
where e.employeeID in (select employeeID from orders group by employeeId having count(orderid )>150)

select * from employees
----------------------------------------------------------------------------------------
--Using MERGE to Modify Data
--==============================
/*
MERGE modifies data based on a condition
When the source matches the target
When the source has no match in the target
When the target has no match in the source


MERGE TOP (10) 
INTO	Store 		AS Destination
USING	StoreBackup 	AS StagingTable
	ON(Destination.Key = StagingTable.Key)

WHEN NOT MATCHED THEN
	INSERT (C1,..)
	VALUES (Source.C1,..)
WHEN MATCHED THEN 
	UPDATE SET Destination.C1 = StagingTable.C1,..;
*/

Create table MonthTrans
(
 id int , Name nvarchar(50),total decimal(9,2), Gtotal decimal(9,2)
)
go
Create table DayTrans
(
 id int , Name nvarchar(50),total decimal(9,2)
)

insert into MonthTrans values (1,'retaj',2000 ,5000),
(2,'Osama',1000 ,4000),(3,'Mariam',200 ,1000)
select *from MonthTrans 


insert into DayTrans values (1,'retaj',250),
(2,'Osama',100),(4,'sayed',100),(5,'ahemd',500)

select * from monthtrans
select * from Daytrans


merge into monthtrans as Mt --Target
using daytrans as Dt --Source
on Mt.Id=Dt.ID
when matched then 
update set Mt.total = Mt.total + dt.total 
when  not Matched by target then 
insert (id,Name,total)values (dt.ID,dt.Name,dt.total);

delete from daytrans
----------------------------------------------------------------------------------------
--==================================================
--Lesson 3: Generating Automatic Column Values
--==================================================
--1)Using IDENTITY
-------------------
/*
--The IDENTITY property generates column values automatically
*)Optional seed and increment values can be provided
*)Only one column in a table may have IDENTITY defined 
*)IDENTITY column must be omitted in a normal INSERT statement
*)Functions are provided to return last generated values
    SELECT @@IDENTITY: default scope is session
    SELECT SCOPE_IDENTITY(): scope is object containing the call in function and procedure 
    SELECT IDENT_CURRENT(' tablename'): in this case, scope is defined by tablename
There is a setting to allow identity columns to be changed manually ON or automatic OFF
SET IDENTITY_INSERT <Tablename> [ON|OFF]
*/
CREATE TABLE Books(PID int IDENTITY(1,1) NOT NULL, Name VARCHAR(15))
go
INSERT INTO Books (Name) VALUES ('MOC 2072 Manual')  
select * from Books
set identity_insert books on;
INSERT INTO Books(PID,Name)  VALUES (100,'MOC SQL ')
select * from books
set identity_insert books off;
INSERT INTO Books(Name)  VALUES ('MOC SQL Query ')
select * from Books
-----------------------------------------------------------
SELECT IDENT_CURRENT('Employees');
select ident_seed('Employees');
select IDENT_INCR('Employees');

SELECT @@IDENTITY
SELECT SCOPE_IDENTITY()
SELECT IDENT_CURRENT(' Employees')

select max (employeeID) , min(employeeID) from Employees
----------------------------------------------------------------------------------------
--2)Using Sequences
--------------------
/*
Sequence objects were first added in SQL Server 2012
Independent objects in database

More flexible than the IDENTITY property
Can be used as default value for a column
Manage with CREATE/ALTER/DROP statements
Retrieve value with the NEXT VALUE FOR clause
*/
-- Define a sequence
CREATE SEQUENCE dbo.InvoiceSeq AS INT START WITH 1 INCREMENT BY 1;
-- Retrieve next available value from sequence
SELECT NEXT VALUE FOR dbo.InvoiceSeq;
------------------------------------------------------------------
 Drop sequence dbo.InvoiceSeq 

 --Best
if object_Id('dbo.InvoiceSeq') is Not Null
begin
 Drop sequence dbo.InvoiceSeq 
end
   
go
CREATE SEQUENCE dbo.InvoiceSeq AS INT START WITH 1 INCREMENT BY 1;
go
Create table subjects (ID int primary key , SuubjectName nvarchar(50))
go 
insert into subjects values (NEXT VALUE FOR dbo.InvoiceSeq,'SQl Query ') 
select * from subjects 


insert into subjects values (100,'SQl Query ')
insert into subjects values (NEXT VALUE FOR dbo.InvoiceSeq,'SQl Query ')
select * from subjects 
---------------------------------------------------------------------------------------
--Advanced 
/* GUIDS
---------
- Data Integrity Rule Number 1 is All rows must be unique.
- Real Life Have Multiple rows are identical and correct.
- GUID Randomly generated values.
- Use GUID to switch Identical data to uniquely values.
- Use GUID by :- 1) Column Datatype Uniqueidentifier.
                 2) Functions NEWID(), NEWSEQUENTIALID().
-----------------------------------------------------------
* NEWID(), NEWSEQUENTIALID()
-------------------------------
- Generate a values based on :- CPU clock, NetworkCard
- NEWID() un order random GUID.
- NEWSEQUENTIALID() generate sequentialy values.
- NEWID() make issues for Indexing.
- NEWSEQUENTIALID() good for Indexing bad for security.
------------------------------------------------------------- */
-- Select NEW() 
SELECT NEWID()

-- CREATE NEWID() COLUMN
CREATE TABLE NEWID_TABLE
(
       ID UNIQUEIDENTIFIER DEFAULT NEWID() ,
	   NAME NVARCHAR(100) ,
	   TITLE  NVARCHAR(100)
)
GO
-- PUT DATA 
INSERT INTO NEWID_TABLE(NAME,TITLE)
VALUES ( 'Osama', 'Maneger'),
       ( 'Sayed', 'Employee'),
	   ( 'Retaj','Developer')
GO
-- SEE RESULT
SELECT * FROM NEWID_TABLE
GO
--Clean
DROP TABLE NEWID_TABLE
GO
----------------------------------------------------

-- Create Column With SequentialID()
CREATE TABLE SEQUENTIALEDID_TABLE
(
       ID UNIQUEIDENTIFIER DEFAULT NEWSEQUENTIALID(),
	   NAME NVARCHAR(100) ,
	   TITLE  NVARCHAR(100)
)
GO
-- PUT DATA 
INSERT INTO SEQUENTIALEDID_TABLE(NAME,TITLE)
VALUES ( 'Osama', 'Maneger'),
       ( 'Sayed', 'Employee'),
	   ( 'Retaj','Developer')
GO
-- SEE RESULT
SELECT * FROM SEQUENTIALEDID_TABLE
GO
--Clean
DROP TABLE SEQUENTIALEDID_TABLE
----------------------------------
-- NEWID Tricks
---------------
-- 1) Generate A random decimal number
SELECT RAND( CHECKSUM( NEWID()));
GO
--OR 
SELECT RAND() 
GO

-- 2) Random Float Number between 
SELECT 20*RAND()                     -- Float From 0-20
SELECT 10 + (30-10)*RAND()           -- Float FROM 10-30
SELECT round(10 + (30-10)*RAND(),0)  -- int FROM 10-30

-- 3) Generate A random number
SELECT ABS(CHECKSUM(NEWID()))
GO

-- 4) Generate Random Numbers between Rang
SELECT CONVERT(INT, (100+1)*RAND()) -- FROM 0-100
GO

--OR 
DECLARE @Random INT;
DECLARE @Upper INT;
DECLARE @Lower INT
---- This will create a random number between 1 and 999
SET @Lower = 1 ---- The lowest random number
SET @Upper = 999 ---- The highest random number
SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
SELECT @Random


-- 5) Retrieving Random Rows from Table 
select * from employees order by (NewID())
select top(3)* from employees order by (NewID())


