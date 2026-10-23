using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akronymer
{
    internal class Program
    {
        public static List<string> Akronymer(string data)
        {
            var resultat = new List<string>();

            foreach (string ord  in data.Split(' '))
            {
                string renset = ord.Trim('.', ',', '(', ')');
                if (renset.Length >= 2 && !renset.Any(char.IsLower) && renset.Any(char.IsLetter)) 
                {
                    resultat.Add(renset);
                }
            }

            return resultat;
        }


        static void Main(string[] args)
        {
            var result = Akronymer(@"For the purposes of the EU General Data Protection Regulation (GDPR), 
            the controller of your personal information is International Business Machines Corporation (IBM Corp.), 
            1 New Orchard Road, Armonk, New York, United States, unless indicated otherwise. Where IBM Corp. or a 
            subsidiary it controls (not established in the European Economic Area (EEA)) is required to appoint a legal
            representative in the EEA, the representative for all such cases is IBM United Kingdom Limited, PO Box 41,
            North Harbour, Portsmouth, Hampshire, United Kingdom PO6 3AU.");


            Console.WriteLine(string.Join(", ", result));

        }
    }
}
