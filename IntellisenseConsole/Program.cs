using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intellisense;

namespace IntellisenseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the amazing intellisense console!");
             
            var classNames = new String[] {
                "GraphView",
                "DetailedDataView",
                "DataGraphView",
                "DataController",
                "GraphViewController",
                "MouseClickHandler",
                "MathCalculationHandler",
                "DataScienceView"
            };
            var finder = new Finder(classNames);
            
            while (true)
            {
                Console.WriteLine("please enter class name");
                var input = Console.ReadLine();

                if (input == "exit")
                    return;

                var results = finder.Get(input);
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
