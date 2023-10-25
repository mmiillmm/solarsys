using System.IO;
using System.Text;

namespace solsys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Planet> planets = new List <Planet>();

            var reader = new StreamReader(
                path: "C:\\Users\\Ny19MakaiK\\source\\repos\\solsys\\bin\\Debug\\solsys.txt",
                encoding: Encoding.UTF8);

            while (!reader.EndOfStream)
            {
                planets.Add(new Planet(reader.ReadLine()));
            }

            Console.WriteLine($"3.1: {planets.Count} bolygó van a naprendszerben");

            var avgMoon = planets.Average(a => a.planetMoons);
            Console.WriteLine($"3.2: a naprendszerben egy bolygónak átlagosan {avgMoon} holdja van");

            var maxPlanVol = planets.Single(a => a.planetVolume == planets.Max(b => b.planetVolume));
            Console.WriteLine($"3.3: a legnagyobb térfogatú bolygó a {maxPlanVol.planetName}");

            Console.Write("írd be a keresett bolygó nevét: ");

            string input = Console.ReadLine();

            Console.WriteLine(planets.Single(a => a.planetName == input) != null ?
                "Van ilyen bolygó a listában." :
                "Nincs ilyen bolygó a listában");


            Console.Write("írj be egy egész számot: ");

            int inputNum = int.Parse(Console.ReadLine());

            var moonCount = planets.Where(a => a.planetMoons > inputNum).Select(a => a.planetName);

            Console.WriteLine($"a következő bolygóknak van {inputNum}-nál/nél több holdja: ");

            foreach (var d in moonCount)
            {
                Console.Write($"[{d}] ");
            }

            Console.WriteLine("c:");

            Console.ReadKey();
        }
    }
}