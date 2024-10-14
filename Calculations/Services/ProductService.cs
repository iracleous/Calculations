using Calculations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Services;

public class ProductService
{
    private Product product = new ();

    public void AddProduct()
    {
          product = new Product
        {
            Name = "chips",
            Category = "food",
            Description = "snack",
            Id = 1,
            Price = 1.30m,
        };
        PrintProduct();
    }

    private void PrintProduct()
    {
        Console.WriteLine($"the product name is {product?.Name}");
    }
}
