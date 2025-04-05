using System;
using System.Linq;

public class LINQToSQL
{
    // Simulating a database
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    public void Run()
    {
        // Sample data, simulating the SQL database
        var customers = new[]
        {
            new Customer { CustomerId = 1, Name = "John Doe", City = "New York" },
            new Customer { CustomerId = 2, Name = "Jane Smith", City = "Los Angeles" },
            new Customer { CustomerId = 3, Name = "Alice Johnson", City = "New York" },
            new Customer { CustomerId = 4, Name = "Bob Brown", City = "Chicago" }
        };

        var customersInNewYork = from customer in customers
                                 where customer.City == "New York"
                                 select customer;

        Console.WriteLine("Customers in New York:");
        foreach (var customer in customersInNewYork)
        {
            Console.WriteLine($"{customer.Name} from {customer.City}");
        }
    }
}
