# Ответ на задание 3
*Запрос составлен в БД PostgreSQL, так как готовые таблички были под рукой.*


SQL-Запрос
```SQL
SELECT product_name, category_name
FROM public."Categories"
RIGHT JOIN public."Products" ON public."Products".category_id=public."Categories".category_id
```

Результат:
![image](https://user-images.githubusercontent.com/67252356/215028331-d52706b6-66c7-4f3a-9c40-5e8acdc62483.png)
