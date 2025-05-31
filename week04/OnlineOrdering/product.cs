using System;
using System.Collections.Generic;

class Product
// Represents a product in an online ordering system
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // This class represents a product in an online ordering system.
    // It includes properties for the product name, ID, price, and quantity.

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
// Constructor to initialize the product with its name, ID, price, and quantity.
    public double GetTotalCost()
    {
        return price * quantity;
    }
    // Calculates the total cost of the product based on its price and quantity.
    // This method returns the total cost of the product by multiplying its price by the quantity.

    public string GetPackingLabel()
    {
        return $"Product: {name} (ID: {productId})";
    }
}