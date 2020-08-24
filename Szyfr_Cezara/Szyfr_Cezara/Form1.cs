using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Szyfr_Cezara
{
    public partial class Form1 : Form
    {
        //public string[] salfabet = new string[] { "abcdefghijklmnoprstuwxyz" };
       // public char[] calfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'x', 'y', 'z' };
        //public int x = 3;
        public List<string> lista = new List<string>(new string[] { "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t", "u", "w", "y", "z", "ź", "ż", "A", "Ą", "B", "C", "Ć", "D", "E", "Ę", "F", "G", "H", "I", "J", "K", "L", "Ł", "M", "N", "Ń", "O", "Ó", "P", "R", "S", "Ś", "T", "U", "W", "Y", "Z", "Ź", "Ż", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", "\"", ",", ".", "/", "\\", "{", "}", "[", "]", "(", ")", "-", "_", "+", "-", "*", "!", "?", "\'", "@", "#", "$", "=", "%", "&", "|", "\\n"});
            
        
        public Form1()
        {
            InitializeComponent();
            int l = 0;
            foreach (string value in lista)
            {
                
                labelAlfabet.Text += lista[l];
                l++;
            }
        }
        

        private void buttonSzyfr_Click(object sender, EventArgs e)
        {
            textBoxDeszyfr.Text = null;
            //int x = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(numericUpDown1.Value);
            //textBox2.Text = textBox1.Text;
    
            string slowo = textBoxSlowo.Text;
            int dlugosc = slowo.Length;
            List<string> lista2 = new List<string>();
            lista2 = lista.ToList();
            int strIndex = 0;
            for (int i = 0; i < x; i++)
            {
                lista2.Add(lista2[0]);
                lista2.RemoveAt(0);
            }
            int j = lista2.Count;
            List<string> szyfr = new List<string>();
            for (int i = 0; i < dlugosc; i++)
            {

                //strIndex = lista[i].IndexOf(slowo[0]);
                //
                strIndex = lista.IndexOf(slowo[i].ToString());
                szyfr.Add(lista2[strIndex]);
                textBoxDeszyfr.Text += szyfr[i];

            }

        }

        private void buttonDeszyfruj_Click(object sender, EventArgs e)
        {
            textBoxSlowo.Text = null;
           // int x = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(numericUpDown1.Value);
            string slowo = textBoxDeszyfr.Text;
            int dlugosc = slowo.Length;
            List<string> lista2 = new List<string>();
            lista2 = lista.ToList();
            int strIndex = 0;
            for (int i = 0; i < x; i++)
            {
                lista2.Add(lista2[0]);
                lista2.RemoveAt(0);
            }
            int j = lista2.Count;
            List<string> szyfr = new List<string>();
            for (int i = 0; i < dlugosc; i++)
            {

                //strIndex = lista[i].IndexOf(slowo[0]);
                //
                strIndex = lista2.IndexOf(slowo[i].ToString());
                szyfr.Add(lista[strIndex]);
                textBoxSlowo.Text += szyfr[i];

            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            string path = labelFile.Text;
            string slowo = string.Join(" ", File.ReadAllLines(path, enc));
            //richTextBox1.Text = slowo;
            richTextBox1.Text = null;
            int x = Convert.ToInt32(numericUpDown1.Value);

            
            int dlugosc = slowo.Length;
            List<string> lista2 = new List<string>();
            lista2 = lista.ToList();
            int strIndex = 0;
            for (int i = 0; i < x; i++)
            {
                lista2.Add(lista2[0]);
                lista2.RemoveAt(0);
            }
            int j = lista2.Count;
            List<string> szyfr = new List<string>();
            for (int i = 0; i < dlugosc; i++)
            {

                //strIndex = lista[i].IndexOf(slowo[0]);
                //
                strIndex = lista.IndexOf(slowo[i].ToString());
                szyfr.Add(lista2[strIndex]);
                richTextBox1.Text += szyfr[i];

            }

            File.WriteAllText("zaszyfrowane.txt", richTextBox1.Text, enc);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Encoding enc = Encoding.GetEncoding("Windows-1250");
                labelFile.Text = openfile.FileName;
                string path = labelFile.Text;
                //string slowo = File.ReadAllText(path);
                string slowo = string.Join(" ", File.ReadAllLines(path, enc));
                richTextBox1.Text = slowo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            string path = labelFile.Text;
            string slowo = string.Join(" ", File.ReadAllLines(path, enc));
            //richTextBox1.Text = slowo;
            richTextBox1.Text = null;

            int x = Convert.ToInt32(numericUpDown1.Value);
            int dlugosc = slowo.Length;
            List<string> lista2 = new List<string>();
            lista2 = lista.ToList();
            int strIndex = 0;
            for (int i = 0; i < x; i++)
            {
                lista2.Add(lista2[0]);
                lista2.RemoveAt(0);
            }
            int j = lista2.Count;
            List<string> szyfr = new List<string>();
            for (int i = 0; i < dlugosc; i++)
            {

                //strIndex = lista[i].IndexOf(slowo[0]);
                //
                strIndex = lista2.IndexOf(slowo[i].ToString());
                szyfr.Add(lista[strIndex]);
                richTextBox1.Text += szyfr[i];

            }

            File.WriteAllText("odszyfrowane.txt", richTextBox1.Text, enc);
        }
    }
}
