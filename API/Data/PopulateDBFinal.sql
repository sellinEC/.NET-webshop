DROP TABLE OrderLines
DROP TABLE Orders
DROP TABLE Users
DROP TABLE Adresses
DROP TABLE Products
DROP TABLE Categories
GO
CREATE Table Categories (
Id int not null identity primary key,
CategoryName nvarchar(33) not null
)
GO
CREATE TABLE Products (
Id int not null identity primary key,
CategoryId int not null references Categories(Id),
ProductName nvarchar(100) not null,
ShortDescription nvarchar(300) not null,
LongDescription nvarchar(max),
ImgUrl nvarchar(max),
Price money default 0,
InStock bit not null

)

CREATE TABLE Adresses (
Id int not null identity primary key,
AdressLine nvarchar(100),
ZipCode nvarchar(5),
City nvarchar(100)
)
GO

CREATE TABLE Users (
Id int not null identity primary key,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Email nvarchar(100) not null,
Password nvarchar(max) not null,
AdressId int references Adresses(Id)
)

GO

CREATE TABLE Orders (
Id int not null identity primary key,
Status bit not null default 0,
UserId int not null references Users(Id)
)
GO
CREATE TABLE OrderLines(
ProductId int not null references Products(Id),
Quantity int not null,
OrderId int not null references Orders(Id)
Primary key (ProductId, OrderId)
)
GO

INSERT INTO Categories
VALUES ('Headphones');
INSERT INTO Categories
VALUES ('Footwear');
INSERT INTO Categories
VALUES ('Sport');
INSERT INTO Categories
VALUES ('Mix');

GO

INSERT INTO Products
VALUES (
1,
'Black Headphones',
'Stylish black headphones for maximum sound',
'Our black headphones feature tyhe greatest in surround technology for great sound and envyous looks from passers by',
'https://images.unsplash.com/photo-1505740420928-5e560c06d30e?ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZHVjdHxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&w=1000&q=80',
300,
1

);
INSERT INTO Products
VALUES (
1,
'Red Headphones',
'Stylish red headphones for maximum sound',
'Our red headphones feature the greatest in surround technology for great sound and envyous looks from passers by',
'https://store.sony.com.au/dw/image/v2/ABBC_PRD/on/demandware.static/-/Sites-sony-master-catalog/default/dwbf55493d/images/MDRZX310APR/MDRZX310APR.png',
300,
1

);
INSERT INTO Products
VALUES (
2,
'Red Shoe',
'Stylish red shoes for maximum walks',
'Our red shoes feature the greatest in walking technology for great walk and envyous looks from passers by',
'https://upload.wikimedia.org/wikipedia/commons/1/1f/Product_photography.jpg',
500,
1

);
INSERT INTO Products
VALUES (
2,
'Green Shoe',
'Stylish green shoes for maximum walks',
'Our green shoes feature the greatest in walking technology for great walk and envyous looks from passers by',
'https://images.unsplash.com/photo-1560343090-f0409e92791a?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fHByb2R1Y3R8ZW58MHx8MHx8&ixlib=rb-1.2.1&w=1000&q=80',
500,
1

);
INSERT INTO Products
VALUES (
2,
'Black Shoe',
'Stylish black shoes for maximum walks',
'Our black shoes feature the greatest in walking technology for great running and envyous looks from passers by',
'https://www.incimages.com/uploaded_files/image/1920x1080/Sp19_BB_Nike_Adapt_20181218_NIKE0538_Detail5_rectangle_1600-(1)_407327.jpg',
500,
1

);

INSERT INTO Products
VALUES (
3,
'Skateboard',
'Stylish black skateboard for maximum skates',
'Our black skateboard feature the greatest in skateboard technology for great skating and envyous looks from passers by',
'https://static.toiimg.com/thumb/msid-84579998,width-1070,height-580,imgsize-1142293,resizemode-75,overlay-toi_sw,pt-32,y_pad-40/photo.jpg',
700,
1

);
INSERT INTO Products
VALUES (
3,
'Goalie gloves',
'Stylish black golie gloves for maximum saves',
'Our black golie gloves feature the greatest in goalie technology for great shots-saving and envyous looks from passers by',
'https://cdn.shopify.com/s/files/1/0405/1189/7758/products/GEO_3.0_Entity_Goalkeeper_Gloves_7_4912e9d3-06cc-48d0-9101-fc5c59536ad5_960x.jpg?v=1618428848',
700,
1

);

INSERT INTO Products
VALUES (
3,
'Hockey Stick',
'Stylish black hockey stick for maximum shots',
'Our black hockey stick feature the greatest in hockey technology for great shots and envyous looks from passers by',
'https://www.stx.com/ca-en/media/catalog/product/cache/c7d685abe37f4d15c439fdc154c3cbf1/h/p/hpr2_detail_42.jpg',
700,
1

);

INSERT INTO Products
VALUES (
4,
'Salad bowl',
'Stylish salad bowl for maximum taste',
'Our salad bowl feature the greatest in food technology for great salads and envyous looks from passers by',
'https://www.kroger.com/product/images/large/front/0064463291536',
700,
1
);
INSERT INTO Products
VALUES (
4,
'Tinker board',
'Stylish tinker board for maximum tinkering',
'Our tinkerboard feature the greatest in tinkering technology for great tinkers and envyous looks from passers by',
'https://tinker-board.asus.com/images/product09.jpg',
700,
0
);

INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Förnamn',
'Efternamnsson',
'mail@domain.com',
'Bytmig111'
);

INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Jan',
'Svensson',
'janne@domain.com',
'Bytmig111'
);

INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Jenny',
'Jansson',
'jenny@domain.com',
'Bytmig111'
);
INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Fritte',
'Fruit',
'fritte@domain.com',
'Bytmig111'
);