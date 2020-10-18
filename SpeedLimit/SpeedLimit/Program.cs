using System;
using UserInput;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 0;
            int carSpeed = 0;
            int aboveLimitSpeed = 5;
            int maximumDemeritPoints = 12;
            int demeritPoints = 0;
            Console.Write("Enter the speed limit : ");
            CUserInput.ReadNumberFromConsole(ref speedLimit);
            Console.Write("Enter the speed of the car : ");
            CUserInput.ReadNumberFromConsole(ref carSpeed);

            if (carSpeed < (speedLimit + aboveLimitSpeed))
            {
                Console.WriteLine("OK.");
            }
            else
            {
                demeritPoints = (carSpeed - speedLimit) / aboveLimitSpeed;

                if (demeritPoints < maximumDemeritPoints)
                {
                    Console.WriteLine("Your speed was above the limit, y ou will get {0} demerit points.", demeritPoints);
                }
                else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
