using System;
using System.Collections.Generic;

namespace build_your_own_universe
{
    class SolarSystem
    {
        private static string _solarSystemName;
        private static string _planetNames;
        private static string _newPlanetName;

        public SolarSystem(string name, string randomNumberString, string planetNames, string newPlanetName)
        {
            _solarSystemName = name;
            _planetNames = planetNames;
            _newPlanetName = newPlanetName;
        }

        public string GetName()
        {
            return _solarSystemName;
        }

        public string AddsPlanetNames()
        {
            List<string> list = new List<string>(new string[] { _planetNames, _newPlanetName });
            //for (int i = 0; i < list.Count; i++)
            //{
            //    //Console.Write($"{i} = {list[i]}  ");
            //}
            string p = _planetNames + " " + _newPlanetName;
            // Console.WriteLine(p);
            return p;
        }

        public Star MakeStar()
        {
            Random random = new Random();
            int rand = random.Next();
            string randomNumberString = rand.ToString();
            Star star = new Star(randomNumberString);
            return star;
        }

        //public Planet[] MakePlanet(int amt)
        //{
        //    var planets = new List<Planet>();
        //    for (int i = 0; i < amt; i++)
        //    {
        //        Random random = new Random();
        //        int rand = random.Next();
        //        string randomNumberString = rand.ToString();
        //        Planet planet = new Planet(randomNumberString);
        //        planets.Add(planet);
        //    }
        //    return planets.ToArray();
        //}
    }
}
