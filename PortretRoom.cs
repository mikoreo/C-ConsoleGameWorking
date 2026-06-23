using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class PortretRoom : Rooms
    {
        public PortretRoom() : base("schilder kamer", "je loopt de nieuwe kamer binnen. het is een grote oude kamer vol met schilderijen. Meeste schilderijen zijn kapot maar er zijn nog 3 hele schilderijen. er is ook een grote deur met een 3 cijverig slot")
        {
        }

        protected override void PlayPuzzle()
        {
            while (!Solved)
            {
                Console.WriteLine("wat wil je als eerste doen. de 3 schilderijen bekijken, de grote deur bekijken of rond kijken in de kamer");
                Console.WriteLine("typ 'schilderijen', 'deur' of 'kijk'");
                string readChoice = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                switch (readChoice)
                {
                    case "schilderijen":
                        if (Insanity == 2)
                        {
                            Console.WriteLine("je bekijkt de schilderijen. het eerste schilderij is een portret van een enge vrouw, ze staart je aan, of lijkt het maar zo. het derde schilderij is een landschap van een bos, het lijkt alsof er iemand achter een boom staat. het middelste schilderij is een schilderij van een gigantische octopus die een schip aanvalt, beweegt het water nou?");
                            Console.WriteLine("je ziet 3 codes staan op elk schilderij. 194, 735 en 456. je denkt dat dit misschien de code is voor het slot van de deur. maar welke klopt");
                        }
                        else if (Insanity == 1)
                        {
                            Console.WriteLine("je bekijkt de schilderijen. het eerste schilderij is een portret van een angstige vrouw. het derde schilderij is een landschap van een bos. het middelste schilderij is een schilderij van een gigantische octopus die een schip aanvalt.");
                            Console.WriteLine("je ziet dat er cijfers staan op het eerste en middelste schilderij staan. 875 en 735. je denkt dat dit misschien de codes zijn voor het slot van de deur. maar welke klopt?");
                        }
                        else if (Insanity == 0)
                        {
                            Console.WriteLine("je bekijkt de schilderijen. het eerste schilderij is een portret van een angstige vrouw. het derde schilderij is een landschap van een bos. het middelste schilderij is een schilderij van een gigantische octopus die een schip aanvalt.");
                            Console.WriteLine("je ziet dat er een cijfer op het middelste schilderij staat. 735. je denkt dat dit misschien de code is voor het slot van de deur.");
                        } else {
                            Console.WriteLine("je bekijkt de schilderijen. het eerste schilderij is een portret van een vrouw, haar ogen blijven je volgen. het derde schilderij is een landschap van een bos, het bos zit vol met rode ogen. het middelste schilderij is een schilderij van een gigantische octopus die een schip aanvalt. AAAAHHH, DE TENTAKELS BEWEGEN");
                            Console.WriteLine("je ziet 3 codes staan op elk schilderij. 194, 735 en 456. je denkt dat dit misschien de code is voor het slot van de deur. maar welke klopt");
                        }
                        ClearConsole();
                    break;
                    case "deur":
                        Console.WriteLine("je bekijkt de deur. het is een grote houten deur met een 3 cijferig slot. je ziet dat er een code nodig is om de deur te openen.");
                        Console.WriteLine("wil je de code proberen in te voeren? (ja/nee)");
                        string codeChoice = Console.ReadLine().ToLower().Trim();

                        if (codeChoice == "ja")
                        {
                            Console.Write("Voer de code in: ");
                            string code = Console.ReadLine().Trim();
                            Console.Clear();
                            if (code == "735")
                            {
                                Console.WriteLine("je draait aan het slot en de deur gaat open. je hebt het landhuis ontsnapt!");
                                Solved = true;
                            }
                            else
                            {
                                Console.WriteLine("je voert de code in en je voelt je lichtjes in je hoofd. de deur gaat open! en er komen tentakels uit!!");
                                Console.WriteLine("-> Je verstand brokkelt af. (+1 Insanity)");
                                Insanity++;
                                Console.WriteLine("je wordt na een paar minuten weer wakker in de kamer. je ziet dat de deur weer dicht is en dat het slot weer op slot zit. je kan de code opnieuw proberen in te voeren.");
                                ClearConsole();
                            }
                        }
                        else
                        {
                            Console.WriteLine("je besluit de code niet in te voeren en kijkt verder rond in de kamer.");
                            ClearConsole();
                        }
                    break;
                    case "kijk":
                        Console.WriteLine("je kijkt rond in de kamer. er is een groot raam met metalen bars erachter. je ziet dat het buiten donker is en dat er een storm op komst is.");
                        Console.WriteLine("je ziet een bijna heel schilderij liggen op de grond. het enige wat je nog kan zien is het getal 2.");
                        ClearConsole();
                    break;
                    default:
                    Console.WriteLine("ongeldige keuze. probeer het opnieuw.");
                    ClearConsole();
                    break;

                }
            }
        }
    }
}
