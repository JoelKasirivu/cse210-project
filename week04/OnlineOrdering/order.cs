class Order
// Represents an order containing multiple products and customer information
{
    // This class represents an order in an online ordering system.
    private List<Product> products;
    private Customer customer;
    private const double ShippingFeeUSA = 5.0;
    private const double ShippingFeeInternational = 35.0;
    // It includes a list of products, customer information, and shipping fees based on the customer's location.

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    // Adds a product to the order. The product is added to the products list.
    // The method takes a Product object as a parameter and adds it to the products list.

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += customer.LivesInUSA() ? ShippingFeeUSA : ShippingFeeInternational;
        return totalCost;
    }
// Calculates the total cost of the order, including the cost of all products and shipping fees.
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }
// Generates a packing label for the order, listing all products with their details.
    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetShippingLabel();
    }
}
