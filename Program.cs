namespace ListTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine($"list [] = {index}");
            }
        }
    }
}
