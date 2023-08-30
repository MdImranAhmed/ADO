﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Entities
{
    public class CustomerViewModel
    {
        public int CusAccountNo { get; set; }
        public string CustFName { get; set; }
        public string CustLName { get; set; }
        public string CustFathersFName { get; set; }
        public string CustFathersLName { get; set; }
        public DateTime CustDateofBirth { get; set; }
        public string CustNID { get; set; }
        public string CustOccupation { get; set; }
        public string CustPhoneNo { get; set; }
        public decimal CustDepositAmount { get; set; }
        public string CustImagePath { get; set; }
        public int CustGenderId { get; set; }
        public string Gender { get; set; }
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public int CustAccountId { get; set; }
        public string AccountType { get; set; }
    }
}
