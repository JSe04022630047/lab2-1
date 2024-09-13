using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_7
{
    class Rational
    {
        public Rational() 
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Rational(double a, double b)
        {
            Numerator = a;
            Denominator = b;
        }

        public Rational Add(Rational objR)
        {
            double a = Numerator;
            double b = Denominator;
            double c = objR.Numerator;
            double d = objR.Denominator;

            return new Rational((a * d) + (b * c), b * d);
        }

        public Rational Subtract(Rational objR)
        {
            double a = Numerator;
            double b = Denominator;
            double c = objR.Numerator;
            double d = objR.Denominator;

            return new Rational((a * d) - (b * c), b * d);
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}",Numerator.ToString(), Denominator.ToString());
        }

        private double _dNumerator;
        protected double Numerator {
            get
            {
                return _dNumerator;
            }
            set
            {
                _dNumerator = value;
            }
        }
        private double _dDenominator;
        protected double Denominator
        {
            get { return _dDenominator; }
            set { _dDenominator = value; }
        }
    }
}
