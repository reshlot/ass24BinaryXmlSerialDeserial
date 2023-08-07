using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLIB
{
    [Serializable]
    public class Employee
    {
        
        //public class Employee
        //Step1 Create a class
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
        
    }
}
