﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backoffice
{
    partial class GUI : Form
    {
        private EditKontaktForm editKontaktForm;
        private EditKundeForm editKundeForm;
        private EditAngebotForm editAngebotForm;
        private EditProjektForm editProjektForm;
        private EditAusgangsrechnungenForm editAusgangsrechnungenForm;
        private EditEingangsrechnungenForm editEingangsrechnungenForm;

        //------------------------------------------------------------------------edit functions START----------------------------------------------------//
        private void edit_Click(object sender, EventArgs e)
        {
            string from = string.Empty;
            if (sender.ToString() == "System.Windows.Forms.DataGridView")
            {
                from = Convert.ToString(((DataGridView)sender).Name);
            }
            else
            {
                from = Convert.ToString(((Button)sender).Name);
            }
            int x = 0;

            switch (from)
            {
                case "dataGridViewKunde":
                case "editKunde":
                    Kunde kunde = new Kunde();

                    foreach (DataGridViewRow selRow in dataGridViewKunde.SelectedRows)
                    {
                        x = selRow.Index;

                        kunde.KundeID = Convert.ToInt32(dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["KundeID"].Index].Value.ToString());
                        kunde.Firma = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Firma"].Index].Value.ToString();
                        kunde.Anrede = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Anrede"].Index].Value.ToString();
                        kunde.Vorname = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Vorname"].Index].Value.ToString();
                        kunde.Nachname = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Nachname"].Index].Value.ToString();
                        kunde.Firmenbuchnummer = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Firmenbuchnummer"].Index].Value.ToString();
                        kunde.UID = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["UID"].Index].Value.ToString();
                        kunde.Telefonnummer = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Telefonnummer"].Index].Value.ToString();
                        kunde.Land = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Land"].Index].Value.ToString();
                        kunde.PLZ = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["PLZ"].Index].Value.ToString();
                        kunde.Strasse = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Strasse"].Index].Value.ToString();
                        kunde.HNr = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["HNr"].Index].Value.ToString();
                        kunde.Kontonummer = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["Kontonummer"].Index].Value.ToString();
                        kunde.BLZ = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["BLZ"].Index].Value.ToString();
                        kunde.IBAN = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["IBAN"].Index].Value.ToString();
                        kunde.BIC = dataGridViewKunde.Rows[x].Cells[dataGridViewKunde.Columns["BIC"].Index].Value.ToString();

                        this.editKundeForm = new EditKundeForm(kunde, false);
                        //on new editForm Close() the dataGridVIewKunde will be refreshed
                        editKundeForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
                        editKundeForm.Show();
                    }
                    break;
                case "dataGridViewKontakt":
                case "editKontakt":

                    Kontakt kontakt = new Kontakt();

                    foreach (DataGridViewRow selRow in dataGridViewKontakt.SelectedRows)
                    {
                        x = selRow.Index;


                        kontakt.KontaktID = Convert.ToInt32(dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["KontaktID"].Index].Value.ToString());
                        kontakt.Firma = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Firma"].Index].Value.ToString();
                        kontakt.Anrede = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Anrede"].Index].Value.ToString();
                        kontakt.Vorname = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Vorname"].Index].Value.ToString();
                        kontakt.Nachname = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Nachname"].Index].Value.ToString();
                        kontakt.Firmenbuchnummer = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Firmenbuchnummer"].Index].Value.ToString();
                        kontakt.UID = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["UID"].Index].Value.ToString();
                        kontakt.Telefonnummer = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Telefonnummer"].Index].Value.ToString();
                        kontakt.Land = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Land"].Index].Value.ToString();
                        kontakt.PLZ = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["PLZ"].Index].Value.ToString();
                        kontakt.Strasse = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Strasse"].Index].Value.ToString();
                        kontakt.HNr = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["HNr"].Index].Value.ToString();
                        kontakt.Kontonummer = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["Kontonummer"].Index].Value.ToString();
                        kontakt.BLZ = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["BLZ"].Index].Value.ToString();
                        kontakt.IBAN = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["IBAN"].Index].Value.ToString();
                        kontakt.BIC = dataGridViewKontakt.Rows[x].Cells[dataGridViewKontakt.Columns["BIC"].Index].Value.ToString();


                        this.editKontaktForm = new EditKontaktForm(kontakt, false);
                        //on new editForm Close() the dataGridVIewKontakt will be refreshed
                        editKontaktForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
                        editKontaktForm.Show();
                    }
                    break;
                case "dataGridViewAngebot":
                case "editAngebot":

                    Angebot angebot = new Angebot();

                    foreach (DataGridViewRow selRow in dataGridViewAngebot.SelectedRows)
                    {
                        x = selRow.Index;
                        angebot.AngebotID = Convert.ToInt32(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["AngebotID"].Index].Value.ToString());
                        angebot.FK_ProjektID = Convert.ToInt32(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["FK_ProjektID"].Index].Value.ToString());
                        angebot.FK_KundeID = Convert.ToInt32(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["FK_KundeID"].Index].Value.ToString());
                        angebot.Angebotsname = Convert.ToString(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["Angebotsname"].Index].Value.ToString());
                        angebot.Angebotssumme = float.Parse(Convert.ToString(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["Angebotssumme"].Index].Value.ToString()));
                        angebot.Datum = Convert.ToDateTime(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["Datum"].Index].Value.ToString());
                        angebot.Dauer = Convert.ToInt32(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["Dauer"].Index].Value.ToString());
                        angebot.UmsetzungsChance = Convert.ToInt32(dataGridViewAngebot.Rows[x].Cells[dataGridViewAngebot.Columns["UmsetzungsChance"].Index].Value.ToString());

                        this.editAngebotForm = new EditAngebotForm(angebot, false);
                        //on new editForm Close() the dataGridVIewKontakt will be refreshed
                        editAngebotForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
                        editAngebotForm.Show();
                    }
                    break;
                case "dataGridViewProjekt":
                case "editProjekt":

                    Projekt projekt = new Projekt();

                    foreach (DataGridViewRow selRow in dataGridViewProjekt.SelectedRows)
                    {
                        x = selRow.Index;
                        projekt.ProjektID = Convert.ToInt32(dataGridViewProjekt.Rows[x].Cells[dataGridViewProjekt.Columns["ProjektID"].Index].Value.ToString());
                        projekt.Name = dataGridViewProjekt.Rows[x].Cells[dataGridViewProjekt.Columns["Name"].Index].Value.ToString();

                        this.editProjektForm = new EditProjektForm(projekt, false);
                        //on new editForm Close() the dataGridVIewKontakt will be refreshed
                        editProjektForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
                        editProjektForm.Show();
                    }
                    break;
                case "dataGridViewAusgangsrechnung":
                case "editAusgangsrechnung":

                    Ausgangsrechnung ausgangsrechnung = new Ausgangsrechnung();

                    foreach (DataGridViewRow selRow in dataGridViewAusgangsrechnung.SelectedRows)
                    {
                        x = selRow.Index;
                        ausgangsrechnung.AusgangsrechnungID = Convert.ToInt32(dataGridViewAusgangsrechnung.Rows[x].Cells[dataGridViewAusgangsrechnung.Columns["AusgangsrechnungID"].Index].Value.ToString());
                        ausgangsrechnung.Projekt = Convert.ToString(dataGridViewAusgangsrechnung.Rows[x].Cells[dataGridViewAusgangsrechnung.Columns["Projekt"].Index].Value.ToString());
                        ausgangsrechnung.Kunde = Convert.ToString(dataGridViewAusgangsrechnung.Rows[x].Cells[dataGridViewAusgangsrechnung.Columns["Kunde"].Index].Value.ToString());
                        ausgangsrechnung.Datum = Convert.ToDateTime(dataGridViewAusgangsrechnung.Rows[x].Cells[dataGridViewAusgangsrechnung.Columns["Datum"].Index].Value.ToString());
                        ausgangsrechnung.Summe = float.Parse(Convert.ToString((dataGridViewAusgangsrechnung.Rows[x].Cells[dataGridViewAusgangsrechnung.Columns["Summe"].Index].Value.ToString())));
                        ausgangsrechnung.Bezahlt = Convert.ToString(dataGridViewAusgangsrechnung.Rows[x].Cells[dataGridViewAusgangsrechnung.Columns["Bezahlt"].Index].Value.ToString());

                        this.editAusgangsrechnungenForm = new EditAusgangsrechnungenForm(ausgangsrechnung, false);
                        //on new editForm Close() the dataGridVIewKontakt will be refreshed
                        editAusgangsrechnungenForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
                        editAusgangsrechnungenForm.Show();
                    }
                    break;
                case "dataGridViewEingangsrechnung":
                case "editEingangsrechnung":

                    Eingangsrechnung eingangsrechnung = new Eingangsrechnung();

                    foreach (DataGridViewRow selRow in dataGridViewEingangsrechnung.SelectedRows)
                    {
                        x = selRow.Index;
                        eingangsrechnung.EingangsrechnungID = Convert.ToInt32(dataGridViewEingangsrechnung.Rows[x].Cells[dataGridViewEingangsrechnung.Columns["EingangsrechnungID"].Index].Value.ToString());
                        eingangsrechnung.FK_KontaktID = Convert.ToInt32(dataGridViewEingangsrechnung.Rows[x].Cells[dataGridViewEingangsrechnung.Columns["FK_KontaktID"].Index].Value.ToString());
                        eingangsrechnung.Beschreibung = Convert.ToString(dataGridViewEingangsrechnung.Rows[x].Cells[dataGridViewEingangsrechnung.Columns["Beschreibung"].Index].Value.ToString());
                        eingangsrechnung.Summe = float.Parse(Convert.ToString(dataGridViewEingangsrechnung.Rows[x].Cells[dataGridViewEingangsrechnung.Columns["Summe"].Index].Value.ToString()));
                        eingangsrechnung.Datum = Convert.ToDateTime(dataGridViewEingangsrechnung.Rows[x].Cells[dataGridViewEingangsrechnung.Columns["Datum"].Index].Value.ToString());
                        eingangsrechnung.Bezahlt = Convert.ToString(dataGridViewEingangsrechnung.Rows[x].Cells[dataGridViewEingangsrechnung.Columns["Bezahlt"].Index].Value.ToString());

                        this.editEingangsrechnungenForm = new EditEingangsrechnungenForm(eingangsrechnung, false);
                        //on new editForm Close() the dataGridVIewKontakt will be refreshed
                        editEingangsrechnungenForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
                        editEingangsrechnungenForm.Show();
                    }
                    break;




            }

         }

        //------------------------------------------------------------------------edit functions END----------------------------------------------------//

        //------------------------------------------------------------------------add functions START----------------------------------------------------//
       
        private void addKunde_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde();
            this.editKundeForm = new EditKundeForm(k, true);
            editKundeForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
            editKundeForm.ShowDialog();
        }

        private void addKontakt_Click(object sender, EventArgs e)
        {

            Kontakt k = new Kontakt();
            this.editKontaktForm = new EditKontaktForm(k, true);
            editKontaktForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
            editKontaktForm.ShowDialog();
        }

        private void addAngebot_Click(object sender, EventArgs e)
        {

            Angebot k = new Angebot();
            this.editAngebotForm = new EditAngebotForm(k, true);
            editAngebotForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
            editAngebotForm.ShowDialog();
        }

        private void addProjekt_Click(object sender, EventArgs e)
        {
            Projekt k = new Projekt();
            this.editProjektForm = new EditProjektForm(k, true);
            editProjektForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
            editProjektForm.ShowDialog();
        }

        private void addAusgangsrechnung_Click(object sender, EventArgs e)
        {
            Ausgangsrechnung k = new Ausgangsrechnung();
            this.editAusgangsrechnungenForm = new EditAusgangsrechnungenForm(k, true);
            editAusgangsrechnungenForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
            editAusgangsrechnungenForm.ShowDialog();
        }

        private void addEingangsrechnung_Click(object sender, EventArgs e)
        {
            Eingangsrechnung k = new Eingangsrechnung();
            this.editEingangsrechnungenForm = new EditEingangsrechnungenForm(k, true);
            editEingangsrechnungenForm.FormClosed += new FormClosedEventHandler(reloadOnFormClose);
            editEingangsrechnungenForm.ShowDialog();
        }



        //------------------------------------------------------------------------add functions END----------------------------------------------------//

    }
}
