namespace Geekbrains._Основы_ООП
{
    public class Area
    {
        public uint TopBorder;
        public uint RightBorder;
        public uint BottomBorder;
        public uint LeftBorder;

        public Area(uint topBorder, uint rightBorder, uint bottomBorder, uint leftBorder)
        {
            TopBorder = topBorder;
            RightBorder = rightBorder;
            BottomBorder = bottomBorder;
            LeftBorder = leftBorder;
        }
    }
}