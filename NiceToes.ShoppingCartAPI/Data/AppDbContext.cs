﻿using Microsoft.EntityFrameworkCore;
using NiceToes.ShoppingCartAPI.Models;

namespace NiceToes.ShoppingCartAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
     
    }
}
