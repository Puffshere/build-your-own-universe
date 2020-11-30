using System;


namespace build_your_own_universe
{
    class Universe
    {
        private static string _nameOfUniverse;
        private static string _newgalaxy;
        private static string _galaxyOne;
        private static string _k;

        public Universe(string nameOfUniverse, string newgalaxy, string galaxyOne, string k)
        {
            _nameOfUniverse = nameOfUniverse;
            _newgalaxy = newgalaxy;
            _galaxyOne = galaxyOne;
            _k = k;
            Y = _galaxyOne;
            P = k;
        }

        public string Y { get; set; }

        public string P { get; set; }

        public string AddsGalaxy()
        {
            String combindedString = Y + P;
            return combindedString;
        }

        public string UniverselName()
        {
            string alert = $"{_nameOfUniverse} is kind of a weird name but you are the boss!";
            return alert;
        }
    }
}

