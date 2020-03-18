using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine
{
    public class Gumball
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string taste;
        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }
        public Gumball(string gumColor, string gumTaste)
        {
            this.color = gumColor;
            this.taste = gumTaste;
        }

        
    }
}
