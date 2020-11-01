namespace Zarada
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtBrojSati = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCijenaSata = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPorez = new System.Windows.Forms.TextBox();
			this.btnIzracunaj = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblZarada1 = new System.Windows.Forms.Label();
			this.lblZarada2 = new System.Windows.Forms.Label();
			this.lblZarada3 = new System.Windows.Forms.Label();
			this.lblZarada4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Broj sati:";
			// 
			// txtBrojSati
			// 
			this.txtBrojSati.Location = new System.Drawing.Point(123, 41);
			this.txtBrojSati.Name = "txtBrojSati";
			this.txtBrojSati.Size = new System.Drawing.Size(127, 23);
			this.txtBrojSati.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Cijena sata:";
			// 
			// txtCijenaSata
			// 
			this.txtCijenaSata.Location = new System.Drawing.Point(123, 81);
			this.txtCijenaSata.Name = "txtCijenaSata";
			this.txtCijenaSata.Size = new System.Drawing.Size(127, 23);
			this.txtCijenaSata.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Porez (%):";
			// 
			// txtPorez
			// 
			this.txtPorez.Location = new System.Drawing.Point(123, 122);
			this.txtPorez.Name = "txtPorez";
			this.txtPorez.Size = new System.Drawing.Size(127, 23);
			this.txtPorez.TabIndex = 2;
			// 
			// btnIzracunaj
			// 
			this.btnIzracunaj.Location = new System.Drawing.Point(47, 175);
			this.btnIzracunaj.Name = "btnIzracunaj";
			this.btnIzracunaj.Size = new System.Drawing.Size(286, 23);
			this.btnIzracunaj.TabIndex = 3;
			this.btnIzracunaj.Text = "Izračunaj";
			this.btnIzracunaj.UseVisualStyleBackColor = true;
			this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Zarada s unesenim parametrima:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(47, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(182, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "Zarada za default cijenu sata (40):";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(48, 291);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 15);
			this.label6.TabIndex = 3;
			this.label6.Text = "Zarada za default porez (20%):";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 325);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(243, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "Zarada (default cijena 40, default porez 20%):";
			// 
			// lblZarada1
			// 
			this.lblZarada1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblZarada1.Location = new System.Drawing.Point(300, 226);
			this.lblZarada1.Name = "lblZarada1";
			this.lblZarada1.Size = new System.Drawing.Size(100, 23);
			this.lblZarada1.TabIndex = 4;
			this.lblZarada1.Text = "0.00";
			// 
			// lblZarada2
			// 
			this.lblZarada2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblZarada2.Location = new System.Drawing.Point(300, 259);
			this.lblZarada2.Name = "lblZarada2";
			this.lblZarada2.Size = new System.Drawing.Size(100, 23);
			this.lblZarada2.TabIndex = 4;
			this.lblZarada2.Text = "0.00";
			// 
			// lblZarada3
			// 
			this.lblZarada3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblZarada3.Location = new System.Drawing.Point(300, 291);
			this.lblZarada3.Name = "lblZarada3";
			this.lblZarada3.Size = new System.Drawing.Size(100, 23);
			this.lblZarada3.TabIndex = 4;
			this.lblZarada3.Text = "0.00";
			// 
			// lblZarada4
			// 
			this.lblZarada4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblZarada4.Location = new System.Drawing.Point(300, 325);
			this.lblZarada4.Name = "lblZarada4";
			this.lblZarada4.Size = new System.Drawing.Size(100, 23);
			this.lblZarada4.TabIndex = 4;
			this.lblZarada4.Text = "0.00";
			// 
			// Glavna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 450);
			this.Controls.Add(this.lblZarada4);
			this.Controls.Add(this.lblZarada3);
			this.Controls.Add(this.lblZarada2);
			this.Controls.Add(this.lblZarada1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnIzracunaj);
			this.Controls.Add(this.txtPorez);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCijenaSata);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBrojSati);
			this.Controls.Add(this.label1);
			this.Name = "Glavna";
			this.Text = "Zarada";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBrojSati;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCijenaSata;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPorez;
		private System.Windows.Forms.Button btnIzracunaj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblZarada1;
		private System.Windows.Forms.Label lblZarada2;
		private System.Windows.Forms.Label lblZarada3;
		private System.Windows.Forms.Label lblZarada4;
	}
}

