using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CeilInn1
{
    public class Employee
    {
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public override bool Equals(object? obj)
        {
            Employee clerk = (Employee)obj;

            if (clerk.EmployeeNumber.Equals(this.EmployeeNumber))
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
