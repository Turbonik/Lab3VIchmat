using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3VIchmat
{
    public class Interpolations
    {
        public static double Interpolate_Lagranshz(double[] x, double[] y, double xEval)
        {
            double result = 0.0;
            int n = x.Length;

            for (int i = 0; i < n; i++)
            {
                double term = y[i];
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        term *= (xEval - x[j]) / (x[i] - x[j]);
                    }
                }
                result += term;
            }
            return result;
        }

        public static double Interpolate_Neuton(double[] knownX, double[] knownY, double xEval)
        {
            int n = knownX.Length;


            double[,] dividedDifferences = CalculateDividedDifferences(knownX, knownY);


            double result = dividedDifferences[0, 0];
            double term = 1.0;

            for (int i = 1; i < n; i++)
            {
                term *= (xEval - knownX[i - 1]);
                result += dividedDifferences[0, i] * term;
            }

            return result;
        }
        public static double[,] CalculateDividedDifferences(double[] x, double[] y)
        {
            int n = x.Length;
            double[,] dividedDifferences = new double[n, n];


            for (int i = 0; i < n; i++)
            {
                dividedDifferences[i, 0] = y[i];
            }


            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    dividedDifferences[i, j] = (dividedDifferences[i + 1, j - 1] - dividedDifferences[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            return dividedDifferences;
        }

    }
}
