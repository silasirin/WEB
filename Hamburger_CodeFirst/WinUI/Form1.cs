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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MenuService menuService = new MenuService();
        BurgerMenu menu = new BurgerMenu();

        private void MenuListele()
        {
            listView1.Items.Clear();

            List<BurgerMenu> menuListesi = menuService.MenuList();

            foreach (BurgerMenu menu in menuListesi)
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = menu.MenuAdi.ToString();
                lvi.SubItems.Add(menu.MenuFiyat.ToString());
                listView1.Items.Add(lvi);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            menu.MenuAdi = txtMenu.Text;
            menu.MenuFiyat = nudFiyat.Value;

            
            string result = menuService.CreateMenu(menu);
            MessageBox.Show(result);
            MenuListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            menu.BurgerMenuID = Convert.ToInt32(txtMenuID.Text);
            menu.MenuAdi = txtMenu.Text;
            menu.MenuFiyat = nudFiyat.Value;


            string result = menuService.UpdateMenu(menu);
            MessageBox.Show(result);
            MenuListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = menuService.DeleteMenu(Convert.ToInt32(txtMenuID.Text));


            MessageBox.Show(result);

            MenuListele();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            EkstraFormu ekstraFormu = new EkstraFormu();
            ekstraFormu.Show();
            this.Hide();
        }
    }
}
