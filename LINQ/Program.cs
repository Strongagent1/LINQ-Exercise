namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string> { "Call of Duty", "World of Warcraft", "Madden", "Contra" , "Street Figter"};

            var sortGames = games.OrderBy(x => x).ToList();
            //Console.WriteLine($"{sortGames}");
            //games.Sort();
            Console.WriteLine(string.Join(" ", games));




        }
    }
}
