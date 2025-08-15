namespace Veri_Tabani_Parti_Secim_Grafik_İstatistik
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPartiB = new System.Windows.Forms.Label();
            this.lblPartiC = new System.Windows.Forms.Label();
            this.lblPartiD = new System.Windows.Forms.Label();
            this.lblPartiE = new System.Windows.Forms.Label();
            this.lblPartiA = new System.Windows.Forms.Label();
            this.prgressBarPartiE = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.prgrssBarPartiD = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.prgrssBarPartiC = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.prgrssBarPartiB = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.prgrssBarPartiA = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(986, 237);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPartiB);
            this.groupBox2.Controls.Add(this.lblPartiC);
            this.groupBox2.Controls.Add(this.lblPartiD);
            this.groupBox2.Controls.Add(this.lblPartiE);
            this.groupBox2.Controls.Add(this.lblPartiA);
            this.groupBox2.Controls.Add(this.prgressBarPartiE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.prgrssBarPartiD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.prgrssBarPartiC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.prgrssBarPartiB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prgrssBarPartiA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbIlce);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // lblPartiB
            // 
            this.lblPartiB.AutoSize = true;
            this.lblPartiB.Location = new System.Drawing.Point(674, 120);
            this.lblPartiB.Name = "lblPartiB";
            this.lblPartiB.Size = new System.Drawing.Size(23, 25);
            this.lblPartiB.TabIndex = 18;
            this.lblPartiB.Text = "0";
            // 
            // lblPartiC
            // 
            this.lblPartiC.AutoSize = true;
            this.lblPartiC.Location = new System.Drawing.Point(674, 163);
            this.lblPartiC.Name = "lblPartiC";
            this.lblPartiC.Size = new System.Drawing.Size(23, 25);
            this.lblPartiC.TabIndex = 17;
            this.lblPartiC.Text = "0";
            // 
            // lblPartiD
            // 
            this.lblPartiD.AutoSize = true;
            this.lblPartiD.Location = new System.Drawing.Point(674, 206);
            this.lblPartiD.Name = "lblPartiD";
            this.lblPartiD.Size = new System.Drawing.Size(23, 25);
            this.lblPartiD.TabIndex = 16;
            this.lblPartiD.Text = "0";
            // 
            // lblPartiE
            // 
            this.lblPartiE.AutoSize = true;
            this.lblPartiE.Location = new System.Drawing.Point(674, 249);
            this.lblPartiE.Name = "lblPartiE";
            this.lblPartiE.Size = new System.Drawing.Size(23, 25);
            this.lblPartiE.TabIndex = 15;
            this.lblPartiE.Text = "0";
            // 
            // lblPartiA
            // 
            this.lblPartiA.AutoSize = true;
            this.lblPartiA.Location = new System.Drawing.Point(674, 77);
            this.lblPartiA.Name = "lblPartiA";
            this.lblPartiA.Size = new System.Drawing.Size(23, 25);
            this.lblPartiA.TabIndex = 14;
            this.lblPartiA.Text = "0";
            // 
            // prgressBarPartiE
            // 
            this.prgressBarPartiE.Location = new System.Drawing.Point(194, 249);
            this.prgressBarPartiE.Maximum = 200;
            this.prgressBarPartiE.Name = "prgressBarPartiE";
            this.prgressBarPartiE.Size = new System.Drawing.Size(474, 37);
            this.prgressBarPartiE.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "E PARTİ:";
            // 
            // prgrssBarPartiD
            // 
            this.prgrssBarPartiD.Location = new System.Drawing.Point(194, 206);
            this.prgrssBarPartiD.Maximum = 200;
            this.prgrssBarPartiD.Name = "prgrssBarPartiD";
            this.prgrssBarPartiD.Size = new System.Drawing.Size(474, 37);
            this.prgrssBarPartiD.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "D PARTİ:";
            // 
            // prgrssBarPartiC
            // 
            this.prgrssBarPartiC.Location = new System.Drawing.Point(194, 163);
            this.prgrssBarPartiC.Maximum = 200;
            this.prgrssBarPartiC.Name = "prgrssBarPartiC";
            this.prgrssBarPartiC.Size = new System.Drawing.Size(474, 37);
            this.prgrssBarPartiC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "C PARTİ:";
            // 
            // prgrssBarPartiB
            // 
            this.prgrssBarPartiB.Location = new System.Drawing.Point(194, 120);
            this.prgrssBarPartiB.Maximum = 200;
            this.prgrssBarPartiB.Name = "prgrssBarPartiB";
            this.prgrssBarPartiB.Size = new System.Drawing.Size(474, 37);
            this.prgrssBarPartiB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // prgrssBarPartiA
            // 
            this.prgrssBarPartiA.Location = new System.Drawing.Point(194, 77);
            this.prgrssBarPartiA.Maximum = 200;
            this.prgrssBarPartiA.Name = "prgrssBarPartiA";
            this.prgrssBarPartiA.Size = new System.Drawing.Size(474, 37);
            this.prgrssBarPartiA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(194, 25);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(294, 32);
            this.cmbIlce.TabIndex = 1;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1016, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar prgrssBarPartiD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prgrssBarPartiC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar prgrssBarPartiB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgrssBarPartiA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgressBarPartiE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.Label lblPartiB;
        private System.Windows.Forms.Label lblPartiC;
        private System.Windows.Forms.Label lblPartiD;
        private System.Windows.Forms.Label lblPartiE;
        private System.Windows.Forms.Label lblPartiA;
    }
}