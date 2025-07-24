
-- create database for ecommerce
create database ECommerce;

-- use Ecommerce
use ECommerce;

-- create table for  category
create table Categories
(
	id int primary key,
	name varchar(50)
);

-- create table for product
CREATE TABLE product (
    ProductId INT PRIMARY KEY,
    Title VARCHAR(50) NOT NULL,
    Description VARCHAR(1000),
    UnitPrice INT NOT NULL,
    Quantity INT NOT NULL,
    image varchar(70),
    Category_id INT,
    FOREIGN KEY (Category_id) REFERENCES Categories(id)
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







