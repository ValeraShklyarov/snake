using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false;

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4,5, '#');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail() )
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    HorizontalLine hgo1 = new HorizontalLine(25,55,6,'-');
                    HorizontalLine hgo2 = new HorizontalLine(25, 55, 16, '-');
                    VerticalLine vgo1 = new VerticalLine(25, 7, 15, '|');
                    VerticalLine vgo2 = new VerticalLine(55, 7, 15, '|');
                    hgo1.Drow();
                    hgo2.Drow();
                    vgo1.Drow();
                    vgo2.Drow();
                    Console.SetCursorPosition(34, 8);
                    Console.WriteLine("GAME OVER!");
                    Console.SetCursorPosition(28, 11);
                    Console.WriteLine("AUTHOR : SHKLYAROV VALERA");
                    Console.SetCursorPosition(31, 14);
                    Console.WriteLine("OOP COURSEWORK 2017");
                    Console.ReadKey();
                    break;
                }

                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else 
                {
                    snake.Move();
                }


                Thread.Sleep(100);
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }


            }
            

        }

        
    }
}
