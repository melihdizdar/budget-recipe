using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButceTarif
{
    public partial class Form_Tarif : Form
    {
        public List<TarifModel> tarifler;
        public Form_Tarif(List<TarifModel> _tarifler)
        {
            InitializeComponent();
            tarifler = _tarifler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_Tarif_Load(object sender, EventArgs e)
        {
            dg_tarif.DataSource = tarifler;
            dg_tarif.Columns["TarifResim"].Visible = false;
            ResimleriGetir();
        }
        private void ResimleriGetir()
        {
            foreach (var item in tarifler)
            {
                PictureBox pb = new PictureBox();
                Image image = Image.FromFile(Directory.GetCurrentDirectory() + $"/Photos/tarif_{item.TarifId}.jpg");
                pb.Image = image;
                pb.Width = 114;
                pb.Height = 85;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                Pictures_Panel.Controls.Add(pb);
            }
        }


    }
}
