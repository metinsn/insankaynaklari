using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insankaynaklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Satistemsilcisi st = new Satistemsilcisi();

        private void Form1_Load(object sender, EventArgs e)
        {
            numudSatisadedi.Enabled = false;
            btnGuncelle.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            st.elemanturu = cmboxElemanturu.SelectedItem.ToString();
            st.tckimlik = Convert.ToInt32(numudTckimlik.Value);
            st.maas = Convert.ToInt32(numudMaas.Value);

            lstboxCalısanlar.Items.Add(st);
        }

        private void lstboxCalısanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboxElemanturu.Enabled = false;
            numudMaas.Enabled =
        }
    }
}
