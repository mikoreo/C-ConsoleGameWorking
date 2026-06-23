using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class Hallway : Rooms
    {
        private bool _wrongDoor = false;
        public Hallway() : base("Gang", "je loopt een stille verlaten gang binnen. het behang is aan het vervagen en valt op stukken van de muren af. je ziet 3 deuren voor je. Er kan maar 1 de goede zijn.")
        {
        }

        protected override void PlayPuzzle()
        {
            while (!Solved)
            {
                Console.WriteLine("Je moet de juiste deur kiezen om verder te gaan. maar welke is de juiste");
                Console.WriteLine();

                if (Insanity == 1)
                {
                    Console.WriteLine("je stapt verder de gang in en ineens hoor je geschreeuw uit kamer 1 komen");
                    Console.WriteLine("het geschreeuw stopt en nu hoor je intens gekrab tegen de deur van kamer 2");
                    Console.WriteLine("nadat dat stopt hoor je iets dat klink als gehuil van een geest komen uit kamer 3");
                    Console.WriteLine();
                }
                else if (Insanity == 0)
                {
                    Console.WriteLine("je stapt verder de gang in en ineens hoor je geschreeuw uit kamer 1 komen");
                    Console.WriteLine("in kamer 2 is het angstaanjagend stil");
                    Console.WriteLine("en in kamer 3 hoor je heel harde wind");
                    Console.WriteLine(); 
                }

                Console.WriteLine("wat kies je te doen: open deur 1, open deur 2, open deur 3 of kijk meer rond in de gang.");
                Console.WriteLine("typ de kamer nummer of typ 'kijk'. ");
                string readChoice = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                switch (readChoice)
                {
                    case "1":
                        if (_wrongDoor == true)
                        {
                            Console.WriteLine("de Deur zit opslot");
                            ClearConsole();
                        }
                        else
                        {
                            Console.WriteLine("je opent de deur en je ziet een lege kamer voor je....  BAM!");
                            Console.WriteLine("je wordt hard op je hoofd geslagen door iets wat je niet kon zien en je wordt de kamer uitgegooid ");
                            Console.WriteLine("-> Je verstand brokkelt af. (+1 Insanity)");
                            Console.WriteLine("de foute deuren zitten nu opslot. je hebt maar 1 keuze.");
                            Insanity++;
                            _wrongDoor = true;
                            ClearConsole();
                        }
                        break;
                    case "2":
                        if (_wrongDoor == true)
                        {
                            Console.WriteLine("de Deur zit opslot");
                            ClearConsole();
                        }
                        else
                        {
                            Console.WriteLine("je opent de deur en je ziet een lege kamer voor je....  BAM!");
                            Console.WriteLine("je wordt hard op je hoofd geslagen door iets wat je niet kon zien en je wordt de kamer uitgegooid ");
                            Console.WriteLine("-> Je verstand brokkelt af. (+1 Insanity)");
                            Console.WriteLine("de foute deuren zitten nu opslot. je hebt maar 1 keuze.");
                            Insanity++;
                            _wrongDoor = true;
                            ClearConsole();
                        }
                        break;
                    case "3":
                        Console.WriteLine("je hebt de goede deur gekozen!");
                        Console.WriteLine("je gaat door naar de volgende kamer");
                        ClearConsole();
                        Solved = true;
                        break;
                    case "kijk":
                        Console.WriteLine("je kijkt rond de gang en je ziet een symbol achter een gedeelte afgebroken behang");
                        Console.WriteLine("het is een symbol van de wind");
                        break;

                }
            }
        }
    }
}
