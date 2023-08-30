using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Entities
{
    public class Employee_E
    {
        public int EmployeeId { get; set; }
        public string Fullname { get; set; }
        public string EmpUserName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPassword { get; set; }
        public string ImagePath { get; set; }
        public string EmpNID { get; set; }
        public string EmpIsActive { get; set; }
        public DateTime EmpJoinDate { get; set; }
    }
}
