class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach (Product _product in _products)
        {
            totalPrice += _product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        if (_customer.IsInUSA())
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Customer: {_customer.GetName()}\nProducts:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} ({product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()}\nAddress:\n{_customer.GetAddress()}";
    }
}