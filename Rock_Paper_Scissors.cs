using System;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to rock paper scissor game");
            Console.WriteLine("1 = Rock");
            Console.WriteLine("2 = Paper");
            Console.WriteLine("3 = Scissor");

                        
            Console.Write("User_1 Please type your name: ");
            string user_1_name = Console.ReadLine();

            Console.Write("User_2 Please type your name: ");
            string user_2_name = Console.ReadLine();


            int Rock = 1;
            int Paper = 2;
            int Scissor = 3;

            int user_1_point = 0;
            int user_2_point = 0;

         while(user_1_point < 3 && user_2_point < 3) 
            
            { 
                
                Console.WriteLine(user_1_name + " choose 1) ROCK  2) PAPER  2) SCISSOR");
                int user_1_choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(user_2_name + " choose 1) ROCK  2) PAPER  2) SCISSOR");
                int user_2_choice = Convert.ToInt32(Console.ReadLine());

                if (user_1_choice == user_2_choice)
                {
                    Console.WriteLine("There is no winner");
                }
                else if ((user_1_choice == 1 && user_2_choice == 3) ||
                        (user_1_choice == 2 && user_2_choice == 1) ||
                        (user_1_choice == 3 && user_2_choice == 2))
                {
                    Console.WriteLine(user_1_name + " wins this round!");
                    user_1_point++;
                }
                else
                {
                    Console.WriteLine(user_2_name + " wins this round!");
                    user_2_point++;
                }
            }

            if (user_1_point >= 3)
            {
                Console.WriteLine("Game Over, " + user_1_name + " wins!");
            }
            else
            
            {
                Console.WriteLine("Game Over, " + user_2_name + " wins!");


            }





        }
    }
}