using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace build_your_own_universe
{
    class Universe
    {
        private static string _nameOfUniverse;
        
        
        public Universe(string nameOfUniverse)
        {
            _nameOfUniverse = nameOfUniverse;
           
        }
        
   
            public string UniverselName()
            {
            string alert = $"{_nameOfUniverse} is kind of a weird name but you are the boss!";
            return alert;
            }
    }
}

