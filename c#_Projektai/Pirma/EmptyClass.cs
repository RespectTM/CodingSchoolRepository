using System;
using System.Threading.Tasks;

namespace Pirma
{
    public class EmptyClass
    {
        public void Main()
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            int pirmas = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int antras = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            int trecias = int.Parse(Console.ReadLine());

            Console.WriteLine("Pasirinkti keisa");
            int skaitau = int.Parse(Console.ReadLine());

            switch (skaitau)
            {
                case 1:

                    if (pirmas == 1)
                    {
                        Console.WriteLine(pirmas + antras + trecias);
                    }
                    else
                    {
                        Console.WriteLine("Skaicius ne 1");
                    }
                    break;
                case 2:
                    if (pirmas == 2)
                    {
                        Console.WriteLine(pirmas - trecias);
                    }

                    else
                    {
                        Console.WriteLine("Skaicius ne 2");
                    }
                    break;
                case 3:pirmaUzduoteleKlaseje();
                    break;
                case 0:
                    break;
                default:
                    break;
            }


        }
        static void pirmaUzduoteleKlaseje()
        {
            Console.WriteLine("Pasirinkite savo gerima:");
            Console.WriteLine("1. Limonadas");
            Console.WriteLine("2. Arbata");
            Console.WriteLine("3. Kakava");
            Console.WriteLine("4. Kava");
            Console.WriteLine("5. Nieko");
            Console.WriteLine("0. Iseiti");

            int pasirinkimas = int.Parse(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Pilamas limonadas");
                    Task.Delay(5000);
                    pirmaUzduoteleKlaseje();
                        break;
                case 2:
                    Console.WriteLine("Pilama arbata");
                    Task.Delay(5000);
                    pirmaUzduoteleKlaseje();
                    break;

                case 3:
                    Console.WriteLine("Pilama kakava");
                    Task.Delay(5000);
                    pirmaUzduoteleKlaseje();
                    break;

                case 4:
                    Console.WriteLine("Pilama kava");
                    Task.Delay(5000);
                    pirmaUzduoteleKlaseje();
                    break;

                case 5:
                    Console.WriteLine("Rinkites per naujo");
                    Task.Delay(5000);
                    pirmaUzduoteleKlaseje();
                    break;
                case 0:
                    Console.WriteLine("Iseinama");
                    Task.Delay(5000);
                    pirmaUzduoteleKlaseje();
                    break;

                default:
                    break;
            }
        }
    }
}
