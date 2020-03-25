using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            // FileStream word = new FileStream("word.txt",FileMode.Open);
            // string allword = word.Reada
            //}
            string words = File.ReadAllText("words.txt").ToLower();
            string[] text0 = File.ReadAllLines("text.txt");
            StringBuilder textBuilder = new StringBuilder();
            //去掉字符串中所有不是连字符或者空格或者英文字母的字符
            for (int i = 0; i < text0.Length; i++)
            {
                text0[i] = text0[i].ToLower();
                for(int j = 0; j < text0[i].Length; j++)
                {
                    if ((text0[i][j] <= 'z' && text0[i][j] >= 'A') || text0[i][j] == '\'' || text0[i][j] == ' ')
                        textBuilder.Append(text0[i][j]);
                    else
                        textBuilder.Append(' ');
                }
                textBuilder.Append(' ');

            }
            //得到新的段落和单词
            string text = textBuilder.ToString();
            string[] word = words.Split(' ');
            string[] eachtext = text.Split(' ');
            //把 每个 Key - 0 写入Dictonary
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for(int i=0;i<word.Length;i++)
            {
                dic.Add(word[i], 0);
            }
            //更新每个Key的值
            for(int i=0;i<eachtext.Length;i++)
            {
                int k;
                if (dic.TryGetValue(eachtext[i], out k))
                    dic[eachtext[i]]++;
            }
            //定义结果数组
            string[] output = new string[word.Length];
            //按Value值排序
            var dicSort = from objDic in dic orderby objDic.Value descending select objDic;
            int num = 0;
            foreach (KeyValuePair<string, int> kvp in dicSort)
            {
                output[num] = kvp.Key + " - " + kvp.Value;
                //在控制台输出
                Console.WriteLine(output[num]);
                num++;
            }
            //写入文件
            File.WriteAllLines("results.txt", output);
        }
    }
}
