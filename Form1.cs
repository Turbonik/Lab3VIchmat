using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        int points_amount = 1000;
        private const double scaleStep = 0.01; // Шаг для кусочно-линейной аппроксимации

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Graph.Series["Многочлен 4 степени"].Color = Color.Red;
            Graph.Series["Интерполяция Лагранжа"].Color = Color.Green;
            Graph.Series["Исходные точки"].Color = Color.Black;
            Graph.Series["Сглаживание 2 степени"].Color = Color.Purple;
            Graph.Series["Сглаживание 3 степени"].Color = Color.Black;
            Graph.Series["Сглаживание 3 степени"].BorderWidth = 1;
            Graph.Series["Сглаживание 2 степени"].BorderWidth = 1;
            Graph.Series["Сглаживание 1 степени"].BorderWidth = 3;
            Graph.Series["Многочлен 4 степени"].BorderWidth = 2;
            Graph.Series["Интерполяция Лагранжа"].BorderWidth = 10;
            Graph.Series["Интерполяция Ньютона"].BorderWidth = 4;

        }

        //Аргументы и значения варианта:
        // -2 0 2 3 4
        // 18 12 7 -1 0
        //Формула Лагранжа
        private void Lagranshz_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищаем только текущую серию, если она уже была построена
                clear_series(Graph.Series["Интерполяция Лагранжа"]);
                string seriesName = "Интерполяция Лагранжа";

                double currentX = minX;
                while (currentX <= maxX)
                {
                    double y = Interpolations.Interpolate_Lagranshz(xValues, yValues, currentX);
                    Graph.Series[seriesName].Points.AddXY(currentX, y);
                    currentX += scaleStep;
                }


                // Отображаем исходные точки
                Graph.Series["Исходные точки"].Points.Clear();
                for (int i = 0; i < xValues.Length; i++)
                {
                    Graph.Series["Исходные точки"].Points.AddXY(xValues[i], yValues[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Формула Ньютона
        private void Neuton_Click(object sender, EventArgs e)
        {
            try
            {
                // Очищаем только текущую серию, если она уже была построена
                clear_series(Graph.Series["Интерполяция Ньютона"]);
                string seriesName = "Интерполяция Ньютона";

                double currentX = minX;
                while (currentX <= maxX)
                {
                    double y = Interpolations.Interpolate_Neuton(xValues, yValues, currentX);
                    Graph.Series[seriesName].Points.AddXY(currentX, y);
                    currentX += scaleStep;
                }

                // Отображаем исходные точки
                Graph.Series["Исходные точки"].Points.Clear();
                for (int i = 0; i < xValues.Length; i++)
                {
                    Graph.Series["Исходные точки"].Points.AddXY(xValues[i], yValues[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void coef_Click(object sender, EventArgs e)
        {
            // Очищаем только текущую серию, если она уже была построена
            clear_series(Graph.Series["Многочлен 4 степени"]);

            try
            {
                string coefsText = coefs.Text;
                coefsText = coefsText.Replace("-", " -");
                coefsText = coefsText.Trim();
                string seriesName = "Многочлен 4 степени";
                double[] coefs_arr = coefsText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s =>
                    {
                        if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
                        {
                            return result;
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка: Не удалось преобразовать строку '{s}' в число.");
                            return 0;
                        }
                    })
                    .ToArray();
                Polynomfourth polynomfourth = new Polynomfourth(coefs_arr);

                double currentX = minX;
                while (currentX <= maxX)
                {
                    double y = polynomfourth.Evaluate(currentX);
                    Graph.Series[seriesName].Points.AddXY(currentX, y);
                    currentX += scaleStep;
                }
                // Отображаем исходные точки
                Graph.Series["Исходные точки"].Points.Clear();
                for (int i = 0; i < xValues.Length; i++)
                {
                    Graph.Series["Исходные точки"].Points.AddXY(xValues[i], yValues[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Squares_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedDegree = int.Parse(Square.Text); // Получаем степень из text
                string coefs = "";
                string seriesName = "";

                try
                {
                    switch (selectedDegree)
                    {
                        case 1:
                            seriesName = "Сглаживание 1 степени";
                            break;
                        case 2:
                            seriesName = "Сглаживание 2 степени";
                            break;
                        case 3:
                            seriesName = "Сглаживание 3 степени";
                            break;
                        default:
                            throw new Exception("Введите число от 1 до 3!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                // Очищаем серию перед построением графика
                clear_series(Graph.Series[seriesName]);

                float[] coef = MinSquares.LeastSquaresPolynomial(xValues, yValues, selectedDegree);
                for (int i = 0; i < coef.Length; i++)
                {
                    coefs += coef[i].ToString() + "  ";
                }
                text.Text = coefs;

                // Вычисляем и добавляем точки для графика
                double currentX = minX;
                while (currentX <= maxX)
                {
                    double y = MinSquares.EvaluatePolynomial(coef, currentX);
                    Graph.Series[seriesName].Points.AddXY(currentX, y);
                    currentX += scaleStep;
                }

                // Отображаем исходные точки
                Graph.Series["Исходные точки"].Points.Clear();
                for (int i = 0; i < xValues.Length; i++)
                {
                    Graph.Series["Исходные точки"].Points.AddXY(xValues[i], yValues[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Кнопка для очистки графика
        private void Clear_button_Click(object sender, EventArgs e)
        {
            foreach (Series series in Graph.Series)
            {
                if (series.Name != "Исходные точки") // Исключаем серию "Исходные точки"
                {
                    series.Points.Clear();
                }
            }
        }


        // Метод для очистки конкретной серии
        private void clear_series(Series series)
        {
            series.Points.Clear();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Graph.Series["Исходные точки"].BorderWidth = 3; // Устанавливаем толщину линии для исходных точек

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

                points = new PointF[points_amount + 1];

                Graph.ChartAreas[0].AxisX.Minimum = minX;
                Graph.ChartAreas[0].AxisX.Maximum = maxX;
                Graph.ChartAreas[0].AxisX.LabelStyle.Angle = 0;


                // Отображаем исходные точки
                Graph.Series["Исходные точки"].Points.Clear();
                for (int i = 0; i < xValues.Length; i++)
                {
                    Graph.Series["Исходные точки"].Points.AddXY(xValues[i], yValues[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}