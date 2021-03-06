﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace backoffice
{
    public partial class GUI : Form
    {
        ProxyLayer myRequest;
        private confirmBox confirmBox;

        public GUI()
        {
            myRequest = new ProxyLayer();
            InitializeComponent();
        }

        
        //------------------------------------------------------------------------SELECT request on enter START-----------------------------------------//
        private void checkEnter(object sender, KeyEventArgs e)
        {   //When enter is pressed query is executed
            if (e.KeyCode == Keys.Enter){

                TextBox b = (TextBox)sender;
                //MessageBox.Show(b.Name);
                switch (b.Name)
                {
                    case "textBoxKunde":
                        Kunde.PerformClick();
                        break;
                    case "textBoxKontakt":
                        Kontakt.PerformClick();
                        break;
                    case "textBoxAngebot":
                        Angebot.PerformClick();
                        break;
                    case "textBoxProjekt":
                        Projekt.PerformClick();
                        break;
                    case "textBoxAusgangsrechnung":
                        Ausgangsrechnung.PerformClick();
                        break;
                    case "textBoxEingangsrechnung":
                        Eingangsrechnung.PerformClick();
                        break;
                    case "textBoxKonto":
                        Konto.PerformClick();
                        break;
 
                }
            }
        }

        //------------------------------------------------------------------------SELECT request on enter END-----------------------------------------//
        //------------------------------------------------------------------------EditFormClosedEventHandler for GUI refresh START----------------------------------------------------//
        void reloadOnFormClose(object sender, FormClosedEventArgs e)
        {
            //Updates the query on save
            if (sender.ToString().Contains("Kunde"))
            {
                Kunde.PerformClick();
            }
            else if (sender.ToString().Contains("Kontakt"))
            {
                Kontakt.PerformClick();
            }
            else if (sender.ToString().Contains("Angebot"))
            {
                Angebot.PerformClick();
            }
            else if (sender.ToString().Contains("Projekt"))
            {
                Projekt.PerformClick();
            }
            else if (sender.ToString().Contains("Ausgangsrechnung"))
            {
                Ausgangsrechnung.PerformClick();
            }
            else if (sender.ToString().Contains("Eingangsrechnung"))
            {
                Eingangsrechnung.PerformClick();
            }
            else if (sender.ToString().Contains("Konto"))
            {
                Konto.PerformClick();
            }

            
           
        }

        //------------------------------------------------------------------------EditFormClosedEventHandler for GUI refresh END----------------------------------------------------//

        private void getOpenOutReceipt_Click(object sender, EventArgs e)
        {
            List<EntityInterface> liste = new List<EntityInterface>();
            liste = myRequest.request("none", "Ausgangsrechnungbezahlt");
            List<Ausgangsrechnung> rechnungliste = liste.Cast<Ausgangsrechnung>().ToList();
            dataGridViewAusgangsrechnung.DataSource = rechnungliste;
            dataGridViewAusgangsrechnung.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void getOpenInreceipt_Click(object sender, EventArgs e)
        {
            List<EntityInterface> liste = new List<EntityInterface>();
            liste = myRequest.request("none", "Eingangsrechnungbezahlt");
            List<Eingangsrechnung> rechnungliste = liste.Cast<Eingangsrechnung>().ToList();
            dataGridViewEingangsrechnung.DataSource = rechnungliste;
            dataGridViewEingangsrechnung.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void AusgangsrechnungenPDF_Click(object sender, EventArgs e)
        {
            string pdfString = "";
            Document pdfDoc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new System.IO.FileStream(System.IO.Directory.GetCurrentDirectory() + "\\exportAusgangsrechnungen.pdf",
               System.IO.FileMode.Create));

            pdfDoc.Open();

            foreach (DataGridViewRow row in dataGridViewAusgangsrechnung.SelectedRows)
            {
               
                foreach(DataGridViewCell cell in row.Cells)
                {
                    
                    pdfString += cell.Value.ToString() + " ";
                }
                pdfDoc.Add(new Paragraph (pdfString));
                pdfString = "";

            }

            
            
            PdfContentByte cb = writer.DirectContent;
            cb.MoveTo(pdfDoc.PageSize.Width, pdfDoc.PageSize.Height);
            cb.LineTo(pdfDoc.PageSize.Width / 2, pdfDoc.PageSize.Height);
            cb.Stroke();

            pdfDoc.Close(); 
        }


    }
}
