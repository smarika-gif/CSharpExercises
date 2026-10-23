using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLigning
{
    internal class Program
    {

        public static string SumLigning(List<int> inputList)
        {
            if (inputList.Count == 0 )
            {
                return "0=0";
            }


            int sum = inputList.Sum();
            string text = string.Join(" + ", inputList);


             return $"{text} = {sum}"; ;

        }

        static void Main(string[] args)
        {

            var answer = SumLigning(new List<int> { 1, 5, 7 });
            Console.WriteLine(answer);
        }
    }
}
