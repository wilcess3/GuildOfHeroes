public class Product {
    public string Name;
    public int Quantity;
    public int Price;
    public string Category;

    public bool IsAvaliable;

    public Product(string name, int price, string category) {
        Name = name;
        this.Category = category;
        Quantity = 1;
        this.Price = price;
        IsAvaliable = true;
    }
}
