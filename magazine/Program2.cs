Product milk = new Product("Молоко", 101, "Молочка");
milk.Quantity = 5;

System.Console.WriteLine("Тест: Применение скидки");
milk.ApplyDiscount(150);
milk.ApplyDiscount(20);
System.Console.WriteLine($"Итоговая цена со скидкой: {milk.Price} руб.");
System.Console.ReadLine();




System.Console.WriteLine($"Начальное количество молока: {milk.Quantity}");
System.Console.WriteLine("\n Добавляем -3(недопустимое действие):");
milk.Restock(-3);
System.Console.WriteLine("\n Добавляем 5(допустимое действие):");
milk.Restock(5);
System.Console.WriteLine($"\nИтоговое количество молока: {milk.Quantity}");

Product apples = new Product("Яблоки", 50, "Фрукты");
Product cutlets = new Product("Котлеты", 167, "Мясо");

Product cheese = new Product("Сыр", 220, "Молочка");

Console.WriteLine(">>> Продукт 1 <<<");
Console.WriteLine($"Товар: {milk.Name}");
Console.WriteLine($"Стоимость: {milk.Price}");
Console.WriteLine($"Количество: {milk.Quantity}");
Console.WriteLine($"Категория: {milk.Category}");

Console.WriteLine();

Console.WriteLine(">>> Продукт 2 <<<");
Console.WriteLine($"Товар: {apples.Name}");
Console.WriteLine($"Стоимость: {apples.Price}");
Console.WriteLine($"Количество: {apples.Quantity}");
Console.WriteLine($"Категория: {apples.Category}");

Console.WriteLine();

Console.WriteLine(">>> Продукт 3 <<<");
Console.WriteLine($"Товар: {cutlets.Name}");
Console.WriteLine($"Стоимость: {cutlets.Price}");
Console.WriteLine($"Количество: {cutlets.Quantity}");
Console.WriteLine($"Категория: {cutlets.Category}");

Console.WriteLine(">>> Проверка <<<");
Console.WriteLine($"Товар: {cheese.Name}");
Console.WriteLine($"Стоимость: {cheese.Price}");
Console.WriteLine($"Количество: {cheese.Quantity}");
Console.WriteLine($"Категория: {cheese.Category}");
Console.WriteLine($"Есть ли в наличии??: {cheese.IsAvaliable}");

Console.WriteLine(">>> Проверка 2 <<<");
//обьекты
Product cucumber = new Product("Огурцы", 40, "Овощи");
Product bread = new Product("Хлеб", 50, "Выпечка");
cucumber.Quantity = 20; 
bread.Quantity = 5;

System.Console.WriteLine("НАЧАЛЬНОЕ СОСТОЯНИЕ");
System.Console.WriteLine($"Огурцы: Цена: {cucumber.Price}, Кол-во: {cucumber.Quantity}");
System.Console.WriteLine($"Хлеб:   Цена: {bread.Price}, Кол-во: {bread.Quantity}");

//метод расчет скидки и проверки на колво
System.Console.WriteLine("ДЕЙСТВИЯ С МОЛОКОМ:");
milk.Sell(3);         
milk.ApplyDiscount(20); 
//метод стоимость * колво
System.Console.WriteLine("ДЕЙСТВИЯ С ХЛЕБОМ:");
int breadCost = bread.CalculateTotalCost(2); 
System.Console.WriteLine($"Стоимость покупки 2-х буханок хлеба: {breadCost} руб.");
bread.Restock(10);
System.Console.WriteLine("ИТОГОВОЕ СОСТОЯНИЕ");
System.Console.WriteLine($">>> Объект 1 (Молоко) <<<");
System.Console.WriteLine($"Цена: {milk.Price}, Кол-во: {milk.Quantity}"); // Изменилось
System.Console.WriteLine($"\n>>> Объект 2 (Хлеб) <<<");
System.Console.WriteLine($"Цена: {bread.Price}, Кол-во: {bread.Quantity}"); // Тоже изменилось, но по-своему
System.Console.ReadLine(); 
