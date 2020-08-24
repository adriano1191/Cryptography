namespace Szyfr_Cezara
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
            this.textBoxSlowo = new System.Windows.Forms.TextBox();
            this.buttonDeszyfruj = new System.Windows.Forms.Button();
            this.buttonSzyfr = new System.Windows.Forms.Button();
            this.textBoxDeszyfr = new System.Windows.Forms.TextBox();
            this.labelAlfabet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSlowo
            // 
            this.textBoxSlowo.Location = new System.Drawing.Point(15, 48);
            this.textBoxSlowo.Name = "textBoxSlowo";
            this.textBoxSlowo.Size = new System.Drawing.Size(144, 20);
            this.textBoxSlowo.TabIndex = 0;
            // 
            // buttonDeszyfruj
            // 
            this.buttonDeszyfruj.Location = new System.Drawing.Point(165, 93);
            this.buttonDeszyfruj.Name = "buttonDeszyfruj";
            this.buttonDeszyfruj.Size = new System.Drawing.Size(59, 23);
            this.buttonDeszyfruj.TabIndex = 3;
            this.buttonDeszyfruj.Text = "Deszyfruj";
            this.buttonDeszyfruj.UseVisualStyleBackColor = true;
            this.buttonDeszyfruj.Click += new System.EventHandler(this.buttonDeszyfruj_Click);
            // 
            // buttonSzyfr
            // 
            this.buttonSzyfr.Location = new System.Drawing.Point(165, 48);
            this.buttonSzyfr.Name = "buttonSzyfr";
            this.buttonSzyfr.Size = new System.Drawing.Size(59, 23);
            this.buttonSzyfr.TabIndex = 4;
            this.buttonSzyfr.Text = "Szyfruj";
            this.buttonSzyfr.UseVisualStyleBackColor = true;
            this.buttonSzyfr.Click += new System.EventHandler(this.buttonSzyfr_Click);
            // 
            // textBoxDeszyfr
            // 
            this.textBoxDeszyfr.Location = new System.Drawing.Point(15, 93);
            this.textBoxDeszyfr.Name = "textBoxDeszyfr";
            this.textBoxDeszyfr.Size = new System.Drawing.Size(144, 20);
            this.textBoxDeszyfr.TabIndex = 5;
            // 
            // labelAlfabet
            // 
            this.labelAlfabet.AutoSize = true;
            this.labelAlfabet.Location = new System.Drawing.Point(12, 9);
            this.labelAlfabet.Name = "labelAlfabet";
            this.labelAlfabet.Size = new System.Drawing.Size(46, 13);
            this.labelAlfabet.TabIndex = 9;
            this.labelAlfabet.Text = "Alfabet: ";
            this.labelAlfabet.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tekst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Szyfr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Przesunięcie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Szyfruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 203);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 110);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Deszyfruj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 146);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(90, 177);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(35, 13);
            this.labelFile.TabIndex = 21;
            this.labelFile.Text = "label7";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 172);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 22;
            this.buttonOpen.Text = "Otwórz";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 367);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAlfabet);
            this.Controls.Add(this.textBoxDeszyfr);
            this.Controls.Add(this.buttonSzyfr);
            this.Controls.Add(this.buttonDeszyfruj);
            this.Controls.Add(this.textBoxSlowo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSlowo;
        private System.Windows.Forms.Button buttonDeszyfruj;
        private System.Windows.Forms.Button buttonSzyfr;
        private System.Windows.Forms.TextBox textBoxDeszyfr;
        private System.Windows.Forms.Label labelAlfabet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonOpen;
    }
}

