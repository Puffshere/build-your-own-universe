﻿using System;

namespace build_your_own_universe
{
    class Program
    {
        static void Main(string[] args)
        {
            string newGalaxy = "";
            string props = "";

            int galaxies = 0;
            int solarSystems = 0;
            int planets = 0;
            int add = 0;
            int organisms = 0;

            bool valid = true;
            bool adds = true;

            Console.WriteLine("Hello Everyone!");
            Console.Write($"If you could create a Universe what would you name it?  ");
            string nameOfUniverse = Console.ReadLine();
            Universe universe = new Universe(nameOfUniverse);
            Galaxy galaxy = new Galaxy(props);
            Console.WriteLine(universe.UniverselName());

            
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
            while (!valid || adds == true)
            {
                Console.WriteLine("Would you like to add another Galaxy?");
                Console.Write("Enter 0 for No or 1 for Yes:  ");
                string input = Console.ReadLine();
                bool isParsed = int.TryParse(input, out add);
                if (isParsed)
                {
                    if (add == 0)
                        valid = true;
                        adds = false;
                    if (add == 1)
                    {
                        Console.Write("What is the name of your newest Galaxy?  ");
                        newGalaxy = Console.ReadLine();
                        Console.WriteLine("Congratulation " + newGalaxy + " exists.");
                        valid = false;
                        adds = false;
                    }
                    if (!valid && adds)
                        Console.WriteLine("Please enter a valid selection.");
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection.");
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
                    Console.WriteLine("Think bigger my guy.");
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
                    Console.WriteLine("With that many Planets if we kill one there should always be a back up.");
                    valid = true;
                }
                if (isPlanets && planets < 5)
                {
                    Console.WriteLine("Probably not to many of them are in the Goldylocks Zone.  Better take care of them.");
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
            int numberOfGalaxies = galaxies;
            Galaxy[] galaxies1 = universe.AddsGalaxies(numberOfGalaxies);


            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }
    }
}

