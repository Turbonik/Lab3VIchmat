namespace Lab3VIchmat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lagranshz = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.Neuton = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Squares = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(20, 18);
            this.Graph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.Graph.Series.Add(series1); 
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(418, 199);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // Lagranshz
            // 
            this.Lagranshz.Location = new System.Drawing.Point(500, 113);
            this.Lagranshz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lagranshz.Name = "Lagranshz";
            this.Lagranshz.Size = new System.Drawing.Size(122, 60);
            this.Lagranshz.TabIndex = 1;
            this.Lagranshz.Text = "Формула Лагранжа";
            this.Lagranshz.UseVisualStyleBackColor = true;
            this.Lagranshz.Click += new System.EventHandler(this.Lagranshz_Click);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(492, 314);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(158, 20);
            this.xTextBox.TabIndex = 2;
            this.xTextBox.Text = "-2 0 2 3 4";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(492, 375);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(158, 20);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.Text = "18 12 7 -1 0";
            // 
            // Neuton
            // 
            this.Neuton.Location = new System.Drawing.Point(500, 200);
            this.Neuton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Neuton.Name = "Neuton";
            this.Neuton.Size = new System.Drawing.Size(122, 60);
            this.Neuton.TabIndex = 4;
            this.Neuton.Text = "Формула Ньютона";
            this.Neuton.UseVisualStyleBackColor = true;
            this.Neuton.Click += new System.EventHandler(this.Neuton_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(500, 25);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(122, 60);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Сохранение данных";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(20, 235);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series3";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.LabelForeColor = System.Drawing.Color.DarkGreen;
            series6.Legend = "Legend1";
            series6.Name = "Series4"; this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(418, 199);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Squares
            // 
            this.Squares.Location = new System.Drawing.Point(683, 235);
            this.Squares.Margin = new System.Windows.Forms.Padding(2);
            this.Squares.Name = "Squares";
            this.Squares.Size = new System.Drawing.Size(122, 60);
            this.Squares.TabIndex = 7;
            this.Squares.Text = "Квадраты";
            this.Squares.UseVisualStyleBackColor = true;
            this.Squares.Click += new System.EventHandler(this.Squares_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(702, 200);
            this.Square.Margin = new System.Windows.Forms.Padding(2);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(78, 20);
            this.Square.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 514);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Squares);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Neuton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.Lagranshz);
            this.Controls.Add(this.Graph);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Button Lagranshz;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button Neuton;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Squares;
        private System.Windows.Forms.TextBox Square;
    }
}