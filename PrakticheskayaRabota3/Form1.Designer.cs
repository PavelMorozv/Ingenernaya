namespace PrakticheskayaRabota3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelOutPut = new System.Windows.Forms.Label();
            this.UpDownK = new System.Windows.Forms.NumericUpDown();
            this.UpDownNmin = new System.Windows.Forms.NumericUpDown();
            this.UpDownN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpDownMin = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.UpDownMin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LabelOutPut);
            this.panel1.Controls.Add(this.UpDownK);
            this.panel1.Controls.Add(this.UpDownNmin);
            this.panel1.Controls.Add(this.UpDownN);
            this.panel1.Location = new System.Drawing.Point(163, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 225);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(28, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "если N mod K = 0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "2) Поделить N на K:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(34, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "1) Вычесть из N:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(86, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число N:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(7, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelOutPut
            // 
            this.LabelOutPut.AutoSize = true;
            this.LabelOutPut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutPut.ForeColor = System.Drawing.Color.Black;
            this.LabelOutPut.Location = new System.Drawing.Point(179, 176);
            this.LabelOutPut.Name = "LabelOutPut";
            this.LabelOutPut.Size = new System.Drawing.Size(17, 19);
            this.LabelOutPut.TabIndex = 3;
            this.LabelOutPut.Text = "0";
            // 
            // UpDownK
            // 
            this.UpDownK.BackColor = System.Drawing.Color.DarkGray;
            this.UpDownK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownK.ForeColor = System.Drawing.Color.Black;
            this.UpDownK.Location = new System.Drawing.Point(164, 76);
            this.UpDownK.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpDownK.Name = "UpDownK";
            this.UpDownK.Size = new System.Drawing.Size(57, 27);
            this.UpDownK.TabIndex = 2;
            this.UpDownK.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UpDownK.ValueChanged += new System.EventHandler(this.UpDownK_ValueChanged);
            // 
            // UpDownNmin
            // 
            this.UpDownNmin.BackColor = System.Drawing.Color.DarkGray;
            this.UpDownNmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownNmin.ForeColor = System.Drawing.Color.Black;
            this.UpDownNmin.Location = new System.Drawing.Point(164, 44);
            this.UpDownNmin.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownNmin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownNmin.Name = "UpDownNmin";
            this.UpDownNmin.Size = new System.Drawing.Size(57, 27);
            this.UpDownNmin.TabIndex = 1;
            this.UpDownNmin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownNmin.ValueChanged += new System.EventHandler(this.UpDownNmin_ValueChanged);
            // 
            // UpDownN
            // 
            this.UpDownN.BackColor = System.Drawing.Color.DarkGray;
            this.UpDownN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownN.ForeColor = System.Drawing.Color.Black;
            this.UpDownN.Location = new System.Drawing.Point(164, 13);
            this.UpDownN.Name = "UpDownN";
            this.UpDownN.Size = new System.Drawing.Size(57, 27);
            this.UpDownN.TabIndex = 0;
            this.UpDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименьшее число шагов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(36, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Число шагов до";
            // 
            // UpDownMin
            // 
            this.UpDownMin.BackColor = System.Drawing.Color.DarkGray;
            this.UpDownMin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDownMin.ForeColor = System.Drawing.Color.Black;
            this.UpDownMin.Location = new System.Drawing.Point(164, 114);
            this.UpDownMin.Name = "UpDownMin";
            this.UpDownMin.Size = new System.Drawing.Size(57, 27);
            this.UpDownMin.TabIndex = 9;
            this.UpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownMin.ValueChanged += new System.EventHandler(this.UpDownMin_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::PrakticheskayaRabota3.Properties.Resources._5b9e4aafc9278731da6c4f92;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelOutPut;
        private System.Windows.Forms.NumericUpDown UpDownK;
        private System.Windows.Forms.NumericUpDown UpDownNmin;
        private System.Windows.Forms.NumericUpDown UpDownN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UpDownMin;
    }
}

