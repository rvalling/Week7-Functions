using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta ome eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Vali number 1-3:");
            char Number = Convert.ToChar(Console.ReadLine());

            switch (Number)
            {
                case '1':
                    NumberOne(userName);
                    break;
                case '2':
                    NumberTwo(userName);
                    break;
                case '3':
                    NumberThree(userName);
                    break;
            }
        }
        public static void NumberOne(string Name)
        {
            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Name[i]);
            }
        }

        public static void NumberTwo(string Name)
        {
            Console.WriteLine($"{Name[0]}");
        }

        public static void NumberThree(string Name)
        {
            Console.WriteLine($"Eesnime pikkus on {Name.Length} tähte.");
        }
        
    }
}
