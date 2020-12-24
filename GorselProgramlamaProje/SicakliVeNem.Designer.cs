
namespace GorselProgramlamaProje
{
    partial class SicakliVeNem
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
            this.btnSicaklik = new System.Windows.Forms.Button();
            this.btnNem = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ctrlSicaklik1 = new GorselProgramlamaProje.ctrlSicaklik();
            this.ctrlNem1 = new GorselProgramlamaProje.ctrlNem();
            this.SuspendLayout();
            // 
            // btnSicaklik
            // 
            this.btnSicaklik.Location = new System.Drawing.Point(12, 127);
            this.btnSicaklik.Name = "btnSicaklik";
            this.btnSicaklik.Size = new System.Drawing.Size(179, 127);
            this.btnSicaklik.TabIndex = 0;
            this.btnSicaklik.Text = "SICAKLIK";
            this.btnSicaklik.UseVisualStyleBackColor = true;
            this.btnSicaklik.Click += new System.EventHandler(this.btnSicaklik_Click);
            // 
            // btnNem
            // 
            this.btnNem.Location = new System.Drawing.Point(12, 293);
            this.btnNem.Name = "btnNem";
            this.btnNem.Size = new System.Drawing.Size(179, 127);
            this.btnNem.TabIndex = 1;
            this.btnNem.Text = "NEM";
            this.btnNem.UseVisualStyleBackColor = true;
            this.btnNem.Click += new System.EventHandler(this.btnNem_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(12, 31);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(82, 61);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(109, 31);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(82, 61);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlSicaklik1
            // 
            this.ctrlSicaklik1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlSicaklik1.Location = new System.Drawing.Point(197, 29);
            this.ctrlSicaklik1.Name = "ctrlSicaklik1";
            this.ctrlSicaklik1.Size = new System.Drawing.Size(1073, 566);
            this.ctrlSicaklik1.TabIndex = 5;
            // 
            // ctrlNem1
            // 
            this.ctrlNem1.Location = new System.Drawing.Point(197, 29);
            this.ctrlNem1.Name = "ctrlNem1";
            this.ctrlNem1.Size = new System.Drawing.Size(1073, 566);
            this.ctrlNem1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 607);
            this.Controls.Add(this.ctrlNem1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnNem);
            this.Controls.Add(this.btnSicaklik);
            this.Controls.Add(this.ctrlSicaklik1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSicaklik;
        private System.Windows.Forms.Button btnNem;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Timer timer1;
        private ctrlNem ctrlNem1;
        private ctrlSicaklik ctrlSicaklik1;
    }
}

