using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingRocks
{
    public class Rock
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        private char[] Representation =
             new char[] { '^', '@', '*', '&', '+', '$', '#', '!', '.', ';' };

        private Random RockRandom = new Random();
        public Rock(int x)
        {
            this.X = x;
            this.Y = 0;

            this.Symbol = Representation[Representation.length)];  //here 
        }
    }
}
