using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Models;

public class EshopDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=(local); Initial Catalog=codeCreate2024; Integrated Security = True; TrustServerCertificate=True; ";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
