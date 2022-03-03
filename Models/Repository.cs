using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public static class Repository
    {
        public static void DeleteEmp(string empName)
        {
            allEmpoyees.Remove(allEmpoyees.FirstOrDefault(e => e.Name == empName));
        }
        private static List<Employee> allEmpoyees = new List<Employee>();
        public static IEnumerable<Employee> AllEmpoyees
        {
            get { return allEmpoyees; }
        }
        public static void Create(Employee employee)
        {
            allEmpoyees.Add(employee);
        } 
    }
}
