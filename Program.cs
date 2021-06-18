using System;
using System.Threading;

namespace Geekbrains._Основы_ООП
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thread.Sleep(300);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            // DrawCoordinates();

            const uint topBorder = 4;
            const uint bottomBorder = 20;
            const uint leftBorder = 4;
            const uint rightBorder = 60;

            var area = new Area(topBorder, rightBorder, bottomBorder, leftBorder);

            var areaWalls = new AreaWalls(area);

            var startPoint = new Point(leftBorder + 5, topBorder + 5, '*');
            var snake = new Snake(startPoint, 4, Direction.Right);

            Point food = new Food(area);

            areaWalls.Draw();
            snake.Draw();
            food.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                if (areaWalls.IsHit(snake) || snake.IsTailHit())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = new Food(area);
                    food.Draw();
                }

                Console.SetCursorPosition((int) area.LeftBorder, (int) area.BottomBorder + 1);
                Console.WriteLine($"Points: {snake.GetSize()}");
                snake.Move();
                Thread.Sleep(100);
            }

            GameOver(area);

            Console.SetCursorPosition(0, (int) bottomBorder + 2);
        }

        private static void DrawCoordinates()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                if (i < 10) Console.Write(i);
                else Console.Write(i % 10);
            }

            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                if (i < 10 || i % 10 != 0) continue;

                Console.SetCursorPosition(i, 1);
                Console.Write(i);
            }

            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Console.BufferHeight; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void GameOver(Area area)
        {
            string text = "Game Over";
            var areaCenterX = (area.RightBorder - area.LeftBorder) / 2;
            var areaCenterY = (area.BottomBorder - area.TopBorder) / 2;
            var halfTextLength = text.Length / 2;
            var x = (int) area.LeftBorder + (int) areaCenterX - halfTextLength;
            var y = (int) (areaCenterY + area.TopBorder);
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
        }
    }
}