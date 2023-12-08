namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door1 = new Door(123, 23, false, true);
            Door door2 = new Door(13, 53, false, false);

            Console.WriteLine(door1.close());
            Console.WriteLine(door2.close());
            Console.WriteLine(door1.open());
            Console.WriteLine(door2.close());
        }
    }
}
