using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rooms> mansion = new List<Rooms>
        {
            new StartRoom()
        };

            Console.WriteLine("Welkom bij Escape the Mansion!");
            Console.WriteLine("Probeer te ontsnappen door alle puzzels op te lossen.");
            Console.WriteLine("Druk een toets in om verder te gaa");
            Console.ReadLine();

            Console.WriteLine("je wordt wakker in een verlaten slaap kamer. hoe ben je hier gekomen?.");
            Console.WriteLine("Je hoort ineens een stem in je hoofd die zegt.....");
            Console.WriteLine("ONTSNAP");
            Console.WriteLine("Druk een toets in om verder te gaan");
            Console.ReadLine();

            foreach (Rooms kamer in mansion)
            {
                kamer.StartKamer();
            }

            Console.Clear();
            Console.WriteLine("Gefeliciteerd! Je hebt alle puzzels opgelost en bent ontsnapt uit het landhuis!");
            Console.ReadLine();
        }
    }
}
