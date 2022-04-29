using System.Collections.Generic;

namespace lesson_8_adv
{
    public class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar x, BmwCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
