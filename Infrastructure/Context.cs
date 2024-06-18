using Core.Domain;
using Fluent.Infrastructure.FluentModel;
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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<ClientClick> ClientClicks { get; set; }

        public IConfiguration _config { get; set; }

        public Context(IConfiguration config)
        {
            _config = config;
        }

        public Context()
        {
        }
        public Context(DbContextOptions<Context> options):base(options) {

        }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientClick>()
            .HasOne(cc => cc.Client)
                .WithMany(c => c.ClientClicks)
            .HasForeignKey(cc => cc.ClientId);

            modelBuilder.Entity<ClientClick>()
                .HasOne(cc => cc.Compte)
                .WithMany(c => c.ClientClicks)
                .HasForeignKey(cc => cc.CompteId);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime");
            base.ConfigureConventions(configurationBuilder);
        }

        private readonly Context _context;

        public ClientClickService(Context context)
        {
            _context = context;
        }

        public void TrackClientClick(int clientId, int compteId)
        {
            var clientClick = new ClientClick
            {
                ClientId = clientId,
                CompteId = compteId,
                ClickedAt = DateTime.Now
            };

            _context.ClientClicks.Add(clientClick);

            var compte = _context.Comptes.Find(compteId);
            if (compte != null)
            {
                compte.ClickedAt = DateTime.Now;
            }

            _context.SaveChanges();
        }

        public void GetClientClicksAndClientNames(int compteId)
        {
            var result = _context.ClientClicks
                .Where(cc => cc.CompteId == compteId)
                .GroupBy(cc => cc.Compte)
                .Select(g => new
                {
                    Link = g.Key.Link,
                    ClickCount = g.Count(),
                    Clients = g.Select(cc => cc.Client.Name).Distinct()
                })
                .FirstOrDefault();

            if (result != null)
            {
                Console.WriteLine($"Link: {result.Link}");
                Console.WriteLine($"Number of Clicks: {result.ClickCount}");
                Console.WriteLine("Clients who clicked the link:");

                foreach (var clientName in result.Clients)
                {
                    Console.WriteLine(clientName);
                }
            }
            else
            {
                Console.WriteLine("No clicks found for this link.");
            }
        }


    }
}
