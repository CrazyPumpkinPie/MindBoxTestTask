## MindBox C# Task
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры

- Проверку на то, является ли треугольник прямоугольным

Библиотека [ссылка](https://github.com/CrazyPumpkinPie/MindBoxTestTask/blob/master/LibMindBox/FindArea.cs)

Тесты бибиотеки [ссылка](https://github.com/CrazyPumpkinPie/MindBoxTestTask/blob/master/LibMindBox.Tests/FindAreaTests.cs)

## MindBox SQL Task
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
  ### Результаты:
![SQL Results](https://user-images.githubusercontent.com/103962183/214548399-047b9447-5886-490f-9b16-4172fbd2abcb.jpg)
