using System;
using System.Collections.Generic;

namespace Geekbrains._Основы_ООП
{
    public class HorizontalLine: Figure
    {
        public HorizontalLine(uint xLeft, uint xRight, uint y, char sym)
        {
            _pList = new List<Point>();
            for (var i = xLeft; i <= xRight; i++)
            {
                _pList.Add(new Point(i, y, sym));
            }
        }
    }
}