using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButceTarif
{
    public partial class Form_Menu : Form
    {
        public List<TarifModel> tarifler;
        public Form_Menu(List<TarifModel> _tarifler)
        {
            InitializeComponent();
            tarifler = _tarifler;
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tarifler;
            dataGridView1.Columns["TarifResim"].Visible = false;
            dataGridView1.Columns["TarifMalzeme"].Visible = false;
            dataGridView1.Columns["TarifTuru"].Visible = true; ;
            dataGridView1.Columns["TarifIcerik"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
