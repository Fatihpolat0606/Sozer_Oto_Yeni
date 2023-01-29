using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sozer_Oto_Yeni
{
    public partial class Form1 : Form
    {
        private bool asaİnisBir;//dinamik paneller için
        private bool asaİnisİki;//dinamik paneller için
        private bool asaİnisUc;//dinamik paneller için
        private bool asaİnisDort;//dinamik paneller için
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (asaİnisBir)
            {
                pnlYeniArabaKayıt.Height += 10;
                if (pnlYeniArabaKayıt.Size == pnlYeniArabaKayıt.MaximumSize)
                {
                    timer1.Stop();
                    asaİnisBir= false;
                }
            }
            else
            {
                pnlYeniArabaKayıt.Height -= 10;
                if (pnlYeniArabaKayıt.Size == pnlYeniArabaKayıt.MinimumSize)
                {
                    timer1.Stop();
                    asaİnisBir = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (asaİnisİki)
            {
                pnlYeniArabaOrtak.Height += 10;
                if (pnlYeniArabaOrtak.Size == pnlYeniArabaOrtak.MaximumSize)
                {
                    timer2.Stop();
                    asaİnisİki = false;
                }
            }
            else
            {
                pnlYeniArabaOrtak.Height -= 10;
                if (pnlYeniArabaOrtak.Size == pnlYeniArabaOrtak.MinimumSize)
                {
                    timer2.Stop();
                    asaİnisİki = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (asaİnisUc)
            {
                pnlYeniArabaMaliyet.Height += 10;
                if (pnlYeniArabaMaliyet.Size == pnlYeniArabaMaliyet.MaximumSize)
                {
                    timer3.Stop();
                    asaİnisUc = false;
                }
            }
            else
            {
                pnlYeniArabaMaliyet.Height -= 10;
                if (pnlYeniArabaMaliyet.Size == pnlYeniArabaMaliyet.MinimumSize)
                {
                    timer3.Stop();
                    asaİnisUc = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (asaİnisDort)
            {
                pnlOrtakKayıt.Height += 10;
                if (pnlOrtakKayıt.Size == pnlOrtakKayıt.MaximumSize)
                {
                    timer4.Stop();
                    asaİnisDort = false;
                }
            }
            else
            {
                pnlOrtakKayıt.Height -= 10;
                if (pnlOrtakKayıt.Size == pnlOrtakKayıt.MinimumSize)
                {
                    timer4.Stop();
                    asaİnisDort = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }
        // deneme yapmak için dgw buraya kodladım
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwTümArabalarListe.ColumnCount = 11;
            dgwTümArabalarListe.Columns[0].Name = "Marka";
            dgwTümArabalarListe.Columns[1].Name = "Model";
            dgwTümArabalarListe.Columns[2].Name = "Plaka";
            dgwTümArabalarListe.Columns[3].Name = "Eksper";
            dgwTümArabalarListe.Columns[4].Name = "Noter";
            dgwTümArabalarListe.Columns[5].Name = "MTV";
            dgwTümArabalarListe.Columns[6].Name = "Sigorta";
            dgwTümArabalarListe.Columns[7].Name = "Bakım";
            dgwTümArabalarListe.Columns[8].Name = "Ulaşım";
            dgwTümArabalarListe.Columns[9].Name = "Yakıt";
            dgwTümArabalarListe.Columns[10].Name = "Fiyat";


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Button";
            btn.Name = "button";
            btn.Text = "Ortaklar";
            btn.UseColumnTextForButtonValue = true;
            dgwTümArabalarListe.Columns.Add(btn);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Button";
            btn2.Name = "button";
            btn.Text = "Detay";
            btn2.UseColumnTextForButtonValue = true;
            dgwTümArabalarListe.Columns.Add(btn2);

        }
    }
}
