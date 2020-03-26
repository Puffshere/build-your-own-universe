﻿using System;
using System.Linq;
using System.Text;

namespace build_your_own_universe
{
    class Program
    {
        class x
        {
            public static void AddsGalaxy(params string[] universe)
            {
               
                foreach (string galaxy in universe)
                {
                    
                    
                    Console.WriteLine("Congratulations the Galaxy " + galaxy + " now exists!"); ;
                }
            }
            static void Main(string[] args)
            {

                

                string y = "";
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


                //while (valid)
                //{
                //    Console.Write($"How many Galaxies would {nameOfUniverse} have?  ");
                //    bool isGalaxies = int.TryParse(Console.ReadLine(), out galaxies);
                //    if (isGalaxies && galaxies >= 10)
                //    {
                //        Console.WriteLine("That is a lot of Galaxies!");
                //        Console.WriteLine("I heard those galaxies were " + (galaxy.SolarSystemsProperties()) + ".");
                //        valid = false;
                //    }
                //    if (isGalaxies && galaxies < 10)
                //    {
                //        Console.WriteLine("That is a pretty small Universe!");
                //        Console.WriteLine("I heard those galaxies were " + (galaxy.SolarSystemsProperties()) + ".");
                //        valid = false;
                //    }
                //    if (!isGalaxies)
                //    {
                //        Console.WriteLine("Enter a valid number of Galaxies please.");
                //        valid = true;
                //    }
                //}
                bool firstTime = false;
                while (!valid || adds == true)
                {
                    if (!firstTime)
                    {
                        Console.WriteLine("Would you like to add a Galaxy into your newly formed Universe " + (nameOfUniverse) +
                        "?");
                        firstTime = true;
                    }
                    else
                    {
                        Console.WriteLine("Would you like to add another Galaxy into your newly formed Universe " + (nameOfUniverse) +
                            "?");
                    }
                    Console.Write("Enter 0 for NO or 1 for YES:  ");
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
                            y = Console.ReadLine();
                            StringBuilder builder = new StringBuilder("Galaxy ");
                            builder.Append(y);
                            builder.Append(".  I like it.");
                            Console.WriteLine(builder);


                            //AddsGalaxy("Voltron", "Nebula");
                            //AddsGalaxy(y);
                            //string[] addsss = { "A", "B" };
                            //string arrayStr = string.Concat(addsss);
                            //Console.WriteLine(arrayStr);
                            //add method to add new galaxy to array

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
                    Console.WriteLine("Here are a list of your Galaxies.");
                
                    
                //choose a galaxy to add solarsystems to


                //string[] newGalaxy1 = { "" };
                
                

                while (!valid || adds == true)
                {
                    if (!firstTime)
                    {
                        Console.Write("Choose a Galaxy you would like to add Solar Systems to:  ");
                        //list array of Galaxies
                        firstTime = true;
                    }
                    else
                    {
                        Console.WriteLine("Would you like to add another Galaxy into your newly formed Universe " + (nameOfUniverse) +
                            "?");
                    }
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
                            y = Console.ReadLine();
                            //add method to add new galaxy to array
                            Console.WriteLine("Congratulation " + y + " exists.");
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
                //Galaxy[] galaxies1 = universe.AddsGalaxies(numberOfGalaxies);


                Console.WriteLine("Press any key to exit program.");
                Console.ReadKey();
            }
        }
    }
}

