using System;
using AvalonV3.Models;
using Microsoft.EntityFrameworkCore;

namespace AvalonV3.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
