CREATE TABLE users (
 Id int not null identity primary key,
 FirstName nvarchar(50) not null, 
 LastName nvarchar(50) not null, 
 email varchar(200) not null unique
)

CREATE TABLE products (
 Id int not null identity primary key,
 ProductName nvarchar(200) not null unique,
 ProductDescription nvarchar(max) not null,
 ProductImgUrl nvarchar(max) not null,
 Price money not null
)