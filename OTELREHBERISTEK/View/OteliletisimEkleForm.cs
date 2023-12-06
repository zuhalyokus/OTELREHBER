using OTELREHBERISTEK.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTELREHBERISTEK.View
{
    public partial class OteliletisimEkleForm : Form
    {
        long _otelid;
        Islemler islem = new Islemler();
        public OteliletisimEkleForm(long Otelid)
        {
            InitializeComponent();
            _otelid = Otelid;
            guncelliste();

        }
        public async void guncelliste()
        {
            dataGridView1.DataSource = await islem.Oteliletisimlistesi(_otelid);
        }
        private async void eklebtn_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "(   )    -")
            {
                MessageBox.Show("Telefon Numarasını Giriniz");
            }
            else if (emailtxt.Text == string.Empty)
            {
                MessageBox.Show("Email Bilgisini Giriniz.");
            }
            else if (konumtxt.Text == string.Empty)
            {
                MessageBox.Show("Konum Bilgisini Giriniz.");
            }
            else
            {
                bool sonuc = await islem.OtelIletisimEkleAsync(maskedTextBox1.Text, emailtxt.Text, konumtxt.Text,_otelid);
                if (sonuc == true) { guncelliste(); }
                else { MessageBox.Show("Bir Hata Oluştu"); }
            }
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                    e.ColumnIndex == 0)
                {
                    DialogResult x = MessageBox.Show("Silmek İstediğinize Eminmisiniz", "Silme Mesajı!", MessageBoxButtons.YesNo);
                    if (x == DialogResult.Yes)
                    {
                        long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                        bool sonuc = await islem.OtelIletisimsil(id);
                        if (sonuc == true)
                        {
                            MessageBox.Show("Kayıt Başarılı Bir şekilde Silinmiştir."); guncelliste();
                        }
                        else
                        {
                            MessageBox.Show("Bir Hata Oluştu");
                        }
                    }

                }
     
            }
            catch (Exception)
            {

            }
        }
    }
}
