using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class AlchemyRoom : Rooms
    {
        public AlchemyRoom() : base("Het Alchemielaboratorium", "Een kamer vol glazen buizen, pruttelende ketels en een penetrante chemische geur. Een zware ijzeren poort verspert de uitgang.")
        {
        }

        protected override void PlayPuzzle()
        {
            List<string> inventory = new List<string>();
           
            Console.WriteLine("Op een stoffig bureau voor je zit een briefje.");

            if (Insanity >= 2)
            {
                Console.WriteLine("De letters dansen en lijken geschreven in vloeibaar vuur.");
                Console.WriteLine("Er staat: 'MENG DE DRIE ELEMENTEN VAN DE DOOD. Vuurkruid, Zwavelpoeder en Drakenbloed... of was het Nachtschade? Drink het op, voel de bevrijding!'");
                Console.WriteLine("Je voelt een onweerstaanbare drang om willekeurige dingen in je zak te steken.");
            }        
            else
            {
                Console.WriteLine("In een mooi handschrift staat er geschreven:");
                Console.WriteLine("Om het zuur te maken dat de poort wegvreet, combineer exact drie ingrediënten:");
                Console.WriteLine("1. VUURKRUID");
                Console.WriteLine("2. ZWAVELPOEDER");
                Console.WriteLine("3. ZUURWORTEL");
                Console.WriteLine("andere combinaties kunnen giftig of explosief zijn.");
            }
            ClearConsole();

            Console.WriteLine("Je loopt door naar de grote alchemietafel achterin de kamer.");
            Console.WriteLine("Hier staan vijf potten met ingrediënten: VUURKRUID, ZWAVELPOEDER, ZUURWORTEL, NACHTSCHADE, en DRAKENBLOED.");

            while (inventory.Count < 3)
            {
                Console.WriteLine($"Jouw Inventory: [ {string.Join(", ", inventory)} ] ({inventory.Count}/3 items)");
                Console.Write("Welk ingrediënt pak je op? -> ");
                string item = Console.ReadLine().ToLower().Trim();

                if (item == "vuurkruid" || item == "zwavelpoeder" || item == "zuurwortel" || item == "nachtschade" || item == "drakenbloed")
                {
                    if (inventory.Contains(item))
                    {
                        Console.WriteLine($"Je hebt {item.ToUpper()} al in je inventaris!");
                    }
                    else
                    {
                        inventory.Add(item);
                        Console.WriteLine($"Je stopt {item.ToUpper()} in je zak.");
                    }
                }
                else
                {
                    Console.WriteLine("Dat ingrediënt staat hier niet op de tafel. Kies uit de lijst!");
                }
            }

            Console.WriteLine("Je zakken zitten vol (3/3). Je loopt naar de lege glazen kolf om alles te mengen.");
            ClearConsole();

            if (inventory.Contains("vuurkruid") && inventory.Contains("zwavelpoeder") && inventory.Contains("zuurwortel"))
            {
                Console.WriteLine("Je goet de drie poeders bij elkaar. Het mengsel begint heftig te sissen en kleurt felgroen!");
                Console.WriteLine("Je giet het bijtende zuur over het slot van de ijzeren poort. Het metaal smelt direct weg.");
                Console.WriteLine("De weg naar de allerlaatste kamer ligt open!");
                Solved = true;
            }
            else if (inventory.Contains("nachtschade") || inventory.Contains("drakenbloed"))
            {
                Console.WriteLine("Je mengt de ingrediënten... Opeens ontploft de kolf in een paarse flits!");
                Console.WriteLine("Je ademt de giftige, psychedelische damp die vrijkomt diep in.");

                if (Insanity >= 2)
                {
                    Console.WriteLine("De stemmen in je hoofd juichen: 'JA! MEER! MEER!' Je lacht als een krankzinnige.");
                }
                else
                {
                    Console.WriteLine("Je grijpt naar je hoofd. Je begint angstaanjagende hallucinaties te zien.");
                }

                Console.WriteLine("-> Je verliest een groot deel van je verstand. (+2 Insanity)");
                Insanity += 2;

                Console.WriteLine("Als de rook optrekt, zie je dat de explosie gelukkig óók het slot heeft opgeblazen! De poort ligt in duigen.");
                Console.WriteLine("Je wankelt, zwaar aangeslagen, door de opening...");
                Solved = true;
            }
            else
            {
                Console.WriteLine("Je mengt de drie stoffen, maar er gebeurt niks... Het wordt een soort mislukte grijze pap.");
                Console.WriteLine("Je gooit de kolf gefrustreerd leeg. Je moet opnieuw beginnen!");

                inventory.Clear();
                PlayPuzzle();
            }

            Console.WriteLine("Druk op Enter om door te lopen naar de finale...");
            Console.ReadLine();
        }
    }
}
