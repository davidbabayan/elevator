using System;

namespace Lecture7
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator(9);
            e.Call(5);
            e.CloseDoors(1);
        }
    }
    
}
