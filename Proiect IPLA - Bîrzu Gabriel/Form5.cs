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
using PP = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace Proiect_IPLA___Bîrzu_Gabriel
{
    
    public partial class Form5 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Hotel.accdb");


        PP.Application Hotel;
        PP.Presentation pres;
        PP.Slide slide;

        public Form5()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {

            con.Open();

            OleDbDataAdapter cmdRezervari = new OleDbDataAdapter("SELECT Nume_Prenume,Tip_Camera,Data_Inceput,Data_Sfarsit " +
                                                                 "FROM Rezervari INNER JOIN Clienti ON Rezervari.ID_Client=Clienti.ID_Client " +
                                                                 "WHERE Email LIKE '" + Form3.email  + "'", con);

            DataTable dtRezervari = new DataTable();

            cmdRezervari.Fill(dtRezervari);

            dgvRevervari.DataSource = dtRezervari.DefaultView;

            con.Close();

        }

        private void btnCautare_Click(object sender, EventArgs e)
        {

            con.Open();

            OleDbDataAdapter cmdDisponibile = new OleDbDataAdapter("SELECT Tip_Camera " +
                                                                   "FROM Camere ", con);

            DataTable dtDisponibile = new DataTable();

            cmdDisponibile.Fill(dtDisponibile);

            cmbDisponibile.DataSource = dtDisponibile;

            cmbDisponibile.DisplayMember = "Tip_Camera";

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();

            string nr;

            OleDbDataAdapter daNR = new OleDbDataAdapter("SELECT MAX([NR_Inregistrare]) " +
                                                         "FROM Rezervari ", con);


            DataTable dtNR = new DataTable();

            try
            {



                daNR.Fill(dtNR);

                nr = dtNR.Rows[0][0].ToString();

                int numar = Int32.Parse(nr) + 1;

                nr = numar.ToString();

            }

            catch (Exception ex)
            {

                nr = "1";

            }





            string id;

            OleDbDataAdapter daID = new OleDbDataAdapter("SELECT ID_Client " +
                                                         "FROM Clienti " +
                                                         "WHERE Email LIKE '" + Form3.email + "'", con);


            DataTable dtID = new DataTable();

            daID.Fill(dtID);

            id = dtID.Rows[0][0].ToString();

            int numar2 = Int32.Parse(id);

            id = numar2.ToString();



            OleDbCommand cmdAdaugare = new OleDbCommand("INSERT INTO Rezervari(NR_Inregistrare,ID_Client,Tip_Camera,Data_Inceput,Data_Sfarsit) " +
                                                        "VALUES (?,?,?,?,?)", con);


            cmdAdaugare.Parameters.Add("NR_Inregistrare", SqlDbType.Int).Value = nr;
            cmdAdaugare.Parameters.Add("ID_Client", SqlDbType.Int).Value = id;
            cmdAdaugare.Parameters.Add("Tip_Camera", SqlDbType.VarChar).Value =  cmbDisponibile.Text;
            cmdAdaugare.Parameters.Add("Data_Inceput", SqlDbType.DateTime).Value = dtpInceput.Value.Date;
            cmdAdaugare.Parameters.Add("Data_Sfarsit", SqlDbType.DateTime).Value = dtpSfarsit.Value.Date;


            try
            {

                cmdAdaugare.ExecuteNonQuery();
                cmdAdaugare.Dispose();

                con.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                con.Close();

            }


            con.Open();

            OleDbDataAdapter cmdRezervari = new OleDbDataAdapter("SELECT Nume_Prenume,Tip_Camera,Data_Inceput,Data_Sfarsit " +
                                                                 "FROM Rezervari INNER JOIN Clienti ON Rezervari.ID_Client=Clienti.ID_Client " +
                                                                 "WHERE Email LIKE '" + Form3.email + "'", con);

            DataTable dtRezervari = new DataTable();

            cmdRezervari.Fill(dtRezervari);

            dgvRevervari.DataSource = dtRezervari.DefaultView;

            con.Close();

        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {

            con.Open();


            string nr;

            OleDbDataAdapter daNR = new OleDbDataAdapter("SELECT MAX([NR_Inregistrare]) " +
                                                         "FROM Rezervari ", con);


            DataTable dtNR = new DataTable();

            try
            {



                daNR.Fill(dtNR);

                nr = dtNR.Rows[0][0].ToString();

                int numar = Int32.Parse(nr);

                nr = numar.ToString();

            }

            catch (Exception ex)
            {

                nr = "1";

            }



            if(cbClub.Checked == true)
            {

                OleDbCommand cmdAdaugare = new OleDbCommand("INSERT INTO Extraoptiuni_Rezervare(NR_Inregistrare,Denumire_Extraoptiune) " +
                                                            "VALUES (?,?)", con);


                cmdAdaugare.Parameters.Add("NR_Inregistrare", SqlDbType.Int).Value = nr;
                cmdAdaugare.Parameters.Add("Denumire_Extraoptiune", SqlDbType.VarChar).Value = "Club";

                try
                {

                    cmdAdaugare.ExecuteNonQuery();
                    cmdAdaugare.Dispose();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);


                }

            }

            if (cbFitness.Checked == true)
            {


                OleDbCommand cmdAdaugare = new OleDbCommand("INSERT INTO Extraoptiuni_Rezervare(NR_Inregistrare,Denumire_Extraoptiune) " +
                                                            "VALUES (?,?)", con);


                cmdAdaugare.Parameters.Add("NR_Inregistrare", SqlDbType.Int).Value = nr;
                cmdAdaugare.Parameters.Add("Denumire_Extraoptiune", SqlDbType.VarChar).Value = "Fitness";

                try
                {

                    cmdAdaugare.ExecuteNonQuery();
                    cmdAdaugare.Dispose();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);


                }

            }

            if (cbMasaj.Checked == true)
            {


                OleDbCommand cmdAdaugare = new OleDbCommand("INSERT INTO Extraoptiuni_Rezervare(NR_Inregistrare,Denumire_Extraoptiune) " +
                                                            "VALUES (?,?)", con);


                cmdAdaugare.Parameters.Add("NR_Inregistrare", SqlDbType.Int).Value = nr;
                cmdAdaugare.Parameters.Add("Denumire_Extraoptiune", SqlDbType.VarChar).Value = "Masaj";

                try
                {

                    cmdAdaugare.ExecuteNonQuery();
                    cmdAdaugare.Dispose();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);


                }

            }

           

            if (cbSauna.Checked == true)
            {

                OleDbCommand cmdAdaugare = new OleDbCommand("INSERT INTO Extraoptiuni_Rezervare(NR_Inregistrare,Denumire_Extraoptiune) " +
                                                            "VALUES (?,?)", con);


                cmdAdaugare.Parameters.Add("NR_Inregistrare", SqlDbType.Int).Value = nr;
                cmdAdaugare.Parameters.Add("Denumire_Extraoptiune", SqlDbType.VarChar).Value = "Sauna";

                try
                {

                    cmdAdaugare.ExecuteNonQuery();
                    cmdAdaugare.Dispose();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }



            }

            MessageBox.Show("Datele au fost salvate în sistem!");

            Form4 frm4 = new Form4();

            frm4.Show();

            this.Close();

            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 frm4 = new Form4();

            frm4.Show();

            this.Close();

        }


        private void btCameraSelectata_Click(object sender, EventArgs e)
        {

            if (cmbDisponibile.Text == "SINGLE")
            {

                Hotel = new PP.Application();
                pres = Hotel.Presentations.Add();

                int nrs = pres.Slides.Count;

                PP.CustomLayout cl = pres.SlideMaster.CustomLayouts[PP.PpSlideLayout.ppLayoutTitle];

                slide = pres.Slides.AddSlide(nrs + 1, cl);

                slide.Shapes.Title.TextFrame.TextRange.Text = "CAMERA SINGLE";

                slide.Shapes[2].TextFrame.TextRange.Text = "Camerele Single ofera oaspetilor o atmosfera calda si linistitoare care imbina perfect relaxarea cu utilul. Camerele single sunt cu vedere spre curtea interioara si asigura liniste deplina atat pe timp de zi cat si pe timp de noapte." +
                                                           "Oaspetii se pot bucura de Internet wireless, televiziune prin cablu si control individual al climei.";

                slide.Shapes.Title.TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();

                slide.Shapes[2].TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();

                slide.Shapes.Title.TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoCTrue;

                slide.Shapes[2].TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoCTrue;

                string cale = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\single1.jpg";

                string cale2 = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\single2.jpg";

                string cale3 = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\single3.jpg";


                float lat = slide.CustomLayout.Width;
                float inalt = slide.CustomLayout.Height;


                PP.Shape shape = slide.Shapes.AddPicture(cale, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);

                slide.Shapes[2].ZOrder(Office.MsoZOrderCmd.msoBringToFront);

                slide.Shapes.Title.ZOrder(Office.MsoZOrderCmd.msoBringToFront);


                slide = pres.Slides.AddSlide(nrs + 2, cl);

                PP.Shape shape2 = slide.Shapes.AddPicture(cale2, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);


                slide = pres.Slides.AddSlide(nrs + 3, cl);

                PP.Shape shape3 = slide.Shapes.AddPicture(cale3, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);

            }

            if(cmbDisponibile.Text == "DOUBLE")
            {

                Hotel = new PP.Application();
                pres = Hotel.Presentations.Add();

                int nrs = pres.Slides.Count;

                PP.CustomLayout cl = pres.SlideMaster.CustomLayouts[PP.PpSlideLayout.ppLayoutTitle];

                slide = pres.Slides.AddSlide(nrs + 1, cl);

                slide.Shapes.Title.TextFrame.TextRange.Text = "CAMERA DOUBLE";

                slide.Shapes[2].TextFrame.TextRange.Text = "Camerele Double oferta oaspetilor nostri o atmosfera calda si linistitoare care imbina perfect relaxarea cu utilul. Camerele double au vedere spre cladirea Cercului Militar si Calea Victoriei asigurand o panorama incontestabila asupra arhitecturii de altadata. Oaspetii se pot bucura de Internet wireless, televiziune prin cablu si control individual al climei";


                slide.Shapes.Title.TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();

                slide.Shapes[2].TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();

                slide.Shapes.Title.TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoCTrue;

                slide.Shapes[2].TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoCTrue;

                string cale = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\double1.jpg";

                string cale2 = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\double2.jpg";

                string cale3 = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\double3.jpg";


                float lat = slide.CustomLayout.Width;
                float inalt = slide.CustomLayout.Height;


                PP.Shape shape = slide.Shapes.AddPicture(cale, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);

                slide.Shapes[2].ZOrder(Office.MsoZOrderCmd.msoBringToFront);

                slide.Shapes.Title.ZOrder(Office.MsoZOrderCmd.msoBringToFront);


                slide = pres.Slides.AddSlide(nrs + 2, cl);

                PP.Shape shape2 = slide.Shapes.AddPicture(cale2, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);


                slide = pres.Slides.AddSlide(nrs + 3, cl);

                PP.Shape shape3 = slide.Shapes.AddPicture(cale3, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);

            }


            if (cmbDisponibile.Text == "APARTAMENT")
            {

                Hotel = new PP.Application();
                pres = Hotel.Presentations.Add();

                int nrs = pres.Slides.Count;

                PP.CustomLayout cl = pres.SlideMaster.CustomLayouts[PP.PpSlideLayout.ppLayoutTitle];

                slide = pres.Slides.AddSlide(nrs + 1, cl);

                slide.Shapes.Title.TextFrame.TextRange.Text = "APARTAMENT";

                slide.Shapes[2].TextFrame.TextRange.Text = "Apartamentele ofera oaspetilor nostri o atmosfera calda si linistitoare care imbina perfect relaxarea cu utilul. Apartamentele au vedere spre cladirea Cercului Militar si Calea Victoriei, asigurand o panorama incontestabila asupra arhitecturii de altadata. Oaspetii se pot bucura de Internet wireless, televiziune prin cablu si control individual al climei.";


                slide.Shapes.Title.TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();

                slide.Shapes[2].TextFrame.TextRange.Font.Color.RGB = Color.White.ToArgb();

                slide.Shapes.Title.TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoCTrue;

                slide.Shapes[2].TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoCTrue;

                string cale = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\ap1.jpg";

                string cale2 = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\ap2.jpg";

                string cale3 = @"C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Poze\ap3.jpg";


                float lat = slide.CustomLayout.Width;
                float inalt = slide.CustomLayout.Height;


                PP.Shape shape = slide.Shapes.AddPicture(cale, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);

                slide.Shapes[2].ZOrder(Office.MsoZOrderCmd.msoBringToFront);

                slide.Shapes.Title.ZOrder(Office.MsoZOrderCmd.msoBringToFront);


                slide = pres.Slides.AddSlide(nrs + 2, cl);

                PP.Shape shape2 = slide.Shapes.AddPicture(cale2, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);


                slide = pres.Slides.AddSlide(nrs + 3, cl);

                PP.Shape shape3 = slide.Shapes.AddPicture(cale3, Office.MsoTriState.msoCTrue, Office.MsoTriState.msoFalse, 0, 0, lat - 0, inalt - 0);

            }


            PP.SlideRange ssr = pres.Slides.Range();
            PP.SlideShowTransition sst = ssr.SlideShowTransition;
            sst.AdvanceOnTime = Office.MsoTriState.msoTrue;
            sst.AdvanceTime = 3;
            sst.EntryEffect = PP.PpEntryEffect.ppEffectRevealSmoothRight;
            PP.SlideShowSettings ssp = pres.SlideShowSettings;
            ssp.StartingSlide = 1;
            ssp.EndingSlide = pres.Slides.Count;
            ssp.Run();

        }

        private void dtpInceput_Leave(object sender, EventArgs e)
        {


            if (dtpSfarsit.Value.Date < dtpInceput.Value.Date)
            {

                
                dtpSfarsit.Enabled = false;
                dtpInceput.Select();

                btnCautare.Visible = false;

            }

            else

            {

                btnCautare.Visible = true;
                dtpSfarsit.Enabled = true;

            }


        }

        private void dtpSfarsit_Leave(object sender, EventArgs e)
        {

            if (dtpSfarsit.Value.Date < dtpInceput.Value.Date)
            {


                dtpInceput.Enabled = false;
                dtpSfarsit.Select();

                btnCautare.Visible = false;

            }

            else

            {

                btnCautare.Visible = true;
                dtpInceput.Enabled = true;

            }

        }

    }
}
