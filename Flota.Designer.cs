namespace Projekt
{
    partial class Flota
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izborSvi = new System.Windows.Forms.RadioButton();
            this.izborJedrilica = new System.Windows.Forms.RadioButton();
            this.izborKatamaran = new System.Windows.Forms.RadioButton();
            this.izborGliser = new System.Windows.Forms.RadioButton();
            this.cijene_uzlazno = new System.Windows.Forms.Button();
            this.cijene_silazno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 80);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(731, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biraj brod iz flote:";
            // 
            // izborSvi
            // 
            this.izborSvi.AutoSize = true;
            this.izborSvi.Location = new System.Drawing.Point(211, 13);
            this.izborSvi.Name = "izborSvi";
            this.izborSvi.Size = new System.Drawing.Size(41, 21);
            this.izborSvi.TabIndex = 2;
            this.izborSvi.TabStop = true;
            this.izborSvi.Text = "Svi";
            this.izborSvi.UseVisualStyleBackColor = true;
            this.izborSvi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // izborJedrilica
            // 
            this.izborJedrilica.AutoSize = true;
            this.izborJedrilica.Location = new System.Drawing.Point(317, 52);
            this.izborJedrilica.Name = "izborJedrilica";
            this.izborJedrilica.Size = new System.Drawing.Size(71, 21);
            this.izborJedrilica.TabIndex = 3;
            this.izborJedrilica.TabStop = true;
            this.izborJedrilica.Text = "Jedrilice";
            this.izborJedrilica.UseVisualStyleBackColor = true;
            this.izborJedrilica.CheckedChanged += new System.EventHandler(this.izborJedrilica_CheckedChanged);
            // 
            // izborKatamaran
            // 
            this.izborKatamaran.AutoSize = true;
            this.izborKatamaran.Location = new System.Drawing.Point(211, 52);
            this.izborKatamaran.Name = "izborKatamaran";
            this.izborKatamaran.Size = new System.Drawing.Size(92, 21);
            this.izborKatamaran.TabIndex = 4;
            this.izborKatamaran.TabStop = true;
            this.izborKatamaran.Text = "Katamarani";
            this.izborKatamaran.UseVisualStyleBackColor = true;
            this.izborKatamaran.CheckedChanged += new System.EventHandler(this.izborKatamaran_CheckedChanged);
            // 
            // izborGliser
            // 
            this.izborGliser.AutoSize = true;
            this.izborGliser.Location = new System.Drawing.Point(317, 13);
            this.izborGliser.Name = "izborGliser";
            this.izborGliser.Size = new System.Drawing.Size(61, 21);
            this.izborGliser.TabIndex = 5;
            this.izborGliser.TabStop = true;
            this.izborGliser.Text = "Gliseri";
            this.izborGliser.UseVisualStyleBackColor = true;
            this.izborGliser.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // cijene_uzlazno
            // 
            this.cijene_uzlazno.Location = new System.Drawing.Point(439, 12);
            this.cijene_uzlazno.Name = "cijene_uzlazno";
            this.cijene_uzlazno.Size = new System.Drawing.Size(199, 23);
            this.cijene_uzlazno.TabIndex = 6;
            this.cijene_uzlazno.Text = "Posloži cijene uzlazno";
            this.cijene_uzlazno.UseVisualStyleBackColor = true;
            this.cijene_uzlazno.Click += new System.EventHandler(this.cijene_uzlazno_Click);
            // 
            // cijene_silazno
            // 
            this.cijene_silazno.Location = new System.Drawing.Point(439, 50);
            this.cijene_silazno.Name = "cijene_silazno";
            this.cijene_silazno.Size = new System.Drawing.Size(199, 23);
            this.cijene_silazno.TabIndex = 7;
            this.cijene_silazno.Text = "Posloži cijene silazno";
            this.cijene_silazno.UseVisualStyleBackColor = true;
            this.cijene_silazno.Click += new System.EventHandler(this.cijene_silazno_Click);
            // 
            // Flota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 433);
            this.Controls.Add(this.cijene_silazno);
            this.Controls.Add(this.cijene_uzlazno);
            this.Controls.Add(this.izborGliser);
            this.Controls.Add(this.izborKatamaran);
            this.Controls.Add(this.izborJedrilica);
            this.Controls.Add(this.izborSvi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Flota";
            this.Text = "Flota";
            this.Load += new System.EventHandler(this.Flota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton izborSvi;
        private System.Windows.Forms.RadioButton izborJedrilica;
        private System.Windows.Forms.RadioButton izborKatamaran;
        private System.Windows.Forms.RadioButton izborGliser;
        private System.Windows.Forms.Button cijene_uzlazno;
        private System.Windows.Forms.Button cijene_silazno;
    }
}