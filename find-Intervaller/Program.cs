using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace find_Intervaller
{
    internal class Program
    {

        public static List<(int Start, int Slut)> FindIntervaller(List<int> inputList)
        {
            var l = new List<int>(inputList);
            l.Sort();

            var result = new List<(int Start, int Slut)>();
            if (l.Count == 0) return result;

            int start = l[0];
            int forrige = l[0];

            for (int i = 1; i < l.Count; i++)
            {
                if (l[i] == forrige + 1)
                {
                    // keep extending the current interval

                }
                else
                {
                    result.Add((start, forrige + 1));
                    start = l[i];
                }
                forrige = l[i];
            }
            result.Add((start, forrige + 1));
            return result;
        }
        static void Main(string[] args)
        {
            var resultat = FindIntervaller(new List<int> { 2, 5, 4, 8, 12, 6, 7, 10, 13});
            var dele = new List<string>();

            foreach (var (s, slut) in resultat)
            {
                if(slut == s + 1)
                {
                    dele.Add(s.ToString());
                }
                else
                {
                    dele.Add($"({s} , {slut})");
                }  
            }
            Console.Write("[" + string.Join(",", dele) + "]");
            Console.WriteLine();

        }
    }
}
