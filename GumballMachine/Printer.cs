using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine
{
    public class Printer : Controller
    {
        Random random = new Random();

        public Printer()
        {
            int ran = random.Next(1, 7);
            Console.WriteLine();
            Controller controller = new Controller();
            switch (ran)
            {
                case 1:
                    Console.WriteLine("*Rødt tyggegummi kommer ud af maskinen*");
                    if (red != null || red.Length != 0)
                    {
                        controller.red = null;
                        Array.Resize(ref red, red.Length - 1);
                        Console.ReadLine();
                        Console.Clear();
                        GaveGum = true;
                    }
                    break;
                case 2:
                    Console.WriteLine("*Grønt tyggegummi kommer ud af maskinen*");
                    if (green != null || green.Length != 0)
                    {
                        controller.green = null;
                        Array.Resize(ref green, green.Length - 1);
                        Console.ReadLine();
                        Console.Clear();
                        GaveGum = true;
                    }
                    break;
                case 3:
                    Console.WriteLine("*Blåt tyggegummi kommer ud af maskinen*");
                    if (blue != null || blue.Length != 0)
                    {
                        controller.blue = null;
                        Array.Resize(ref blue, blue.Length - 1);
                        Console.ReadLine();
                        Console.Clear();
                        GaveGum = true;
                    }
                    break;
                case 4:
                    Console.WriteLine("*Lilla tyggegummi kommer ud af maskinen*");
                    if (purple != null || purple.Length != 0)
                    {
                        controller.purple = null;
                        Array.Resize(ref purple, purple.Length - 1);
                        Console.ReadLine();
                        Console.Clear();
                        GaveGum = true;
                    }
                    break;
                case 5:
                    Console.WriteLine("*Gult tyggegummi kommer ud af maskinen*");
                    if (yellow != null || yellow.Length != 0)
                    {
                        controller.yellow = null;
                        Array.Resize(ref yellow, yellow.Length - 1);
                        Console.ReadLine();
                        Console.Clear();
                        GaveGum = true;
                    }
                    break;
                case 6:
                    Console.WriteLine("*Orange tyggegummi kommer ud af maskinen*");
                    if (orange != null || orange.Length != 0)
                    {
                        controller.orange = null;
                        Array.Resize(ref orange, orange.Length - 1);
                        Console.ReadLine();
                        Console.Clear();
                        GaveGum = true;
                    }
                    break;
                default:
                    Console.WriteLine("Maskinen er tom ..");
                    GaveGum = false;
                    break;
            }
        }
    }
}
