
USE [BTVNSQLBUOI1]
CREATE DATABASE BTVNSQLBUOI1
-- 1. Bài t?p SELECT c? b?n:
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
VALUES (N'PH?M', N'B?O KIÊN', N'Công Nhân', 1, 1000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'PH?M', N'B?O KHIÊM', N'Công Nhân', 2, 1000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'??', N'??C UY', N'PHÓ GIÁM ??C', 3, 2000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'??', N'NHÂN', N'GIÁM ??C', 4, 3000)
INSERT INTO [dbo].[Employees] (FirstName, LastName , Position, DepartmentID,Salary)
VALUES (N'S?N', N'TÙNG', N'CH? T?CH', 5, 10000)

SELECT * FROM [dbo].[Employees]

--2.Bài t?p JOIN:
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


--3 Bài t?p Aggregation và Group By:

--S? d?ng d? li?u t? b?ng "Employees", vi?t m?t truy v?n ?? tính toán t?ng l??ng m?i phòng ban ?ã chi tr?.

--S?p x?p k?t qu? theo t?ng l??ng gi?m d?n.

--Hi?n th? phòng ban có t?ng l??ng cao nh?t ??ng ??u danh sách.
SELECT d.DepartmentName, SUM(e.Salary) AS TotalSalary
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentName
ORDER BY TotalSalary DESC;
