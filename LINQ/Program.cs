
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vids = new List<string> () { "name1", "vidname2", "D&D", "The Collection of the Orgs" };
            var orderedList = vids.OrderBy(vid => vid.Length);
            foreach (var vid in orderedList)
            {
                Console.WriteLine (vid);
            }

        }
    }
}
