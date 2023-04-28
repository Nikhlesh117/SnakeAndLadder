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
            Console.WriteLine("\nWelcome Player");
            Console.WriteLine("\nPlayer at position : " + position);
            int dice;
            Random random = new Random();
            dice = random.Next(1, 7);
            Console.WriteLine("\nPlayer rolls dice :" + dice);
        }
    }
}
