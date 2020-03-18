using System;

namespace GumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen!");
            Console.WriteLine("Tryk på ENTER for at få et gratis tyggegummi!");
            Console.ReadLine();
            Console.Clear();

            Controller controller = new Controller();

            while (controller.GaveGum == false)
            {
                Printer printer = new Printer();
            }
        }
    }
}