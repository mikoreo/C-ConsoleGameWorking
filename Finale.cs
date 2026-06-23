using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ConsoleGame
{
    internal class Finale : Rooms
    {
        public Finale() : base("De Grote Hal", "Je stapt de gigantische centrale hal van het landhuis binnen. Voor je zie je de immense, dubbele houten voordeuren. Dit is de uitgang. Maar je bent niet alleen...")
        {
        }

        protected override void PlayPuzzle()
        {
            Console.WriteLine("In het midden van de hal staat een mysterieuze, in schaduwen gehulde gedaante.");
            Console.WriteLine("De gedaante draait zich langzaam naar je om en spreekt met een echoënde stem:");
            Console.WriteLine("'Dus... je hebt mijn puzzels overleefd. Maar hoeveel van jezelf ben je onderweg verloren?'");
            Console.WriteLine("Druk op Enter om je lot onder ogen te zien...");
            Console.ReadLine();

            Console.Clear();


            if (Insanity >= 4)
            {
                // EIND 1: De speler heeft te veel insanity
                Console.WriteLine("EIND 1: DE WAANZIN OVERHEERST");
                Console.WriteLine();
                Console.WriteLine("Je probeert naar de voordeur te rennen, maar de gedaante begint hard te lachen.");
                Console.WriteLine("Plotseling besef je het... DE GEDAANTE BEN JEZELF! Er is helemaal geen uitgang.");
                Console.WriteLine("Je bent al die tijd al gek geweest. Je valt op je knieën en lacht hysterisch mee.");
                Console.WriteLine("Je zult dit landhuis nooit meer verlaten. Je bent nu één met de schaduwen.");
            }
            else if (Insanity >= 1 && Insanity < 4)
            {
                // EIND 2: Getraumatiseerd ontsnapt, De speler heeft een klein beetje insanity
                Console.WriteLine("EIND 2: DE GEBROKEN ONTSNAPPING");
                Console.WriteLine();
                Console.WriteLine("De gedaante heft zijn hand, maar met je laatste krachten ren je erlangs.");
                Console.WriteLine("Je beukt de zware voordeuren open en stort naar buiten, de frisse nachtlucht in.");
                Console.WriteLine("Je bent vrij! Je hebt het overleefd.");
                Console.WriteLine("Maar de herinneringen... Het gefluister in de gangen en de smeltende portretten...");
                Console.WriteLine("Die zullen je de rest van je leven in je dromen blijven achtervolgen. Je bent vrij, maar nooit meer de oude.");
            }
            else
            {
                // EIND 3: De perfecte ontsnapping, 0 Insanity de speler is volledig helder gebleven

                Console.WriteLine("EIND 3: DE PURS ONTSNAPPING");
                Console.WriteLine();    
                Console.WriteLine("De gedaante kijkt je aan en krimpt langzaam in elkaar. Je heldere geest biedt geen grip voor zijn waanzin.");
                Console.WriteLine("'Jij bent sterk,' fluistert de stem, waarna de gedaante in het niets oplost.");
                Console.WriteLine("Rustig loop je naar de grote voordeuren, draait de sleutel om en stapt met opgeheven hoofd naar buiten.");
                Console.WriteLine("Het landhuis is verslagen. Je bent volledig ongeschonden en helder van geest ontsnapt!");
            }

            // De game is nu officieel afgelopen
            Solved = true;
        }
    }
}
