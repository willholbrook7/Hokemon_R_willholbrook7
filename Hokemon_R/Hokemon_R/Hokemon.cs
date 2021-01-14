using System;
namespace Hokemon_R
{
    public class Hokemon
    {
        //MEMBERS


        //VARIABLES
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;


        //PROPERTIES


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }


        //METHODS

        public Hokemon()   //CONSTRUCTOR METHOD
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);

        }


        public void provide_name()
        {
            Console.WriteLine("Please enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }


        public void get_details()
        {
            Console.WriteLine("\n\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5} ", name, health, max_health, attack, speed, defense);
        }   //GET DETAILS METHOD


        public int random_int_generator(int min_value, int max_value) //PARAMETERS
        {
            Random rnd = new Random(); // INSTANTIATING the rnd object from the RANDOM classes

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

    }
}
