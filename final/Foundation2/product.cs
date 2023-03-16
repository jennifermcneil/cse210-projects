public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double ComputeTotalPrice()
    {
        return _price * _quantity;
    }

}
//Contains the name, product id, price, and quantity of each product.
//The price of this product is computed by multiplying the price and the quantity.