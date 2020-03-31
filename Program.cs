using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace build_your_own_universe
{
    class Program
    {

        static void Main(string[] args)
        {
            string galaxyOne = "";
            string galaxyTwo = galaxyOne;
            string X = new string(galaxyOne);
            string props = "";
            string k = "";
            string lifeForms = "";
            string addsLife = " ";
            string planetName = " ";
            string additionalForms = " ";
            string j = " ";
            string planetsName = " ";
            string name = " ";
            string randomNumberString = " ";
            string newestPlanet = " ";
            string newPlanetName = " ";
            string newPlanetArray = " ";
            string M = "";

            int numberOfYSolarSystems = 0;
            int numberOfPSolarSystems = 0;
            int galaxies = 0;
            int solarSystems = 0;
            int planets = 0;
            int add = 0;
            int organisms = 0;
            int r = 0;

            bool valid = true;
            bool adds = true;
            bool sock = false;
            bool addLifeForms = false;
            bool ifOrganism = false;
            bool again = true;
            bool next = true;
            bool loop = false;
            bool before = false;
            bool firstTime = false;

            Console.WriteLine();
            Console.WriteLine("Hello Everyone!");
            Console.WriteLine();
            Console.Write($"If you could create a Universe what would you name it?  ");
            string nameOfUniverse = Console.ReadLine();
            string newgalaxy = galaxyOne;
            Universe universe = new Universe(nameOfUniverse, newgalaxy, galaxyOne, galaxyTwo);
            Console.WriteLine();
            Console.WriteLine(universe.UniverselName());
            Console.WriteLine();
            Galaxy galaxy = new Galaxy(props, galaxyOne);
            while (valid)
            {
                Console.Write($"How many Galaxies would {nameOfUniverse} have?  ");
                bool isGalaxies = int.TryParse(Console.ReadLine(), out galaxies);
                Console.WriteLine();
                if (isGalaxies && galaxies >= 10)
                {
                    Console.WriteLine("That is a lot of Galaxies!");
                    Console.WriteLine("I heard those galaxies were " + (galaxy.SolarSystemsProperties()) + ".");
                    Console.WriteLine();
                    valid = false;
                }
                if (isGalaxies && galaxies < 10)
                {
                    Console.WriteLine("That is a pretty small Universe!  Lets add 1 or 2 more and we will give them names.");
                    Console.WriteLine("I heard those galaxies were " + (galaxy.SolarSystemsProperties()) + ".");
                    Console.WriteLine();
                    valid = false;
                }
                if (!isGalaxies)
                {
                    Console.WriteLine("Enter a valid number of Galaxies please.");
                    Console.WriteLine();
                    valid = true;
                }
            }
            while (!valid || adds == true && loop)
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
                    M = "A shit ton";
                    if (add == 1)
                    {
                        Console.WriteLine();
                        if (!before)
                        {
                            before = true;
                            Console.Write("What is the name of your newest Galaxy?  ");
                            galaxyOne = Console.ReadLine();
                        }
                        else
                        {
                            loop = true;
                            Console.Write("What is the name of your newest Galaxy?  ");
                            galaxyTwo = Console.ReadLine();
                            k = " and " + galaxyTwo;
                        }
                        Universe addsGalaxy = new Universe(nameOfUniverse, newgalaxy, galaxyOne, k);
                        string m = addsGalaxy.AddsGalaxy();
                        List<string> addsSomething = new List<string>();
                        StringBuilder builder = new StringBuilder("Galaxy ");
                        builder.Append(galaxyOne);
                        builder.Append(k);
                        builder.Append(".  I like it.");
                        Console.WriteLine();
                        Console.WriteLine(builder);
                        valid = false;
                        adds = false;
                        Galaxy start = new Galaxy(props, galaxyOne);
                        Console.Write("And then there was ");
                        Console.WriteLine(m + ".");
                        r++;
                        M = m;
                        if (r == 2)
                        {
                            valid = true;
                        }
                    }
                    if (!valid && adds)
                        Console.WriteLine("Please enter a valid selection.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Here are the current Galaxies in the " + nameOfUniverse + " Universe.");
            Console.WriteLine();
            Console.WriteLine(M + " and a whole hell of a lot more yet to be named.");
            Console.WriteLine();
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
                        galaxyOne = Console.ReadLine();
                        Console.WriteLine("Congratulation " + galaxyOne + " exists.");
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
                Console.Write("Which Galaxy would you like to add Solar Systems to:  ");
                List<string> list = new List<string>(new string[] { galaxyOne, galaxyTwo });
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{i} = {list[i]}  ");
                }
                bool isSolarSystem = int.TryParse(Console.ReadLine(), out solarSystems);
                if (isSolarSystem && solarSystems == 0)
                {
                    Console.Write("How many Solar Systems would you like the " + galaxyOne + " Galaxy to have?  ");
                    bool isAnswer = int.TryParse(Console.ReadLine(), out numberOfYSolarSystems);
                    Console.WriteLine("The " + galaxyOne + " Galaxy now has " + numberOfYSolarSystems + " Solar Systems!");
                    Console.WriteLine();
                    valid = false;
                    sock = true;
                }
                if (isSolarSystem && solarSystems == 1)
                {
                    Console.WriteLine();
                    Console.Write("How many Solar Systems would you like the " + galaxyTwo + " Galaxy to have?  ");
                    bool isAnswer = int.TryParse(Console.ReadLine(), out numberOfPSolarSystems);
                    Console.WriteLine("The " + galaxyTwo + " Galaxy now has " + numberOfPSolarSystems + " Solar Systems!");
                    Console.WriteLine();
                    valid = false;
                    sock = false;
                }
                if (!isSolarSystem)
                {
                    Console.WriteLine("Please enter a valid galaxy.");
                    Console.WriteLine();
                    valid = true;
                }
            }
            bool yes = false;
            Console.Write("How many Planets would be in each Solar System?  ");
            bool isPlanets = int.TryParse(Console.ReadLine(), out planets);
            if (isPlanets && planets >= 5)
            {
                Console.WriteLine();
                Console.WriteLine("With that many Planets if we kill one there should always be a back up.");
                while (!valid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add another Planet to the Galaxy?");
                    Console.Write("Enter 0 for No or 1 for Yes:  ");
                    string input = Console.ReadLine();
                    Console.WriteLine();
                    bool isParsed = int.TryParse(input, out add);
                    if (isParsed)
                    {
                        if (add == 0)
                            valid = true;
                        adds = false;
                        if (add == 1)
                        {
                            Console.Write("What is the name of the Planet you would like to add to the Galaxy?  ");
                            newestPlanet = Console.ReadLine();
                            //add method to add new galaxy to array
                            Console.WriteLine();
                            Console.WriteLine("Congratulations " + newestPlanet + " exists.");
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
                    SolarSystem addPlanets = new SolarSystem(name, randomNumberString, newestPlanet, newPlanetName);
                    if (add == 1)
                    {
                        planetName = addPlanets.AddsPlanetNames();
                        Console.WriteLine(planetName);
                    }

                    //What kind of stars should the ___ Solar System have?       " In Star "
                    //MakeStar();
                    //MakePlanet();

                }
            }
            bool planetAdd = true;
            if (isPlanets && planets < 5)
            {
                while (planetAdd)
                {
                    Console.WriteLine("Probably not to many of them are in the Goldylocks Zone.  Better take care of them.");
                    Console.WriteLine();
                    Console.Write("What is the name of a Planet that you would like to add?  ");
                    newPlanetArray = Console.ReadLine();
                    SolarSystem addPlanets = new SolarSystem(name, randomNumberString, planetName, newPlanetName);
                    string addMore = " ";
                    int wally = 0;
                    while (next)
                    {
                        Console.WriteLine();
                        Console.Write("Enter 1 to add another Planet or Enter 2 to continue on with program.  ");
                        addMore = Console.ReadLine();
                        bool isMixed = int.TryParse(addMore, out wally);
                        if (isMixed && wally == 1)
                        {
                            Console.WriteLine();
                            Console.Write("What is the name of a Planet that you would like to add?  ");
                            newPlanetName = Console.ReadLine();
                            planetName = newPlanetArray;
                            SolarSystem addPlanetsTwo = new SolarSystem(name, randomNumberString, planetName, newPlanetName);
                            newPlanetArray = addPlanetsTwo.AddsPlanetNames();
                            next = true;
                        }
                        if (isMixed && wally == 2)
                        {
                            planetAdd = false;
                            next = false;
                        }
                    }
                }
                valid = true;
            }
            if (!isPlanets)
            {
                Console.WriteLine("Pleae enter a valid amount of Planets.");
                Console.WriteLine();
                valid = false;
            }
            Console.WriteLine();
            Console.WriteLine("Here is a list of your newly created Planets:  ");
            Console.WriteLine();
            Console.WriteLine(newPlanetArray);
            while (valid)
            {
                Console.WriteLine();
                Console.Write("How many organisms populate each Planet?  ");
                ifOrganism = int.TryParse(Console.ReadLine(), out organisms);
                if (ifOrganism && organisms >= 1000)
                {
                    Console.WriteLine("That is a lot or critters running around.");
                    Console.WriteLine();
                    Console.Write("What kind of Life Forms are there in this Galaxy?  ");
                    lifeForms = Console.ReadLine();
                    Console.WriteLine();
                    if (sock)
                    {
                        while (again)
                        {
                            Console.WriteLine("Would you like to add any more Life Forms to the Planets in the " + galaxyOne + " Galaxy?");
                            Console.WriteLine("So far the " + galaxyOne + " Galaxy is just made up of " + lifeForms + ".");
                            Console.WriteLine("[1] - Yes");
                            Console.Write("[2] - No    ");
                            string c = Console.ReadLine();
                            bool isParsed = int.TryParse(c, out add);
                            Console.WriteLine();
                            while (!addLifeForms)
                                if (add == 1)
                                {
                                    Console.Write("What kind of Life Forms would you like to add to the " + galaxyOne + " Galaxy in addition to the " + lifeForms + ".  ");
                                    additionalForms = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine("Now the " + galaxyOne + " Galaxy is made up of:  ");
                                    Planet addsLives = new Planet(planetName, lifeForms, additionalForms);
                                    j = addsLives.AddsLifeFormsNames();
                                    Console.WriteLine();
                                    valid = false;
                                    addLifeForms = true;
                                    again = true;
                                }
                            if (add == 2)
                            {
                                addLifeForms = true;
                                again = false;
                            }
                        }
                    }
                }
                if (!sock && organisms >= 1000)
                {
                    while (again)
                    {
                        Console.WriteLine("Would you like to add any more Life Forms to the Planets in the " + galaxyTwo + " Galaxy?");
                        Console.WriteLine("So far the " + galaxyTwo + " Galaxy is just made up of " + lifeForms + ".");
                        Console.WriteLine("[1] - Yes");
                        Console.Write("[2] - No    ");
                        string c = Console.ReadLine();
                        bool isParsed = int.TryParse(c, out add);
                        Console.WriteLine();
                        while (!addLifeForms)
                            if (add == 1)
                            {
                                Console.Write("What kind of Life Forms would you like to add to the " + galaxyTwo + " Galaxy in addition to the " + lifeForms + ".  ");
                                additionalForms = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Now the " + galaxyTwo + " Galaxy is made up of:  ");
                                Planet addsLives = new Planet(planetName, lifeForms, additionalForms);
                                j = addsLives.AddsLifeFormsNames();
                                Console.WriteLine();
                                valid = false;
                                addLifeForms = true;
                                again = true;
                            }
                        if (add == 2)
                        {
                            addLifeForms = true;
                            again = false;
                        }
                    }
                }
                valid = false;
                if (ifOrganism && organisms < 1000)
                {
                    Console.WriteLine("There is not a lot of room for error if organisms start to die off.");
                    Console.WriteLine();
                    Console.Write("What kind of Life Forms are they?  ");
                    lifeForms = Console.ReadLine();
                }
                if (!ifOrganism)
                {
                    Console.WriteLine("Please enter a valid amount of Organisms.");
                    valid = true;
                }
            }
            Console.WriteLine("");
            while (!valid)
            {
                Console.WriteLine($"Congratulations on the creation of your new Univere {nameOfUniverse}.");
                valid = true;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit program.");
            Console.ReadKey();
        }
    }
}
