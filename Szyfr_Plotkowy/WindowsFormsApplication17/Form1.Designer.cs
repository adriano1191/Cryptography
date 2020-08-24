namespace WindowsFormsApplication17
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonOtwórz = new System.Windows.Forms.Button();
            this.buttonSzyfrowanie = new System.Windows.Forms.Button();
            this.buttonDeszyfrowanie = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Szyfrowanie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Deszyfrowanie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(50, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Klucz";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 146);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 17);
            this.textBox3.TabIndex = 9;
            // 
            // buttonOtwórz
            // 
            this.buttonOtwórz.Location = new System.Drawing.Point(12, 235);
            this.buttonOtwórz.Name = "buttonOtwórz";
            this.buttonOtwórz.Size = new System.Drawing.Size(75, 23);
            this.buttonOtwórz.TabIndex = 10;
            this.buttonOtwórz.Text = "Otwórz";
            this.buttonOtwórz.UseVisualStyleBackColor = true;
            this.buttonOtwórz.Click += new System.EventHandler(this.buttonOtwórz_Click);
            // 
            // buttonSzyfrowanie
            // 
            this.buttonSzyfrowanie.Location = new System.Drawing.Point(13, 117);
            this.buttonSzyfrowanie.Name = "buttonSzyfrowanie";
            this.buttonSzyfrowanie.Size = new System.Drawing.Size(75, 23);
            this.buttonSzyfrowanie.TabIndex = 11;
            this.buttonSzyfrowanie.Text = "Szyfrowanie";
            this.buttonSzyfrowanie.UseVisualStyleBackColor = true;
            this.buttonSzyfrowanie.Click += new System.EventHandler(this.buttonSzyfrowanie_Click);
            // 
            // buttonDeszyfrowanie
            // 
            this.buttonDeszyfrowanie.Location = new System.Drawing.Point(94, 117);
            this.buttonDeszyfrowanie.Name = "buttonDeszyfrowanie";
            this.buttonDeszyfrowanie.Size = new System.Drawing.Size(75, 23);
            this.buttonDeszyfrowanie.TabIndex = 12;
            this.buttonDeszyfrowanie.Text = "Deszyfrowanie";
            this.buttonDeszyfrowanie.UseVisualStyleBackColor = true;
            this.buttonDeszyfrowanie.Click += new System.EventHandler(this.buttonDeszyfrowanie_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(175, 56);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 310);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonDeszyfrowanie);
            this.Controls.Add(this.buttonSzyfrowanie);
            this.Controls.Add(this.buttonOtwórz);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonOtwórz;
        private System.Windows.Forms.Button buttonSzyfrowanie;
        private System.Windows.Forms.Button buttonDeszyfrowanie;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

