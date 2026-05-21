using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class Rooms
    {
        private string _name;
        private string _description;
        private bool _solvedPuzzle;
        private int _sanity;
        public Rooms(string Name, string Description, int Sanity)
        {
            _name = Name;
            _description = Description;
            _sanity = Sanity;
        }
    }
}
