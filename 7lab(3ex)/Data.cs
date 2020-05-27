using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Data : IComparable
    {
        public string lastName;
        public string firstName;
        public string age;
        public string weight;

        public Data() { }
        public override string ToString()
        {
            return this.lastName + " " + this.firstName + " " + this.age + " " + this.weight;
        }
        public int CompareTo(object obj)
        {
            Data person = obj as Data;
            if (person != null)
                return this.age.CompareTo(person.age);
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}

