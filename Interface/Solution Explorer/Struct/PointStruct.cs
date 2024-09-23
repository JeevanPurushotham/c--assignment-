namespace StructVsClassDemo
{
    public struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"PointStruct: X = {X}, Y = {Y}");
        }
    }
}
