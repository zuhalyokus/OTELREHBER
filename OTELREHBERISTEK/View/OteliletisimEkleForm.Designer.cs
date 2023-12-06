namespace OTELREHBERISTEK.View
{
    partial class OteliletisimEkleForm
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Telefon_Numarası = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            OtelID = new DataGridViewTextBoxColumn();
            sil = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            eklebtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            konumtxt = new TextBox();
            emailtxt = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 327);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Otel Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Telefon_Numarası, Email, Location, OtelID, sil });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 299);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // Telefon_Numarası
            // 
            Telefon_Numarası.DataPropertyName = "Telefon_Numarası";
            Telefon_Numarası.HeaderText = "Telefon Numarası";
            Telefon_Numarası.Name = "Telefon_Numarası";
            Telefon_Numarası.Width = 200;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Location
            // 
            Location.DataPropertyName = "Location";
            Location.HeaderText = "Konum";
            Location.Name = "Location";
            // 
            // OtelID
            // 
            OtelID.DataPropertyName = "OtelID";
            OtelID.HeaderText = "OtelID";
            OtelID.Name = "OtelID";
            OtelID.Visible = false;
            // 
            // sil
            // 
            sil.HeaderText = "Sil";
            sil.Image = Properties.Resources.Actions_edit_delete_icon;
            sil.Name = "sil";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(eklebtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(konumtxt);
            groupBox1.Controls.Add(emailtxt);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 83);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otel Ekle";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 46);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(173, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // eklebtn
            // 
            eklebtn.Location = new Point(590, 45);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(114, 23);
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
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Konum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 27);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "E-Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Telefon";
            // 
            // konumtxt
            // 
            konumtxt.Location = new Point(376, 45);
            konumtxt.Name = "konumtxt";
            konumtxt.Size = new Size(208, 23);
            konumtxt.TabIndex = 2;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(185, 46);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(185, 23);
            emailtxt.TabIndex = 1;
            // 
            // OteliletisimEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 462);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OteliletisimEkleForm";
            Text = "OteliletisimEkleForm";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button eklebtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox konumtxt;
        private TextBox emailtxt;
        private MaskedTextBox maskedTextBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Telefon_Numarası;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn OtelID;
        private DataGridViewImageColumn sil;
    }
}