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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lagranshz = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.Neuton = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Squares = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea3.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Graph.Legends.Add(legend3);
            this.Graph.Location = new System.Drawing.Point(27, 22);
            this.Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graph.Name = "Graph";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.Graph.Series.Add(series7);
            this.Graph.Series.Add(series8);
            this.Graph.Size = new System.Drawing.Size(557, 245);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // Lagranshz
            // 
            this.Lagranshz.Location = new System.Drawing.Point(667, 139);
            this.Lagranshz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lagranshz.Name = "Lagranshz";
            this.Lagranshz.Size = new System.Drawing.Size(163, 74);
            this.Lagranshz.TabIndex = 1;
            this.Lagranshz.Text = "Формула Лагранжа";
            this.Lagranshz.UseVisualStyleBackColor = true;
            this.Lagranshz.Click += new System.EventHandler(this.Lagranshz_Click);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(656, 386);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(209, 22);
            this.xTextBox.TabIndex = 2;
            this.xTextBox.Text = "-2 0 2 3 4";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(656, 462);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(209, 22);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.Text = "18 12 7 -1 0";
            // 
            // Neuton
            // 
            this.Neuton.Location = new System.Drawing.Point(667, 246);
            this.Neuton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Neuton.Name = "Neuton";
            this.Neuton.Size = new System.Drawing.Size(163, 74);
            this.Neuton.TabIndex = 4;
            this.Neuton.Text = "Формула Ньютона";
            this.Neuton.UseVisualStyleBackColor = true;
            this.Neuton.Click += new System.EventHandler(this.Neuton_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(667, 31);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(163, 74);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Сохранение данных";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(27, 289);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Series3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.LabelForeColor = System.Drawing.Color.DarkGreen;
            series12.Legend = "Legend1";
            series12.Name = "Series4";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(557, 245);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Squares
            // 
            this.Squares.Location = new System.Drawing.Point(911, 289);
            this.Squares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Squares.Name = "Squares";
            this.Squares.Size = new System.Drawing.Size(163, 74);
            this.Squares.TabIndex = 7;
            this.Squares.Text = "Квадраты";
            this.Squares.UseVisualStyleBackColor = true;
            this.Squares.Click += new System.EventHandler(this.Squares_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(936, 246);
            this.Square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(103, 22);
            this.Square.TabIndex = 8;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(653, 551);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 16);
            this.text.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 633);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Squares);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Neuton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.Lagranshz);
            this.Controls.Add(this.Graph);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label text;
    }
}