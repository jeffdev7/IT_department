using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_department
{
    class Designer:Employee
    {
        public override void Adjust()
        {
            Salary += 500;
        }
    }
}
