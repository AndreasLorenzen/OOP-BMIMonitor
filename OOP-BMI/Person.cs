using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BMI
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        // Opdater navneområdet til OOP_BMI.ValueTypes
        public double BMI => new OOP_BMI.ValueTypes.Measurement(Weight, Height).BMI;
    }
}
