using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_IPLA___Bîrzu_Gabriel
{
    public partial class Form3 : Form
    {

        public static string email = "";

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Hotel.accdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {

            con.Open();

            OleDbCommand cmdAutentificare = new OleDbCommand("SELECT * " +
                                                             "FROM Clienti " +
                                                             "WHERE Email LIKE '" + txtEmail.Text + "' AND Parola LIKE '" + txtParola.Text + "'", con);

            OleDbDataReader drAutentificare = cmdAutentificare.ExecuteReader();

            if (drAutentificare.Read() == true)
            {

                email = txtEmail.Text;

                Form4 frm4 = new Form4();

                this.Hide();

                frm4.Show();

                txtEmail.Text = "";

                txtParola.Text = "";

            }

            else

            {

                MessageBox.Show("Utilizator inexistent sau parola incorectă!");

                txtEmail.Text = "";

                txtParola.Text = "";

            }

            con.Close();

        }

        private void btnRevenire_Click(object sender, EventArgs e)
        {

            this.Close();

            Form1 frm1 = new Form1();

            frm1.Show();

        }
    }
}
