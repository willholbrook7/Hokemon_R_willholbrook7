using System;

namespace Hokemon_R
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Pokemon!");

            // INSTANTIATING out first object (first Hokemon)

            Hokemon HokeObject01 = new Hokemon();

            HokeObject01.get_details();

            System.Threading.Thread.Sleep(500); // Pauses for half a second

            // Create a second Hokemon

            Hokemon Hoke02 = new Hokemon();

            Hoke02.get_details();


        }
    }
}
