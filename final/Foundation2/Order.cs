using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> Products = new List<Product>();
    private Customer Customer;
    private static readonly decimal ShippingCostUSA = 5m;
    private static readonly decimal ShippingCostInternational = 35m;

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal productTotal = 0m;
        foreach (var product in Products)
        {
            productTotal += product.GetTotalCost();
        }

        return productTotal + (Customer.LivesInUSA() ? ShippingCostUSA : ShippingCostInternational);
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in Products)
        {
            label.AppendLine($"{product.Name} - ID: {product.ProductId}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address}";
    }
}
