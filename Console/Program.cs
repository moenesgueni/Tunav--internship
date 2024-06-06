using Interfaces;
using Core.Domain;
using Services;

Console.WriteLine("Hello, World!");
Client client1 = new Client();
client1.ClientId = 123456;
client1.Name = "Moenes";
Client client2 = new Client();
client1.ClientId = 222222;
client1.Name = "Ameni";

Client client3 = new Client();
client1.ClientId = 333333;
client1.Name = "farah";

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

