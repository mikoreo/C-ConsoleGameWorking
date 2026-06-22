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
        public Rooms(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void StartKamer()
        {
            Console.Clear();
            Console.WriteLine(Name);
            Console.WriteLine(Description);

            SpeelPuzzel();
        }

        protected abstract void SpeelPuzzel();
    }
}
