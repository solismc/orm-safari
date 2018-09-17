using System;
using orm_safari.Models;

namespace orm_safari
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Enter a Species you have seen:");
            // var name = Console.ReadLine();

            // var newSpecies = new SeenAnimals{
                // Species = name 
            // };

            // var db = new SafariVacationContext();

            // db.SeenAnimalsTable.Add(newSpecies);

            // db.SaveChanges();
        
        
        
        var db = new SafariVacationContext();
        
        var Species = db.SeenAnimalsTable;

            foreach (var seenAnimals in Species)
            {
                System.Console.WriteLine($"Species:{db} ");
            }    
            
            
            
           
        }
    }
}
