using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public  class Motorcycle: Vehicle
    {
        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Motocycle is in drive");
        }

       
       
    }
}
