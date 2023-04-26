using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public double TrunkCapacityCuFt  { get; set; }
        public bool IsCrosstrek { get ; set; }
        public int Year { get; set ; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Cylinders { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
    }
}
