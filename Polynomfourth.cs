using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3VIchmat
{
    public class Polynomfourth
    {
  
        public double A0 { get; set; }
        public double A1 { get; set; }
        public double A2 { get; set; }
        public double A3 { get; set; }
        public double A4 { get; set; }


        public Polynomfourth(double A4, double A3, double A2, double A1, double A0) { 
            this.A0  = A0; 
            this.A1 = A1;
            this.A2 = A2;
            this.A3 = A3;
            this.A4 = A4;
        }
        public double Evaluate(double x)
        {
            return A0 + A1 * x + A2 * Math.Pow(x, 2) + A3 * Math.Pow(x, 3) + A4 * Math.Pow(x, 4);
        }
    }
}
