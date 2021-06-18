using System;
using System.Collections.Generic;
using System.Linq;

namespace Geekbrains._Основы_ООП
{
    public class Snake : Figure
    {
        Direction direction;
        private int startLength;

        public Snake(Point tail, uint length, Direction _direction)
        {
            direction = _direction;
            _pList = new List<Point>();
            startLength = (int)length;
            
            for (uint i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                _pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = _pList.First();
            _pList.Remove(tail);
            Point head = GetNextPoint();
            _pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = _pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.Top;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.Bottom;
                    break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (!head.IsHit(food)) return false;
            
            food.sym = head.sym;
            _pList.Add(food);
            return true;
        }

        public bool IsTailHit()
        {
            var head = GetNextPoint();
            var tail = _pList.GetRange(1, _pList.Count - 1);
            return tail.Any(tailPoint => tailPoint.IsHit(head));
        }

        public int GetSize()
        {
            return _pList.Count - startLength;
        }
    }
}