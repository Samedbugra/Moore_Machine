using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author Samed Buğra Karataş

namespace MooreMachine
{
    public partial class Form1 : Form
    {
        public int qSayisi;
        public String strQ,strE,strR;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tboxQ.Text = null;
            qSayisi = comboBox1.SelectedIndex;
            
            for(int i=1;i<=qSayisi;i++)
            {
                tboxQ.Text +="q"+(i-1);
                if (i != qSayisi)
                    tboxQ.Text += ',';
            } 
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        { 
            strQ = tboxQ.Text.ToString();
            for(int i=0;i< tboxR.Text.ToString().Length;i++)
            {
                if(Char.IsDigit(tboxR.Text.ToString()[i]))
                    strR += tboxR.Text.ToString()[i];
            }
            for (int i = 0; i < tboxE.Text.ToString().Length; i++)
            {
                if(Char.IsLetter(tboxE.Text.ToString()[i]))
                    strE += tboxE.Text.ToString()[i];
            }

             
            if (strQ=="" || strE==null || strR==null || qSayisi<strE.Length)// q sayisi E sayısından fazla olması gerekir
            {
                MessageBox.Show("Girdileri Kontrol Ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                strE = null; strQ = null;
            }
            else
            {
                Table table = new Table();
                table.Tablo_Olustur(qSayisi, strE, strR);
                table.Show();
                
                this.Hide();
            } 
        }
    }
}
