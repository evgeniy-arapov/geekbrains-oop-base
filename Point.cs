using System;

namespace Geekbrains._Основы_ООП
{
    public class Point
    {
        public uint x;
        public uint y;
        public char sym;

        public Point(){}

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(uint _x, uint _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        
        public virtual void Draw()
        {
            Console.SetCursorPosition((int)x, (int)y);
            Console.Write(sym);
        }
        
        public void Move(uint offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Bottom:
                    y += offset;
                    break;
                case Direction.Top:
                    y -= offset;
                    break;
                case Direction.Left:
                    x -= offset;
                    break;
                case Direction.Right:
                    x += offset;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool IsHit(Point point)
        {
            return x == point.x && y == point.y;
        }
    }
}