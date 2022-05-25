using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biletarnica
{
    public partial class Karte : Form
    {
        public Karte()
        {
            InitializeComponent();
        }

        SqlDataAdapter adapter;
        DataTable podaci;

        private void Karte_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from pogled2", Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);

            dgvTabela.DataSource = podaci;
            label1.Text = Program.koncert;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
