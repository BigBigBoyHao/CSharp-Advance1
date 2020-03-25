using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem1
{
    class Program
    {
        static void Sequence(int Num)
        {
            Console.WriteLine("当N的值为{0}时，队列S为：", Num);
            Queue<long> fifty = new Queue<long>(50);
            int counter = 1;
            int N = Num;
            int nexS = Num;
            int id = 1;
            int NNN = N;
            for (int i = 0; i < 50; i++)
            {
                if (i == 0)
                    fifty.Enqueue(N);
                else
                {
                    if (counter == 1)
                    {
                        counter++;
                        N = nexS + 1;
                        fifty.Enqueue(N);
                    }
                    else if (counter == 2)
                    {
                        counter++;
                        N = nexS * 2 + 1;
                        fifty.Enqueue(N);
                    }
                    else
                    {
                        counter = 1;
                        N = nexS + 2;
                        fifty.Enqueue(N);
                        if (id == 1)
                        {
                            id = 2;
                            nexS++;
                            NNN = nexS;
                        }
                        else if (id == 2)
                        {
                            id = 3;
                            nexS += Num;
                        }
                        else
                        {
                            id = 1;
                            nexS = nexS - Num + 1;
                            Num = nexS;
                        }
                    }
                }


            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write("{0,-4} ", fifty.Dequeue());
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //测试用例
            Sequence(2);
            Sequence(-1);
            Sequence(1000);
            Console.ReadKey();

        }
    }
}
