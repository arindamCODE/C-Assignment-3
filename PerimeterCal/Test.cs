using System;

namespace PerimeterCal
{
    public class PeriTest
    {
        public int TraiPeri(int s1, int b, int s2)
        {
            return s1+b+s2;
        }

        public int RectPeri(int l, int w)
        {
            return 2*(l+w);
        }

        public int SqPeri(int s)
        {
            return 4*s;
        }
    }
}