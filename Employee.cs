using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Classes_Objects
{
    class Employee
    {
        public Employee()
        {
            Name = "";
        }

        public Employee(string name)
        {
            Name = name;
        }
        public string Name;
    }
}
