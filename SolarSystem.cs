using System;
using System.Collections.Generic;

namespace build_your_own_universe
{
    class SolarSystem
    {
        private static string _solarSystemName;

        public SolarSystem(string name)
        {
            _solarSystemName = name;
        }

        public string GetName()
        {
            return _solarSystemName;
        }

        public Star MakeStar()
        {
            Random random = new Random();
            int rand = random.Next();
            string randomNumberString = rand.ToString();
            Star star = new Star(randomNumberString);
            return star;
        }

        public Planet[] MakePlanet(int amt)
        {
            var planets = new List<Planet>();
            for (int i = 0; i < amt; i++)
            {
                Random random = new Random();
                int rand = random.Next();
                string randomNumberString = rand.ToString();
                Planet planet = new Planet(randomNumberString);
                planets.Add(planet);
            }
            return planets.ToArray();
        }
    }
}
