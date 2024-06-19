using Core.Domain;
using Core.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Core.Services
{
    public class ClientClickService : Service<ClientClick>,IClientClick
    {
        public List<ClientClick> ClientClicks { get; set; } = new List<ClientClick>();
        public List<Compte> Comptes { get; set; } = new List<Compte>();

        public ClientClickService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
/*
        public void TrackClientClick(int clientId, int compteId)
        {
                      ClientClick clientClick = new ClientClick()
                       {
                           ClientId = clientId,
                           CompteId = compteId,
                           date_dernier_cnx = DateTime.Now
                       };

                       ClientClicks.Add(clientClick);

                       Compte compte = Comptes.Find(compteId);
                       if (compte != null)
                       {
                           compte.date_dernier_cnx = DateTime.Now;
                       }

                       _context.SaveChanges();
            var clientClick = new ClientClick()
            {
                ClientId = clientId,
                CompteId = compteId,
                date_dernier_cnx = DateTime.Now
            };

            ClientClicks.Add(clientClick);

            var compte = Get(c => c.CompteId == compteId);
            if (compte != null)
            {
                compte.date_dernier_cnx = DateTime.Now;
            }


           
        }

        public void GetClientClicksAndClientNames(int compteId)
        {
            ClientClick result = ClientClicks
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
        }*/
    }
}
