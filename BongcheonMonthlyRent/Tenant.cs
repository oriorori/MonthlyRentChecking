using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BongcheonMonthlyRent
{
    internal class Tenant
    {
        public string name;
        public bool isMonthly;
        public int deposit;
        public int rent;
        public int maintenanceFee;
        public DateOnly executionDate;
        public DateOnly lastDate;
        public string phoneNumber;
        public StringBuilder note;

        public Tenant(string name, bool isMonthly, int deposit, int rent, int maintenanceFee, DateOnly executionDate, DateOnly lastDate, string phoneNumber, StringBuilder note)
        {
            this.name = name;
            this.isMonthly = isMonthly;
            this.deposit = deposit;
            this.rent = rent;
            this.maintenanceFee = maintenanceFee;
            this.executionDate = executionDate;
            this.lastDate = lastDate;
            this.phoneNumber = phoneNumber;
            this.note = note;
        }
    }
}
