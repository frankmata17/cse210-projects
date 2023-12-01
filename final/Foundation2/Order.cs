class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;

        foreach (var product in products)
        {
            totalPrice += product.GetTotalPrice();
        }

        // Add shipping cost based on customer location
        if (customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (var product in products)
        {
            packingLabel += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {customer.Name}\nAddress: {customer.Address.GetFullAddress()}";
    }
}
