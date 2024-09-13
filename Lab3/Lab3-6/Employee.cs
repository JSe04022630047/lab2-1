using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_6 // Why does Visual Studio generate this?
{
    class Employee
    {
        public Employee()
        {
            ID = "EMP001";
            Name = "Mr. X";
            Salary = 5000;
        }
        public Employee(double dSalary = 5000.0) 
        {
            ID = "EMP001";
            Name = "Mr. X";
            Salary = dSalary;
        }

        public Employee(int nSalary = 5000)
        {
            ID = "EMP001";
            Name = "Mr. X";
            Salary = nSalary;
        }

        public Employee(string sID, string sName, double dSalary = 5000.0)
        {
            ID = sID;
            Name = sName;
            Salary = dSalary;
        }

        public double IncreaseSalary()
        {
            double newSalary = (Salary * 10 / 100) + Salary;
            Salary = newSalary;
            return newSalary;
        }

        public double IncreaseSalary(double dMoney)
        {
            double newSalary = Salary + dMoney;
            Salary = newSalary;
            return newSalary;
        }
        public double IncreaseSalary(float fPercent)
        {
            double newSalary = (Salary * fPercent / 100) + Salary;
            Salary = newSalary;
            return newSalary;
        }

        private string _sID;
        public string ID { get { return _sID; } set { _sID = value; } }

        private string _sName;
        public string Name { get { return _sName; } set { _sName = value; } }

        private double _dSalary;
        public double Salary
        {
            get { return _dSalary; }
            set { _dSalary = value; }
        }
    }
}
