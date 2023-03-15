public class Product
{
    public string _name;
    public string _productId;
    public double _price;
    public int _quantity;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }

    public double ComputePrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productId;
    }

}
//Contains the name, product id, price, and quantity of each product.
//The price of this product is computed by multiplying the price and the quantity.