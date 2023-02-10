using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assign2
{
    public class Circle
    {
        private int radius;

        public Circle()
        {
            radius = 1;
        }
        public Circle(int pRadius)
        {
            radius = pRadius;
        }
        public int GetRadius()
        {
            return radius;
        }
        public void SetRadius(int pRadius)
        {
            if (pRadius > 0)
            {
                radius = pRadius;
            }

        }
        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
