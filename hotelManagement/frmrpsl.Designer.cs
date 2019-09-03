namespace login
{
    partial class frmrpsl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrpsl));
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnclr = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnfc = new System.Windows.Forms.Button();
            this.PaymenttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnch = new System.Windows.Forms.Button();
            this.DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblrs = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymenttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(25, 212);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(99, 20);
            this.dtp1.TabIndex = 162;
            this.dtp1.Value = new System.DateTime(2016, 6, 20, 22, 3, 56, 0);
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclr.Location = new System.Drawing.Point(25, 86);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(167, 28);
            this.btnclr.TabIndex = 163;
            this.btnclr.Text = "Change button color";
            this.btnclr.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button2.Location = new System.Drawing.Point(25, 253);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 28);
            this.Button2.TabIndex = 161;
            this.Button2.Text = "view";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // btnfc
            // 
            this.btnfc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfc.Location = new System.Drawing.Point(25, 115);
            this.btnfc.Name = "btnfc";
            this.btnfc.Size = new System.Drawing.Size(167, 28);
            this.btnfc.TabIndex = 164;
            this.btnfc.Text = "Change button font color";
            this.btnfc.UseVisualStyleBackColor = true;
            // 
            // PaymenttblBindingSource
            // 
            this.PaymenttblBindingSource.DataMember = "Paymenttbl";
            // 
            // btnch
            // 
            this.btnch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnch.Location = new System.Drawing.Point(25, 57);
            this.btnch.Name = "btnch";
            this.btnch.Size = new System.Drawing.Size(167, 28);
            this.btnch.TabIndex = 160;
            this.btnch.Text = "Change window color";
            this.btnch.UseVisualStyleBackColor = true;
            // 
            // lblrs
            // 
            this.lblrs.AutoSize = true;
            this.lblrs.BackColor = System.Drawing.Color.White;
            this.lblrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrs.ForeColor = System.Drawing.Color.Black;
            this.lblrs.Location = new System.Drawing.Point(35, 152);
            this.lblrs.Name = "lblrs";
            this.lblrs.Size = new System.Drawing.Size(89, 19);
            this.lblrs.TabIndex = 165;
            this.lblrs.Text = "Reset colors";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(276, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(394, 425);
            this.chart1.TabIndex = 166;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 41);
            this.button1.TabIndex = 167;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmrpsl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnfc);
            this.Controls.Add(this.btnch);
            this.Controls.Add(this.lblrs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrpsl";
            this.Text = "Club Palm Bay Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.PaymenttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtp1;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.Button btnclr;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btnfc;
        internal System.Windows.Forms.BindingSource PaymenttblBindingSource;
        internal System.Windows.Forms.Button btnch;
        internal System.Windows.Forms.BindingSource DataSet1BindingSource;
        internal System.Windows.Forms.Label lblrs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}