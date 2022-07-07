using BLL.CRUD;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class EkstraFormu : Form
    {
        public EkstraFormu()
        {
            InitializeComponent();
        }

        EkstraService ekstraService = new EkstraService();  
        Ekstra ekstra = new Ekstra();

        private void EkstraListele()
        {
            listView2.Items.Clear();

            List<Ekstra> ekstraListesi = ekstraService.EkstraList();

            foreach (Ekstra ekstra in ekstraListesi)
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ekstra.EkstraAdi.ToString();
                lvi.SubItems.Add(ekstra.EkstraFiyat.ToString());
                lvi.SubItems.Add(ekstra.BurgerMenuID.ToString());
                listView2.Items.Add(lvi);
            }
        }
        private void EkstraFormu_Load(object sender, EventArgs e)
        {
            EkstraListele();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekstra.EkstraAdi = txtEkstra.Text;
            ekstra.EkstraFiyat = nudEkstraFiyat.Value;
            ekstra.BurgerMenuID = int.Parse(txtMenuID.Text);

            string result = ekstraService.CreateEkstra(ekstra);
            MessageBox.Show(result);
            EkstraListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ekstra.EkstraID = Convert.ToInt32(txtEkstraID.Text);
            ekstra.EkstraAdi = txtEkstra.Text;
            ekstra.EkstraFiyat = nudEkstraFiyat.Value;
            ekstra.BurgerMenuID = int.Parse(txtMenuID.Text);

            string result = ekstraService.UpdateEkstra(ekstra);
            MessageBox.Show(result);
            EkstraListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = ekstraService.DeleteEkstra(Convert.ToInt32(txtEkstraID.Text));

            MessageBox.Show(result);

            EkstraListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
