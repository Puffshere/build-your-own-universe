using System;
using System.Collections.Generic;

namespace build_your_own_universe
{
    class Planet
    {
        private static string _planetName;
        private static string _lifeForm;
        private static string _additionalForms;

        public Planet(string planetName, string lifeForm, string additionalForms)
        {
            _planetName = planetName;
            _lifeForm = lifeForm;
            _additionalForms = additionalForms;
        }
        public string AddsLifeFormsNames()
        {
            //string[] array = new string[] { _lifeForm };
            //List<string> addsLife = new List<string>(new string[] { _lifeForm });
            //addsLife.Add("Snakes and Bears");
            //Console.WriteLine(addsLife);
            //return " ";


            List<string> list = new List<string>(new string[] { _lifeForm, _additionalForms });
            // Part A: loop with for and access count.
            //list.Add(_additionalForms);
            for (int i = 0; i < list.Count; i++)
            {
                // Part B: access element with index.
                Console.Write($"{i} = {list[i]}  ");
            }

            return "";

        }

        public string GetName()
        {
            return _planetName;
        }
    }
}