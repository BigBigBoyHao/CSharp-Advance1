using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of the chemical compounds:");
            int N = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();
            for(int i=0;i<N;i++)
            {
                Console.WriteLine("Please input one of the chemical compounds:");
                string compounds = Console.ReadLine();
                string[] elements = compounds.Split(' ');
                for (int j = 0; j < elements.Length; j++)
                    set.Add(elements[j]);
            }
            foreach(string item in set)
            {
                Console.Write("{0,-4}",item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
