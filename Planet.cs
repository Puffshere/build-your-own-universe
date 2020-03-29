using System;
using System.Collections.Generic;

namespace build_your_own_universe
{
    class Planet
    {
        private static string _planetName;

        public Planet(string planetName)
        {
            _planetName = planetName;
        }

        public string GetName()
        {
            return _planetName;
        }
    }
}