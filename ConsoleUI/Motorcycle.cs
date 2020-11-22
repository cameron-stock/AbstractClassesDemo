using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorocycle is in drive!");
        }

        public bool HasSideCart { get; set; } = true;

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive!");
        }
    }
}
