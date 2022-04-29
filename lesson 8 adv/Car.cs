using System;

namespace lesson_8_adv
{
    public class Car : ICar
    {
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }

        public override string Drive(ref int fuel)
        {
            if (fuel > 0)
            {
                fuel -= 10;
                return $"degalu likutis: {fuel+10} - vaziuojam";
            }
            else
            {
                return $"degalu likutis: {fuel} - nevaziuojam, baigesi kuras. ";
            }
        }

        public override string Refuel(ref int fuel, int fuelInput)
        {
            if (fuelInput > 0)
            {
                fuel += fuelInput;
                return $"uzsipylem degalu. degalu likutis: {fuel}.";
            }
            else return "nera is ko uzsipilti, nevaziuojam";
        }
    }
}
