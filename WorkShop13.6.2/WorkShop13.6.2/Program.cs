using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop136ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
            string text;
            char[] delimiterChars = {'–',' ', ',', '.', ':', ';', '?', '<', '>', '!', '\t', '\n' };
            string path = "Text1.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }

            Console.WriteLine("Текст успешно прочитан");
            string[] words = text.Split(delimiterChars);
            for (int i = 0; i < words.Length; i++) {
                if (words[i] != string.Empty && words[i] != "–")
                {
                    if (wordsDictionary.ContainsKey(words[i]))
                        wordsDictionary[words[i]]++;
                    else                    
                        wordsDictionary.Add(words[i], 1);
                }
                
            }

            var output = wordsDictionary.OrderBy(e => e.Value).Select(e => new { count = e.Value, word = e.Key }).ToList();
            output.Reverse();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Количество попаданий в тексте:{0}, слово: {1}", output[i].count, output[i].word);
            }
            Console.ReadKey();
        }
    }
}
