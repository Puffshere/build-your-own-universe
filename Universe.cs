using System;
using System.Collections.Generic;
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
        public Galaxy[] AddsGalaxies(int amt)
        {
            var galaxies1 = new List<Galaxy>();
            for (int i = 0; i < amt; i++)
            {

                Random random = new Random();
                int rand = random.Next();
                string randomNumberString = rand.ToString();
                galaxies1.Add(new Galaxy(randomNumberString));
            }
            return galaxies1.ToArray();
        }



    }
}

