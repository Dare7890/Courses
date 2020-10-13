using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geekbrains_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int xSizeWindow = 80;
            int ySizeWindow = 26;
            Console.SetWindowSize(xSizeWindow, ySizeWindow );
            Console.SetBufferSize(xSizeWindow, ySizeWindow );

            Walls walls = new Walls(xSizeWindow , ySizeWindow - 1);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.DOWN);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(xSizeWindow, ySizeWindow - 1, '0');
            Point food = foodCreator.CreateFood();
            food.Draw();
            Console.SetCursorPosition(0, ySizeWindow - 1);
            Console.Write("Количество съеденных фруктов: {0}", snake.CountOfEat());

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Console.SetCursorPosition(0, ySizeWindow - 1);
                    Console.Write("Количество съеденных фруктов: {0}", snake.CountOfEat());
                }
                else
                {
                    try
                    {
                        snake.Move();
                    }
                    catch
                    {
                        break;
                    }
                }

                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            Console.SetCursorPosition(xSizeWindow / 2, ySizeWindow / 2);
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
