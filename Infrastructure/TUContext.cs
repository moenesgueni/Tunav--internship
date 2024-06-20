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
using static System.Collections.Specialized.BitVector32;

namespace Infrastructure
{
    public class TUContext:DbContext

    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<ClientClick> ClientClicks { get; set; }


        public IConfiguration _config { get; set; }

        public TUContext(IConfiguration config)
        {
            _config = config;
        }

        public TUContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime");
            base.ConfigureConventions(configurationBuilder);
        }


        //public TUContext(DbContextOptions<TUContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ClientClick>()
            //    .HasOne(cc => cc.Client)
            //    .WithMany(c => c.ClientClicks)
            //    .OnDelete(DeleteBehavior.Restrict); 

            //modelBuilder.Entity<ClientClick>()
            //    .HasOne(cc => cc.Compte)
            //    .WithMany(c => c.ClientClicks)
            //    .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);

        }
    }

    }