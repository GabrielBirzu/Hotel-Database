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
    public partial class Form2 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Hotel.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 frm1 = new Form1();

            this.Close();

            frm1.Show();

        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {

            if (txtAdresa.Text == "")
            {

                MessageBox.Show("Introduceți toate datele cerute de sistem!");
                return;

            }

            else if (txtNume.Text == "")
            {

                MessageBox.Show("Introduceți toate datele cerute de sistem!");
                return;

            }

            else if (txtCNP.Text == "")
            {

                MessageBox.Show("Introduceți toate datele cerute de sistem!");
                return;

            }

            if (txtEmail.Text == "")
            {

                MessageBox.Show("Introduceți toate datele cerute de sistem!");
                return;

            }

            else if (txtTelefon.Text == "")
            {

                MessageBox.Show("Introduceți toate datele cerute de sistem!");
                return;

            }

            else if (txtParola.Text == "")
            {

                MessageBox.Show("Introduceți toate datele cerute de sistem!");
                return;

            }


            con.Open();

            OleDbCommand cmdRezerva = new OleDbCommand("INSERT INTO Clienti(ID_Client,CNP,Nume_Prenume,Data_Nastere,Adresa,Email,Telefon,Parola)" +
                                                       "VALUES (?,?,?,?,?,?,?,?);", con);

            cmdRezerva.Parameters.Add("ID_Client", SqlDbType.Int).Value = txtID.Text;
            cmdRezerva.Parameters.Add("CNP", SqlDbType.NVarChar).Value = txtCNP.Text;
            cmdRezerva.Parameters.Add("Nume_Prenume", SqlDbType.NVarChar).Value = txtNume.Text;
            cmdRezerva.Parameters.Add("Data_Nastere", SqlDbType.DateTime).Value = dtpDataNasterii.Value.Date;
            cmdRezerva.Parameters.Add("Adresa", SqlDbType.NVarChar).Value = txtAdresa.Text;
            cmdRezerva.Parameters.Add("Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            cmdRezerva.Parameters.Add("Telefon", SqlDbType.NVarChar).Value = txtTelefon.Text;
            cmdRezerva.Parameters.Add("Parola", SqlDbType.NVarChar).Value = txtParola.Text;

            try
            {

                cmdRezerva.ExecuteNonQuery();
                cmdRezerva.Dispose();

                con.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Datele au fost introduse deja în sistem!");

                con.Close();

                return;

            }

            MessageBox.Show("Datele au fost verificate și introduse în baza de date!");

            Form1 frm1 = new Form1();

            this.Close();

            frm1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            txtID.Enabled = false;

            con.Open();

            OleDbDataAdapter daID = new OleDbDataAdapter("SELECT MAX([ID_Client]) " +
                                                         "FROM Clienti ", con);


            DataTable dtID = new DataTable();

            daID.Fill(dtID);

            txtID.Text = dtID.Rows[0][0].ToString();

            int numar = Int32.Parse(txtID.Text) + 1;

            txtID.Text = numar.ToString();

            con.Close();


        }
    }
}
