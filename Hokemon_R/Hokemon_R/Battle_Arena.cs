using System;
namespace Hokemon_R
{
    public class Battle_Arena
    {
        public Battle_Arena() //CONSTRUCTOR method //Runs first when OBJECT INTANTIATED
        {
            Console.WriteLine("***** WELCOME TO THE BATTLE ARENA *****");
            Console.WriteLine("");
        }

        public void Request_Challenger(Hokemon contendor)
        {
            Console.WriteLine("{0}: say's 'I want a BATTLE... Who is ready to challenge me?'", contendor.Name);
        }

        public void Accept_Battle(Hokemon contendor01, Hokemon contendor02)
        {
            Console.WriteLine("{0}: 'I accept the challenge to fight you, {1}' ", contendor02.Name, contendor01.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{1}: 'Great {0}, Let's BATTLE!' ", contendor02.Name, contendor01.Name);
        }
    }
}
