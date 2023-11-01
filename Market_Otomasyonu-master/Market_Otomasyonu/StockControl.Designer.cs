namespace Market_Otomasyonu.UI
{
	partial class StockControl
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
			lstUrunler = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			columnHeader9 = new ColumnHeader();
			columnHeader10 = new ColumnHeader();
			columnHeader11 = new ColumnHeader();
			columnHeader12 = new ColumnHeader();
			label5 = new Label();
			nmrStokAdedi = new NumericUpDown();
			grpStokAdedi = new GroupBox();
			btnGuncelle = new Button();
			((System.ComponentModel.ISupportInitialize)nmrStokAdedi).BeginInit();
			grpStokAdedi.SuspendLayout();
			SuspendLayout();
			// 
			// lstUrunler
			// 
			lstUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
			lstUrunler.FullRowSelect = true;
			lstUrunler.GridLines = true;
			lstUrunler.Location = new Point(11, 74);
			lstUrunler.Name = "lstUrunler";
			lstUrunler.Size = new Size(1256, 341);
			lstUrunler.TabIndex = 6;
			lstUrunler.UseCompatibleStateImageBehavior = false;
			lstUrunler.View = View.Details;
			lstUrunler.SelectedIndexChanged += lstUrunler_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "ID";
			columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Kategori";
			columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Marka";
			columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Birim Fiyatı";
			columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Alış Fiyatı";
			columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Satış Fiyatı";
			columnHeader7.Width = 100;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Vergi Oranı";
			columnHeader8.Width = 100;
			// 
			// columnHeader9
			// 
			columnHeader9.Text = "Paketteki Ürün Sayısı";
			columnHeader9.Width = 110;
			// 
			// columnHeader10
			// 
			columnHeader10.Text = "Stok Miktarı";
			columnHeader10.Width = 110;
			// 
			// columnHeader11
			// 
			columnHeader11.Text = "Son Kullanma Tarihi";
			columnHeader11.Width = 110;
			// 
			// columnHeader12
			// 
			columnHeader12.Text = "Satışa Açık Mı?";
			columnHeader12.Width = 110;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(18, 19);
			label5.Name = "label5";
			label5.Size = new Size(75, 18);
			label5.TabIndex = 7;
			label5.Text = "Stok Adedi";
			// 
			// nmrStokAdedi
			// 
			nmrStokAdedi.Location = new Point(112, 19);
			nmrStokAdedi.Name = "nmrStokAdedi";
			nmrStokAdedi.Size = new Size(188, 23);
			nmrStokAdedi.TabIndex = 8;
			// 
			// grpStokAdedi
			// 
			grpStokAdedi.Controls.Add(label5);
			grpStokAdedi.Controls.Add(nmrStokAdedi);
			grpStokAdedi.Location = new Point(12, 12);
			grpStokAdedi.Name = "grpStokAdedi";
			grpStokAdedi.Size = new Size(341, 56);
			grpStokAdedi.TabIndex = 9;
			grpStokAdedi.TabStop = false;
			// 
			// btnGuncelle
			// 
			btnGuncelle.BackColor = Color.Orange;
			btnGuncelle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnGuncelle.Location = new Point(359, 22);
			btnGuncelle.Name = "btnGuncelle";
			btnGuncelle.Size = new Size(300, 46);
			btnGuncelle.TabIndex = 10;
			btnGuncelle.Text = "GÜNCELLE";
			btnGuncelle.UseVisualStyleBackColor = false;
			btnGuncelle.Click += btnGuncelle_Click;
			// 
			// StockControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1279, 429);
			Controls.Add(btnGuncelle);
			Controls.Add(grpStokAdedi);
			Controls.Add(lstUrunler);
			Name = "StockControl";
			Text = "StockControl";
			Load += StockControl_Load;
			((System.ComponentModel.ISupportInitialize)nmrStokAdedi).EndInit();
			grpStokAdedi.ResumeLayout(false);
			grpStokAdedi.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private ListView lstUrunler;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private ColumnHeader columnHeader9;
		private ColumnHeader columnHeader10;
		private ColumnHeader columnHeader11;
		private ColumnHeader columnHeader12;
		private Label label5;
		private NumericUpDown nmrStokAdedi;
		private GroupBox grpStokAdedi;
		private Button btnGuncelle;
	}
}