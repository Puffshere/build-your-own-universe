﻿using System;
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


        public string GetName()
        {
            return _y;
        }

        public string AddsGalaxy()
        {
            string y = _y;
            List<string> abc = new List<string>();
            abc.Add("hello");
            abc.Add("yes");
            abc.Add(_y);

            foreach (string i in abc)
            {
                Console.WriteLine(i);
            }
            String combindedString = string.Join(",", abc);
            return combindedString;


            //SolarSystem[] MakeChildren(int amt)
            //{
            //    var solarSystems = new List<SolarSystem>();
            //    for (int i = 0; i < amt; i++)
            //    {
            //        Random random = new Random();
            //        int rand = random.Next();
            //        string randomNumberString = rand.ToString();

            //        solarSystems.Add(new SolarSystem(randomNumberString));
            //    }

            //    return solarSystems.ToArray();
            //}
        }
    }
}
