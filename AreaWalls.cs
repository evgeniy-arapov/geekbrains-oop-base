using System;
using System.Collections.Generic;

namespace Geekbrains._Основы_ООП
{
    public class AreaWalls : Figure
    {
        public AreaWalls(Area area)
        {
            _pList = new List<Point>();
            
            HorizontalLine hTopLine = new HorizontalLine(area.LeftBorder, area.RightBorder, area.TopBorder, '+');
            HorizontalLine hBottomLine = new HorizontalLine(area.LeftBorder, area.RightBorder, area.BottomBorder, '+');
            VerticalLine vLeftLine = new VerticalLine(area.TopBorder, area.BottomBorder, area.LeftBorder, '+');
            VerticalLine vRightLine = new VerticalLine(area.TopBorder, area.BottomBorder, area.RightBorder, '+');
            
            this.Add(hTopLine);
            this.Add(hBottomLine);
            this.Add(vLeftLine);
            this.Add(vRightLine);
        }
        
        
        public override void Draw()
        {
            var consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();
            Console.ForegroundColor = consoleColor;
        }
    }
}