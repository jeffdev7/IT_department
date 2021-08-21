using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_department
{
    class WebDev:Employee
    {
        public override void Adjust()
        {
            Salary += 1500;
        }
    }
}
