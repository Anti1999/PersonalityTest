using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai 'A' , konsool kuvab "Suurepärane!",
            //'B', konsool kuvab "Väga hea!";
            //'C', konsool kuvab "Hea!";
            //'D', konsool kuvab ""Rahuldav";
            //'E', konsool kuvab "kasin";
            //'F', konsool kuvab " Puudulik".
            // kui kasutaja sisestab midagi muud, siis konsool kuvab "vale väärtus"
            // kasutame IF

            Console.WriteLine("Sisesta oma tulemus:");
            // char- Character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            
            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            
            if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            
            if (userResult == 'C')
            {
                Console.WriteLine("Hea!");

            }
            
            if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            
            if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }

            if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }

            else
            {
                Console.WriteLine("vale väärtus");
            }



             Console.WriteLine("Kena päeva!");
        }
    }
}
