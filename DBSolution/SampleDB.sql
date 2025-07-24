-- use in case of set update mode error
set SQL_SAFE_UPDATES=0;

-- insert into categories table
insert into categories values(1,"flowers");
insert into categories values(2, "Electronic Devices");
insert into categories values(3, "Fashion");
insert into categories values(4, "Home & Furniture");
insert into categories values(5, "Beauty & Personal care");
insert into categories values(6, "Toys & Books");
insert into categories values(7, "Grocery");

-- insert into product tables
-- data for flowers having category 1
INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (1, 'rose', 'valentine flower', 10, 452, '/images/flowers/Rose.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (3, 'lotus', 'unique flower', 50, 62, '/images/flowers/Lotus.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (6, 'Gerberra', 'merriage flower', 18, 5723, '/images/flowers/Gerbera.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (10, 'aster', 'festival Flower', 6, 5000, '/images/flowers/Aster.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (15, 'mogra', 'smelly flower', 2, 4563, '/images/flowers/Mogra.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (16, 'Lily', 'Cute flower', 4, 57230, '/images/flowers/lily.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (17, 'hibiscus', 'perfect flower', 20, 853, '/images/flowers/Hibiscus.png', 1);

INSERT INTO Product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (20, 'Tulip', 'Colorful flower', 12, 89, '/images/flowers/Tulip.png', 1);



-- data for Electronics having category 2
INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (19, "Laptop", "High-performance laptop", 75000, 30, "/images/ElectronicDevices/laptop.jpeg", 2);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (11, "mobile", "favrourite of all", 25000, 853, "/images/ElectronicDevices/mobile.png", 2);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (21, "fan", "Efficient and powerful fan", 25000, 853, "/images/ElectronicDevices/fan.jpeg", 2);


-- data for Fashion  having category 3
INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (2, "topware", "Stylish and comfortable for ladies", 500, 10, "/images/Fashion/topware.png", 3);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (5, "Shoes", "Trendy and durable shoes", 1230, 25, "/images/Fashion/shoes.png", 3);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (14, "Jewellery", "Elegant and timeless jewellery", 2560, 5, "/images/Fashion/jewellery.png", 3);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (18, "Watch", "sophisticated watches", 350, 13, "/images/Fashion/watch.jpeg", 3);


-- data for Home & Furniture  having category 4
INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (4, "BedSheet", "Soft and luxurious bedsheets", 250, 16, "/images/Home_Farniture/BedSheet.jpeg", 4);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (7, "Farniture", "Stylish and functional furniture", 45600, 3, "/images/Home_Farniture/farniture.jpeg", 4);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (13, "Wall Lamp", "Modern and decorative wall lamps", 780, 9, "/images/Home_Farniture/lamp.jpeg", 4);


-- data for Beauty & Personal Care   having category 5
INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (8, "Beauty Products", "Premium beauty products", 9860, 5, "/images/Beauty_PersonalCare/Beautyset.jpeg", 5);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (22, "Cosmetic Products", "Quality cosmetic products", 7999, 9, "/images/Beauty_PersonalCare/cosmetic.jpeg", 5);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (28, "aloe vera gel", "aloe vera gel for natural skin and hair care", 120, 78, "/images/Beauty_PersonalCare/aloe_vera_gel.jpeg", 5);



-- data for Books & Toys  having category 6
INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (9, "Let Us C", "Simple to understand C programmming", 580, 47, "/images/Toys_Books/letusc.jpeg", 6);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (26, "Clean Code", "used for writing readable, maintainable, and efficient software.", 799, 99, "/images/Toys_Books/cleancode.jpeg", 6);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (27, "Teddy", "Soft and cuddly teddy bear", 199, 35, "/images/Toys_Books/teddy.jpeg", 6);



-- data for Grocery  having category 7
INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (12, "Wheat flour", "Fresh and finely milled wheat flour", 99, 120, "/images/Grocery/flour.jpeg", 7);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (23, "Cooking oil", "Pure and healthy cooking oil", 149, 80, "/images/Grocery/oil.jpeg", 7);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (24, "Tomato Sauce", "Rich and tangy tomato sauce", 79, 79, "/images/Grocery/tomato_souse.jpeg", 7);

INSERT INTO product (ProductId, Title, Description, UnitPrice, Quantity, Image, Category_id)
VALUES (25, "cheese", "Creamy and delicious cheese", 39, 65, "/images/Grocery/cheese.jpeg", 7);

-- insert into users

INSERT INTO Users (Name, PhoneNo, Email, Password, City, DOB)
VALUES ('Sanika Bhor', '9876543210', 'sanika0239@gmail.com', 'sanika123', 'Pune', '2006-04-27');

INSERT INTO Users (Name, PhoneNo, Email, Password, City, DOB)
VALUES ('Sumit Bhor', '8530086989', 'sumit@gmail.com', 'sumit123', 'Pune', '2006-06-13');

INSERT INTO Users (Name, PhoneNo, Email, Password, City, DOB)
VALUES ('Rishika Narwade', '9999999999', 'RN@gmail.com', 'RN1212', 'Pune', '2020-12-12');



-- insert into cart tables
INSERT INTO cart (itemid, itemname, itemImage, Quantity, UnitPrice, Product_Id, User_Id)
VALUES (1, "rose", "/images/flowers/rose.png", 4, 20, 1, 1);

INSERT INTO cart (itemid, itemname, itemImage, Quantity, UnitPrice, Product_Id, User_Id)
VALUES (2, "BedSheet", "/images/Home_Farniture/BedSheet.jpeg", 3, 520, 4, 1);

INSERT INTO cart (itemid, itemname, itemImage, Quantity, UnitPrice, Product_Id, User_Id)
VALUES (3, "rose", "/images/flowers/rose.png", 4, 20, 1, 2);




-- insert into subcategories table 
insert into subcategories(product_id,category_id,categoryName) values (5,3,"shoes");
insert into subcategories(product_id,category_id,categoryName) values (14,3,"jewellery");
insert into subcategories(product_id,category_id,categoryName) values (6,1,"Gerberra");
insert into subcategories(product_id,category_id,categoryName) values (1,1,"Rose");
insert into subcategories(product_id,category_id,categoryName) values (2,3,"Topware");
insert into subcategories(product_id,category_id,categoryName) values (18,3,"watch");
insert into subcategories(product_id,category_id,categoryName) values (11,2,"mobile");
insert into subcategories(product_id,category_id,categoryName) values (19,2,"laptop");
insert into subcategories(product_id,category_id,categoryName) values (21,2,"fan");
insert into subcategories(product_id,category_id,categoryName) values (8,5,"Beauty Products");
insert into subcategories(product_id,category_id,categoryName) values (22,5,"Cosmetic Products");
insert into subcategories(product_id,category_id,categoryName) values (28,5,"aloe vera gel");
insert into subcategories(product_id,category_id,categoryName) values (12,7,"Wheat flour");
insert into subcategories(product_id,category_id,categoryName) values (23,7,"Cooking Oil");
insert into subcategories(product_id,category_id,categoryName) values (24,7,"Tomato souce");
insert into subcategories(product_id,category_id,categoryName) values (25,7,"Cheese");


-- insert into categories product table 

-- shoes
insert into  CategoryProduct values (1,"Crocs","Lightweight and comfortable Crocs" ,250,30,"/images/Fashion/Crocs.jpeg",3,1);
insert into  CategoryProduct values (2,"High heels","Elegant and stylish high heels " ,590,11,"/images/Fashion/highheels.jpeg",3,1);
insert into  CategoryProduct values (3,"sneaker","Trendy and comfortable sneakers" ,450,20,"/images/Fashion/sneakar.jpeg",3,1);
insert into  CategoryProduct values (4,"necklace","Beautifully crafted necklace" ,199,25,"/images/Fashion/necklace.jpeg",3,2);

-- flower
insert into  CategoryProduct values (5,"Pink Elegence","A vibrant and charming bloom " ,20,853,"/images/flowers/pinkelegence.jpeg",1,3);
insert into  CategoryProduct values (6,"Double dutch"," multi-layered flower" ,45,630,"/images/flowers/doubledutch.jpg",1,3);
insert into  CategoryProduct values (7,"Pink Rose","  A symbol of grace, admiration, and gentle affection in a timeless bloom." ,16,369,"/images/flowers/pinkrose.jpg",1,4);
insert into  CategoryProduct values (8,"Black Rose","Black Roses – Mysterious and captivating blooms symbolizing elegance" ,85,20,"/images/flowers/blackrose.jpeg",1,4);
insert into  CategoryProduct values (9,"Rainbow Sorbet","A dazzling blend of vibrant colors" ,16,369,"/images/flowers/RainbowSorbet.jpeg",1,4);
insert into  CategoryProduct values (10,"French Rose","French Rose – A delicate and fragrant bloom that embodies elegance," ,45,369,"/images/flowers/frenchrose.jpg",1,4);
insert into  CategoryProduct values (11,"Gown","A gown is a long, formal or elegant woman's dress," ,9800,5,"/images/Fashion/gowns.jpeg",3,5);
insert into  CategoryProduct values (12,"Tank top"," tank top is a sleeveless shirt with wide straps," ,750,36,"/images/Fashion/tanktop.jpeg",3,5);
insert into  CategoryProduct values (13,"T-Shirt","A T-shirt is a casual, collarless top with short sleeves" ,300,45,"/images/Fashion/tshirt.jpeg",3,5);


-- watch
insert into  CategoryProduct values (14,"Rolex Watch","A Rolex watch is a symbol of precision, prestige, and timeless elegance" ,560,5,"/images/Fashion/rolexwatch.jpeg",3,6);
insert into  CategoryProduct values (15,"Girls Watch"," A curated collection of timepieces, offering quality and style for every wrist." ,350,36,"/images/Fashion/girlswatch.jpeg",3,6);
insert into  CategoryProduct values (16,"Smart Watch","our smartphone's stylish companion, offering notifications, fitness tracking" ,1200,45,"/images/Fashion/smartwatch.jpeg",3,6);
insert into  CategoryProduct values (17,"Kids Watch","Delightful and durable watches that inspire learning and independence in your little ones" ,200,45,"/images/Fashion/kidswatch.jpeg",3,6);

-- mobile
insert into  CategoryProduct values (19,"IPhone","A sleek, powerful smartphone that combines cutting-edge technology with elegant design." ,109000,10,"/images/ElectronicDevices/iphone.webp",2,7);
insert into  CategoryProduct values (20,"Samsung","Innovative smartphones and electronics known for performance, style, and advanced features." ,75000,15,"/images/ElectronicDevices/samsung.jpg",2,7);
insert into  CategoryProduct values (21,"poco"," Performance-driven smartphones offering powerful features at an unbeatable value." ,35000,25,"/images/ElectronicDevices/poco.jpg",2,7);
insert into  CategoryProduct values (22,"redmi"," Affordable and feature-rich smartphones designed for reliable performance and everyday use." ,40000,36,"/images/ElectronicDevices/redmi.webp",2,7);

-- laptop
insert into  CategoryProduct values (23,"Lenovo","Dependable and innovative devices built for productivity, performance, and versatility." ,120000,9,"/images/ElectronicDevices/lenovo.jpeg",2,8);
insert into  CategoryProduct values (24,"HP","Dependable and innovative devices built for productivity, performance, and versatility." ,115000,7,"/images/ElectronicDevices/hp.webp",2,8);

-- fan
insert into  CategoryProduct values (25,"Ceiling Fan","Efficient and stylish cooling solution for comfortable airflow in any room." ,5000,26,"/images/ElectronicDevices/ceilingfan.jpeg",2,9);
insert into  CategoryProduct values (26,"Mini Table Fan"," Compact and portable fan for quick, targeted cooling anywhere you need it." ,7000,26,"/images/ElectronicDevices/minitablefan.webp",2,9);

-- face wash
insert into  CategoryProduct values (27,"Face Wash","Gentle and refreshing face wash that cleanses, hydrates, and revitalizes your skin." ,250,100,"/images/Beauty_PersonalCare/facewash.jpeg",5,10);
insert into  CategoryProduct values (28,"Moisturizer","Nourishing moisturizer that keeps your skin soft, smooth, and hydrated all day long." ,320,55,"/images/Beauty_PersonalCare/Moisturizer.jpeg",5,10);
insert into  CategoryProduct values (29,"Shampoo","Revitalizing shampoo that gently cleanses and strengthens hair for a fresh, healthy shine." ,50,78,"/images/Beauty_PersonalCare/Shampoo.jpeg",5,10);
insert into  CategoryProduct values (30,"Hair Oil","Enriching hair oil that strengthens, nourishes, and promotes healthy, shiny hair." ,75,89,"/images/Beauty_PersonalCare/Hair Oil.jpeg",5,10);

-- cosmetic
insert into  CategoryProduct values (31,"Foundation","Flawless foundation that provides smooth coverage and a natural, radiant finish." ,350,78,"/images/Beauty_PersonalCare/Foundation.jpeg",5,11);
insert into  CategoryProduct values (32,"Kajal","Intense and smudge-proof kajal for bold, defined eyes that last all day." ,150,96,"/images/Beauty_PersonalCare/kajal.png",5,11);
insert into  CategoryProduct values (33,"Lipstick ","Vibrant and long-lasting lipstick to add a pop of color and confidence to your smile." ,150,23,"/images/Beauty_PersonalCare/Lipstick.jpeg",5,11);
insert into  CategoryProduct values (34,"Nail Polish","Glossy and chip-resistant nail polish for vibrant, salon-quality nails at home." ,60,12,"/images/Beauty_PersonalCare/NailPolish.jpeg",5,11);

-- aloe vera gel
insert into  CategoryProduct values (35,"aloe vera gel","Natural soothing gel that hydrates, heals, and refreshes skin and hair." ,60,12,"/images/Beauty_PersonalCare/aloe_vera_gel.jpeg",5,12);

-- grocery
insert into  CategoryProduct values (36,"aashirvaad","High-quality whole wheat flour for soft, tasty, and nutritious rotis every day" ,125,12,"/images/Grocery/aashirvaad.jpeg",7,13);
insert into  CategoryProduct values (37,"Fortune","Freshly milled whole wheat flour for soft, fluffy rotis full of natural goodness" ,120,23,"/images/Grocery/Fortune.jpeg",7,13);

-- cooking oil
insert into  CategoryProduct values (38,"Gemini","Pure and healthy oil that enhances the taste of your everyday meals" ,149,50,"/images/Grocery/Gemini.jpeg",7,14);
insert into  CategoryProduct values (39,"SunFlower ","Light and heart-healthy oil, perfect for everyday cooking and frying" ,120,50,"/images/Grocery/SunFlower.jpeg",7,14);
insert into  CategoryProduct values (40,"Dhara ","Nutritious and light oil crafted for healthy and flavorful cooking" ,175,50,"/images/Grocery/Dhara.jpeg",7,14);

-- floor
insert into  CategoryProduct values (41,"Kissan ","Rich, tangy, and flavorful tomato ketchup that adds a delicious twist to every snack" ,75,36,"/images/Grocery/kisan.jpeg",7,15);

-- chesse
insert into  CategoryProduct values (42,"Amul","Creamy and delicious cheese made from pure milk, perfect for cooking and snacking" ,49,36,"/images/Grocery/Amul.jpeg",7,16);
