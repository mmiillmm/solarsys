using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solsys
{
    internal class Planet
    {
        public string planetName { get; set; }
        public int planetMoons { get; set; }
        public float planetVolume { get; set; }

        public Planet(string line)
        {
            var data = line.Split(";");
            planetName = data[0];
            planetMoons = int.Parse(data[1]);
            planetVolume = float.Parse(data[2].Replace(".", ","));
        }
    }
}
