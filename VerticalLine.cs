using System;
using System.Collections.Generic;

namespace Geekbrains._Основы_ООП
{
    public class VerticalLine : Figure
    {
        public VerticalLine(uint yTop, uint yBottom, uint x, char sym)
        {
            _pList = new List<Point>();
            for (var y = yTop; y <= yBottom; y++)
            {
                _pList.Add(new Point(x, y, sym));
            }
        }
    }
}