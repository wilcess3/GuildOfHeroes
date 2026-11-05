public class Product {
    public string Name;
    public int Quantity;
    public int Price;
    public string Category;

    public bool IsAvaliable;

    public Product(string name, int price, string category) {
        Name = name;
        Category = category;
        Quantity = 1;
        Price = price;
        IsAvaliable = true;
    }
    public void Restock(int amount) {
        if (amount <= 0) {
            System.Console.WriteLine("Ошибка: Количество для пополнения должно быть больше нуля!");
            return;
        }
        Quantity = Quantity + amount;
    }

    // метод 1
    public void Sell(int amount) {
        if (amount > Quantity || amount <= 0) {
            System.Console.WriteLine($"Ошибка: Нельзя продать {amount} шт. товара '{Name}'. На складе только {Quantity} шт.");
            return;
        }
        Quantity = Quantity - amount;
        System.Console.WriteLine($"Успешно продано {amount} шт. товара '{Name}'.");
    }

    //метод 2(расчет стоимости)
    public int CalculateTotalCost(int amountToBuy) {
        return Price * amountToBuy;
    }

    //метод 3 (применение скидки)
    public void ApplyDiscount(int percent) {
        if (percent <= 0 || percent >= 100) {
            System.Console.WriteLine("Ошибка: Скидка должна быть от 1 до 99%!");
            return;
        }
        int discountAmount = (Price * percent) / 100;
        Price = Price - discountAmount;
        System.Console.WriteLine($"На товар '{Name}' применена скидка {percent}%. Новая цена: {Price} руб.");
    }
}
