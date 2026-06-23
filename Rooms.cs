using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal abstract class Rooms
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Solved { get; protected set; } = false;

        //Static zodat de score behouden blijft bij het wisselen van kamers
        public static int Insanity { get; set; } = 0;

        public Rooms(string name, string description)
        {
            Name = name;
            Description = description;
        }

        //regelt de vaste opstart-lay-out voor elke kamer
        public virtual void StartKamer()
        {
            Console.Clear();
            Console.WriteLine(Name);
            Console.WriteLine(Description);

            PlayPuzzle();
        }

        //Hulpmethode om het scherm netjes leeg te maken tussen acties door
        protected virtual void ClearConsole()
        {
            Console.WriteLine("Druk op enter om verder te gaan.");
            Console.ReadLine();
            Console.Clear();
        }
        //Moet door elke kamer zelf ingevuld
        protected abstract void PlayPuzzle();
    }
}
