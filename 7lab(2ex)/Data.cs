using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Data
    {
        public string lastName;
        public string firstName;
        public string age;
        public string weight;

        public override string ToString()
        {
            return this.lastName + " " + this.firstName + " " + this.age + " " + this.weight;
        }
    }
}