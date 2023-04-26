using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public int LoadCapacity { get; set; }
        public bool HasExtendedCab { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Cylinders { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
    }
}
