using System;
using InsuranceBrokerApp.Models;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client
        {
            Id = 1,
            Nume = "Popescu Ion",
            CNP = "1234567890123",
            Telefon = "0712345678"
        };

        PolitaRCA rca = new PolitaRCA
        {
            Id = 1,
            CapacitateCilindrica = 2000,
            VarstaSofer = 23,
            DataInceput = DateTime.Now,
            DataExpirare = DateTime.Now.AddMonths(6)
        };

        rca.CalculeazaPret();

        client.AdaugaPolita(rca);

        Console.WriteLine($"Client: {client.Nume}");
        Console.WriteLine($"Pret RCA: {rca.Pret}");
    }
}