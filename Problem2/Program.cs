using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void IsBalanced(string str)
        {
            bool flag = true;
            Stack<char> p = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    p.Push(str[i]);
                }
                else
                {
                    if (str[i] - p.Peek() <= 2)   //ASCII码
                    {
                        p.Pop();
                    }
                    else
                        flag = false;
                }
            }
            if (flag)
                Console.WriteLine("The result of the input \"{0}\" is YES! ", str);
            else
                Console.WriteLine("The result of the input \"{0}\" is NO! ", str);
        }
        static void Main(string[] args)
        {
            //测试用例
            IsBalanced("{[()]}");
            IsBalanced("{[(])}");
            IsBalanced("{{[[(())]]}}");
            Console.ReadKey();
        }
    }
}
