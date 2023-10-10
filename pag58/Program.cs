using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string name;
                const double priceForKm = 1.20;
                double km_start;
                double km_end;
                double km_travelled;
                double price;

                Console.Write("Nome del cliente: ");
                name = Console.ReadLine();

                Console.Write("Chilometri iniziali: ");
                km_start = double.Parse(Console.ReadLine());

                Console.Write("Chilometri finali: ");
                km_end = double.Parse(Console.ReadLine());

                km_travelled = km_end - km_start;
                price = km_travelled * priceForKm;

                Console.WriteLine(string.Format("Hai percorso {0}km", km_travelled));
                Console.WriteLine($"gentile Sig. {name} deve pagare: {price}euro");

                Console.ReadKey();                                                      
            
        }
    }
}