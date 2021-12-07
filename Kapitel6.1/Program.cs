using System;

namespace Kapitel6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6.1
            Console.WriteLine("Skriv tre tal du vill veta i kvadrat:");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());

            SkrivTalKvadrat(tal1);
            SkrivTalKvadrat(tal2);
            SkrivTalKvadrat(tal3);
        }
        
        static void SkrivTalKvadrat(int tal)
        {
            int kvadrat = tal * tal;
            Console.WriteLine($"{tal} i kvadrat är {kvadrat}");
        }
            */
            /* 6.2
            SkrivBaklänges("Hej");
            SkrivBaklänges("Hallå");
            SkrivBaklänges("Hello");

        }

        static void SkrivBaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
            Console.WriteLine();
        }
            */
            /* 6.3
            SkrivTalMellan(1, 20);
        }

        static void SkrivTalMellan(int nedreGräns, int övreGräns)
        {
            for (int i = nedreGräns; i <= övreGräns; i++)
            {
                SkrivTalKvadrat(i);
            }
        }

        static void SkrivTalKvadrat(int tal)
        {
            int kvadrat = tal * tal;
            Console.WriteLine($"{tal} i kvadrat är {kvadrat}");
        }
            */

            Console.WriteLine("Hur stor sidlängs vill du ha på trianglarna?");
            int sidLängd1 = int.Parse(Console.ReadLine());
            int sidLängd2 = int.Parse(Console.ReadLine());

        }

        static void Triangel(int längd)
        {
            for (int i = 0; i < längd; i++) ;
            {
                SkrivUpprepadText("*", längd);
            }
        }

        static void SkrivUpprepadText(string text, int antalUpprepningar)
        {
            for (int i = 0; i < antalUpprepningar; i++)
            {

            }
        }
    }
}
