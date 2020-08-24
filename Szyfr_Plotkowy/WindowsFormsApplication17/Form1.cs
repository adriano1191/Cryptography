using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 2;
            
        }
        public string path;
        private void button1_Click(object sender, EventArgs e)
        {

            char[] mtxt = textBox1.Text.ToCharArray(), ctxt = new char[mtxt.Length];
            int n = Convert.ToInt32(numericUpDown1.Value);
            int actIndex = 0;


            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; (j * (n - 1) * 2) - i < mtxt.Length; ++j)
                {
                    if (i > 0 && j > 0 && i != n - 1)
                    {
                        ctxt[actIndex++] = mtxt[j * (n - 1) * 2 - i];
                    }
                    if (j * (n - 1) * 2 + i < mtxt.Length && actIndex < mtxt.Length)
                    {
                        ctxt[actIndex++] = mtxt[j * (n - 1) * 2 + i];
                    }
                }
            }
            textBox2.Text = new string(ctxt);

        }       
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            char[] ctxt = textBox2.Text.ToCharArray(), atxt = new char[ctxt.Length];

             
            int n = Convert.ToInt32(numericUpDown1.Value);
            int actIndex = 0;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j * (n - 1) * 2 - i < ctxt.Length; ++j)
                {
                  if (j > 0 && i > 0 && i != n - 1)
                    {
                        atxt[j * (n - 1) * 2 - i] += ctxt[actIndex++];
                    }
                  if (j * (n - 1) * 2 + i < ctxt.Length && actIndex < ctxt.Length)
                    {
                        atxt[j * (n - 1) * 2 + i] += ctxt[actIndex++];
                    }
                }
            }
         textBox1.Text = new string(atxt);

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonSzyfrowanie_Click(object sender, EventArgs e)
        {
            char[] mtxt = richTextBox1.Text.ToCharArray(), ctxt = new char[mtxt.Length];
            int n = Convert.ToInt32(numericUpDown1.Value);
            int actIndex = 0;


            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; (j * (n - 1) * 2) - i < mtxt.Length; ++j)
                {
                    if (i > 0 && j > 0 && i != n - 1)
                    {
                        ctxt[actIndex++] = mtxt[j * (n - 1) * 2 - i];
                    }
                    if (j * (n - 1) * 2 + i < mtxt.Length && actIndex < mtxt.Length)
                    {
                        ctxt[actIndex++] = mtxt[j * (n - 1) * 2 + i];
                    }
                }
            }
            richTextBox1.Text = new string(ctxt);
            File.WriteAllText("zaszyfrowane.txt", richTextBox1.Text);

        }

        private void buttonOtwórz_Click(object sender, EventArgs e)
        {    //Polskie znaki
            Encoding enc = Encoding.GetEncoding("Windows-1250");

            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileName;
                richTextBox1.Text = File.ReadAllText(path, enc);
            }
        }




        private void buttonDeszyfrowanie_Click(object sender, EventArgs e)
        {
            char[] ctxt = richTextBox1.Text.ToCharArray(), atxt = new char[ctxt.Length];


            int n = Convert.ToInt32(numericUpDown1.Value);
            int actIndex = 0;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j * (n - 1) * 2 - i < ctxt.Length; ++j)
                {
                    if (j > 0 && i > 0 && i != n - 1)
                    {
                        atxt[j * (n - 1) * 2 - i] += ctxt[actIndex++];
                    }
                    if (j * (n - 1) * 2 + i < ctxt.Length && actIndex < ctxt.Length)
                    {
                        atxt[j * (n - 1) * 2 + i] += ctxt[actIndex++];
                    }
                }
            }
            richTextBox1.Text = new string(atxt);
            File.WriteAllText("odszyfrowane.txt", richTextBox1.Text);
        }
    }
}


  
