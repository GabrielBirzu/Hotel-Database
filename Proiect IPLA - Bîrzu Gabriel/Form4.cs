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
using Word = Microsoft.Office.Interop.Word;


namespace Proiect_IPLA___Bîrzu_Gabriel
{
    public partial class Form4 : Form
    {

        Word.Application Tarife;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Hotel.accdb");

        public Form4()
        {
            InitializeComponent();

        }

        private void btnRezervare_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form5 frm5 = new Form5();

            frm5.Show();

        }

        private void btnTarife_Click(object sender, EventArgs e)
        {

            Tarife = new Word.Application();

            Tarife.Visible = true;

            Word.Document wdoc = Tarife.Documents.Add();

            Word.Range wr = wdoc.Range();

            wr.Text = "\n\n" + "TARIFE HOTEL" + "\n\n\n";


            wr.Font.Name = "Segoe UI";

            wr.Font.Size = 14;

            wr.Font.Bold = -1;

            wdoc.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            wr.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            Word.Table tabel = wr.Tables.Add(wr, 9, 2);

            wr.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            tabel.set_Style("Table Grid 8");

            tabel.Borders.Enable = 1;

            tabel.Cell(1, 1).Range.Text = "TIP CAMERĂ";

            tabel.Cell(1, 1).Range.Font.Size = 17;

            tabel.Cell(1, 2).Range.Text = "PREȚ PE NOAPTE";

            tabel.Cell(1, 2).Range.Font.Size = 17;

            con.Open();


            OleDbDataAdapter cmdTip = new OleDbDataAdapter("SELECT Tip_Camera, Pret_Noapte " +
                                                           "FROM Camere ", con);

            DataTable dtTip = new DataTable();

            cmdTip.Fill(dtTip);

            int nr = 0;

            int linie = 2;


            try
            {



                while (dtTip.Rows[nr][0].ToString() != "")
                {

                    tabel.Cell(linie, 1).Range.Text = dtTip.Rows[nr][0].ToString();

                    tabel.Cell(linie, 2).Range.Text = dtTip.Rows[nr][1].ToString() + " LEI";

                    nr += 1;

                    linie += 1;

                }



            }

            catch (Exception ex)
            {

            }

 

                tabel.Cell(linie, 1).Range.Text = "EXTRAOPȚIUNE";

                tabel.Cell(linie, 1).Range.Font.Size = 17;

                tabel.Cell(linie, 1).Range.Font.Bold = 0;

                tabel.Cell(linie, 1).Range.Font.Color = Word.WdColor.wdColorWhite;

                tabel.Cell(linie, 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkBlue;

                tabel.Cell(linie, 2).Range.Text = "PREȚ";

                tabel.Cell(linie, 2).Range.Font.Size = 17;

                tabel.Cell(linie, 2).Range.Font.Bold = 0;

                tabel.Cell(linie, 2).Range.Font.Color = Word.WdColor.wdColorWhite;

                tabel.Cell(linie, 2).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkBlue;



            OleDbDataAdapter cmdExtra = new OleDbDataAdapter("SELECT Denumire_Extraoptiune, Pret_Extraoptiune " +
                                                             "FROM Extraoptiuni ", con);

            DataTable dtExtra = new DataTable();

            cmdExtra.Fill(dtExtra);

            nr = 0;

            try
            {

                while (dtExtra.Rows[nr][0].ToString() != "")
                {

                    nr += 1;

                    linie += 1;

                    tabel.Cell(linie, 1).Range.Text = dtExtra.Rows[nr][0].ToString();

                    tabel.Cell(linie, 2).Range.Text = dtExtra.Rows[nr][1].ToString() + " LEI";




                }

            }

            catch (Exception ex)

            {


            }

        }

    }
}
