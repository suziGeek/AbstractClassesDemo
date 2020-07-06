using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Im driving the motorcyle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This is virtual Drive for Motorcycle");
        }

    }
}
