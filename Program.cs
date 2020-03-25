using System;

namespace build_your_own_universe
{
    class Program
    {
        static void Main(string[] args)
        {
            string newUniverse = "";
            int galaxies = 0;
            int solarSystems = 0;
            int planets = 0;
            int organisms = 0;
            bool valid = false;
            string props = "";
            bool adds = true;

            Console.WriteLine("Hello Everyone!");
            Console.Write($"If you could create a Universe what would you name it?  ");
            string nameOfUniverse = Console.ReadLine();
            Universe universe = new Universe(nameOfUniverse);
            Galaxy galaxy = new Galaxy(props);
            Console.WriteLine(universe.UniverselName());

            while (!valid || adds == true)
            {
                Console.WriteLine("Would you like to add another Universe?");
                Console.Write("Enter 0 for No or 1 for Yes:  ");

                int add = int.Parse(Console.ReadLine());

                if (add == 0)
                    valid = true;
                if (add == 1)
                {
                    Console.Write("What is the name of your newest Universe?  ");
                    newUniverse = Console.ReadLine();
                    Console.WriteLine("Congratulation " + newUniverse + " exists.");
                    valid = false;
                    adds = false;
                }
                if (!valid && adds)
                    Console.WriteLine("Please enter a valid selection.");
            }
            while (valid)
            {
                Console.Write($"How many Galaxies would {nameOfUniverse} have?  ");

                bool isGalaxies = int.TryParse(Console.ReadLine(), out galaxies);
                if (isGalaxies && galaxies >= 10)
                {
                    Console.WriteLine("That is a lot of Galaxies!");
                    Console.WriteLine("I heard those galaxies were " + (galaxy.SolarSystemsProperties()) + ".");
                    valid = false;
                }
                if (isGalaxies && galaxies < 10)
                {
                    Console.WriteLine("That is a pretty small Universe!");
                    Console.WriteLine("I heard those galaxies were " + (galaxy.SolarSystemsProperties()) + ".");
                    valid = false;
                }
                if (!isGalaxies)
                {
                    Console.WriteLine("Enter a valid number of Galaxies please.");
                    valid = true;
                }
            }

            while (!valid)
            {
                Console.Write("How many Solar Systems do you imagine are in each Galaxy?  ");

                bool isSolarSystem = int.TryParse(Console.ReadLine(), out solarSystems);
                if (isSolarSystem && solarSystems >= 20)
                {
                    Console.WriteLine("Way to think large!");
                    valid = true;
                }
                if (isSolarSystem && solarSystems < 20)
                {
                    Console.WriteLine("You should try to broden your herizons.");
                    valid = true;
                }
                if (!isSolarSystem)
                {
                    Console.WriteLine("Please enter a valid amount of Solar Systems.");
                    valid = false;
                }
            }
            while (valid)
            {
                Console.Write("How many Planets would be in each Solar System?  ");

                bool isPlanets = int.TryParse(Console.ReadLine(), out planets);
                if (isPlanets && planets >= 5)
                {
                    Console.WriteLine("With that many Planets if we kill one maybe we will have a back up.");
                    valid = false;
                }
                if (isPlanets && planets < 5)
                {
                    Console.WriteLine("If we ruin the Planet don't really have a lot of second chances.");
                    valid = false;
                }
                if (!isPlanets)
                {
                    Console.WriteLine("Pleae enter a valid amount of Planets.");
                    valid = true;
                }
            }
            while (!valid)
            {
                Console.Write("How many organisms populate each Planet?  ");
                bool ifOrganism = int.TryParse(Console.ReadLine(), out organisms);
                if (ifOrganism && organisms >= 1000)
                {
                    Console.WriteLine("That is a lot or critters running around.");
                    valid = true;
                }
                if (ifOrganism && organisms < 1000)
                {
                    Console.WriteLine("There is not a lot of room for error if organisms start to die off.");
                    valid = true;
                }
                if (!ifOrganism)
                {
                    Console.WriteLine("Please enter a valid amount of Organisms.");
                    valid = false;
                }
            }
            while (valid)
            {
                Console.WriteLine($"Congratulations on the creation of your new Univere {nameOfUniverse}.");
                valid = false;
            }
            int numberOfGalaxies = galaxies;
            Galaxy[] galaxies1 = universe.AddsGalaxies(numberOfGalaxies);




            Console.WriteLine("Press any key to exit program.");

            Console.ReadKey();

        }

    }

}

