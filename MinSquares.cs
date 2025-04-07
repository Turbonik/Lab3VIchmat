using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3VIchmat
{
    public static class MinSquares
    {
        public static float[] LeastSquaresPolynomial(double[] x, double[] y, int degree)
        {
            int n = x.Length;

            float[,] A = new float[degree + 1, degree + 1];
            float[] b = new float[degree + 1];
            for (int i = 0; i <= degree; i++)
            {
                for (int j = 0; j <= degree; j++)
                {
                    A[i, j] = (float)x.Sum(xi => Math.Pow(xi, i + j));
                }
                b[i] = (float)x.Zip(y, (xi, yi) => yi * Math.Pow(xi, i)).Sum();
            }
            GaussElimination gauss = new GaussElimination();

            float[] coeffs = gauss.SolveWithColumnPivoting(A, b);
            return coeffs;
        }
        public static float EvaluatePolynomial(float[] coeffs, double x)
        {
            float result = 0;
            for (int i = 0; i < coeffs.Length; i++)
            {
                result += (float)(coeffs[i] * Math.Pow(x, i));
            }
            return result;
        }
    }
}
