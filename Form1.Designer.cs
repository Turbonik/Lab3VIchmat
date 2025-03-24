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
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lagranshz = new System.Windows.Forms.Button();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.Neuton = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea3.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Graph.Legends.Add(legend3);
            this.Graph.Location = new System.Drawing.Point(27, 22);
            this.Graph.Name = "Graph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.Graph.Series.Add(series5);
            this.Graph.Series.Add(series6);
            this.Graph.Size = new System.Drawing.Size(492, 342);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // Lagranshz
            // 
            this.Lagranshz.Location = new System.Drawing.Point(667, 139);
            this.Lagranshz.Name = "Lagranshz";
            this.Lagranshz.Size = new System.Drawing.Size(162, 74);
            this.Lagranshz.TabIndex = 1;
            this.Lagranshz.Text = "Формула Лагранжа";
            this.Lagranshz.UseVisualStyleBackColor = true;
            this.Lagranshz.Click += new System.EventHandler(this.Lagranshz_Click);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(656, 387);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(210, 22);
            this.xTextBox.TabIndex = 2;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(656, 462);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(210, 22);
            this.yTextBox.TabIndex = 3;
            // 
            // Neuton
            // 
            this.Neuton.Location = new System.Drawing.Point(667, 246);
            this.Neuton.Name = "Neuton";
            this.Neuton.Size = new System.Drawing.Size(162, 74);
            this.Neuton.TabIndex = 4;
            this.Neuton.Text = "Формула Ньютона";
            this.Neuton.UseVisualStyleBackColor = true;
            this.Neuton.Click += new System.EventHandler(this.Neuton_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(667, 31);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(162, 74);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Сохранение данных";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 534);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Neuton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.Lagranshz);
            this.Controls.Add(this.Graph);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

