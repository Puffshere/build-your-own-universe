using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace build_your_own_universe
{
    class Universe
    {
        private static string _nameOfUniverse;
        private static string _newgalaxy;
        
        public Universe(string nameOfUniverse, string newgalaxy)
        {
            _nameOfUniverse = nameOfUniverse;
            _newgalaxy = newgalaxy;
           
        }

            public string addsuniverse()
            {
            List<string> universelist = new List<string>();
            universelist.Add("shitty");
            universelist.Add("ass");
            universelist.Add("people");
            //universelist.Add(_newgalaxy);
            foreach (string i in universelist)
            {
                Console.WriteLine(i);
            }
            return "";
            }
            public string UniverselName()
            {
            string alert = $"{_nameOfUniverse} is kind of a weird name but you are the boss!";
            return alert;
            }
    }
}

