CREATE DATABASE Learning
GO

USE  Learning
GO 

CREATE TABLE Products(
ProductId INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(100) NOT NULL,
Category VARCHAR(100),
Color VARCHAR(20),
UnitPrice DECIMAL NOT NULL,
AvailableQuantity INT NOT NULL)
GO

CREATE TABLE Users(
UserId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
FirstName VARCHAR(30) NOT NULL,
LastName VARCHAR(30) NOT NULL,
UserName VARCHAR(30) NOT NULL,
Email VARCHAR(50) NOT NULL,
Password VARCHAR(20) NOT NULL,
CreatedDate DATETIME DEFAULT(GETDATE()) NOT NULL)
GO

INSERT INTO Users(FirstName, LastName, UserName, Email, Password) 
VALUES ('Hanumantappa', 'Budihal', 'Admin', 'admin@abc.com', '$admin@2020')
GO

-- Run the below command to create the model and dbcontext classes
-- change server as per your SQL instance
--Scaffold-DbContext “Server=MSI\LEARNING;Database=Learning;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models