using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BMI.ValueTypes
{
    public struct Measurement
    {
        public double BMI { get; private set; }

        public Measurement(double weight, double height)
        {
            if (height <= 0) throw new ArgumentException("Height must be greater than zero.");
            BMI = weight / (height * height);
        }
    }
}
