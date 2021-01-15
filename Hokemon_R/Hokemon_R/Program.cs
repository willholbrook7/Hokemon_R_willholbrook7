using System;

namespace Hokemon_R
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Pokemon!");

            // INSTANTIATING out first object (first Hokemon)

            Hokemon HokeObject01 = new Hokemon();

            HokeObject01.get_details();

            System.Threading.Thread.Sleep(555); // Pauses for half a second

            Console.WriteLine("");

            // Create a second Hokemon

            Hokemon Hoke02 = new Hokemon();

            Hoke02.get_details();

            Console.WriteLine("");
            Console.WriteLine("");

            System.Threading.Thread.Sleep(555);

            Battle_Arena firstArena = new Battle_Arena(); //Creating the object 'firstArena' // from the Battle_Arena CLASS

            firstArena.Request_Challenger(HokeObject01);

            System.Threading.Thread.Sleep(400);

            firstArena.Accept_Battle(HokeObject01, Hoke02);

            System.Threading.Thread.Sleep(400);

        }
    }
}
