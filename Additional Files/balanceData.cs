﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcnSession
{
    public class balanceData : SQL
    {
        public double Cash { get; set; }
        public double Receivable { get; set; }
        public double Payable { get; set; }
        public double Inventory { get; set; }

        public double Trademark { get; set; }
        public double Taxes { get; set; }

        public double Payroll { get; set; }
        public double Insurance { get; set; }

    }
}