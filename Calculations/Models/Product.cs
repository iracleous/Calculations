using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Models;

public class Product
{
    public int Id { set; get; }
    public string Name { set; get; } = string.Empty;
    public string Description { set; get; } = string.Empty;
    public string Category { set; get; } = string.Empty;
    public decimal Price { set; get; }
}
