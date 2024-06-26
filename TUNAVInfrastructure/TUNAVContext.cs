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
using TUNAV.Core.Domain;
using TUNAVCore.Domain;

namespace TUNAVInfrastructure
{
    public class TUNAVContext:DbContext
    {
        private IConfiguration _config { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<ClientClick> ClientClicks { get; set; }

        public TUNAVContext(IConfiguration config)
        {
            _config = config;
        }

        public TUNAVContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    //  modelBuilder.ApplyConfiguration(new PlaneConfiguration());
        //    modelBuilder.Entity<Plane>().HasKey(p => p.PlaneId);
        //    modelBuilder.Entity<Plane>().ToTable("MyPlanes");
        //    modelBuilder.Entity<Plane>().Property(p => p.Capacity)
        //                .HasColumnName("PlaneCapacity");
        //    modelBuilder.ApplyConfiguration(new FlightConfiguration());
        //    //Configuring Owned Type
        //    modelBuilder.Entity<Passenger>().OwnsOne(p => p.FullName);
        //    //Configurer l'héritage Table Par Hierarchy (TPH)
        //    //modelBuilder.Entity<Passenger>()
        //    //     .HasDiscriminator<int>("IsTraveller")
        //    //     .HasValue<Passenger>(0)
        //    //     .HasValue<Traveller>(1)
        //    //     .HasValue<Staff>(2);
        //    //Configurer l'héritage Table Par Type
        //    modelBuilder.Entity<Staff>().ToTable("Staffs");
        //    modelBuilder.Entity<Traveller>().ToTable("Travellers");
        //    //Configurer la clé primaire de la porteuse de données
        //    modelBuilder.Entity<Ticket>().HasKey(t => new { t.FlightFK, t.PassengerFK });
            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime");
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
