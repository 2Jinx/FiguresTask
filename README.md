## 3 вопрос 

```sql
SELECT Products.ProductName, ISNULL(Categories.CategoryName, 'Без категории') AS CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;
```