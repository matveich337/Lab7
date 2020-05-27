using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static bool ComplexBracketsBalance(string input)
        {
            Stack<char> symbolStack = new Stack<char>();
            foreach (char symbol in input)
            {
                if (symbol == '(')
                {
                    symbolStack.Push(symbol);
                }

                if (symbol == ')')
                {
                    if (symbolStack.Count > 0)
                    {
                        char lastSymbol = symbolStack.Peek(); 
                        symbolStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return symbolStack.Count == 0;
        }
        static void Main(string[] args)
        {
            string path = @"str.txt";
            string expression;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    expression = Convert.ToString(sr.ReadToEnd());
                    Console.WriteLine(expression);                    
                    Console.WriteLine(ComplexBracketsBalance(expression));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}