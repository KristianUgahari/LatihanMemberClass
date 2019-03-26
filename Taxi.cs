using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public string PassName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty ? "No" : "Yes");
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine("Passenger Name : {0}\n", PassName);
        }

        public void PickUpPassenger() 
        {
            Console.WriteLine("{0} sedang menjemput {1}", DriverName, PassName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar {1}", DriverName, PassName);
            Console.WriteLine();
        }
    }
}
