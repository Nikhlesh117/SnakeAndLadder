using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {
        public void SnakeAndLadderGame()
        {
            int position = 0;
            int temp = 0;
            Console.WriteLine("\nWelcome Player");
            Console.WriteLine("Player at position : " + position);
            Random random = new Random();
            while (position < 100)
            {
                int dice = random.Next(1, 7);
                Console.WriteLine("\nPlayer rolls dice :" + dice);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position += dice;
                        if (position > 100)
                        {
                            position = temp;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position -= dice;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                }
                Console.WriteLine("Player Current Position : " + position);
            }
            Console.WriteLine("Player Position : " + position);
        }        
    } 
}
