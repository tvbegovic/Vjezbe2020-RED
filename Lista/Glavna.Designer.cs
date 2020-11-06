namespace Lista
{
    partial class Glavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
			this.txtJednarijec = new System.Windows.Forms.TextBox();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.txtViseRijeci = new System.Windows.Forms.TextBox();
			this.btnDodajVise = new System.Windows.Forms.Button();
			this.lstPopis = new System.Windows.Forms.ListBox();
			this.btnUkloni = new System.Windows.Forms.Button();
			this.btnDodajNaPos = new System.Windows.Forms.Button();
			this.txtPozicija = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOcisti = new System.Windows.Forms.Button();
			this.btnSortAsc = new System.Windows.Forms.Button();
			this.btnSortDesc = new System.Windows.Forms.Button();
			this.txtTrazi = new System.Windows.Forms.TextBox();
			this.btnTrazi = new System.Windows.Forms.Button();
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnOcistiFilter = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtJednarijec
			// 
			this.txtJednarijec.Location = new System.Drawing.Point(7, 22);
			this.txtJednarijec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtJednarijec.Name = "txtJednarijec";
			this.txtJednarijec.Size = new System.Drawing.Size(300, 23);
			this.txtJednarijec.TabIndex = 0;
			// 
			// btnDodaj
			// 
			this.btnDodaj.Location = new System.Drawing.Point(7, 56);
			this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(135, 26);
			this.btnDodaj.TabIndex = 1;
			this.btnDodaj.Text = "Dodaj riječ na kraj";
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// txtViseRijeci
			// 
			this.txtViseRijeci.Location = new System.Drawing.Point(7, 22);
			this.txtViseRijeci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtViseRijeci.Multiline = true;
			this.txtViseRijeci.Name = "txtViseRijeci";
			this.txtViseRijeci.Size = new System.Drawing.Size(365, 66);
			this.txtViseRijeci.TabIndex = 0;
			// 
			// btnDodajVise
			// 
			this.btnDodajVise.Location = new System.Drawing.Point(380, 22);
			this.btnDodajVise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDodajVise.Name = "btnDodajVise";
			this.btnDodajVise.Size = new System.Drawing.Size(96, 26);
			this.btnDodajVise.TabIndex = 1;
			this.btnDodajVise.Text = "Dodaj";
			this.btnDodajVise.UseVisualStyleBackColor = true;
			this.btnDodajVise.Click += new System.EventHandler(this.btnDodajVise_Click);
			// 
			// lstPopis
			// 
			this.lstPopis.FormattingEnabled = true;
			this.lstPopis.ItemHeight = 15;
			this.lstPopis.Location = new System.Drawing.Point(28, 246);
			this.lstPopis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lstPopis.Name = "lstPopis";
			this.lstPopis.Size = new System.Drawing.Size(430, 199);
			this.lstPopis.TabIndex = 2;
			// 
			// btnUkloni
			// 
			this.btnUkloni.Location = new System.Drawing.Point(465, 246);
			this.btnUkloni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnUkloni.Name = "btnUkloni";
			this.btnUkloni.Size = new System.Drawing.Size(96, 28);
			this.btnUkloni.TabIndex = 3;
			this.btnUkloni.Text = "Ukloni";
			this.btnUkloni.UseVisualStyleBackColor = true;
			this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
			// 
			// btnDodajNaPos
			// 
			this.btnDodajNaPos.Location = new System.Drawing.Point(149, 56);
			this.btnDodajNaPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDodajNaPos.Name = "btnDodajNaPos";
			this.btnDodajNaPos.Size = new System.Drawing.Size(157, 26);
			this.btnDodajNaPos.TabIndex = 1;
			this.btnDodajNaPos.Text = "Dodaj riječ na poziciju";
			this.btnDodajNaPos.UseVisualStyleBackColor = true;
			this.btnDodajNaPos.Click += new System.EventHandler(this.btnDodajNaPos_Click);
			// 
			// txtPozicija
			// 
			this.txtPozicija.Location = new System.Drawing.Point(314, 58);
			this.txtPozicija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPozicija.Name = "txtPozicija";
			this.txtPozicija.Size = new System.Drawing.Size(116, 23);
			this.txtPozicija.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtJednarijec);
			this.groupBox1.Controls.Add(this.txtPozicija);
			this.groupBox1.Controls.Add(this.btnDodaj);
			this.groupBox1.Controls.Add(this.btnDodajNaPos);
			this.groupBox1.Location = new System.Drawing.Point(28, 8);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(490, 92);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Jedna riječ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtViseRijeci);
			this.groupBox2.Controls.Add(this.btnDodajVise);
			this.groupBox2.Location = new System.Drawing.Point(28, 107);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(490, 97);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Više riječi";
			// 
			// btnOcisti
			// 
			this.btnOcisti.Location = new System.Drawing.Point(465, 280);
			this.btnOcisti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOcisti.Name = "btnOcisti";
			this.btnOcisti.Size = new System.Drawing.Size(96, 28);
			this.btnOcisti.TabIndex = 3;
			this.btnOcisti.Text = "Isprazni listu";
			this.btnOcisti.UseVisualStyleBackColor = true;
			this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
			// 
			// btnSortAsc
			// 
			this.btnSortAsc.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAsc.Image")));
			this.btnSortAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSortAsc.Location = new System.Drawing.Point(465, 315);
			this.btnSortAsc.Name = "btnSortAsc";
			this.btnSortAsc.Size = new System.Drawing.Size(96, 29);
			this.btnSortAsc.TabIndex = 7;
			this.btnSortAsc.Text = "Sortiraj";
			this.btnSortAsc.UseVisualStyleBackColor = false;
			this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
			// 
			// btnSortDesc
			// 
			this.btnSortDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnSortDesc.Image")));
			this.btnSortDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSortDesc.Location = new System.Drawing.Point(465, 350);
			this.btnSortDesc.Name = "btnSortDesc";
			this.btnSortDesc.Size = new System.Drawing.Size(96, 28);
			this.btnSortDesc.TabIndex = 8;
			this.btnSortDesc.Text = "Sortiraj";
			this.btnSortDesc.UseVisualStyleBackColor = true;
			this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
			// 
			// txtTrazi
			// 
			this.txtTrazi.Location = new System.Drawing.Point(30, 216);
			this.txtTrazi.Name = "txtTrazi";
			this.txtTrazi.Size = new System.Drawing.Size(163, 23);
			this.txtTrazi.TabIndex = 10;
			// 
			// btnTrazi
			// 
			this.btnTrazi.Location = new System.Drawing.Point(199, 216);
			this.btnTrazi.Name = "btnTrazi";
			this.btnTrazi.Size = new System.Drawing.Size(75, 23);
			this.btnTrazi.TabIndex = 11;
			this.btnTrazi.Text = "Traži";
			this.btnTrazi.UseVisualStyleBackColor = true;
			this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(280, 216);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(86, 23);
			this.btnFilter.TabIndex = 12;
			this.btnFilter.Text = "Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnOcistiFilter
			// 
			this.btnOcistiFilter.Location = new System.Drawing.Point(372, 216);
			this.btnOcistiFilter.Name = "btnOcistiFilter";
			this.btnOcistiFilter.Size = new System.Drawing.Size(86, 23);
			this.btnOcistiFilter.TabIndex = 13;
			this.btnOcistiFilter.Text = "Očisti";
			this.btnOcistiFilter.UseVisualStyleBackColor = true;
			this.btnOcistiFilter.Click += new System.EventHandler(this.btnOcistiFilter_Click);
			// 
			// Glavna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 465);
			this.Controls.Add(this.btnOcistiFilter);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.btnTrazi);
			this.Controls.Add(this.txtTrazi);
			this.Controls.Add(this.btnSortDesc);
			this.Controls.Add(this.btnSortAsc);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOcisti);
			this.Controls.Add(this.btnUkloni);
			this.Controls.Add(this.lstPopis);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Glavna";
			this.Text = "Lista";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJednarijec;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtViseRijeci;
        private System.Windows.Forms.Button btnDodajVise;
        private System.Windows.Forms.ListBox lstPopis;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodajNaPos;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOcisti;
		private System.Windows.Forms.Button btnSortAsc;
		private System.Windows.Forms.Button btnSortDesc;
		private System.Windows.Forms.TextBox txtTrazi;
		private System.Windows.Forms.Button btnTrazi;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnOcistiFilter;
	}
}

