CREATE DATABASE Store;
GO

USE Store;
GO

CREATE TABLE Category (
    CategoryId SMALLINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    CategoryName NVARCHAR(128) NOT NULL
);
GO

INSERT INTO Category (CategoryName) VALUES
    ('Mouse'), 
    ('Laptop'), 
    ('Keyboard');
GO
