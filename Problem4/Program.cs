using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dic = new SortedDictionary<char, int>();
            Console.WriteLine("请输入一段话：");
            string str = Console.ReadLine();
            for(int i = 0;i<str.Length;i++)
            {
                int val;
                if (dic.TryGetValue(str[i], out val))
                    dic[str[i]]++;
                else
                    dic.Add(str[i], 1);
            }
            foreach(var item in dic)
            {
                Console.WriteLine("{0}:{1} time/s",item.Key,item.Value);
            }
            Console.ReadKey();
        }
    }
}
