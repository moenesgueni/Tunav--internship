using Core.Domain;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Context:DbContext

    {
        public IConfiguration _config { get; set; }

        public Context(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
           // optionsBuilder.UseLazyLoadingProxies();
           // base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
    }
}
