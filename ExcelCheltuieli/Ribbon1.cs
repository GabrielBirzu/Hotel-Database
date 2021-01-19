using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace ExcelCheltuieli
{
    public partial class Ribbon1
    {

        Word.Application factura;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gabriel Birzu\OneDrive\Desktop\Proiect IPLA\Hotel.accdb");

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {


        }

        private void btnExcel_Click(object sender, RibbonControlEventArgs e)
        {

            factura = new Word.Application();

            factura.Visible = true;

            Word.Document wdoc = factura.Documents.Add();

            Word.Range wr = wdoc.Range();

            wr.Text = "\n\n" + "FACTURĂ" + "\n\n\n";


            wr.Font.Name = "Segoe UI";

            wr.Font.Size = 14;

            wr.Font.Bold = -1;

            wdoc.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            wr.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            Word.Table tabel = wr.Tables.Add(wr, 4, 2);

            wr.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            tabel.set_Style("Table Grid 8");

            tabel.Borders.Enable = 1;

            tabel.Cell(1, 1).Range.Text = "DENUMIRE";

            tabel.Cell(1, 1).Range.Font.Size = 17;

            tabel.Cell(1, 2).Range.Text = "DE PLĂTIT";

            tabel.Cell(1, 2).Range.Font.Size = 17;

            tabel.Cell(2, 1).Range.Text = "REZERVARE";

            tabel.Cell(3, 1).Range.Text = "ALTE CHELTUIELI";

            tabel.Cell(4, 1).Range.Text = "TOTAL";



            Excel.Application excel = Globals.ThisAddIn.Application;
            Excel.Worksheet wsh = excel.ActiveSheet;
            Excel.Range rsh = excel.Selection;

            

            con.Open();

            OleDbDataAdapter cmdInregistrari = new OleDbDataAdapter("SELECT (Pret_Noapte*(Data_Sfarsit-Data_Inceput)) AS TotalRez, Sum(Extraoptiuni.Pret_Extraoptiune) AS TotalEx " +
                                                                    "FROM Clienti INNER JOIN((Rezervari INNER JOIN(Camere INNER JOIN Camere_Rezervate ON Camere.Tip_Camera = Camere_Rezervate.Tip_Camera) ON Rezervari.NR_Inregistrare = Camere_Rezervate.NR_Inregistrare) INNER JOIN(Extraoptiuni INNER JOIN Extraoptiuni_Rezervare ON Extraoptiuni.Denumire_Extraoptiune = Extraoptiuni_Rezervare.Denumire_Extraoptiune) ON Rezervari.NR_Inregistrare = Extraoptiuni_Rezervare.NR_Inregistrare) ON Clienti.ID_Client = Rezervari.ID_Client " +
                                                                    "WHERE Rezervari.NR_Inregistrare Like '" + rsh.Value2.ToString() + "'" +
                                                                    "GROUP BY Rezervari.NR_Inregistrare, Rezervari.Data_Inceput, Rezervari.Data_Sfarsit, Camere.Pret_Noapte; ", con) ; 
            DataTable dtInregistrari = new DataTable();

            cmdInregistrari.Fill(dtInregistrari);

            int a;

            int b;

            a = Int32.Parse(dtInregistrari.Rows[0][0].ToString());

            b = Int32.Parse(dtInregistrari.Rows[0][1].ToString());


            tabel.Cell(2, 2).Range.Text = dtInregistrari.Rows[0][0].ToString() + " LEI";

            tabel.Cell(3, 2).Range.Text = dtInregistrari.Rows[0][1].ToString() + " LEI";

            tabel.Cell(4, 2).Range.Text = (a + b).ToString() + " LEI";


            con.Close();


        }

        private void btnIntroducereDate_Click(object sender, RibbonControlEventArgs e)
        {


            string value = Interaction.InputBox("INTRODUCEȚI CODUL NUMERIC PERSONAL", "CNP","",500, 300);

            if (value != "")
            {


                con.Open();

                OleDbDataAdapter cmdInregistrari = new OleDbDataAdapter("SELECT Rezervari.NR_Inregistrare, Rezervari.Data_Inceput, Rezervari.Data_Sfarsit, (Pret_Noapte*(Data_Sfarsit-Data_Inceput)) AS TotalRez, Sum(Extraoptiuni.Pret_Extraoptiune) AS TotalEx " +
                                                                        "FROM Clienti INNER JOIN((Rezervari INNER JOIN(Camere INNER JOIN Camere_Rezervate ON Camere.Tip_Camera = Camere_Rezervate.Tip_Camera) ON Rezervari.NR_Inregistrare = Camere_Rezervate.NR_Inregistrare) INNER JOIN(Extraoptiuni INNER JOIN Extraoptiuni_Rezervare ON Extraoptiuni.Denumire_Extraoptiune = Extraoptiuni_Rezervare.Denumire_Extraoptiune) ON Rezervari.NR_Inregistrare = Extraoptiuni_Rezervare.NR_Inregistrare) ON Clienti.ID_Client = Rezervari.ID_Client " +
                                                                        "WHERE Clienti.[CNP] Like '" + value + "'" +
                                                                        "GROUP BY Rezervari.NR_Inregistrare, Rezervari.Data_Inceput, Rezervari.Data_Sfarsit, Camere.Pret_Noapte; ", con);


                DataTable dtInregistrari = new DataTable();

                cmdInregistrari.Fill(dtInregistrari);


                Excel.Application excel = Globals.ThisAddIn.Application;
                Excel.Worksheet wsh = excel.ActiveSheet;
                Excel.Range rsh = excel.Selection;



                int nl = rsh.Rows.Count;
                int nc = rsh.Columns.Count;

                rsh.Cells[1, 1].Value = "Nr_Înregistrare";
                wsh.Cells[1, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                rsh.Cells[1, 2].Value = "Dată_Început";
                wsh.Cells[1, 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                rsh.Cells[1, 3].Value = "Dată_Sfârșit";
                wsh.Cells[1, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                rsh.Cells[1, 4].Value = "Total_Rezervare";
                wsh.Cells[1, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                rsh.Cells[1, 5].Value = "Total_Extraopțiuni";
                wsh.Cells[1, 5].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                int nr = 0;
                int i = 2;

                try
                {

                    while (dtInregistrari.Rows[nr][0].ToString() != "")
                    {

                        rsh.Cells[i, 1].Value = dtInregistrari.Rows[nr][0].ToString();
                        rsh.Cells[i, 2].Value = dtInregistrari.Rows[nr][1].ToString();
                        rsh.Cells[i, 3].Value = dtInregistrari.Rows[nr][2].ToString();
                        rsh.Cells[i, 4].Value = dtInregistrari.Rows[nr][3].ToString();
                        rsh.Cells[i, 5].Value = dtInregistrari.Rows[nr][4].ToString();

                        i += 1;
                        nr += 1;

                    }


                }

                catch (Exception ex)
                {


                    wsh.Columns.AutoFit();
                    wsh.Rows.AutoFit();

                    con.Close();
                    return;

                }

            }


        }
    }
}
