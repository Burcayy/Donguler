namespace Donguler
{
    partial class Form5
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
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnekDort.Location = new System.Drawing.Point(12, 150);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(360, 40);
            this.btnOrnekDort.TabIndex = 17;
            this.btnOrnekDort.Text = "KONTROL DEĞİŞİMİ";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnekUc.Location = new System.Drawing.Point(12, 104);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(360, 40);
            this.btnOrnekUc.TabIndex = 16;
            this.btnOrnekUc.Text = "LİSTBOX1 => LİSTBOX2";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(195, 196);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(177, 212);
            this.listBox2.TabIndex = 15;
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnekIki.Location = new System.Drawing.Point(12, 58);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(360, 40);
            this.btnOrnekIki.TabIndex = 14;
            this.btnOrnekIki.Text = "İKİYE BÖLÜNENLER";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(177, 212);
            this.listBox1.TabIndex = 13;
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnekBir.Location = new System.Drawing.Point(12, 12);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(360, 40);
            this.btnOrnekBir.TabIndex = 12;
            this.btnOrnekBir.Text = "DİZİNİN ELEMANLARINI LİSTEYE AT";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 420);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnekBir);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOrnekBir;
    }
}