using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisan
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
           

            Calisan calisan = new Calisan();
            calisan.Isim = "Mehmet Atıf";
            calisan.maasHesapla();
            MessageBox.Show("Calisan Maaş: " +calisan.Maas.ToString());

            Mudur mudur = new Mudur();
            mudur.Isim = "Akif Tek";
            mudur.maasHesapla();
            MessageBox.Show("Mudur Maaş: " + mudur.Maas.ToString());



        }
    }
}
