using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class Program
    {
        static void Main(string[] args)
        {

            int Dot = 10;
            int VulnerableGhost = 200;
            int InvincibleGhost = 1;
            int Cherry = 100;
            int Strawberry = 300;
            int Orange = 500;
            int Apple = 700;
            int Melon = 1000;
            int Galaxian = 2000;
            int Bell = 3000;
            int Key = 5000;

            var user = new PacManClass();
            int newLife = 1000;




            int[] Sequence = new int[] { Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, InvincibleGhost,
                Melon, Galaxian, VulnerableGhost, VulnerableGhost, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot,
                Dot, Bell, Cherry, Strawberry, InvincibleGhost, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot,
                Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot,
                Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Dot, Orange, Apple, InvincibleGhost, VulnerableGhost,
                Key, InvincibleGhost, Dot, Dot, Dot, Dot, Dot, VulnerableGhost };




            for (int i = 0; i < Sequence.Length; i++)
            {

              
              

                user.Points += Sequence[i];

               

            }

            for (int i = 0; i < Sequence.Length; i++)
            {


                user.Lives += Sequence[i]/newLife;



            }








            Console.WriteLine($"Total Points: {user.Points} and Total Lives: { user.Lives}");

            Console.ReadLine();


        }
    }
}
