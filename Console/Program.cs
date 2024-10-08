﻿using Interfaces;
using Core.Domain;
using Services;
using Infrastructure;
using Core.Services;
using Core.Interfaces;

Infrastructure.TUContext context = new Infrastructure.TUContext();
IUnitOfWork uow = new UnitOfWork(context);
IClientService clientService = new ClientService(uow);


Console.WriteLine("Hello, World!");
Client client1 = new Client();
client1.ClientId = 123456;
client1.Name = "Moenes";
context.Add(client1);
context.Clients.Add(client1);
Console.WriteLine(clientService.ClientsNb());
context.SaveChanges();


Client client2 = new Client();
client2.ClientId = 222222;
client2.Name = "Ameni";

Client client3 = new Client();
client3.ClientId = 333333;
client3.Name = "farah";

Compte compte1 = new Compte();
compte1.CompteId = 123040;
compte1.login = "moenesMO";
compte1.password = "mooooo";
compte1.date_dernier_cnx = DateTime.Now;
compte1.lien = "Gamix";

Compte compte2 = new Compte();
compte2.CompteId = 127019;
compte2.login = "AmeniAo";
compte2.password = "Aooomeni";
compte2.date_dernier_cnx = DateTime.Now;
compte2.lien = "Mobile";

Compte compte3 = new Compte();
compte3.CompteId = 325614;
compte3.login = "FarahFH";
compte3.password = "FarahHH";
compte3.date_dernier_cnx = DateTime.Now;
compte3.lien = "Réseau";

Compte compte4 = new Compte();
compte4.CompteId = 896574;
compte4.login = "MoensMOO";
compte4.password = "Moookiu";
compte4.date_dernier_cnx = DateTime.Now;
compte4.lien = "SysEmbarqué";

