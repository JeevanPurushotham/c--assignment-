namespace StructVsClassDemo
{
    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"PointClass: X = {X}, Y = {Y}");
        }
    }
}
