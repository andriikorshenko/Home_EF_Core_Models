using Microsoft.EntityFrameworkCore;
using Task_002;
using Task_002.Entities;

using AppDbContext adc = new();

var pillow = new Order
{
    ProductName = "Tomato Pillow",
    Quontity = 1,
    Price = 399
};

var magnet = new Order
{
    ProductName = "Magnet Pillow",
    Quontity = 1,
    Price = 599
};

var alex = new Customer
{
    FirstName = "Alex",
    SecondName = "Former",
    PhoneNumber = "380934544433"
};

pillow.Customer = alex;
magnet.Customer = alex;

adc.Add(pillow);
adc.Add(magnet);
adc.Add(alex);

adc.SaveChanges();

var customers = adc.Customers
    .Include(p => p.Orders)
    .ToList();

foreach (var customer in customers)
{
    Console.WriteLine(customer.FirstName + " " + customer.SecondName 
        + "\n" + customer.PhoneNumber
        + "\nordered : ");

    foreach (var order in customer.Orders)
    {
        Console.WriteLine(order.ProductName);
        Console.WriteLine(order.Quontity);
        Console.WriteLine(order.Price);
    }
}