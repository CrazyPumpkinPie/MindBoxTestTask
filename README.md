# MindBox SQL Test Task
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```SQL
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL);

CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL);

CREATE TABLE ProductCategories ( 
    ProductId INT FOREIGN KEY REFERENCES Products(Id), 
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id), 
    PRIMARY KEY (ProductId, CategoryId) ); 


  INSERT INTO Products VALUES ('Дерево'),('Бетон'),('Диван'),('Окно');
  INSERT INTO Categories VALUES ('Стройматериалы'),('Мебель'),('Горючее');
  INSERT INTO ProductCategories VALUES (1,1),(1,3),(2,1),(3,2);

  SELECT p.Name AS 'Product Name', c.Name AS 'Category Name' FROM Products p
  LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId LEFT JOIN Categories c ON pc.CategoryId = c.Id;
  ```
