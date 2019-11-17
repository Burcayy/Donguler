namespace Donguler
{
    partial class Form4
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
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.lblYaziAlani = new System.Windows.Forms.Label();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrnekBes.ForeColor = System.Drawing.Color.White;
            this.btnOrnekBes.Location = new System.Drawing.Point(12, 184);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(220, 40);
            this.btnOrnekBes.TabIndex = 33;
            this.btnOrnekBes.Text = "ÇARPIM TABLOSU";
            this.btnOrnekBes.UseVisualStyleBackColor = false;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(238, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 355);
            this.listBox1.TabIndex = 32;
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrnekDort.ForeColor = System.Drawing.Color.White;
            this.btnOrnekDort.Location = new System.Drawing.Point(12, 141);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(220, 40);
            this.btnOrnekDort.TabIndex = 31;
            this.btnOrnekDort.Text = "X İLE DİKKENAR ÜÇGEN";
            this.btnOrnekDort.UseVisualStyleBackColor = false;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "X İLE KARE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrnekIki.ForeColor = System.Drawing.Color.White;
            this.btnOrnekIki.Location = new System.Drawing.Point(12, 55);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(220, 40);
            this.btnOrnekIki.TabIndex = 29;
            this.btnOrnekIki.Text = "ALT ALTA X";
            this.btnOrnekIki.UseVisualStyleBackColor = false;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // lblYaziAlani
            // 
            this.lblYaziAlani.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblYaziAlani.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblYaziAlani.ForeColor = System.Drawing.Color.White;
            this.lblYaziAlani.Location = new System.Drawing.Point(12, 227);
            this.lblYaziAlani.Name = "lblYaziAlani";
            this.lblYaziAlani.Size = new System.Drawing.Size(220, 178);
            this.lblYaziAlani.TabIndex = 28;
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrnekBir.ForeColor = System.Drawing.Color.White;
            this.btnOrnekBir.Location = new System.Drawing.Point(12, 12);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(220, 40);
            this.btnOrnekBir.TabIndex = 27;
            this.btnOrnekBir.Text = "YAN YANA X";
            this.btnOrnekBir.UseVisualStyleBackColor = false;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(238, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 30);
            this.textBox1.TabIndex = 34;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.lblYaziAlani);
            this.Controls.Add(this.btnOrnekBir);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Label lblYaziAlani;
        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.TextBox textBox1;
    }
}