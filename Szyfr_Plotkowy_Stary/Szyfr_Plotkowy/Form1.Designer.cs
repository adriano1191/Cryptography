namespace Szyfr_Plotkowy
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
            this.textBoxTekst = new System.Windows.Forms.TextBox();
            this.textBoxSzyfr = new System.Windows.Forms.TextBox();
            this.labelTekst = new System.Windows.Forms.Label();
            this.labelSzyfr = new System.Windows.Forms.Label();
            this.buttonDeszyfruj = new System.Windows.Forms.Button();
            this.buttonSzyfruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTekst
            // 
            this.textBoxTekst.Location = new System.Drawing.Point(12, 25);
            this.textBoxTekst.Name = "textBoxTekst";
            this.textBoxTekst.Size = new System.Drawing.Size(179, 20);
            this.textBoxTekst.TabIndex = 0;
            // 
            // textBoxSzyfr
            // 
            this.textBoxSzyfr.Location = new System.Drawing.Point(12, 65);
            this.textBoxSzyfr.Name = "textBoxSzyfr";
            this.textBoxSzyfr.Size = new System.Drawing.Size(179, 20);
            this.textBoxSzyfr.TabIndex = 1;
            // 
            // labelTekst
            // 
            this.labelTekst.AutoSize = true;
            this.labelTekst.Location = new System.Drawing.Point(12, 9);
            this.labelTekst.Name = "labelTekst";
            this.labelTekst.Size = new System.Drawing.Size(34, 13);
            this.labelTekst.TabIndex = 2;
            this.labelTekst.Text = "Tekst";
            // 
            // labelSzyfr
            // 
            this.labelSzyfr.AutoSize = true;
            this.labelSzyfr.Location = new System.Drawing.Point(12, 49);
            this.labelSzyfr.Name = "labelSzyfr";
            this.labelSzyfr.Size = new System.Drawing.Size(30, 13);
            this.labelSzyfr.TabIndex = 3;
            this.labelSzyfr.Text = "Szyfr";
            // 
            // buttonDeszyfruj
            // 
            this.buttonDeszyfruj.Location = new System.Drawing.Point(197, 65);
            this.buttonDeszyfruj.Name = "buttonDeszyfruj";
            this.buttonDeszyfruj.Size = new System.Drawing.Size(75, 23);
            this.buttonDeszyfruj.TabIndex = 5;
            this.buttonDeszyfruj.Text = "Deszyfruj";
            this.buttonDeszyfruj.UseVisualStyleBackColor = true;
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.Location = new System.Drawing.Point(197, 25);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(75, 23);
            this.buttonSzyfruj.TabIndex = 6;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = true;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSzyfruj);
            this.Controls.Add(this.buttonDeszyfruj);
            this.Controls.Add(this.labelSzyfr);
            this.Controls.Add(this.labelTekst);
            this.Controls.Add(this.textBoxSzyfr);
            this.Controls.Add(this.textBoxTekst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTekst;
        private System.Windows.Forms.TextBox textBoxSzyfr;
        private System.Windows.Forms.Label labelTekst;
        private System.Windows.Forms.Label labelSzyfr;
        private System.Windows.Forms.Button buttonDeszyfruj;
        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

