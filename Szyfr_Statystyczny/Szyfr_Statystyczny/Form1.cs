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

namespace Szyfr_Statystyczny
{
    public partial class Form1 : Form
    {
        public class Statistics
        {
            public char Sign { get; set; }
            public double Number { get; set; }

            public Statistics()
            {
            }

            public Statistics(char sSign, double sNumber)
            {
                Sign = sSign;
                Number = sNumber;

            }

        }
        public static class GlobalList
        {
            public static List<Statistics> ListStatistics = new List<Statistics>();
            public static List<Statistics> EncryptList = new List<Statistics>();

        }



        public List<char> lista = new List<char>(new char[] { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'r', 's', 'ś', 't', 'u', 'w', 'y', 'z', 'ź', 'ż', 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'R', 'S', 'Ś', 'T', 'U', 'W', 'Y', 'Z', 'Ź', 'Ż', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '\'', ',', '.', '/', '\\', '{', '}', '[', ']', '(', ')', '-', '_', '+', '-', '*', '!', '?', '\'', '@', '#', '$', '=', '%', '&', '|','\n' });
      
        public string statisticText;
        public string encryptText;
        public char[] encryptArray;
        public char[] statisticArray;
        public char[] lastArray;
        public char[] decArray;
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonLoadText_Click(object sender, EventArgs e)
        {

            openFileDialogLoadStatistic.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogLoadStatistic.FileName = "";
            if (openFileDialogLoadStatistic.ShowDialog() == DialogResult.OK)
            {
                Encoding enc = Encoding.GetEncoding("Windows-1250");
                string path = openFileDialogLoadStatistic.FileName;
                statisticText = File.ReadAllText(path, enc);
                richTextBox1.Text = statisticText;
                statisticArray = richTextBox1.Text.ToCharArray();
                int arrayLength = statisticArray.Length;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GlobalList.ListStatistics.Clear();
            List<char> statisticList = new List<char>();
            statisticList = richTextBox1.Text.ToList();

            double listCount = 0.0;
            foreach (char value in statisticList)
            {
                listCount++;
            }


            int j = 0;
            double count = 0.0;
            foreach (char value in lista)
            {

                GlobalList.ListStatistics.Add(new Statistics(
                    lista[j],
                    count = ((statisticList.Count(i => i == lista[j]) / listCount) * 100)
                    ));
                j++;
            }




            GlobalList.ListStatistics = GlobalList.ListStatistics.OrderByDescending(item => item.Number).ToList();
            dataGridViewStatistic.DataSource = GlobalList.ListStatistics;
            dataGridViewStatistic.Columns[1].DefaultCellStyle.Format = "N2";

       
            


        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialogLoadStatistic.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogLoadStatistic.FileName = "";
            if (openFileDialogLoadStatistic.ShowDialog() == DialogResult.OK)
            {
                Encoding enc = Encoding.GetEncoding("Windows-1250");
                string path = openFileDialogLoadStatistic.FileName;
                encryptText = File.ReadAllText(path, enc);
                richTextBox2.Text = encryptText;
                encryptArray = richTextBox2.Text.ToCharArray();


            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            
            GlobalList.EncryptList.Clear();
            List<char> statisticList = new List<char>();
            statisticList = richTextBox2.Text.ToList();
            double listCount = 0.0;
            foreach (char value in statisticList)
            {
                listCount++;
            }


            int j = 0;
            double count = 0.0;
            foreach (char value in lista)
            {
            
                GlobalList.EncryptList.Add(new Statistics(
                    lista[j],
                    count = ((statisticList.Count(i => i == lista[j]) / listCount) * 100)
                    ));
                j++;
            }
            GlobalList.EncryptList = GlobalList.EncryptList.OrderByDescending(item => item.Number).ToList();
            dataGridView1.DataSource = GlobalList.EncryptList;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";



          
            encryptArray = richTextBox2.Text.ToCharArray();

            int EncArrayLeng = encryptArray.Length;
            int listLeng = lista.Count;
            lastArray = new char[EncArrayLeng];

           
            for (int k = 0; k < EncArrayLeng; k++)
            {


                for (int l = 0; l < listLeng; l++)
                {
                    if (encryptArray[k] == GlobalList.EncryptList[l].Sign)
                    {
                        lastArray[k] = GlobalList.ListStatistics[l].Sign;
                        

                    }
                }
            }



             

                richTextBox2.Text =new string(lastArray);


          
        }

        private void dataGridViewStatistic_Click(object sender, EventArgs e)
        {
            label1.Text = dataGridViewStatistic.CurrentCell.RowIndex.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.CurrentCell.RowIndex.ToString();
            
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
        
            List<char> statisticList = new List<char>();
            statisticList = richTextBox2.Text.ToList();

            double listCount = 0.0;
            foreach (char value in statisticList)
            {
                listCount++;
            }


            int j = 0;
            double count = 0.0;



            encryptArray = richTextBox2.Text.ToCharArray();

            int EncArrayLeng = encryptArray.Length;
            int listLeng = lista.Count;
            decArray = new char[EncArrayLeng];
         

            for (int k = 0; k < EncArrayLeng; k++)
            {


                for (int l = 0; l < listLeng; l++)
                {
                    if (encryptArray[k] == GlobalList.ListStatistics[l].Sign)
                    {
                        decArray[k] = GlobalList.EncryptList[l].Sign;
                        
                    }
                }
            }


            richTextBox2.Text = new string(decArray);

        }
    }
}

