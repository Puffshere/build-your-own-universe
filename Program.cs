using System;

namespace build_your_own_universe
{
    class Program
    {
        static void Main(string[] args)
        {
            int galaxies = 0;
            int solarSystems = 0;
            int planets = 0;
            int organisms = 0;
            bool valid = false;

            Console.WriteLine("Hello Everyone!");
            Console.Write($"If you could create a Universe what would you name it?  ");

            string nameOfUniverse = Console.ReadLine();

            Universe universe = new Universe(nameOfUniverse);

            Console.WriteLine(universe.UniverseName());
            while (!valid)
            {
                Console.Write($"How many Galaxies would {nameOfUniverse} have?  ");
                //Galaxy galaxy = new Galaxy(mind);
                //Console.WriteLine(galaxy.SolarSystems());

                bool isGalaxies = int.TryParse(Console.ReadLine(), out galaxies);
                if (isGalaxies && galaxies >= 10)
                {
                    Console.WriteLine("That is a lot of Galaxies!");
                    valid = true;
                }
                if (isGalaxies && galaxies < 10)
                {
                    Console.WriteLine("That is a pretty small Universe!");
                    valid = true;
                }
                if (!isGalaxies)
                {
                    Console.WriteLine("Enter a valid number of Galaxies please.");
                    valid = false;
                }
            }

            while (valid)
            {
                Console.Write("How many Solar Systems do you imagine are in each Galaxy?  ");

                bool isSolarSystem = int.TryParse(Console.ReadLine(), out solarSystems);
                if (isSolarSystem && solarSystems >= 20)
                {
                    Console.WriteLine("Way to think large!");
                    valid = false;
                }
                if (isSolarSystem && solarSystems < 20)
                {
                    Console.WriteLine("You should try to broden your herizons.");
                    valid = false;
                }
                if (!isSolarSystem)
                {
                    Console.WriteLine("Please enter a valid amount of Solar Systems.");
                    valid = true;
                }
            }
            while (!valid)
            {
                Console.Write("How many Planets would be in each Solar System?  ");

                bool isPlanets = int.TryParse(Console.ReadLine(), out planets);
                if (isPlanets && planets >= 5)
                {
                    Console.WriteLine("With that many Planets if we kill one maybe we will have a back up.");
                    valid = true;
                }
                if (isPlanets && planets < 5)
                {
                    Console.WriteLine("If we ruin the Planet don't really have a lot of second chances.");
                    valid = true;
                }
                if (!isPlanets)
                {
                    Console.WriteLine("Pleae enter a valid amount of Planets.");
                    valid = false;
                }
            }
            while (valid)
            {
                Console.Write("How many organisms populate each Planet?  ");

                bool ifOrganism = int.TryParse(Console.ReadLine(), out organisms);
                if (ifOrganism && organisms >= 1000)
                {
                    Console.WriteLine("That is a lot or critters running around.");
                    valid = false;
                }
                if (ifOrganism && organisms < 1000)
                {
                    Console.WriteLine("There is not a lot of room for error if organisms start to die off.");
                    valid = false;
                }
                if (!ifOrganism)
                {
                    Console.WriteLine("Please enter a valid amount of Organisms.");
                    valid = true;
                }
            }
                while (!valid)
                {
                    Console.WriteLine($"Congratulations on the creation of your new Univere {nameOfUniverse}.");
                    valid = true;
                }
           // universe.GetPropertiesNameOfClass(string hello);
           // Console.WriteLine(universe.GetPropertiesNameOfClass());

                Console.WriteLine("Press any key to exit program.");
                Console.ReadKey();
            }
        }
    }

