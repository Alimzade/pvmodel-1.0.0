using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace pvmodel_1._1._1
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {

            double guctoplam = 0;
            double calisaat = 0;
            double guc = 0;
            double toptuketilen = 0;
            foreach (DataGridViewRow row in yukpano.Rows)
            {
                guctoplam += Convert.ToDouble(row.Cells[1].Value);
                calisaat = Convert.ToDouble(row.Cells[2].Value);
                guc = Convert.ToDouble(row.Cells[1].Value);
                toptuketilen += calisaat * guc;
                row.Cells[3].Value = calisaat * guc;
            }
            label4.Text = Convert.ToString(guctoplam);
            label3.Text = Convert.ToString(toptuketilen);
            kaydet.Visible = true;
            
        }

        private void PVModel_Load(object sender, EventArgs e)
        {

        }

        private void BarButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelprojedetaylari.Visible = true;
            panelsebeke.Visible = false;
            panelyuk1.Visible = false;
            panelyuk2.Visible = false;
            panelhosgeldiniz.Visible = false;
            panel3d.Visible = false;
        }

        private void BarButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelhosgeldiniz.Visible = true;
            panelsebeke.Visible = false;
            panelyuk1.Visible = false;
            panelyuk2.Visible = false;
            panelprojedetaylari.Visible = false;
            panel3d.Visible = false;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            panelsebeke.Visible = false;
            panelprojedetaylari.Visible=true;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            panelhosgeldiniz.Visible = false;
            panelprojedetaylari.Visible = true;
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            panelprojedetaylari.Visible = false;
            panelhosgeldiniz.Visible = true;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            panelprojedetaylari.Visible = false;
            panelsebeke.Visible = true;
            
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panelhosgeldiniz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            panel3d.Visible = false;
            panelyuk1.Visible = true;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            panel3d.Visible = false;
            panelyuk1.Visible = true;
        }

        private void Hesaplar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panelyuk1.Visible = false;
            panelsebeke.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelyuk1.Visible = false;
            panel3d.Visible = true;
        }

        private void Yukpano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            panelsebeke.Visible = false;
            panelyuk1.Visible = true;
        }
    }
}
