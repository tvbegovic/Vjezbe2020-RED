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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtJednarijec
            // 
            this.txtJednarijec.Location = new System.Drawing.Point(9, 29);
            this.txtJednarijec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJednarijec.Name = "txtJednarijec";
            this.txtJednarijec.Size = new System.Drawing.Size(384, 26);
            this.txtJednarijec.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(9, 74);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(174, 35);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj riječ na kraj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtViseRijeci
            // 
            this.txtViseRijeci.Location = new System.Drawing.Point(9, 29);
            this.txtViseRijeci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViseRijeci.Multiline = true;
            this.txtViseRijeci.Name = "txtViseRijeci";
            this.txtViseRijeci.Size = new System.Drawing.Size(468, 87);
            this.txtViseRijeci.TabIndex = 0;
            // 
            // btnDodajVise
            // 
            this.btnDodajVise.Location = new System.Drawing.Point(488, 29);
            this.btnDodajVise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodajVise.Name = "btnDodajVise";
            this.btnDodajVise.Size = new System.Drawing.Size(123, 35);
            this.btnDodajVise.TabIndex = 1;
            this.btnDodajVise.Text = "Dodaj";
            this.btnDodajVise.UseVisualStyleBackColor = true;
            this.btnDodajVise.Click += new System.EventHandler(this.btnDodajVise_Click);
            // 
            // lstPopis
            // 
            this.lstPopis.FormattingEnabled = true;
            this.lstPopis.ItemHeight = 20;
            this.lstPopis.Location = new System.Drawing.Point(36, 282);
            this.lstPopis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPopis.Name = "lstPopis";
            this.lstPopis.Size = new System.Drawing.Size(496, 164);
            this.lstPopis.TabIndex = 2;
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(543, 282);
            this.btnUkloni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(123, 37);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnDodajNaPos
            // 
            this.btnDodajNaPos.Location = new System.Drawing.Point(192, 74);
            this.btnDodajNaPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodajNaPos.Name = "btnDodajNaPos";
            this.btnDodajNaPos.Size = new System.Drawing.Size(202, 35);
            this.btnDodajNaPos.TabIndex = 1;
            this.btnDodajNaPos.Text = "Dodaj riječ na poziciju";
            this.btnDodajNaPos.UseVisualStyleBackColor = true;
            this.btnDodajNaPos.Click += new System.EventHandler(this.btnDodajNaPos_Click);
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(404, 77);
            this.txtPozicija.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(148, 26);
            this.txtPozicija.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtJednarijec);
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.btnDodajNaPos);
            this.groupBox1.Location = new System.Drawing.Point(36, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(630, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jedna riječ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtViseRijeci);
            this.groupBox2.Controls.Add(this.btnDodajVise);
            this.groupBox2.Location = new System.Drawing.Point(36, 143);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(630, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Više riječi";
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(543, 328);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(123, 37);
            this.btnOcisti.TabIndex = 3;
            this.btnOcisti.Text = "Isprazni listu";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.lstPopis);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Glavna";
            this.Text = "Lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

