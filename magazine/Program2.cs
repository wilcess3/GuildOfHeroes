//         Product milk = new Product("Молоко", 101, "Молочка",5);
//         //milk.Quantity = 5;

//         Console.WriteLine("Тест: Применение скидки");
//         // milk.ApplyDiscount(150);
//         Console.WriteLine($"Итоговая цена со скидкой: {milk.Price} руб.");
//         Console.ReadLine();


//         Console.WriteLine($"Начальное количество молока: {milk.Quantity}");
//         Console.WriteLine("Добавляем -3(недопустимое действие):");
//         milk.Restock(-3);
//         Console.WriteLine("Добавляем 5(допустимое действие):");
//         milk.Restock(5);
//         Console.WriteLine($"Итоговое количество молока: {milk.Quantity}");

//         Product apples = new Product("Яблоки", 50, "Фрукты", 1);
//         Product cutlets = new Product("Котлеты", 167, "Мясо", 1);
//         Product cheese = new Product("Сыр", 220, "Молочка", 1);

//         Console.WriteLine(">>> Продукт 1 <<<");
//         Console.WriteLine($"Товар: {milk.Name}");
//         Console.WriteLine($"Стоимость: {milk.Price}");
//         Console.WriteLine($"Количество: {milk.Quantity}");
//         Console.WriteLine($"Категория: {milk.Category}");

//         Console.WriteLine();

//         Console.WriteLine(">>> Продукт 2 <<<");
//         Console.WriteLine($"Товар: {apples.Name}");
//         Console.WriteLine($"Стоимость: {apples.Price}");
//         Console.WriteLine($"Количество: {apples.Quantity}");
//         Console.WriteLine($"Категория: {apples.Category}");

//         Console.WriteLine();

//         Console.WriteLine(">>> Продукт 3 <<<");
//         Console.WriteLine($"Товар: {cutlets.Name}");
//         Console.WriteLine($"Стоимость: {cutlets.Price}");
//         Console.WriteLine($"Количество: {cutlets.Quantity}");
//         Console.WriteLine($"Категория: {cutlets.Category}");

//         Console.WriteLine(">>> Проверка <<<");
//         Console.WriteLine($"Товар: {cheese.Name}");
//         Console.WriteLine($"Стоимость: {cheese.Price}");
//         Console.WriteLine($"Количество: {cheese.Quantity}");
//         Console.WriteLine($"Категория: {cheese.Category}");
//         Console.WriteLine($"Есть ли в наличии??: {cheese.IsAvailable}"); // ПРАВКА: исправил опечатку IsAvaliable -> IsAvailable

//         Console.WriteLine(">>> Проверка 2 <<<");
//         //обьекты
//         Product cucumber = new Product("Огурцы", 40, "Овощи", 20);
//         Product bread = new Product("Хлеб", 50, "Выпечка", 5);
//         // cucumber.Quantity = 20;
//         // bread.Quantity = 5;

//         Console.WriteLine("НАЧАЛЬНОЕ СОСТОЯНИЕ");
//         Console.WriteLine($"Огурцы: Цена: {cucumber.Price}, Кол-во: {cucumber.Quantity}");
//         Console.WriteLine($"Хлеб:   Цена: {bread.Price}, Кол-во: {bread.Quantity}");

//         //метод расчет скидки и проверки на колво
//         Console.WriteLine("ДЕЙСТВИЯ С МОЛОКОМ:");
//         milk.Sell(3);
//         // milk.ApplyDiscount(20);
        
//         //метод стоимость * колво
//         Console.WriteLine("ДЕЙСТВИЯ С ХЛЕБОМ:");
//         int breadCost = bread.CalculateTotalCost(2);
//         Console.WriteLine($"Стоимость покупки 2-х буханок хлеба: {breadCost} руб.");
//         bread.Restock(10);
        
//         Console.WriteLine("ИТОГОВОЕ СОСТОЯНИЕ");
//         Console.WriteLine($">>> Объект 1 (Молоко) <<<");
//         Console.WriteLine($"Цена: {milk.Price}, Кол-во: {milk.Quantity}");
//         Console.WriteLine($"\n>>> Объект 2 (Хлеб) <<<");
//         Console.WriteLine($"Цена: {bread.Price}, Кол-во: {bread.Quantity}");
//         Console.ReadLine();

//         //метод проверки стоимости отриц
//         Console.WriteLine(">>> Проверка 3 (действие с ананасом и яйцами) <<<");
//         Product pineapple = new Product("Ананас", -200, "Фрукты", 1);
//         Console.WriteLine($"Фактическая цена: {pineapple.Price} руб."); 
//         // изм цены
//         Product eggs = new Product("яйца", 100, "Яйца", 1);
//         Console.WriteLine($"Текущая цена: {eggs.Price} руб.");

//         // Допустимое действие
//         eggs.ChangePrice(120);

//         // недопустимое действие
//         eggs.ChangePrice(0);
//         Console.WriteLine($"Итоговая цена: {eggs.Price} руб.");
// //временная строка для ошибки !!!
// //eggs.Price = 999;



// // доп часть (Г)!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// // Product milk = new Product("Молоко", 100, "Молочка", 10); 
// // //создание обьекта с ошибками
// // Product badApple = new Product("   ", -5, "Фрукты", -2); 
// // Console.WriteLine("Объект 1: Молоко (ДО)");
// // Console.WriteLine($"Название: '{milk.Name}', Цена: {milk.Price}, Кол-во: {milk.Quantity}");

// // допустимые действия с молоком
// // milk.Sell(3);
// // milk.ChangePrice(120);
// // // недопустимые действия с молоком 
// // milk.Sell(100); 
// // milk.ChangePrice(-50); 

// // Console.WriteLine("Объект 1: Молоко (ПОСЛЕ)");
// // Console.WriteLine($"Название: '{milk.Name}', Цена: {milk.Price}, Кол-во: {milk.Quantity}");
// // Console.WriteLine("Объект 2: Яблоко (не изменилось)");
// // Console.WriteLine($"Название: '{badApple.Name}', Цена: {badApple.Price}, Кол-во: {badApple.Quantity}");

// // //для проверки ошибк
// // milk.Quantity = 1000; 
// // milk.Name = "Новое имя";

// //Практическая 4 шаг 13
//         List<Product> products = new List<Product>();
        
//         products.Add(milk);
//         products.Add(apples);
//         products.Add(cutlets);

//         Console.WriteLine($"Количество товаров в списке: {products.Count} ");
        
//         if (products.Count > 0) {
//             Console.WriteLine($"Первый товар: {products[0].Name}");
//             Console.WriteLine($"Последний товар: {products[products.Count - 1].Name}");
//         }
//         Console.WriteLine(" Список всех товаров");
//         foreach (Product p in products) {
//             Console.WriteLine($"Товар: {p.Name} | Цена: {p.Price} | Кол-во: {p.Quantity} | Категория: {p.Category}");
//         }
//         products.Add(new Product("Сыр", 220, "Молочка", 1));
//         Console.WriteLine($"[Добавлен Сыр. Теперь товаров: {products.Count}]");

//         int lowStockCount = 0;
//         Console.WriteLine("Товары, которых осталось меньше 5 штук");
        
//         foreach (Product p in products) {
//             if (p.Quantity < 5) {
//                 lowStockCount++;
//                 Console.WriteLine($"- {p.Name} (осталось {p.Quantity} шт.)");
//             }
//         }
//         Console.WriteLine($"Итого нужно заказать: {lowStockCount} видов товара.");

//         Console.WriteLine("Изменение Молока через список ");
//         products[0].Sell(2); 
//         Console.WriteLine($"Проверка через список: {products[0].Name}, остаток: {products[0].Quantity} шт.");

//         Console.ReadLine(); 