namespace lab7
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.PSNum = new System.Windows.Forms.NumericUpDown();
            this.SDFGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.TPNUm = new System.Windows.Forms.NumericUpDown();
            this.SPDNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PSNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDFGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPNUm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPDNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programer\'s skills";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // PSNum
            // 
            this.PSNum.Location = new System.Drawing.Point(202, 15);
            this.PSNum.Name = "PSNum";
            this.PSNum.Size = new System.Drawing.Size(120, 20);
            this.PSNum.TabIndex = 2;
            this.PSNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SDFGraf
            // 
            chartArea1.Name = "ChartArea1";
            this.SDFGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SDFGraf.Legends.Add(legend1);
            this.SDFGraf.Location = new System.Drawing.Point(379, 12);
            this.SDFGraf.Name = "SDFGraf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Software functionality";
            this.SDFGraf.Series.Add(series1);
            this.SDFGraf.Size = new System.Drawing.Size(694, 398);
            this.SDFGraf.TabIndex = 3;
            this.SDFGraf.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team productivity ( 1- max)";
            // 
            // TPNUm
            // 
            this.TPNUm.Location = new System.Drawing.Point(202, 113);
            this.TPNUm.Name = "TPNUm";
            this.TPNUm.Size = new System.Drawing.Size(120, 20);
            this.TPNUm.TabIndex = 6;
            this.TPNUm.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // SPDNum
            // 
            this.SPDNum.Location = new System.Drawing.Point(202, 64);
            this.SPDNum.Name = "SPDNum";
            this.SPDNum.Size = new System.Drawing.Size(120, 20);
            this.SPDNum.TabIndex = 7;
            this.SPDNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shedule pressure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SPDNum);
            this.Controls.Add(this.TPNUm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SDFGraf);
            this.Controls.Add(this.PSNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Разработка ПО";
            ((System.ComponentModel.ISupportInitialize)(this.PSNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SDFGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPNUm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPDNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.NumericUpDown PSNum;
        private System.Windows.Forms.DataVisualization.Charting.Chart SDFGraf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TPNUm;
        private System.Windows.Forms.NumericUpDown SPDNum;
        private System.Windows.Forms.Label label3;
    }
}

