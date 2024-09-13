using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/////////////////////////////////////////////////////////////////////////////////////
// Subject          : Object Oriented Programming
// Academic Year    : 1/2022
// Topic      	    : Lab5-1
// Module           : Employee Class
// Instructor       : Asst. Prof. Dr.Dome Lohpetch
// Student ID       :
// Student Name     : 
// Lab Date         : 
/////////////////////////////////////////////////////////////////////////////////////

namespace Lab8_1
{
    class Employee
    {
        #region Fields
        private string _sID;
        private string _sName;
        private int _nPostion;
        private double _dSalary;
        #endregion

        #region Constructors
        public Employee()
        {
            _sID = "EMP001";
            _sName = "MR. X";
            _nPostion = 3;
            _dSalary = 15000;
        
        }
        
        public Employee(string sID, string sName, int nPosition, double dSalary)
        {
            _sID = sID;
            _sName = sName;
            _nPostion = nPosition;
            _dSalary = dSalary;
        }
        #endregion

        #region Properties
        public string ID
        {
            get { return _sID; }
            set { _sID = value; }
        }

        public string Name
        {
            get { return _sName; }
            set { _sName = value; }
        }
        public int Position
        {
            get { return _nPostion; }
            set
            {
                if (value < 0 || value > 3)
                {
                    throw new ArgumentOutOfRangeException("Position must be between 0 and 3");
                }
                _nPostion = value;
            }        
        }

        public string PositionName
        {
            get
            {
                string toReturn = String.Empty;
                switch (Position)
                {
                    case 0:
                        toReturn = "President";
                        break;
                    case 1:
                        toReturn = "Manager";
                        break;
                    case 2:
                        toReturn = "Supervisor";
                        break;
                    case 3:
                        toReturn = "Officer";
                        break;
                    default:
                        toReturn = "Unknown";
                        break;
                }
                return toReturn;
            }
        }

        public double Salary
        {
            get { return _dSalary; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary must be greater than 0");
                }
                _dSalary = value; 
            }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("{0}: {1}-{2} [{3}]", new object[] { ID, Name, PositionName, Salary });
        }

        #endregion
    }
}
