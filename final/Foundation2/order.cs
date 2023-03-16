public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private double _cost;

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }

    public void AddProduct()
    {
        Console.WriteLine("Name: ");
        string _name = Console.ReadLine();
        Console.WriteLine("ProductID: ");
        string _productId = Console.ReadLine();
        Console.WriteLine("Price: $");
        double _price = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantity: ");
        int _quantity = int.Parse(Console.ReadLine());
        Product product = new Product(_name, _productId, _price, _quantity);
        _productList.Add(product);
    }

    public double CalculateTotalCost()
    {
        double cost = 0;
        foreach (Product product in _productList)
        {
            cost += product.ComputeTotalPrice();
        }
        if (_customer.IsInUSA())
            cost += 5;
        else
            cost += 35;

        _cost = cost;
        return Math.Round(cost, 2);
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _productList)
        {
            label += $"{product.GetName()} - {product.GetProductID()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        string label = "";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().GetAddressText()}";
        return label;
    }
    // Create method
    // Create empty label string
    // call getName() from customer and add that to the label with a new line
    // call the getAdressText() stored in the address class in customer
    // _customer.GetAddress().GetAddressText(), add that to the label
    // return label.


}
//Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
//The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
//This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
//A packing label should list the name and product id of each product in the order.
//A shipping label should list the name and address of the customer