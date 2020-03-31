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
            string p = _planetNames + " " + _newPlanetName;
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
    }
}
