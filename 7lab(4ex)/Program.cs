using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> numbers = new Stack<char>();
            string readPath = @"input.txt";
            string writePath = @"output.txt";
            using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
            {
                string line;
                char[] arrNumbers;
                while ((line = sr.ReadLine()) != null)
                {
                    arrNumbers = line.ToCharArray();
                    for (int i = 0; i < arrNumbers.Length; i++)
                    {
                        numbers.Push(arrNumbers[i]);
                    }
                } 
            }
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                int count = numbers.Count;
                for (int i = 0; i < count; i++)
                {
                    sw.Write(numbers.Pop());
                   
                }
                Console.WriteLine("Success!");
            }
        }
    }
}
