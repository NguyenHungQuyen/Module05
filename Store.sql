CREATE DATABASE Store;
GO
USE Store;
GO
CREATE TABLE Category(
	CategoryId SMALLINT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	CategoryName NVARCHAR(128) NOT NULL
);
GO
INSERT INTO Category (CategoryName) VALUES
	('Mouse'), ('Laptop'), ('Keyboard');
GO
CREATE TABLE Product(
	ProductId INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	CategoryId SMALLINT NOT NULL REFERENCES Category(CategoryId),
	ProductName NVARCHAR(64) NOT NULL,
	Description NVARCHAR(1024) NOT NULL,
	Quantity SMALLINT NOT NULL,
	Price DECIMAL(10, 2) NOT NULL,
	ImageUrl CHAR(32) NOT NULL,
	Unit NVARCHAR(32) NOT NULL
);
GO

INSERT INTO Product (CategoryId, ProductName, ImageUrl, Description, Price, Quantity, Unit)
VALUES
-- Laptops
(1, 'Dell XPS 13', '1.jpg', '13.4-inch FHD+ display, Intel i7, 16GB RAM, 512GB SSD, Windows 11.', 1299.99, 15, 'piece'),
(1, 'MacBook Pro 14-inch', '2.jpg', '14-inch Liquid Retina XDR display, M1 Pro chip, 16GB RAM, 512GB SSD.', 1999.99, 10, 'piece'),
(1, 'HP Spectre x360', '3.jpg', '13.3-inch OLED touchscreen, Intel i7, 16GB RAM, 512GB SSD, Windows 11.', 1499.99, 12, 'piece'),
(1, 'Lenovo ThinkPad X1 Carbon', '4.jpg', '14-inch FHD display, Intel i7, 16GB RAM, 512GB SSD, Windows 10 Pro.', 1799.99, 8, 'piece'),
(1, 'Asus ZenBook 14', '5.jpg', '14-inch FHD display, AMD Ryzen 5, 8GB RAM, 256GB SSD, Windows 11.', 899.99, 20, 'piece'),
(1, 'Microsoft Surface Laptop 4', '6.jpg', '13.5-inch PixelSense display, Intel i7, 16GB RAM, 512GB SSD, Windows 11.', 1699.99, 18, 'piece'),
(1, 'Razer Blade 15', '7.jpg', '15.6-inch 4K display, Intel i7, 32GB RAM, 1TB SSD, NVIDIA RTX 3080 GPU.', 2399.99, 7, 'piece'),
(1, 'Apple MacBook Air M2', '8.jpg', '13.6-inch Retina display, M2 chip, 8GB RAM, 256GB SSD, macOS.', 1299.99, 25, 'piece'),
(1, 'Acer Swift 3', '9.jpg', '14-inch FHD display, Intel i5, 8GB RAM, 512GB SSD, Windows 10.', 749.99, 22, 'piece'),
(1, 'Samsung Galaxy Book Pro 360', '10.jpg', '13.3-inch AMOLED touchscreen, Intel i7, 8GB RAM, 256GB SSD, Windows 10.', 1399.99, 10, 'piece'),

-- Desktops
(2, 'Apple iMac 24-inch', '11.jpg', '24-inch 4.5K Retina display, M1 chip, 8GB RAM, 256GB SSD, macOS.', 1299.99, 10, 'piece'),
(2, 'Dell Inspiron Desktop', '12.jpg', 'Intel i5, 8GB RAM, 1TB HDD, Windows 10, built for everyday use.', 599.99, 15, 'piece'),
(2, 'HP Pavilion Desktop', '13.jpg', 'Intel i7, 16GB RAM, 512GB SSD, Windows 11, sleek design for work and play.', 999.99, 12, 'piece'),
(2, 'Alienware Aurora R13', '14.jpg', 'Intel i9, 32GB RAM, 1TB SSD, NVIDIA RTX 3080, Windows 11, for gaming and content creation.', 2599.99, 5, 'piece'),
(2, 'CyberPowerPC Gamer Xtreme', '15.jpg', 'Intel i7, 16GB RAM, 1TB SSD, NVIDIA RTX 3060, Windows 11, perfect for gaming.', 1499.99, 18, 'piece'),
(2, 'MSI Trident 3', '16.jpg', 'Intel i7, 16GB RAM, 512GB SSD, NVIDIA GTX 1660 Ti, Windows 10, compact gaming desktop.', 1299.99, 14, 'piece'),
(2, 'Lenovo Legion Tower 5', '17.jpg', 'AMD Ryzen 7, 16GB RAM, 512GB SSD, NVIDIA RTX 3070, Windows 11, for immersive gaming.', 1799.99, 9, 'piece'),
(2, 'Acer Aspire TC', '18.jpg', 'Intel i5, 8GB RAM, 512GB SSD, Windows 11, budget-friendly desktop for everyday tasks.', 549.99, 20, 'piece'),
(2, 'HP Omen 30L', '19.jpg', 'Intel i9, 32GB RAM, 1TB SSD, NVIDIA RTX 3080, Windows 11, high-performance gaming desktop.', 2999.99, 6, 'piece'),
(2, 'Apple Mac Mini M1', '20.jpg', 'Apple M1 chip, 8GB RAM, 256GB SSD, macOS, compact desktop for productivity and entertainment.', 699.99, 15, 'piece'),

-- Peripherals
(3, 'Logitech MX Master 3', '21.jpg', 'Ergonomic wireless mouse with customizable buttons and rechargeable battery, Bluetooth and USB receiver.', 99.99, 50, 'piece'),
(3, 'Razer BlackWidow V3', '22.jpg', 'Mechanical gaming keyboard with RGB lighting, Green switches, and media controls.', 139.99, 30, 'piece'),
(3, 'Apple Magic Keyboard', '23.jpg', 'Wireless keyboard with a scissor mechanism for quiet and responsive typing, with numeric keypad.', 129.99, 45, 'piece'),
(3, 'Bose QuietComfort 35 II', '24.jpg', 'Noise-canceling over-ear headphones with Alexa voice control and up to 20 hours of battery life.', 299.99, 25, 'piece'),
(3, 'Samsung 32-inch Curved Monitor', '25.jpg', '32-inch curved 4K monitor with ultra-wide viewing angle and 75Hz refresh rate.', 349.99, 20, 'piece'),
(3, 'Logitech G Pro X Superlight', '26.jpg', 'Ultra-lightweight gaming mouse, HERO sensor, customizable buttons, and RGB lighting.', 149.99, 35, 'piece'),
(3, 'JBL Quantum 800', '27.jpg', 'Wireless gaming headset with immersive sound, active noise cancellation, and a built-in microphone.', 199.99, 40, 'piece'),
(3, 'Microsoft Sculpt Ergonomic Mouse', '28.jpg', 'Wireless ergonomic mouse with an advanced 2.4 GHz wireless technology and comfort design.', 49.99, 60, 'piece'),
(3, 'SteelSeries Arctis 7', '29.jpg', 'Wireless gaming headset with long battery life, clear voice communication, and immersive sound quality.', 169.99, 20, 'piece'),
(3, 'Razer Kraken V3', '30.jpg', 'RGB gaming headset with 50mm drivers, THX Spatial Audio, and cooling gel-infused ear cushions.', 119.99, 55, 'piece');

GO
