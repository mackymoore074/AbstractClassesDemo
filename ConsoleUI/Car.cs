using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // Add a distinct property in the 2 derived classes such as HasTrunk for Car
    // Provide the implementations for the abstract methods
    public  class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Car is in drive"); 
        }
        



    }
}
