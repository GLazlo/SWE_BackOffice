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
using System.Globalization;

namespace backoffice
{
    public partial class EditProjektForm : Form
    {
        private Button Save_Projekt;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox Projket_Name;
        private TextBox Projekt_ProjektID;
        private Button Discard_Projekt;


        public EditProjektForm(Projekt a, bool newProjekt)
        {
            InitializeComponent();

            if (newProjekt)
            {
                Projekt_ProjektID.Text = "none";
                this.Text = "Neues Projekt anlegen";
            }
            else
            {
                this.Text = "Bearbeiten von Projekt \"" + a.Name + "\"";
                Projekt_ProjektID.Text = a.ProjektID.ToString();
                Projket_Name.Text = a.Name.ToString();
            }
            
        }


        private void Discard_Projekt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Save_Projekt_Click(object sender, EventArgs e)
        {

            ProxyLayer myProxy = new ProxyLayer();

            List<EntityInterface> projektListe = new List<EntityInterface>();
            
            Projekt a = new Projekt();

           
            a.Name = Convert.ToString(Projket_Name.Text);

            if (Projekt_ProjektID.Text == "none")
            {
                projektListe.Add(a);
                myProxy.add(projektListe, "Projekt");
            }
            else
            {
                a.ProjektID = Convert.ToInt32(Projekt_ProjektID.Text);
                projektListe.Add(a);
                myProxy.edit(projektListe, "Projekt");
            }



           


            this.Close();

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                this.Dispose();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProjektForm));
            this.Save_Projekt = new System.Windows.Forms.Button();
            this.Discard_Projekt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Projekt_ProjektID = new System.Windows.Forms.TextBox();
            this.Projket_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save_Projekt
            // 
            this.Save_Projekt.Location = new System.Drawing.Point(476, 12);
            this.Save_Projekt.Name = "Save_Projekt";
            this.Save_Projekt.Size = new System.Drawing.Size(110, 35);
            this.Save_Projekt.TabIndex = 1;
            this.Save_Projekt.Text = "Save and close";
            this.Save_Projekt.UseVisualStyleBackColor = true;
            this.Save_Projekt.Click += new System.EventHandler(this.Save_Projekt_Click);
            // 
            // Discard_Projekt
            // 
            this.Discard_Projekt.Location = new System.Drawing.Point(476, 53);
            this.Discard_Projekt.Name = "Discard_Projekt";
            this.Discard_Projekt.Size = new System.Drawing.Size(110, 35);
            this.Discard_Projekt.TabIndex = 2;
            this.Discard_Projekt.Text = "Discard Changes and Close (Esc)";
            this.Discard_Projekt.UseVisualStyleBackColor = true;
            this.Discard_Projekt.Click += new System.EventHandler(this.Discard_Projekt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Projekt_ProjektID);
            this.groupBox1.Controls.Add(this.Projket_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekt bearbeiten";
            // 
            // Projekt_ProjektID
            // 
            this.Projekt_ProjektID.Location = new System.Drawing.Point(148, 56);
            this.Projekt_ProjektID.Name = "Projekt_ProjektID";
            this.Projekt_ProjektID.Size = new System.Drawing.Size(296, 20);
            this.Projekt_ProjektID.TabIndex = 19;
            this.Projekt_ProjektID.Visible = false;
            // 
            // Projket_Name
            // 
            this.Projket_Name.Location = new System.Drawing.Point(148, 22);
            this.Projket_Name.Name = "Projket_Name";
            this.Projket_Name.Size = new System.Drawing.Size(296, 20);
            this.Projket_Name.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projektname";
            // 
            // EditProjektForm
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(598, 99);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Discard_Projekt);
            this.Controls.Add(this.Save_Projekt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "EditProjektForm";
            this.Text = "Edit Projekt Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

       


      
    }
}
