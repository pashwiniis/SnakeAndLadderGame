﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~Snake and Ladder game~~~~~~~~~~");
            SnakeAndLadder game = new SnakeAndLadder();
            game.Board();
        }
    }
}
