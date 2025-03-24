using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3VIchmat
{
    public partial class Form1 : Form
    {
        private double[] xValues;
        private double[] yValues;
        PointF[] points;
        double rangeX, minX, maxX, step;
        int points_amount = 100;

        public Form1()
        {
            InitializeComponent();
        }

        public void Set_Settings()
        {

        }

        //Формула Лагранжа
        private void Lagranshz_Click(object sender, EventArgs e)
        {
            try
            {
              
               
                for (int i = 0; i <= points_amount; i++)
                {
                    double x = minX + i * step;
                    double y = Interpolate(xValues, yValues, x);
                    points[i] = new PointF((float)x, (float)y);
                }

         
                Graph.Series[1].Points.Clear();
                Graph.Series[1].Points.DataBind(points, "X", "Y", "");

  
                Graph.Series[0].Points.Clear();
                for (int i = 0; i < xValues.Length; i++)
                {
                        Graph.Series[0].Points.AddXY(xValues[i], yValues[i]);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
    private double Interpolate(double[] x, double[] y, double xEval)
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

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {

                xValues = xTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                yValues = yTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                if (xValues.Length != yValues.Length)
                {
                    MessageBox.Show("Количество значений x и y должно совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                minX = xValues.Min();
                maxX = xValues.Max();

                rangeX = maxX - minX;
                minX -= rangeX * 0.05;
                maxX += rangeX * 0.05;



                step = (maxX - minX) / points_amount;

                points = new PointF[points_amount + 1];

                Graph.ChartAreas[0].AxisX.Minimum = minX;
                Graph.ChartAreas[0].AxisX.Maximum = maxX;
                Graph.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Neuton_Click(object sender, EventArgs e)
        {

        }
    }
}
