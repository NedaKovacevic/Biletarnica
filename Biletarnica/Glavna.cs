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
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

 

        SqlDataAdapter adapter;
        DataTable podaci;
        private void Glavna_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from pogled", Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);

            dgvTabela.DataSource = podaci;
            //dgTabela.ReadOnly = true;
            //dgTabela.AllowUserToAddRows = false;
           

        }
    }
    
}
