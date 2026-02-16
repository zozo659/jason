using System.Diagnostics.Tracing;
using System.Text.Json;

namespace json
{
    class adat
    { 
        public List<string> nevek { get; set; }
        public List<int> korok { get; set; }

    }
        class Diak
        {
        public String nev { get; set; }
        public List<int> jegyek { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String fajl=File.ReadAllText("adatok.json",System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
            adat adattok = System.Text.Json.JsonSerializer.Deserialize<adat>(fajl);
            foreach (var nevee in adattok.nevek)
            {
                Console.WriteLine(nevee);
            }
            //első életkor
            Console.WriteLine($"{adattok.nevek[0]} életkora: {adattok.korok[0]}");

            //diakok.json
            fajl = File.ReadAllText("diakok.json", System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
            List<Diak> diakok =JsonSerializer.Deserialize<List<Diak>>(fajl);
            Console.WriteLine("Keresett név:");
            String neve = Console.ReadLine();
            bool megvan = false;
            foreach (var diak in diakok)
            {
                {
                    if (diak.nev == neve)
                        Console.WriteLine("Átlaga:" + diak.jegyek.Average());
                    megvan=true;
                }
            }
            if (megvan==false)
                Console.WriteLine("Nincs ilyen nevű diák!");

        }
    }
}
