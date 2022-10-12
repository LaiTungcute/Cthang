using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    class Circle
    {
        private float radius;
        public float Radius { get { return radius; } set { radius = value; } }

        public Circle ()
        {
            radius = 1;
        }

        public Circle (float radius)
        {
            this.radius = radius;
        }

        public float Area()
        {
            return (float)(radius * radius * Math.PI);
        }

        public float Perimeter()
        {
            return (float)(2 * Math.PI * radius);
        }
    }
}
