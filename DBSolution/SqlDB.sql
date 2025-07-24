-- describe tables
desc product;
desc Users;
desc categories;
desc cart;
desc subcategories;
desc CategoryProduct;
desc customer;
desc shoppingcart;


-- select data from tables
select * from categories;
select * from product;
select * from Users;
select * from cart;
select * from subcategories;
select * from CategoryProduct;
select * from Customer;
select * from shoppingcart;


-- join query for getting all product depending on thier category
SELECT cp.* FROM CategoryProduct cp
JOIN subcategories sc ON cp.SubCategory_id = sc.id
WHERE sc.Product_Id = 5;


-- for deleting whole table
drop table Categories;
drop table cart;
drop table subcategories;
drop table categoryproduct;
drop table users;
drop table product;

