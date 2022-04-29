namespace lesson_8_adv
{
    public class AudiCar : Car
    {
        public bool IsQuattro { get; set; }

        public AudiCar(bool isQuattro, string model) : base(model)
        {

        }
    }
}
