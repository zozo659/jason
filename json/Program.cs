using System.Diagnostics.Tracing;

namespace json
{
    class adat
    { 
        public List<string> nevek { get; set; }
        public List<int> korok { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String fajl=File.ReadAllText("adatok.json",System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
            adat adattok = System.Text.Json.JsonSerializer.Deserialize<adat>(fajl);
            foreach (var nev in adattok.nevek)
            {
                Console.WriteLine(nev);
            }
            //első életkor
            Console.WriteLine($"{adattok.nevek[0]} életkora: {adattok.korok[0]}");

        }
    }
}
