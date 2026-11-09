// public class Product {
//     public string Name;
//     public int Quantity;
//     public string Category;
//     public bool IsAvaliable;
//     public int Price { get; private set; }
//     public Product(string name, int price, string category) {
//         Name = name;
//         Category = category;
//         Quantity = 1;
//         IsAvaliable = true;

//         //поле и правило допустимости (практическая 3)
//         if (price <= 0) {
//             Console.WriteLine($" Цена товара '{Name}' не может быть {price}. Установлена минимальная цена 1 руб.");
//             Price = 1;
//         }
//         else {
//             Price = price;
//         }
//     }
//        // метод изменения цены
//     public void ChangePrice(int newPrice) {
//         if (newPrice <= 0) {
//             Console.WriteLine($"Ошибка: Нельзя установить цену {newPrice} руб. Цена должна быть больше нуля!");
//             return;
//         }

//         Price = newPrice;
//         Console.WriteLine($"Цена на товар '{Name}' успешно изменена на {Price} руб.");
//     }

//     public void Restock(int amount) {
//         if (amount <= 0) {
//             Console.WriteLine("Ошибка: Количество для пополнения должно быть больше нуля!");
//             return;
//         }
//         Quantity = Quantity + amount;
//     }

//     // метод 1
//     public void Sell(int amount) {
//         if (amount > Quantity || amount <= 0) {
//             Console.WriteLine($"Ошибка: Нельзя продать {amount} шт. товара '{Name}'. На складе только {Quantity} шт.");
//             return;
//         }
//         Quantity = Quantity - amount;
//         Console.WriteLine($"Успешно продано {amount} шт. товара '{Name}'.");
//     }

//     // метод 2 (расчет стоимости)
//     public int CalculateTotalCost(int amountToBuy) {
//         return Price * amountToBuy;
//     }

//     // метод 3 (применение скидки)
//     public void ApplyDiscount(int percent) {
//         if (percent <= 0 || percent >= 100) {
//             Console.WriteLine("Ошибка: Скидка должна быть от 1 до 99%!");
//             return;
//         }
//         int discountAmount = (Price * percent) / 100;
//         Price = Price - discountAmount;
//         Console.WriteLine($"На товар '{Name}' применена скидка {percent}%. Новая цена: {Price} руб.");
//     }

// }

//доп часть (Г)
// public class Product {
//     private string _name; 
//     public string Name {
//         get { return _name; }
//         private set {
//             if (string.IsNullOrWhiteSpace(value)) {
//                 Console.WriteLine("Название не может быть пустым! Установлено 'Без названия'.");
//                 _name = "Без названия";
//             } else {
//                 _name = value.Trim();
//             }
//         }
//     }
//     public int Quantity { get; private set; }
//     public string Category;
//     public bool IsAvailable;
//     public int Price { get; private set; }
//     public Product(string name, int price, string category, int startQuantity) {
//         Name = name; 
//         Category = category;
//         IsAvailable = true;
//         if (price <= 0) {
//             Console.WriteLine($"Цена не может быть {price}. Установлена 1.");
//             Price = 1;
//         } else {
//             Price = price;
//         }

//         if (startQuantity < 0) {
//             Console.WriteLine($"Начальное количество не может быть {startQuantity}. Установлено 0.");
//             Quantity = 0;
//         } else {
//             Quantity = startQuantity;
//         }
//     }
//     public void Restock(int amount) {
//         if (amount <= 0) {
//             Console.WriteLine("Ошибка: Количество для пополнения должно быть больше нуля!");
//             return;
//         }
//         Quantity = Quantity + amount;
//         Console.WriteLine($"Товар пополнен. Теперь на складе: {Quantity} шт.");
//     }

//     public void Sell(int amount) {
//         if (amount > Quantity || amount <= 0) {
//             Console.WriteLine($"Ошибка: Нельзя продать {amount} шт. На складе: {Quantity} шт.");
//             return;
//         }
//         Quantity = Quantity - amount;
//         Console.WriteLine($"Успешно продано {amount} шт. Остаток: {Quantity} шт.");
//     }

//     public void ChangePrice(int newPrice) {
//         if (newPrice <= 0) {
//             Console.WriteLine("Ошибка: Цена должна быть больше нуля!");
//             return;
//         }
//         Price = newPrice;
//         Console.WriteLine($"Цена изменена на {Price} руб.");
//     }

//     public int CalculateTotalCost(int amountToBuy) {
//         return Price * amountToBuy;
//     }
// }