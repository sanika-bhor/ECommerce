-- create database for ecommerce
create database ECommerce;

-- use Ecommerce
use ECommerce;

-- create table for product
CREATE TABLE Product (
    ProductId INT PRIMARY KEY,
    Title VARCHAR(50) NOT NULL,
    Description VARCHAR(1000),
    UnitPrice INT NOT NULL,
    Quantity INT NOT NULL,
    Category_id INT,
    FOREIGN KEY (Category_id) REFERENCES Categories(id)
);


-- create table for  category
create table Categories
(
	id int primary key,
	name varchar(50)
);

-- create table for user
CREATE TABLE Users (
    CustomerId INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    PhoneNo VARCHAR(15),
    Email VARCHAR(100) UNIQUE,
    Password VARCHAR(255),
    City VARCHAR(100),
    DOB DATE
);

-- create table cart for managing shopping cart
create table cart(
ItemId int auto_increment primary key,
ItemName varchar(255),
ItemImage varchar(255),
Quantity int,
UnitPrice int,
product_id int,
foreign key (product_id) references product(ProductId)
);

-- describe tables
desc Product;
desc Users;
desc categories;

-- use in case of set update mode error
set SQL_SAFE_UPDATES=0;