namespace WinFormUI
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenButton = new System.Windows.Forms.Button();
            this.BuildChartButton = new System.Windows.Forms.Button();
            this.periodTextBox = new System.Windows.Forms.TextBox();
            this.periodLabel = new System.Windows.Forms.Label();
            this.typeRateLabel = new System.Windows.Forms.Label();
            this.typeRateComboBox = new System.Windows.Forms.ComboBox();
            this.parametrEmaTextBox = new System.Windows.Forms.TextBox();
            this.parametrEmaLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(988, 451);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(1125, 440);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // BuildChartButton
            // 
            this.BuildChartButton.Location = new System.Drawing.Point(1126, 170);
            this.BuildChartButton.Name = "BuildChartButton";
            this.BuildChartButton.Size = new System.Drawing.Size(75, 43);
            this.BuildChartButton.TabIndex = 2;
            this.BuildChartButton.Text = "Построить график";
            this.BuildChartButton.UseVisualStyleBackColor = true;
            this.BuildChartButton.Click += new System.EventHandler(this.BuildChartButton_Click);
            // 
            // periodTextBox
            // 
            this.periodTextBox.Location = new System.Drawing.Point(1100, 23);
            this.periodTextBox.Name = "periodTextBox";
            this.periodTextBox.Size = new System.Drawing.Size(100, 20);
            this.periodTextBox.TabIndex = 3;
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(1006, 26);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(89, 13);
            this.periodLabel.TabIndex = 4;
            this.periodLabel.Text = "Период (в днях):";
            // 
            // typeRateLabel
            // 
            this.typeRateLabel.AutoSize = true;
            this.typeRateLabel.Location = new System.Drawing.Point(1037, 65);
            this.typeRateLabel.Name = "typeRateLabel";
            this.typeRateLabel.Size = new System.Drawing.Size(58, 13);
            this.typeRateLabel.TabIndex = 5;
            this.typeRateLabel.Text = "Вид цены:";
            // 
            // typeRateComboBox
            // 
            this.typeRateComboBox.FormattingEnabled = true;
            this.typeRateComboBox.Location = new System.Drawing.Point(1101, 62);
            this.typeRateComboBox.Name = "typeRateComboBox";
            this.typeRateComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeRateComboBox.TabIndex = 6;
            // 
            // parametrEmaTextBox
            // 
            this.parametrEmaTextBox.Location = new System.Drawing.Point(1101, 126);
            this.parametrEmaTextBox.Name = "parametrEmaTextBox";
            this.parametrEmaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parametrEmaTextBox.TabIndex = 7;
            // 
            // parametrEmaLabel
            // 
            this.parametrEmaLabel.AutoSize = true;
            this.parametrEmaLabel.Location = new System.Drawing.Point(1006, 110);
            this.parametrEmaLabel.Name = "parametrEmaLabel";
            this.parametrEmaLabel.Size = new System.Drawing.Size(200, 13);
            this.parametrEmaLabel.TabIndex = 8;
            this.parametrEmaLabel.Text = "Доля использования цены (для EMA):";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1024, 170);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(71, 43);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Удалить график";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 475);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.parametrEmaLabel);
            this.Controls.Add(this.parametrEmaTextBox);
            this.Controls.Add(this.typeRateComboBox);
            this.Controls.Add(this.typeRateLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.periodTextBox);
            this.Controls.Add(this.BuildChartButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button BuildChartButton;
        private System.Windows.Forms.TextBox periodTextBox;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label typeRateLabel;
        private System.Windows.Forms.ComboBox typeRateComboBox;
        private System.Windows.Forms.TextBox parametrEmaTextBox;
        private System.Windows.Forms.Label parametrEmaLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

