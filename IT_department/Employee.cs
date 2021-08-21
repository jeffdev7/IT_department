using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_department
{
    public abstract class Employee
    {
        public string Name;
        public decimal Salary;

        public abstract void Adjust();
    }
}
