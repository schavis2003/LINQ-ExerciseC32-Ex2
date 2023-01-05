namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> fish = new()
            {
                "Black Bass",
                "Cod",
                "Chilean Black Sea Bass",
                "Tuna",
                "Goldfish"
            };

            IEnumerable<string> sortList = fish.OrderBy(x => x.Length);

            foreach (var item in sortList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
