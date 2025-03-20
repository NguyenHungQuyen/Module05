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
CREATE TABLE Product (
    ProductId INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    CategoryId SMALLINT NOT NULL REFERENCES Category(CategoryId),
    ProductName NVARCHAR(64) NOT NULL,
    Description NVARCHAR(1024) NOT NULL,
    Quantity SMALLINT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    ImageUrl CHAR(32) NOT NULL
);
