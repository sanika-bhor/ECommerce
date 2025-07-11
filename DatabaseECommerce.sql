-- create database for ecommerce
create database ECommerce;

-- use Ecommerce
use ECommerce;

-- create table for product
CREATE TABLE product (
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
user_id int,
foreign key (product_id) references product(ProductId),
foreign key(user_id) references users(CustomerId)
);


-- create table subcategories for managing different categories
create table subcategories(
id int primary key auto_increment, 
product_id int,
category_id int, 
categoryName varchar(100),
 foreign key (product_id) references product(ProductId),
 foreign key (category_id) references categories(id)
 );
 
 -- create table CategoryProduct for managing different categories products
 CREATE TABLE CategoryProduct (
    ProductId INT PRIMARY KEY,
    Title VARCHAR(50) NOT NULL,
    Description VARCHAR(1000),
    UnitPrice INT NOT NULL,
    Quantity INT NOT NULL,
    image varchar(255),
    Category_id INT,
    SubCategory_id int,
    FOREIGN KEY (Category_id) REFERENCES Categories(id),
    FOREIGN KEY (SubCategory_id) REFERENCES subcategories(id)
);

-- describe tables
desc Product;
desc Users;
desc categories;
desc cart;
desc subcategories;
desc CategoryProduct;

-- select data from tables
select * from categories;
select * from product;
select * from Users;
select * from cart;
select * from subcategories;
select * from CategoryProduct;

-- insert into categories table
insert into categories values(1,"flowers");
insert into categories values(2, "Electronic Devices");
insert into categories values(3, "Fashion");
insert into categories values(4, "Home & Furniture");
insert into categories values(5, "Beauty & Personal care");
insert into categories values(6, "Toys & Books");
insert into categories values(7, "Grocery");

-- use in case of set update mode error
set SQL_SAFE_UPDATES=0;

