namespace lesson_8_adv
{
    public abstract class ICar
    {
        public abstract string Drive(ref int fuel);

        public abstract string Refuel(ref int fuel, int fuelInput);

    }
}
