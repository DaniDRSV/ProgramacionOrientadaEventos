using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeesLibrary.Enums;

namespace employeesLibrary
{
    public class Employee : Person
    {
        public int id { get; set; }

        public employeeTypeEnum Type { get; set; }

        public employeeStatusEnum Status { get; set; }
    }
}
