/*
Module 15 
Executing Stored Procedures
------------------------------

				Querying Data with Stored Procedures
				Passing Parameters to Stored Procedures
				Creating Simple Stored Procedures
				Working with Dynamic SQL


Lesson 1: Querying Data with Stored Procedures
-----------------------------------------------
			Examining Stored Procedures
			Executing Stored Procedures


Examining Stored Procedures
	- Stored procedures are collections of T-SQL statements stored in a database
	- Procedures can return results, manipulate data, and perform administrative actions on the server
	- With other objects, procedures can provide a trusted application programming interface to a database, insulating applications from database structure changes
			* Use views, functions, and procedures to return data
			* Use procedures to modify and add new data
			* Alter procedure definition in one place, rather than update application code

Executing Stored Procedures
      -Invoke a stored procedure using EXECUTE or EXEC
      -Call procedure with two-part name
      -Pass parameters in @name=value form, using appropriate data type
*/
-- SP  Select , Insert , Update , Delete (DML)
-- Fun Select 
USE Northwind
GO
Select * from Employees 

--Create ,Alter, Drop 
GO
Create proc Sp_SelectEmployee 
AS
Begin 
     Select * from Employees
END
GO
Execute Sp_SelectEmployee

--      SP With Params
GO
Create proc Sp_SelectEmployeeWithParamter 
@Id int 
AS
Begin 
     Select * from Employees Where EmployeeID =@Id 
END
GO
Execute Sp_SelectEmployeeWithParamter 2




use Northwind
go
--Create Procedure
Create Proc sp_ShowEmployees
as 
begin 
   select employeeId , FirstName,Lastname,Country 
   from employees
end

Create table tabelTest1 (Id int Primary key identity , Name nvarchar(50) , Age int ) 

GO
Create Proc Sp_insert_tabelTest1 
@name nvarchar(50) ,  --IN ,Out 
@age int
as
begin
        Insert into tabelTest1 values (@name , @age)
end 
Exec Sp_insert_tabelTest1 'ahmed' , 25 


--call Procedure 
exec sp_ShowEmployees
------------------------------------------------------------------------------------------------
--Lesson 2: Passing Parameters to Stored Procedures
-------------------------------------------------------
			--Passing Input Parameters to Stored Procedures

/*
Parameters are defined in the header of the procedure code, including name, data type and direction (input is default)
Parameters are discoverable using SQL Server Management Studio and the sys.parameters view
To pass parameters in an EXEC statement, use names defined in procedure

*/
go
Create  Proc sp_ShowEmployeesByCountry @Country nvarchar(50) 
as 
begin 
   select employeeId , FirstName,Lastname,Country 
   from employees
   where Country = @Country
end
go

exec sp_ShowEmployeesByCountry 'usa'
exec sp_ShowEmployeesByCountry 'UK'

GO
Create  Proc sp_ShowEmployeesByCountry2 
@Country nvarchar(50) ,  --IN
@counter int out         --OUT
as 
begin 
   select  employeeId , FirstName,Lastname,Country 
   from employees
   where Country = 'UK' -- @Country
   -- set @counter = (select @@ROWCOUNT)
   Select @counter = @@ROWCOUNT
end

GO

Declare @result int 
Exec sp_ShowEmployeesByCountry2 'USA' , @result out
Select @result
-------------------------------------------------------------------------------

--MetaData Query table Object 
exec SP_help 'Sp_SelectEmployee'
Exec Sp_help 'Employees'
exec SP_helptext 'Sp_SelectEmployee'


Declare @x nvarchar(500);
set @x = 'Select * from Employees'
Exec Sp_executesql @x

GO
Create Proc Sp_DymaicSelect 
@table nvarchar(50) ,
@ColumnsName nvarchar(50),
@Codition nvarchar(50)
as
begin 
    declare @x nvarchar(500)
	set @x = 'Select '+@ColumnsName+' from '+@table+' Where '+@Codition;
	Exec Sp_ExecuteSql @x
end 

Exec Sp_DymaicSelect 'Employees','[EmployeeID],[FirstName],[LastName]' ,'EmployeeId > 3'

Exec Sp_DymaicSelect '[Order Details]','[ProductID],[Quantity]' ,'OrderId > 2000'

/*
Writing Queries with Dynamic SQL

 - Using sp_executesql
			- Accepts string as code to be run
			- Supports input, output parameters for query
			- Allows parameterized code while minimizing risk of SQL injection
			- Can perform better than EXEC due to query plan reuse

Syntax:-
--------
DECLARE @sqlcode AS NVARCHAR(256) = 	N'<code_to_run>';
EXEC sys.sp_executesql @statement = @sqlcode;

DECLARE @sqlcode AS NVARCHAR(256) = N'SELECT GETDATE() AS dt';
EXEC sys.sp_executesql @statement = @sqlcode;



*/








DECLARE @sqlcode AS NVARCHAR(256) = N'SELECT GETDATE() AS dt';
EXEC sys.sp_executesql @statement = @sqlcode;

declare @Database nvarchar(100) = 'Northwind';
declare @Table nvarchar(100) = 'Employees';
declare @Columns nvarchar(200) = 'EmployeeId , FirstName,LastName , Country ';
declare @Condition nvarchar(100) = 'country = ''usa''';

declare @Command  nvarchar(max) = 'use '+ @database +';'+' select '+ @Columns + ' From ' + @table + ' Where ' + @condition;  
EXEC sys.sp_executesql  @command










