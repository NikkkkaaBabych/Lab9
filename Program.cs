using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_1
{
    abstract class plane
    {
        public abstract void input();
    }
    class fighter : plane
    {
        string destination;
        public override void input()
        {
            Console.WriteLine("destination of fighter");
            destination = Console.ReadLine();
            Console.WriteLine("saved!");
        }
    }
    class passenger_liner : plane
    {
        int passengers;
        public override void input()
        {
            Console.WriteLine("passengers number of passenger_liner");
            passengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saved!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fighter F = new fighter();
            F.input();
            passenger_liner P = new passenger_liner();
            P.input();
            Console.ReadLine();
        }
    }
}
