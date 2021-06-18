using System;

namespace Geekbrains._Основы_ООП
{
    public class Food : Point
    {
        private readonly Random _random = new Random();

        public Food(Area area)
        {
            x = (uint)_random.Next((int)area.LeftBorder + 1, (int)(area.RightBorder - 1));
            y = (uint)_random.Next((int)area.TopBorder + 1, (int)(area.BottomBorder - 1));
            sym = '$';
        }
        
        public override void Draw()
        {
            var consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
            Console.ForegroundColor = consoleColor;
        }
    }
}