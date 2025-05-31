class Customer
// Represents a customer in an online ordering system
{
    private string name;
    private Address address;

    // This class represents a customer in an online ordering system.
    // It includes properties for the customer's name and address.

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
// Constructor to initialize the customer with their name and address.
    public bool LivesInUSA()
    // This method checks if the customer lives in the USA based on their address.
    // It returns true if the address is in the USA, otherwise false.
    {
        return address.IsInUSA();
    }

    public string GetShippingLabel()
    // Generates a shipping label for the customer, including their name and full address.
    {
        return $"Customer: {name}\nAddress:\n{address.GetFullAddress()}";
    }
}
