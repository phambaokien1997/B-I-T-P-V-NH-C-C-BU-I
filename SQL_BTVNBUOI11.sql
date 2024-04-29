
USE [BTVNSQLBUOI1]
CREATE DATABASE BTVNSQLBUOI1
-- 1. B�i t?p SELECT c? b?n:
CREATE TABLE Employees
(
EmployeeID INT PRIMARY KEY IDENTITY NOT NULL,
FirstName NVARCHAR(250),
LastName NVARCHAR(250),
 Position NVARCHAR(250),
 DepartmentID INT,
 Salary INT
)

INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'PH?M', N'B?O KI�N', N'C�ng Nh�n', 1, 1000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'PH?M', N'B?O KHI�M', N'C�ng Nh�n', 2, 1000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'??', N'??C UY', N'PH� GI�M ??C', 3, 2000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'??', N'NH�N', N'GI�M ??C', 4, 3000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'S?N', N'T�NG', N'CH? T?CH', 5, 10000)

SELECT * FROM [dbo].[Employees]

--2.B�i t?p JOIN:
CREATE TABLE Departments 
(
DepartmentID INT PRIMARY KEY IDENTITY NOT NULL ,
DepartmentName NVARCHAR(250)
)
INSERT INTO [dbo].[Departments] (DepartmentName)
VALUES (N'C?P TH?P')
INSERT INTO [dbo].[Departments] (DepartmentName)
VALUES (N'C?P TRUNG')
INSERT INTO [dbo].[Departments] (DepartmentName)
VALUES (N'C?P CAO')
INSERT INTO [dbo].[Departments] (DepartmentName)
VALUES (N'C?P TH?P')
INSERT INTO [dbo].[Departments] (DepartmentName)
VALUES (N'C?P TRUNG')


SELECT * FROM [dbo].[Departments]

SELECT e.FirstName,e.LastName,d.DepartmentName FROM [dbo].[Employees] e INNER JOIN [dbo].[Departments] d
ON e.DepartmentID = d.DepartmentID
--DROP table [dbo].[Departments]
--DROP table [dbo].[Employees]


--3 B�i t?p Aggregation v� Group By:

--S? d?ng d? li?u t? b?ng "Employees", vi?t m?t truy v?n ?? t�nh to�n t?ng l??ng m?i ph�ng ban ?� chi tr?.

--S?p x?p k?t qu? theo t?ng l??ng gi?m d?n.

--Hi?n th? ph�ng ban c� t?ng l??ng cao nh?t ??ng ??u danh s�ch.
SELECT d.DepartmentName, SUM(e.Salary) AS TotalSalary
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentName
ORDER BY TotalSalary DESC;
