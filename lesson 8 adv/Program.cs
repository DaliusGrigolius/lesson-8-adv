using System;
using System.Collections.Generic;

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

            var bmwCars = new List<BmwCar> 
            {   
                new BmwCar(true, "model2"),
                new BmwCar(true, "model3"), 
                new BmwCar(true, "model1") 
            };
            var carComparer = new BmwCarComparer();
            bmwCars.Sort(carComparer);
            foreach (var c in bmwCars) Console.WriteLine(c.Model);
            //var bmw = new BmwCar(false, "X5");
            //Console.WriteLine($"BMW: {bmw.Drive(ref kuras)}");
            //Console.WriteLine(bmw.Drive(ref kuras));
            //Console.WriteLine(bmw.Drive(ref kuras));
            //Console.WriteLine(bmw.Refuel(ref kuras, fuelInput));
            //Console.WriteLine(bmw.Drive(ref kuras));
            //Console.WriteLine(bmw.Drive(ref kuras));

            var audiCars = new List<AudiCar>
            {
                new AudiCar(false, "model20"),
                new AudiCar(false, "model30"),
                new AudiCar(false, "model10")
            };
            var carComparer1 = new AudiCarComparer();
            audiCars.Sort(carComparer1);
            foreach (var c in audiCars) Console.WriteLine(c.Model);
            //var audi = new AudiCar(false, "C4");
            //Console.WriteLine($"Audi model: {audi.Model}");
            //Console.WriteLine($"Is Quattro: {audi.IsQuattro}");
            //Console.WriteLine(audi.Drive(ref kuras));
            //Console.WriteLine(audi.Drive(ref kuras));
            //Console.WriteLine(audi.Drive(ref kuras));
            //Console.WriteLine(audi.Refuel(ref kuras, fuelInput));
            //Console.WriteLine(audi.Drive(ref kuras));
            //Console.WriteLine(audi.Drive(ref kuras));
        }
    }
}
