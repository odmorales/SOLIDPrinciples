using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsability
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public double BaseSalary { get; set; }
        public double Bonuses { get; set; }
        public double Salary { get; set; }
        public void CalculateSalary() { /* ... */ }
    }
}
