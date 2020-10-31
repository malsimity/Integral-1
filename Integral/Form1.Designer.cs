namespace Integral
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._tbMAX = new System.Windows.Forms.TextBox();
            this._tbMIN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._nudN = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._btCalculate = new System.Windows.Forms.Button();
            this._cbmMetod = new System.Windows.Forms.ComboBox();
            this._rtbResult = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this._nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // _tbMAX
            // 
            this._tbMAX.Location = new System.Drawing.Point(36, 34);
            this._tbMAX.Margin = new System.Windows.Forms.Padding(4);
            this._tbMAX.Name = "_tbMAX";
            this._tbMAX.Size = new System.Drawing.Size(132, 22);
            this._tbMAX.TabIndex = 0;
            this._tbMAX.Text = "143";
            // 
            // _tbMIN
            // 
            this._tbMIN.Location = new System.Drawing.Point(36, 87);
            this._tbMIN.Margin = new System.Windows.Forms.Padding(4);
            this._tbMIN.Name = "_tbMIN";
            this._tbMIN.Size = new System.Drawing.Size(132, 22);
            this._tbMIN.TabIndex = 1;
            this._tbMIN.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAX";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "MIN";
            // 
            // _nudN
            // 
            this._nudN.Location = new System.Drawing.Point(36, 181);
            this._nudN.Margin = new System.Windows.Forms.Padding(4);
            this._nudN.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this._nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudN.Name = "_nudN";
            this._nudN.Size = new System.Drawing.Size(160, 22);
            this._nudN.TabIndex = 4;
            this._nudN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество шагов";
            // 
            // _btCalculate
            // 
            this._btCalculate.Location = new System.Drawing.Point(52, 287);
            this._btCalculate.Margin = new System.Windows.Forms.Padding(4);
            this._btCalculate.Name = "_btCalculate";
            this._btCalculate.Size = new System.Drawing.Size(100, 28);
            this._btCalculate.TabIndex = 6;
            this._btCalculate.Text = "Расчитать";
            this._btCalculate.UseVisualStyleBackColor = true;
            this._btCalculate.Click += new System.EventHandler(this._btCalculate_Click);
            // 
            // _cbmMetod
            // 
            this._cbmMetod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbmMetod.FormattingEnabled = true;
            this._cbmMetod.Items.AddRange(new object[] {
            "Метод трапеции",
            "Метод прямоугольника"});
            this._cbmMetod.Location = new System.Drawing.Point(238, 34);
            this._cbmMetod.Margin = new System.Windows.Forms.Padding(4);
            this._cbmMetod.Name = "_cbmMetod";
            this._cbmMetod.Size = new System.Drawing.Size(160, 24);
            this._cbmMetod.TabIndex = 7;
            // 
            // _rtbResult
            // 
            this._rtbResult.Location = new System.Drawing.Point(40, 335);
            this._rtbResult.Margin = new System.Windows.Forms.Padding(4);
            this._rtbResult.Name = "_rtbResult";
            this._rtbResult.ReadOnly = true;
            this._rtbResult.Size = new System.Drawing.Size(292, 203);
            this._rtbResult.TabIndex = 8;
            this._rtbResult.Text = "";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(431, 34);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(610, 438);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this._rtbResult);
            this.Controls.Add(this._cbmMetod);
            this.Controls.Add(this._btCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._nudN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbMIN);
            this.Controls.Add(this._tbMAX);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Баринов Н. 3-47";
            ((System.ComponentModel.ISupportInitialize)(this._nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbMAX;
        private System.Windows.Forms.TextBox _tbMIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _nudN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btCalculate;
        private System.Windows.Forms.ComboBox _cbmMetod;
        private System.Windows.Forms.RichTextBox _rtbResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

