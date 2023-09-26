using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokerXD
{
    internal class cards
    {
        public string name { get; set; }
        public string color { get; set; }
        public cards(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public override string ToString()
        {
            return $"{ name } { color }";
        }
    }
}
