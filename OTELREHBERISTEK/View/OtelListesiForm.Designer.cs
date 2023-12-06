namespace OTELREHBERISTEK
{
    partial class OtelListesiForm
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
            groupBox1 = new GroupBox();
            eklebtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            yetkilisoyadtxt = new TextBox();
            yetkiliadtxt = new TextBox();
            firmaunvantxt = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            UUID = new DataGridViewTextBoxColumn();
            YetkiliAd = new DataGridViewTextBoxColumn();
            YetkiliSoyad = new DataGridViewTextBoxColumn();
            FirmaUnvan = new DataGridViewTextBoxColumn();
            sil = new DataGridViewImageColumn();
            Column2 = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(eklebtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(yetkilisoyadtxt);
            groupBox1.Controls.Add(yetkiliadtxt);
            groupBox1.Controls.Add(firmaunvantxt);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otel Ekle";
            // 
            // eklebtn
            // 
            eklebtn.Location = new Point(590, 45);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(119, 23);
            eklebtn.TabIndex = 6;
            eklebtn.Text = "Ekle";
            eklebtn.UseVisualStyleBackColor = true;
            eklebtn.Click += eklebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 27);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Yetkili Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Yetkili Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Firma Ünvaı";
            // 
            // yetkilisoyadtxt
            // 
            yetkilisoyadtxt.Location = new Point(370, 45);
            yetkilisoyadtxt.Name = "yetkilisoyadtxt";
            yetkilisoyadtxt.Size = new Size(214, 23);
            yetkilisoyadtxt.TabIndex = 2;
            // 
            // yetkiliadtxt
            // 
            yetkiliadtxt.Location = new Point(185, 45);
            yetkiliadtxt.Name = "yetkiliadtxt";
            yetkiliadtxt.Size = new Size(179, 23);
            yetkiliadtxt.TabIndex = 1;
            // 
            // firmaunvantxt
            // 
            firmaunvantxt.Location = new Point(6, 45);
            firmaunvantxt.Name = "firmaunvantxt";
            firmaunvantxt.Size = new Size(173, 23);
            firmaunvantxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 327);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Otel Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UUID, YetkiliAd, YetkiliSoyad, FirmaUnvan, sil, Column2 });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 299);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // UUID
            // 
            UUID.DataPropertyName = "UUID";
            UUID.HeaderText = "UUI";
            UUID.Name = "UUID";
            // 
            // YetkiliAd
            // 
            YetkiliAd.DataPropertyName = "YetkiliAd";
            YetkiliAd.HeaderText = "Yetkili Ad";
            YetkiliAd.Name = "YetkiliAd";
            // 
            // YetkiliSoyad
            // 
            YetkiliSoyad.DataPropertyName = "YetkiliSoyad";
            YetkiliSoyad.HeaderText = "Yetkili Soyad";
            YetkiliSoyad.Name = "YetkiliSoyad";
            // 
            // FirmaUnvan
            // 
            FirmaUnvan.DataPropertyName = "FirmaUnvan";
            FirmaUnvan.HeaderText = "Firma Ünvanı";
            FirmaUnvan.Name = "FirmaUnvan";
            // 
            // sil
            // 
            sil.HeaderText = "Sil";
            sil.Image = Properties.Resources.Actions_edit_delete_icon;
            sil.Name = "sil";
            // 
            // Column2
            // 
            Column2.HeaderText = "İletisim Ekle";
            Column2.Image = Properties.Resources.edit_icon_png_3598;
            Column2.Name = "Column2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox firmaunvantxt;
        private TextBox yetkilisoyadtxt;
        private TextBox yetkiliadtxt;
        private Button eklebtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UUID;
        private DataGridViewTextBoxColumn YetkiliAd;
        private DataGridViewTextBoxColumn YetkiliSoyad;
        private DataGridViewTextBoxColumn FirmaUnvan;
        private DataGridViewImageColumn sil;
        private DataGridViewImageColumn Column2;
    }
}
