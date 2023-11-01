namespace Market_Otomasyonu.UI
{
	partial class Report
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
			dateTimePickerGunlukRapor = new DateTimePicker();
			grpGünlükRapor = new GroupBox();
			lblGunlukKar = new Label();
			label3 = new Label();
			lblGunlukCiro = new Label();
			label2 = new Label();
			lblGunlukSatisAdedi = new Label();
			label1 = new Label();
			btnRaporla = new Button();
			lstGunlukSatisDetay = new ListView();
			columnHeader2 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			lstSatışlar = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			label4 = new Label();
			label5 = new Label();
			grpYıllıkRapor = new GroupBox();
			lblYıllıkKar = new Label();
			label7 = new Label();
			lblYıllıkCiro = new Label();
			label9 = new Label();
			lblYıllıkSatisAdedi = new Label();
			label11 = new Label();
			grpGünlükRapor.SuspendLayout();
			grpYıllıkRapor.SuspendLayout();
			SuspendLayout();
			// 
			// dateTimePickerGunlukRapor
			// 
			dateTimePickerGunlukRapor.Location = new Point(12, 12);
			dateTimePickerGunlukRapor.Name = "dateTimePickerGunlukRapor";
			dateTimePickerGunlukRapor.Size = new Size(288, 23);
			dateTimePickerGunlukRapor.TabIndex = 0;
			// 
			// grpGünlükRapor
			// 
			grpGünlükRapor.Controls.Add(lblGunlukKar);
			grpGünlükRapor.Controls.Add(label3);
			grpGünlükRapor.Controls.Add(lblGunlukCiro);
			grpGünlükRapor.Controls.Add(label2);
			grpGünlükRapor.Controls.Add(lblGunlukSatisAdedi);
			grpGünlükRapor.Controls.Add(label1);
			grpGünlükRapor.Location = new Point(12, 71);
			grpGünlükRapor.Name = "grpGünlükRapor";
			grpGünlükRapor.Size = new Size(173, 188);
			grpGünlükRapor.TabIndex = 1;
			grpGünlükRapor.TabStop = false;
			grpGünlükRapor.Text = "Günlük Rapor";
			// 
			// lblGunlukKar
			// 
			lblGunlukKar.AutoSize = true;
			lblGunlukKar.Location = new Point(118, 98);
			lblGunlukKar.Name = "lblGunlukKar";
			lblGunlukKar.Size = new Size(13, 15);
			lblGunlukKar.TabIndex = 2;
			lblGunlukKar.Text = "0";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 98);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 2;
			label3.Text = "Günlük Kar";
			// 
			// lblGunlukCiro
			// 
			lblGunlukCiro.AutoSize = true;
			lblGunlukCiro.Location = new Point(118, 63);
			lblGunlukCiro.Name = "lblGunlukCiro";
			lblGunlukCiro.Size = new Size(13, 15);
			lblGunlukCiro.TabIndex = 2;
			lblGunlukCiro.Text = "0";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 63);
			label2.Name = "label2";
			label2.Size = new Size(70, 15);
			label2.TabIndex = 2;
			label2.Text = "Günlük Ciro";
			// 
			// lblGunlukSatisAdedi
			// 
			lblGunlukSatisAdedi.AutoSize = true;
			lblGunlukSatisAdedi.Location = new Point(118, 31);
			lblGunlukSatisAdedi.Name = "lblGunlukSatisAdedi";
			lblGunlukSatisAdedi.Size = new Size(13, 15);
			lblGunlukSatisAdedi.TabIndex = 2;
			lblGunlukSatisAdedi.Text = "0";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 31);
			label1.Name = "label1";
			label1.Size = new Size(106, 15);
			label1.TabIndex = 2;
			label1.Text = "Günlük Satış Adedi";
			// 
			// btnRaporla
			// 
			btnRaporla.Location = new Point(333, 14);
			btnRaporla.Name = "btnRaporla";
			btnRaporla.Size = new Size(75, 23);
			btnRaporla.TabIndex = 2;
			btnRaporla.Text = "Raporla";
			btnRaporla.UseVisualStyleBackColor = true;
			btnRaporla.Click += btnRaporla_Click;
			// 
			// lstGunlukSatisDetay
			// 
			lstGunlukSatisDetay.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader4, columnHeader3, columnHeader5 });
			lstGunlukSatisDetay.FullRowSelect = true;
			lstGunlukSatisDetay.GridLines = true;
			lstGunlukSatisDetay.Location = new Point(216, 283);
			lstGunlukSatisDetay.Name = "lstGunlukSatisDetay";
			lstGunlukSatisDetay.Size = new Size(284, 178);
			lstGunlukSatisDetay.TabIndex = 11;
			lstGunlukSatisDetay.UseCompatibleStateImageBehavior = false;
			lstGunlukSatisDetay.View = View.Details;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Ürün Adı";
			columnHeader2.Width = 100;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Marka";
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Birimi";
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Fiyat";
			// 
			// lstSatışlar
			// 
			lstSatışlar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader6, columnHeader7 });
			lstSatışlar.FullRowSelect = true;
			lstSatışlar.GridLines = true;
			lstSatışlar.Location = new Point(216, 71);
			lstSatışlar.Name = "lstSatışlar";
			lstSatışlar.Size = new Size(284, 178);
			lstSatışlar.TabIndex = 12;
			lstSatışlar.UseCompatibleStateImageBehavior = false;
			lstSatışlar.View = View.Details;
			lstSatışlar.SelectedIndexChanged += lstSatışlar_SelectedIndexChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Satışlar";
			columnHeader1.Width = 50;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Satış Tutarı";
			columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Satış Tarihi";
			columnHeader7.Width = 120;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(216, 261);
			label4.Name = "label4";
			label4.Size = new Size(249, 19);
			label4.TabIndex = 13;
			label4.Text = "Satıştaki Ürünleri Burda Görebilirsiniz";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point);
			label5.Location = new Point(216, 49);
			label5.Name = "label5";
			label5.Size = new Size(169, 19);
			label5.TabIndex = 13;
			label5.Text = "Satışlar Burada Listelenir";
			// 
			// grpYıllıkRapor
			// 
			grpYıllıkRapor.Controls.Add(lblYıllıkKar);
			grpYıllıkRapor.Controls.Add(label7);
			grpYıllıkRapor.Controls.Add(lblYıllıkCiro);
			grpYıllıkRapor.Controls.Add(label9);
			grpYıllıkRapor.Controls.Add(lblYıllıkSatisAdedi);
			grpYıllıkRapor.Controls.Add(label11);
			grpYıllıkRapor.Location = new Point(12, 265);
			grpYıllıkRapor.Name = "grpYıllıkRapor";
			grpYıllıkRapor.Size = new Size(173, 188);
			grpYıllıkRapor.TabIndex = 1;
			grpYıllıkRapor.TabStop = false;
			grpYıllıkRapor.Text = "Yıllık Rapor";
			// 
			// lblYıllıkKar
			// 
			lblYıllıkKar.AutoSize = true;
			lblYıllıkKar.Location = new Point(118, 98);
			lblYıllıkKar.Name = "lblYıllıkKar";
			lblYıllıkKar.Size = new Size(13, 15);
			lblYıllıkKar.TabIndex = 2;
			lblYıllıkKar.Text = "0";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 98);
			label7.Name = "label7";
			label7.Size = new Size(52, 15);
			label7.TabIndex = 2;
			label7.Text = "Yıllık Kar";
			// 
			// lblYıllıkCiro
			// 
			lblYıllıkCiro.AutoSize = true;
			lblYıllıkCiro.Location = new Point(118, 63);
			lblYıllıkCiro.Name = "lblYıllıkCiro";
			lblYıllıkCiro.Size = new Size(13, 15);
			lblYıllıkCiro.TabIndex = 2;
			lblYıllıkCiro.Text = "0";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 63);
			label9.Name = "label9";
			label9.Size = new Size(57, 15);
			label9.TabIndex = 2;
			label9.Text = "Yıllık Ciro";
			// 
			// lblYıllıkSatisAdedi
			// 
			lblYıllıkSatisAdedi.AutoSize = true;
			lblYıllıkSatisAdedi.Location = new Point(118, 31);
			lblYıllıkSatisAdedi.Name = "lblYıllıkSatisAdedi";
			lblYıllıkSatisAdedi.Size = new Size(13, 15);
			lblYıllıkSatisAdedi.TabIndex = 2;
			lblYıllıkSatisAdedi.Text = "0";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(6, 31);
			label11.Name = "label11";
			label11.Size = new Size(93, 15);
			label11.TabIndex = 2;
			label11.Text = "Yıllık Satış Adedi";
			// 
			// Report
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(532, 464);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(lstSatışlar);
			Controls.Add(lstGunlukSatisDetay);
			Controls.Add(btnRaporla);
			Controls.Add(grpYıllıkRapor);
			Controls.Add(grpGünlükRapor);
			Controls.Add(dateTimePickerGunlukRapor);
			Name = "Report";
			Text = "Report";
			grpGünlükRapor.ResumeLayout(false);
			grpGünlükRapor.PerformLayout();
			grpYıllıkRapor.ResumeLayout(false);
			grpYıllıkRapor.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePickerGunlukRapor;
		private GroupBox grpGünlükRapor;
		private Label lblGunlukKar;
		private Label label3;
		private Label lblGunlukCiro;
		private Label label2;
		private Label lblGunlukSatisAdedi;
		private Label label1;
		private Button btnRaporla;
		private ListView lstGunlukSatisDetay;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader5;
		private ListView lstSatışlar;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private Label label4;
		private Label label5;
		private GroupBox grpYıllıkRapor;
		private Label lblYıllıkKar;
		private Label label7;
		private Label lblYıllıkCiro;
		private Label label9;
		private Label lblYıllıkSatisAdedi;
		private Label label11;
	}
}