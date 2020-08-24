using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfr_Plotkowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBoxSzyfr.Text = null;
            bool strona = false;
            string slowo = textBoxTekst.Text;
            string[,] szyfr;
            int plotek = 3;
            int length = slowo.Length;
            int x = 1;
            int y = 0;
            szyfr = new string[length/2, plotek];
            szyfr[0, 0] = slowo[0].ToString();
            for (int i = 0; i < 5; i++)
            {


                if(strona == false)
                {
                    for (int j = 1; j < plotek; j++)
                    {

                        szyfr[i, j] = slowo[x].ToString();
                        x++;
                        y++;
                        textBox1.Text +=i.ToString() + j.ToString() + szyfr[i, j] + " ";
                        //textBoxSzyfr.Text += szyfr[i, j];


                }

                    /*if (y == 1)
                    {
                        strona = true;
                        label1.Text += " T ";

                    }*/
                }

                if (strona == true)
                {
                    for (int j = 1; j >= 0; j--)
                    {

                        szyfr[i, j] = slowo[x].ToString();
                        x++;
                        y--;
                        textBox1.Text +=i.ToString() + j.ToString() + szyfr[i, j] + " ";
                        //textBoxSzyfr.Text += szyfr[i, j];


                    }
                   /* if (y == 0)
                    {
                        strona = false;
                        label1.Text = " F ";
                    }*/
                }


                strona = !strona;

            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < plotek; j++)
                {
                    //szyfr = new string[i,j];
                    textBoxSzyfr.Text += szyfr[i, j];
                }
            }

            //for (int i = 0; i < 6; i++)
            //{

               // textBoxSzyfr.Text += szyfr[i, 3];

          //  }

            //szyfrowanie
/*
            for (int i = 0; i < (length / plotek); i++)
            {
                for (int j = 0; j < plotek; j++)
                {

                    szyfr[i, j] = slowo[x].ToString();
                    x++;
                    //textBoxSzyfr.Text += szyfr[i, j];
                }
            }
*/

            
            //Dwa schodki na sztywno
            /*
            int x = 0;
            int y = 1;

            for (int i = 0; i < (length / 2); i++)
            {

                textBoxSzyfr.Text += slowo[x];
                x = x + 2;
            }
            for (int i = 0; i < (length / 2); i++)
            {

                textBoxSzyfr.Text += slowo[y];
                y = y + 2;
            }
              /*


            //wyświetlenie tablicy w textboxie
            /*for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < plotek; j++)
                {
                    //szyfr = new string[i,j];
                    textBoxSzyfr.Text += array2Db[i, j];
                }
            }*/


        }
    }
}
