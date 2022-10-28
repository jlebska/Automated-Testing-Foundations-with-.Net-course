

namespace dotNet_Automation_course
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x=0, int y=0, int z=0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"x = {X}; y = {Y}; z = {Z}";
        }
    }
}
