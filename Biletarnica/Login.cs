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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Unesite E-mail i Password!");
                return;
            }
            else // lako se razdvoje slucajevi admin i korisnik, ako je email simikic.nikola@gmail.com
                 // onda idi na admin page, a ako nije, idi na user page
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM Korisnik WHERE email = @username", veza);
                    komanda.Parameters.AddWithValue("@username", textBoxMail.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;
                    if (brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), textBoxPass.Text) == 0)
                        {
                            MessageBox.Show("Login Successful!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();

                            this.Hide();
                            Admin frm_Admin = new Admin();
                            frm_Admin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Neispravna Lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci E-mail!");
                    }
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
