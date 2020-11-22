
namespace Igra_ListeObjekata_Datoteke
{
	partial class Glavna
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnUnesi = new System.Windows.Forms.Button();
			this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
			this.nazivLabel = new System.Windows.Forms.Label();
			this.txtNaziv = new System.Windows.Forms.TextBox();
			this.idIzdavacLabel = new System.Windows.Forms.Label();
			this.cijenaLabel = new System.Windows.Forms.Label();
			this.txtCijena = new System.Windows.Forms.TextBox();
			this.datumIzdavanjaLabel = new System.Windows.Forms.Label();
			this.opisLabel = new System.Windows.Forms.Label();
			this.txtOpis = new System.Windows.Forms.TextBox();
			this.idVrstaIgreLabel = new System.Windows.Forms.Label();
			this.txtIzdavac = new System.Windows.Forms.TextBox();
			this.txtVrsta = new System.Windows.Forms.TextBox();
			this.lstIgre = new System.Windows.Forms.ListBox();
			this.btnUkloni = new System.Windows.Forms.Button();
			this.btnSpremi = new System.Windows.Forms.Button();
			this.btnUcitaj = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnUnesi
			// 
			this.btnUnesi.Location = new System.Drawing.Point(126, 206);
			this.btnUnesi.Name = "btnUnesi";
			this.btnUnesi.Size = new System.Drawing.Size(233, 23);
			this.btnUnesi.TabIndex = 29;
			this.btnUnesi.Text = "Unesi";
			this.btnUnesi.UseVisualStyleBackColor = true;
			this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
			// 
			// txtDatumIzdavanja
			// 
			this.txtDatumIzdavanja.Location = new System.Drawing.Point(535, 58);
			this.txtDatumIzdavanja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
			this.txtDatumIzdavanja.Size = new System.Drawing.Size(233, 23);
			this.txtDatumIzdavanja.TabIndex = 20;
			// 
			// nazivLabel
			// 
			this.nazivLabel.AutoSize = true;
			this.nazivLabel.Location = new System.Drawing.Point(14, 61);
			this.nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nazivLabel.Name = "nazivLabel";
			this.nazivLabel.Size = new System.Drawing.Size(39, 15);
			this.nazivLabel.TabIndex = 21;
			this.nazivLabel.Text = "Naziv:";
			// 
			// txtNaziv
			// 
			this.txtNaziv.Location = new System.Drawing.Point(126, 58);
			this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtNaziv.Name = "txtNaziv";
			this.txtNaziv.Size = new System.Drawing.Size(233, 23);
			this.txtNaziv.TabIndex = 17;
			// 
			// idIzdavacLabel
			// 
			this.idIzdavacLabel.AutoSize = true;
			this.idIzdavacLabel.Location = new System.Drawing.Point(429, 131);
			this.idIzdavacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.idIzdavacLabel.Name = "idIzdavacLabel";
			this.idIzdavacLabel.Size = new System.Drawing.Size(49, 15);
			this.idIzdavacLabel.TabIndex = 23;
			this.idIzdavacLabel.Text = "Izdavač:";
			// 
			// cijenaLabel
			// 
			this.cijenaLabel.AutoSize = true;
			this.cijenaLabel.Location = new System.Drawing.Point(429, 91);
			this.cijenaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.cijenaLabel.Name = "cijenaLabel";
			this.cijenaLabel.Size = new System.Drawing.Size(43, 15);
			this.cijenaLabel.TabIndex = 25;
			this.cijenaLabel.Text = "Cijena:";
			// 
			// txtCijena
			// 
			this.txtCijena.Location = new System.Drawing.Point(535, 88);
			this.txtCijena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCijena.Name = "txtCijena";
			this.txtCijena.Size = new System.Drawing.Size(233, 23);
			this.txtCijena.TabIndex = 22;
			// 
			// datumIzdavanjaLabel
			// 
			this.datumIzdavanjaLabel.AutoSize = true;
			this.datumIzdavanjaLabel.Location = new System.Drawing.Point(429, 61);
			this.datumIzdavanjaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.datumIzdavanjaLabel.Name = "datumIzdavanjaLabel";
			this.datumIzdavanjaLabel.Size = new System.Drawing.Size(98, 15);
			this.datumIzdavanjaLabel.TabIndex = 26;
			this.datumIzdavanjaLabel.Text = "Datum Izdavanja:";
			// 
			// opisLabel
			// 
			this.opisLabel.AutoSize = true;
			this.opisLabel.Location = new System.Drawing.Point(14, 91);
			this.opisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.opisLabel.Name = "opisLabel";
			this.opisLabel.Size = new System.Drawing.Size(34, 15);
			this.opisLabel.TabIndex = 27;
			this.opisLabel.Text = "Opis:";
			// 
			// txtOpis
			// 
			this.txtOpis.Location = new System.Drawing.Point(126, 88);
			this.txtOpis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtOpis.Multiline = true;
			this.txtOpis.Name = "txtOpis";
			this.txtOpis.Size = new System.Drawing.Size(233, 61);
			this.txtOpis.TabIndex = 18;
			// 
			// idVrstaIgreLabel
			// 
			this.idVrstaIgreLabel.AutoSize = true;
			this.idVrstaIgreLabel.Location = new System.Drawing.Point(14, 168);
			this.idVrstaIgreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.idVrstaIgreLabel.Name = "idVrstaIgreLabel";
			this.idVrstaIgreLabel.Size = new System.Drawing.Size(59, 15);
			this.idVrstaIgreLabel.TabIndex = 28;
			this.idVrstaIgreLabel.Text = "Vrsta Igre:";
			// 
			// txtIzdavac
			// 
			this.txtIzdavac.Location = new System.Drawing.Point(535, 128);
			this.txtIzdavac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtIzdavac.Name = "txtIzdavac";
			this.txtIzdavac.Size = new System.Drawing.Size(233, 23);
			this.txtIzdavac.TabIndex = 24;
			// 
			// txtVrsta
			// 
			this.txtVrsta.Location = new System.Drawing.Point(126, 165);
			this.txtVrsta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtVrsta.Name = "txtVrsta";
			this.txtVrsta.Size = new System.Drawing.Size(233, 23);
			this.txtVrsta.TabIndex = 19;
			// 
			// lstIgre
			// 
			this.lstIgre.FormattingEnabled = true;
			this.lstIgre.ItemHeight = 15;
			this.lstIgre.Location = new System.Drawing.Point(126, 270);
			this.lstIgre.Name = "lstIgre";
			this.lstIgre.Size = new System.Drawing.Size(352, 154);
			this.lstIgre.TabIndex = 30;
			// 
			// btnUkloni
			// 
			this.btnUkloni.Location = new System.Drawing.Point(535, 270);
			this.btnUkloni.Name = "btnUkloni";
			this.btnUkloni.Size = new System.Drawing.Size(118, 35);
			this.btnUkloni.TabIndex = 31;
			this.btnUkloni.Text = "Ukloni";
			this.btnUkloni.UseVisualStyleBackColor = true;
			this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
			// 
			// btnSpremi
			// 
			this.btnSpremi.Location = new System.Drawing.Point(14, 12);
			this.btnSpremi.Name = "btnSpremi";
			this.btnSpremi.Size = new System.Drawing.Size(132, 23);
			this.btnSpremi.TabIndex = 32;
			this.btnSpremi.Text = "Spremi u datoteku";
			this.btnSpremi.UseVisualStyleBackColor = true;
			this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
			// 
			// btnUcitaj
			// 
			this.btnUcitaj.Location = new System.Drawing.Point(167, 12);
			this.btnUcitaj.Name = "btnUcitaj";
			this.btnUcitaj.Size = new System.Drawing.Size(167, 23);
			this.btnUcitaj.TabIndex = 33;
			this.btnUcitaj.Text = "Učitaj iz datoteke";
			this.btnUcitaj.UseVisualStyleBackColor = true;
			this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
			// 
			// Glavna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnUcitaj);
			this.Controls.Add(this.btnSpremi);
			this.Controls.Add(this.btnUkloni);
			this.Controls.Add(this.lstIgre);
			this.Controls.Add(this.btnUnesi);
			this.Controls.Add(this.txtDatumIzdavanja);
			this.Controls.Add(this.nazivLabel);
			this.Controls.Add(this.txtNaziv);
			this.Controls.Add(this.idIzdavacLabel);
			this.Controls.Add(this.cijenaLabel);
			this.Controls.Add(this.txtCijena);
			this.Controls.Add(this.datumIzdavanjaLabel);
			this.Controls.Add(this.opisLabel);
			this.Controls.Add(this.txtOpis);
			this.Controls.Add(this.idVrstaIgreLabel);
			this.Controls.Add(this.txtIzdavac);
			this.Controls.Add(this.txtVrsta);
			this.Name = "Glavna";
			this.Text = "Igre";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUnesi;
		private System.Windows.Forms.TextBox txtDatumIzdavanja;
		private System.Windows.Forms.Label nazivLabel;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Label idIzdavacLabel;
		private System.Windows.Forms.Label cijenaLabel;
		private System.Windows.Forms.TextBox txtCijena;
		private System.Windows.Forms.Label datumIzdavanjaLabel;
		private System.Windows.Forms.Label opisLabel;
		private System.Windows.Forms.TextBox txtOpis;
		private System.Windows.Forms.Label idVrstaIgreLabel;
		private System.Windows.Forms.TextBox txtIzdavac;
		private System.Windows.Forms.TextBox txtVrsta;
		private System.Windows.Forms.ListBox lstIgre;
		private System.Windows.Forms.Button btnUkloni;
		private System.Windows.Forms.Button btnSpremi;
		private System.Windows.Forms.Button btnUcitaj;
	}
}

