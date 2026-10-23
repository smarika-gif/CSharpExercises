using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglæns_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<string>>
            {
                ["move"] = new List<string> { "liikuttaa" },
                ["hide"] = new List<string> { "piilotta", "salata" },
                ["six"] = new List<string> { "kuusi" },
                ["fir"] = new List<string> { "kuusi" }
            };

            var omvendt = VendOrdbog(d);
            foreach (var par in omvendt)
            {
                Console.WriteLine($"{par.Key}: {string.Join(", ", par.Value)}");
            }
        }

        public static Dictionary<string, List<string>> VendOrdbog(Dictionary<string, List<string>> d)
        {
            Dictionary<string, List<string>> rd = new Dictionary<string, List<string>>();

            foreach (var pair in d)
            {
                foreach (var w in pair.Value)
                {
                    if (!rd.ContainsKey(w))
                    {
                        rd[w] = new List<string>() { pair.Key };
                    }
                    else
                    {
                        rd[w].Add(pair.Key);
                    }

                }
            }
            return rd;
            Console.WriteLine();
        }
    }
}
