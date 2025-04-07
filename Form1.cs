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
using System.Xml.Linq;

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

        //Аргументы и значения варианта:
        // -2 0 2 3 4
        // 18 12 7 -1 0
        //Формула Лагранжа
        private void Lagranshz_Click(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i <= points_amount; i++)
                {
                    double x = minX + i * step;
                    double y = Interpolations.Interpolate_Lagranshz(xValues, yValues, x);
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
            Array.Clear(points, 0, points.Length);

        }


        //Формула Ньютона
        private void Neuton_Click(object sender, EventArgs e)
        {
            try
            {


                for (int i = 0; i <= points_amount; i++)
                {
                    double x = minX + i * step;
                    double y = Interpolations.Interpolate_Neuton(xValues, yValues, x);
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
            Array.Clear(points, 0, points.Length);
        }
   


   
        private void Squares_Click(object sender, EventArgs e)
        {
            clear_chart(chart1, 3); 

         
            if (chart1.Series.Count < 4)
            {
                MessageBox.Show("Необходимо создать хотя бы 4 серии на графике: Исходные данные, 1-я степень, 2-я степень, 3-я степень.");
                return; 
            }

          
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < xValues.Length; i++)
            {
                chart1.Series[0].Points.AddXY(xValues[i], yValues[i]);
            }

            int selectedDegree = 0;

            if (Square.Text == "1")
            {
                selectedDegree = 1;
            }
            else if (Square.Text == "2")
            {
                selectedDegree = 2;
            }
            else if (Square.Text == "3")
            {
                selectedDegree = 3;
            }

          
            if (selectedDegree > 0)
            {
                chart1.Series[selectedDegree].Points.Clear();
                for (int i = 0; i <= points_amount; i++)
                {
                    double x = minX + i * step;
                    double y = MinSquares.EvaluatePolynomial(MinSquares.LeastSquaresPolynomial(xValues, yValues, selectedDegree), x);
                    chart1.Series[selectedDegree].Points.AddXY(x, y);
                }
            }
        }

        private void clear_chart(Chart chart, int numSeriesToClear)
        {
            for (int i = 1; i <= numSeriesToClear; i++)
            {
                if (chart.Series.Count > i)
                {
                    chart.Series[i].Points.Clear();
                }
            }
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

                chart1.ChartAreas[0].AxisX.Minimum = minX;
                chart1.ChartAreas[0].AxisX.Maximum = maxX;
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
