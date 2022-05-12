using System;
using System.Collections.Generic;

namespace KöProjekt
{
    class Program
    {
        static void Main(string[] args)
        {



            Queue<string> Kö = new Queue<string>();

            string answer = "";


            Kö.Enqueue("jens");
            Kö.Enqueue("edvin");
            Kö.Enqueue("amir");
            Kö.Enqueue("gunnar");
            Kö.Enqueue("lukas");


            Console.WriteLine("Du ska hantera en affär. I Affären står det kunder i en kö. Skriv deras namn för att hantera deras order.");

            while (Kö.Count > 0)
            {

                Console.WriteLine("Detta är din nästa kund:");

                Console.WriteLine(Kö.Peek());

                Console.WriteLine("Skriv nu kundens namn");

                answer = Console.ReadLine().ToLower();

                if (answer == Kö.Peek())
                {
                    string i = Kö.Dequeue();
                }
                else
                {
                    Console.WriteLine("Det är inte rätt kund. Försök igen.");
                }


            }

        }
    }
}
