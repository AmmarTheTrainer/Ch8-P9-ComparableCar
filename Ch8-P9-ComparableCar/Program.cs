using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P9_ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****\n");
            
            // Make an array of Car objects.
            Car[] myAutos = new Car[5];

            myAutos[0] = new Car("Rusty", 80, 1  );
            myAutos[1] = new Car("Mary",  40, 234);
            myAutos[2] = new Car("Viper", 40, 34 );
            myAutos[3] = new Car("Mel",   40, 4  );
            myAutos[4] = new Car("Chucky",40, 5  );

            //Array.Sort(myAutos);

            //foreach (var item in myAutos)
            //{
            //    Console.WriteLine(item);
            //}


            // Display current array.
            Console.WriteLine("Here is the unordered set of cars:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine(c);
            }

            // Now, sort them using IComparable!
            Array.Sort(myAutos);
            Console.WriteLine();
            // Display sorted array.
            Console.WriteLine("Here is the ordered set of cars:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
