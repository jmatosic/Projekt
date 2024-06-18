namespace Projekt
{
    partial class Skiperi
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sviIzbor = new System.Windows.Forms.RadioButton();
            this.zeneIzbor = new System.Windows.Forms.RadioButton();
            this.muskiIzbor = new System.Windows.Forms.RadioButton();
            this.godine_silazno = new System.Windows.Forms.Button();
            this.godine_uzalzno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biraj skipera:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(13, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(731, 325);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // sviIzbor
            // 
            this.sviIzbor.AutoSize = true;
            this.sviIzbor.Location = new System.Drawing.Point(174, 34);
            this.sviIzbor.Name = "sviIzbor";
            this.sviIzbor.Size = new System.Drawing.Size(41, 21);
            this.sviIzbor.TabIndex = 4;
            this.sviIzbor.TabStop = true;
            this.sviIzbor.Text = "Svi";
            this.sviIzbor.UseVisualStyleBackColor = true;
            this.sviIzbor.CheckedChanged += new System.EventHandler(this.sviIzbor_CheckedChanged);
            // 
            // zeneIzbor
            // 
            this.zeneIzbor.AutoSize = true;
            this.zeneIzbor.Location = new System.Drawing.Point(304, 34);
            this.zeneIzbor.Name = "zeneIzbor";
            this.zeneIzbor.Size = new System.Drawing.Size(54, 21);
            this.zeneIzbor.TabIndex = 5;
            this.zeneIzbor.TabStop = true;
            this.zeneIzbor.Text = "Žene";
            this.zeneIzbor.UseVisualStyleBackColor = true;
            this.zeneIzbor.CheckedChanged += new System.EventHandler(this.zeneIzbor_CheckedChanged);
            // 
            // muskiIzbor
            // 
            this.muskiIzbor.AutoSize = true;
            this.muskiIzbor.Location = new System.Drawing.Point(221, 34);
            this.muskiIzbor.Name = "muskiIzbor";
            this.muskiIzbor.Size = new System.Drawing.Size(77, 21);
            this.muskiIzbor.TabIndex = 6;
            this.muskiIzbor.TabStop = true;
            this.muskiIzbor.Text = "Muškarci";
            this.muskiIzbor.UseVisualStyleBackColor = true;
            this.muskiIzbor.CheckedChanged += new System.EventHandler(this.muskiIzbor_CheckedChanged);
            // 
            // godine_silazno
            // 
            this.godine_silazno.Location = new System.Drawing.Point(413, 13);
            this.godine_silazno.Name = "godine_silazno";
            this.godine_silazno.Size = new System.Drawing.Size(233, 23);
            this.godine_silazno.TabIndex = 7;
            this.godine_silazno.Text = "Složi godine staža silazno";
            this.godine_silazno.UseVisualStyleBackColor = true;
            this.godine_silazno.Click += new System.EventHandler(this.godine_silazno_Click);
            // 
            // godine_uzalzno
            // 
            this.godine_uzalzno.Location = new System.Drawing.Point(413, 46);
            this.godine_uzalzno.Name = "godine_uzalzno";
            this.godine_uzalzno.Size = new System.Drawing.Size(233, 23);
            this.godine_uzalzno.TabIndex = 8;
            this.godine_uzalzno.Text = "Složi godine staža uzlazno";
            this.godine_uzalzno.UseVisualStyleBackColor = true;
            this.godine_uzalzno.Click += new System.EventHandler(this.godine_uzalzno_Click);
            // 
            // Skiperi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 433);
            this.Controls.Add(this.godine_uzalzno);
            this.Controls.Add(this.godine_silazno);
            this.Controls.Add(this.muskiIzbor);
            this.Controls.Add(this.zeneIzbor);
            this.Controls.Add(this.sviIzbor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Skiperi";
            this.Text = "Skiperi";
            this.Load += new System.EventHandler(this.Skiperi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton sviIzbor;
        private System.Windows.Forms.RadioButton zeneIzbor;
        private System.Windows.Forms.RadioButton muskiIzbor;
        private System.Windows.Forms.Button godine_silazno;
        private System.Windows.Forms.Button godine_uzalzno;
    }
}