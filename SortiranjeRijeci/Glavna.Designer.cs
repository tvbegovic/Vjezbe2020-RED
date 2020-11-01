namespace SortiranjeRijeci
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnSortiraj = new System.Windows.Forms.Button();
			this.txtRijeci = new System.Windows.Forms.TextBox();
			this.lstSortirano = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Riječi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 230);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sortirani niz";
			// 
			// btnSortiraj
			// 
			this.btnSortiraj.Location = new System.Drawing.Point(613, 44);
			this.btnSortiraj.Name = "btnSortiraj";
			this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
			this.btnSortiraj.TabIndex = 2;
			this.btnSortiraj.Text = "Sortiraj";
			this.btnSortiraj.UseVisualStyleBackColor = true;
			
			// 
			// txtRijeci
			// 
			this.txtRijeci.Location = new System.Drawing.Point(156, 45);
			this.txtRijeci.Multiline = true;
			this.txtRijeci.Name = "txtRijeci";
			this.txtRijeci.Size = new System.Drawing.Size(422, 151);
			this.txtRijeci.TabIndex = 3;
			// 
			// lstSortirano
			// 
			this.lstSortirano.FormattingEnabled = true;
			this.lstSortirano.ItemHeight = 15;
			this.lstSortirano.Location = new System.Drawing.Point(156, 230);
			this.lstSortirano.Name = "lstSortirano";
			this.lstSortirano.Size = new System.Drawing.Size(329, 199);
			this.lstSortirano.TabIndex = 4;
			// 
			// Glavna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lstSortirano);
			this.Controls.Add(this.txtRijeci);
			this.Controls.Add(this.btnSortiraj);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Glavna";
			this.Text = "Sortiranje riječi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSortiraj;
		private System.Windows.Forms.TextBox txtRijeci;
		private System.Windows.Forms.ListBox lstSortirano;
	}
}

