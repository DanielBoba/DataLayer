using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class DBContextCryptoBots : DbContext
    {
        public DbSet<BitfinexFundings> BitfinexFundings { get; set; }
        public DbSet<BitfinexTrades> BitfinexTrades { get; set; }
        public DbSet<BitfinexReadingHighRates> BitfinexReadingHighRates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-P9P0J64\SQLSERVER2016;Initial Catalog=DBCryptoBots;Integrated Security=False;User ID=sa;Password=1078;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
