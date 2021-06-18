using System.Collections.Generic;
using System.Linq;

namespace Geekbrains._Основы_ООП
{
    public class Figure
    {
        protected List<Point> _pList;

        public virtual void Draw()
        {
            foreach (Point point in _pList)
            {
                point.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            return figure._pList.Any(this.IsHit);
        }
        
        public bool IsHit(Point point)
        {
            return _pList.Any(internalPoint => internalPoint.IsHit(point));
        }

        public void Add(Figure figure)
        {
            foreach (Point point in figure._pList)
            {
                _pList.Add(point);
            }
        }
    }
}