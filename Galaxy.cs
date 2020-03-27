using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace build_your_own_universe
{
    class Galaxy
    {
        private static string _props;
        private static string _y;
        public Galaxy(string props, string y)
        {
            _props = props;
            _y = y;
        }
        public string SolarSystemsProperties()
        {
            string properties = $"Cold, Wet, and Lonely";
        return properties;
        }

        public string AddsGalaxy(string y)
        {
            string X = _y + " " + y + " and I hope you have a wonderful day!";
            return X;
        }

    }
}
