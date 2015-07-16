using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSix
{
    class Person
    {
        string fname;
        string lname;

        public Person(string _fname,string _lname)
        {
            fname = _fname;
            lname = _lname;
        }
        public void print()
        {
            Console.Write(fname + "\t");
            Console.WriteLine(lname);
        }
    }
}
