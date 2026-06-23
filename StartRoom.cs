using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class StartRoom : Rooms
    {
        private bool _hasKey = false;
        
        public StartRoom() : base("De slaap kamer", "Een oude verlaten slaap kamer. Er is maar 1 deur en die is opslot. verder zie je een bed, kast, bureau en een raam met metalen bars erachter.")
        {
        }

        protected override void PlayPuzzle()
        {
            Console.WriteLine("Je weet dat je moet onstnappen. de sleutel ligt waarschijnlijk in de kamer, maar waar?.");
            Console.WriteLine();

            while (!Solved)
            {
                Console.Write("Wat wil je onderzoeken? -> ");
                Console.WriteLine("Je kan kiezen uit: bed, kast, bureau, raam en deur");
                Console.WriteLine("Typ je keuze in en druk op enter.");
                string choice = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                switch (choice)
                {
                    case "bed":
                        Console.WriteLine("Je kijkt onder het bed, maar er is niets te vinden behalve stof en doode spinnen.");
                        ClearConsole();
                        break;
                    case "kast":
                        Console.WriteLine("Je kijkt de kast in maar ziet de sleutel niet. je ziet wel iets anders interesants");
                        Console.WriteLine("een verdacht boek met een bloedkleurige cover. de cover heeft een rondje in het midden met de naam er in. 'Bestiary of Demonic Beasts'. vanuit het rondje spreiden er tentakels het boek rond");
                        Console.Write("Wil je het boek lezen? (ja/nee): ");
                        string readChoice = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        if (readChoice == "ja")
                        {
                            Console.WriteLine("Je slaat het boek open. De pagina's staan vol met chaotische, buitenaardse symbolen.");
                            Console.WriteLine("Terwijl je leest, hoor je gefluister in je hoofd. Je krijgt vreselijke visioenen van wezens uit de diepte...");
                            Console.WriteLine("-> Je verstand brokkelt af. (+1 Insanity)");
                            Insanity++;
                        }
                        else
                        {
                            Console.WriteLine("Je vertrouwt het boek niet en legt het voorzichtig terug.");
                        }
                        ClearConsole();
                        break;
                    case "bureau":
                        Console.WriteLine("Je doorzoekt het bureau, het zit vol met schetsen van beesten aparte beesten die je nog nooit hebt gezien. je schuift ze aan de kant en ziet de sleutel.");
                        _hasKey = true;
                        ClearConsole();
                        break;
                    case "raam":
                        Console.WriteLine("Je kijkt door het raam, maar het is afgesloten met metalen bars. Er is niets te vinden.");
                        ClearConsole();
                        break;
                    case "deur":
                        if (_hasKey)
                        {
                            Console.WriteLine("Je gebruikt de sleutel om de deur te openen. Je bent ontsnapt uit de kamer!");
                            Solved = true;
                        }
                        else
                        {
                            Console.WriteLine("De deur is op slot. Je hebt een sleutel nodig om te ontsnappen.");
                        }
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Probeer het opnieuw.");
                        break;

                }
            }
        }
    }
}
