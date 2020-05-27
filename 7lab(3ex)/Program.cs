using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Data[] people = new Data[3];
            for (int i = 0; i < people.Length; i++)
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
            ArrayList list = new ArrayList();
            for (int i = 0; i < people.Length; i++)
            {
                list.Add(people[i]);
            }
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
