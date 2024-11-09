using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WorkShop136ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            List<string> ListWords = new List<string>();
            LinkedList<string> LinkedListWords = new LinkedList<string>();
            string text;
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
            string path = "Text1.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            } 
            
            Console.WriteLine("Текст успешно прочитан");
            
            string[] words = text.Split(delimiterChars);

            stopWatch.Start();
            for (int i = 0; i < words.Length; i++)
                ListWords.Add(words[i]);
            
            double SecondValueInsertList = stopWatch.Elapsed.TotalMilliseconds;
            stopWatch.Stop();
            Console.WriteLine($"SecondValueInsertList = {SecondValueInsertList}");
            
            stopWatch.Start();
            for (int i = 0; i < words.Length; i++)
                LinkedListWords.AddLast(words[i]);
             
            SecondValueInsertList = stopWatch.Elapsed.TotalMilliseconds;
            stopWatch.Stop();
            Console.WriteLine($"SecondValueInsertLinkedListWords = {SecondValueInsertList}");
            Console.ReadKey();
        }
    }
}
