using System;

namespace lesson_8_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kuras = 20;
            var fuelInput = 20;
            //Car masina = new Car("bmw", kuras);

            //Console.WriteLine(masina.Drive(ref kuras));
            //Console.WriteLine(masina.Drive(ref kuras));
            //Console.WriteLine(masina.Drive(ref kuras));
            //Console.WriteLine(masina.Refuel(ref kuras, fuelInput));
            //Console.WriteLine(masina.Drive(ref kuras));
            //Console.WriteLine(masina.Drive(ref kuras));

            //var bmw = new BmwCar(false, "X5");
            //Console.WriteLine($"BMW: {bmw.Drive(ref kuras)}");
            //Console.WriteLine(bmw.Drive(ref kuras));
            //Console.WriteLine(bmw.Drive(ref kuras));
            //Console.WriteLine(bmw.Refuel(ref kuras, fuelInput));
            //Console.WriteLine(bmw.Drive(ref kuras));
            //Console.WriteLine(bmw.Drive(ref kuras));

            var audi = new AudiCar(false, "C4");
            Console.WriteLine($"Audi model: {audi.Model}");
            Console.WriteLine($"Is Quattro: {audi.IsQuattro}");
            Console.WriteLine(audi.Drive(ref kuras));
            Console.WriteLine(audi.Drive(ref kuras));
            Console.WriteLine(audi.Drive(ref kuras));
            Console.WriteLine(audi.Refuel(ref kuras, fuelInput));
            Console.WriteLine(audi.Drive(ref kuras));
            Console.WriteLine(audi.Drive(ref kuras));
        }
    }
}
