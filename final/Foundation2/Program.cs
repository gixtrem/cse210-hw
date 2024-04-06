class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", 101, 1223.45m, 1);
        Product product2 = new Product("Headphones", 102, 300.99m, 2);
        Product product3 = new Product("Backpack", 100, 89.33m, 1);

        // Create address and customer
        Address address = new Address("225 Main St", "Rexburg", "ID", "USA");
        Customer customer = new Customer("Umah Godday", address);

        // Create order and add products
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        // Display packing label, shipping label, and total cost
        Console.WriteLine("Packing Label: House_Of_Gucci");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label: FEDEX");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
    }
}
