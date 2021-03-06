using System;
using Microsoft.EntityFrameworkCore;
using DotnetWebApi.Models;

namespace DotnetWebApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Character> Characters {get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}