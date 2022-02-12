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

        DbSet<Character> Characters {get; set;}
    }
}