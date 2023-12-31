﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll_Services
{
    public class PayRoll_Model
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public double Salary { get; set; }
        public DateTime Start_Date { get; set; }
        public char Gender { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double Basic_Pay { get; set; }
        public double Deduction { get; set; }
        public double Taxable_Pay { get; set; }
        public double Income_Tax { get; set; }
        public double Net_Pay { get; set; }
    }
}
