using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Random rand = new Random();
            for (int i = 0; i < 2131; i++)
            {
                list.Add(rand.Next(400, 801));
            }
            list.Sort();
            foreach(int i in list)
                Console.Write(i + " ");
            Console.WriteLine();
            list[10] = 10;
            int temp = rand.Next(0, 10 + 1000);
            Console.WriteLine(temp);
            List<int> indexes = new List<int>();
            for (int i = 0; i < 2131; i++)
            {
                if (Convert.ToInt32(list[i]) == temp)
                    indexes.Add(i);
            }
            if (indexes.Count != 0)
                foreach (int i in indexes)
                    Console.Write(i + " ");
            else
                Console.WriteLine("No matches found");
            Console.WriteLine();
            int temp2 = rand.Next(0, 2130);
            Console.WriteLine(temp2);
            for (int i = 0; i < list.Count; i++)
            {
                if (Convert.ToInt32(list[i]) == temp2)
                    list.RemoveAt(i);
            }
            foreach (int i in list)
                Console.Write(i + " ");
            for (int i = 0; i < list.Count; i++)
            {
                list.RemoveAt(i);
            }
            foreach (int i in list)
                Console.Write(i + " ");
        }
    }
}