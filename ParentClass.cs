using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class ParentClass
    {
        public abstract class Kamer
        {
            public string Naam { get; set; }
            public string Beschrijving { get; set; }
            public bool IsOpgelost { get; protected set; } = false;

            public Kamer(string naam, string beschrijving)
            {
                Naam = naam;
                Beschrijving = beschrijving;
            }
            public virtual void StartKamer()
            {
                Console.Clear();
                Console.WriteLine(Naam);
                Console.WriteLine(Beschrijving);

                SpeelPuzzel();
            }

            protected abstract void SpeelPuzzel();
        }
    }
}
