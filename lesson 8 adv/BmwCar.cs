namespace lesson_8_adv
{
    public class BmwCar : Car
    {
        public bool IsXDrive { get; set; }

        public BmwCar(bool isXDrive, string model) : base(model)
        {

        }
    }
}
