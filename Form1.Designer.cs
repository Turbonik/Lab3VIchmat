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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lagranshz = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.Neuton = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Squares = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.coefs = new System.Windows.Forms.TextBox();
            this.coef = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea5.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Graph.Legends.Add(legend5);
            this.Graph.Location = new System.Drawing.Point(12, 11);
            this.Graph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Graph.Name = "Graph";
            series29.BorderWidth = 5;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Legend = "Legend1";
            series29.Name = "Интерполяция Лагранжа";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Legend = "Legend1";
            series30.MarkerSize = 22;
            series30.Name = "Интерполяция Ньютона";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series31.Legend = "Legend1";
            series31.Name = "Сглаживание 1 степени";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series32.Legend = "Legend1";
            series32.Name = "Сглаживание 2 степени";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Legend = "Legend1";
            series33.Name = "Сглаживание 3 степени";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.Legend = "Legend1";
            series34.Name = "Многочлен 4 степени";
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series35.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series35.Legend = "Legend1";
            series35.Name = "Исходные точки";
            this.Graph.Series.Add(series29);
            this.Graph.Series.Add(series30);
            this.Graph.Series.Add(series31);
            this.Graph.Series.Add(series32);
            this.Graph.Series.Add(series33);
            this.Graph.Series.Add(series34);
            this.Graph.Series.Add(series35);
            this.Graph.Size = new System.Drawing.Size(803, 386);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // Lagranshz
            // 
            this.Lagranshz.Location = new System.Drawing.Point(29, 422);
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
            this.xTextBox.Location = new System.Drawing.Point(1018, 31);
            this.xTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(209, 22);
            this.xTextBox.TabIndex = 2;
            this.xTextBox.Text = "-2 0 2 3 4";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(1018, 87);
            this.yTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(209, 22);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.Text = "18 12 7 -1 0";
            // 
            // Neuton
            // 
            this.Neuton.Location = new System.Drawing.Point(230, 422);
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
            this.Save_Button.Location = new System.Drawing.Point(909, 141);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(232, 74);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Сохранение данных";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Squares
            // 
            this.Squares.Location = new System.Drawing.Point(43, 551);
            this.Squares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Squares.Name = "Squares";
            this.Squares.Size = new System.Drawing.Size(373, 74);
            this.Squares.TabIndex = 7;
            this.Squares.Text = "Построить сглаживающий многочлен";
            this.Squares.UseVisualStyleBackColor = true;
            this.Squares.Click += new System.EventHandler(this.Squares_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(353, 504);
            this.Square.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(103, 22);
            this.Square.TabIndex = 8;
            this.Square.Text = " ";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(486, 648);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 16);
            this.text.TabIndex = 9;
            // 
            // coefs
            // 
            this.coefs.Location = new System.Drawing.Point(893, 501);
            this.coefs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coefs.Name = "coefs";
            this.coefs.Size = new System.Drawing.Size(236, 22);
            this.coefs.TabIndex = 10;
            this.coefs.Text = "0.3292 -1.3792 -1.1917 2.7667 12.0000";
            // 
            // coef
            // 
            this.coef.Location = new System.Drawing.Point(657, 551);
            this.coef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coef.Name = "coef";
            this.coef.Size = new System.Drawing.Size(325, 74);
            this.coef.TabIndex = 11;
            this.coef.Text = "Построить интерполяционный многочлен";
            this.coef.UseVisualStyleBackColor = true;
            this.coef.Click += new System.EventHandler(this.coef_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(862, 256);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(315, 182);
            this.Clear_button.TabIndex = 12;
            this.Clear_button.Text = "Очистить график";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Степень сглаживающего многочлена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(821, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Набор аргументов x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(821, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Набор значений f(x):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(473, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Коэффиценты интерполяционного многочлена 4-й степени:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(56, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Коэффиценты текущей степени сглаживающего многочлена:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.coef);
            this.Controls.Add(this.coefs);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Squares);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Neuton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.Lagranshz);
            this.Controls.Add(this.Graph);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Аппроксимация функций";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
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
        private System.Windows.Forms.Button Squares;
        private System.Windows.Forms.TextBox Square;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox coefs;
        private System.Windows.Forms.Button coef;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}