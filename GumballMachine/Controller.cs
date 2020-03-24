using System;
using System.Collections.Generic;
using System.Text;

//HVis du havde sat kodekommentar ind her, så kunne jeg se hvad klassen skulle gøre godt for.
//Så vidt jeg kan se, er dette din tyggegummimaskine og den burde navngives sådan....
namespace GumballMachine
{
    public class Controller
    {
        private bool gaveGum = false;
        
        //Betyder det at du giver tyggegumiet her? I så fald er det forkert! Det skulle være en metode i stedet
        public bool GaveGum
        {
            get { return gaveGum; }
            set { gaveGum = value; }
        }
        private static Controller instance;

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public Gumball[] red = new Gumball[7];
        public Gumball[] green = new Gumball[6];
        public Gumball[] blue = new Gumball[14];
        public Gumball[] purple = new Gumball[7];
        public Gumball[] yellow = new Gumball[11];
        public Gumball[] orange = new Gumball[10];
        
        public Controller()
        {
            for (int i = 0; i < red.Length; i++)
            {
                red[i] = new Gumball("Rød", "Jordbær");
            }
            for (int i = 0; i < green.Length; i++)
            {
                green[i] = new Gumball("Grøn", "Æble");
            }
            for (int i = 0; i < blue.Length; i++)
            {
                blue[i] = new Gumball("Blå", "Blåbær");
            }
            for (int i = 0; i < purple.Length; i++)
            {
                purple[i] = new Gumball("Lilla", "Brombær");
            }
            for (int i = 0; i < yellow.Length; i++)
            {
                yellow[i] = new Gumball("Gul", "Tutti Frutti");
            }
            for (int i = 0; i < orange.Length; i++)
            {
                orange[i] = new Gumball("Orange", "Appelsin");
            }
        }
    }
}
