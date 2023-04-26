using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle , ICompany
    {
        public int NumberOfSeats { get; set; }
        public bool IsMidSize { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Cylinders { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
    }
}
