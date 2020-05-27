using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data[] people = new Data[3];
            for(int i = 0; i < people.Length; i++)
            {
                people[i] = new Data();
            }
            string path = @"people.txt";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                string[] dataPeople;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    dataPeople = line.Split(new char[] { ' ' });
                    people[i].lastName = dataPeople[0];
                    people[i].firstName = dataPeople[1];
                    people[i].age = dataPeople[2];
                    people[i].weight = dataPeople[3];
                    i++;
                }
                
            }
            Queue<object> less40 = new Queue<object>();
            Queue<object> more40 = new Queue<object>();
            for(int i = 0; i < people.Length; i++)
            {
                if (Convert.ToInt32(people[i].age) < 40)
                    less40.Enqueue(people[i]);
                else
                    more40.Enqueue(people[i]);
            }
            foreach (object i in less40)
                Console.WriteLine(i);
            foreach (object i in more40)
                Console.WriteLine(i);
        }
    }
}
