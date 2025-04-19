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


        public Polynomfourth(double[] arr)
        {
            A0 = arr[4];
            A1 = arr[3];
            A2 = arr[2];
            A3 = arr[1];
            A4 = arr[0];

        }
        public double Evaluate(double x)
        {
            return A0 + A1 * x + A2 * Math.Pow(x, 2) + A3 * Math.Pow(x, 3) + A4 * Math.Pow(x, 4);
        }
    }
}

