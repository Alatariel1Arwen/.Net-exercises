using System;
using System.Collections.Generic;
using System.Linq;
using Experiment;

class Program
{
    static void Main(string[] args)
    {
        List<Articolo> listaArticoli = new List<Articolo>
        {
            new Articolo { ID = 1, Nome = "Item 1" },
            new Articolo { ID = 2, Nome = "Item 2" },
            new Articolo { ID = 3, Nome = "Item 3" }
        };

        int targetID = 2;

        Articolo articolo = listaArticoli.FirstOrDefault(a => a.ID == targetID);
        Console.WriteLine("FirstOrDefault:");
        if (articolo != null)
        {
            Console.WriteLine($"Article found: {articolo.Nome}");
        }
        else
        {
            Console.WriteLine("No articles found.");
        }

        Articolo articoloUnico = listaArticoli.SingleOrDefault(a => a.ID == targetID);
        Console.WriteLine("SingleOrDefault:");
        if (articoloUnico != null)
        {
            Console.WriteLine($"Unique item found: {articoloUnico.Nome}");
        }
        else
        {
            Console.WriteLine("No items found or duplicates found.");
        }
    }
}