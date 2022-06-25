using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if staement variables 
            string heroName = "Vincent";
            string HeroPower = "Super Accurcy";
            int heroHP = 1000;

            string villName = "Abdo";
            string VillPower = "Annoying";
            int villHP = 900;

            //function variabless
            double oldplayerSpeed = 5;
            double newplayerSpeed;



            if (heroHP > villHP)
            {
                Console.WriteLine("Hero " + heroName + " is Stronger");
            }
            else if (heroHP == villHP)
            {
                Console.WriteLine("Hero " + heroName + " and villain " + villName + "are equally strong ");

            }
            else 
            {
                Console.WriteLine("Hero " + heroName + " is weaker than villain " + villName);
            }


            //calling functions
            SetSpeed(2.5);
            CompareSpeed();

    
            void SetSpeed(double z)
            {
                Console.WriteLine("The player old speed "+ oldplayerSpeed);
                newplayerSpeed = z;
                Console.WriteLine("The player old speed "+ newplayerSpeed);

            }

            void CompareSpeed()
            {
                if (oldplayerSpeed > newplayerSpeed)
                {
                    Console.WriteLine("The old player is faster " + oldplayerSpeed);
                }
                else if (oldplayerSpeed == newplayerSpeed)
                {
                    Console.WriteLine("Both players are equally fast old player = " + oldplayerSpeed + " new player = " + newplayerSpeed);
                }
                else
                {
                    Console.WriteLine("The new player is faster " + newplayerSpeed);
                }
            }



        }
    }
}
