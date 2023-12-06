using OTELREHBERISTEK.Services;
using OTELREHBERISTEK.View;
namespace OTELREHBERISTEK
{
    public partial class OtelListesiForm : Form
    {
        Islemler islem = new Islemler();
        public OtelListesiForm()
        {
            InitializeComponent();
            guncelliste();
        }
        public async void guncelliste()
        {
            dataGridView1.DataSource = await islem.Otellistesi();
        }
        private async void eklebtn_Click(object sender, EventArgs e)
        {
            if (firmaunvantxt.Text == string.Empty)
            {
                MessageBox.Show("Firma Ünvanýný Giriniz.");
            }
            else if (yetkiliadtxt.Text == string.Empty)
            {
                MessageBox.Show("Yetkili Adýný Giriniz.");
            }
            else if (yetkilisoyadtxt.Text == string.Empty)
            {
                MessageBox.Show("Yetkili Soyadýný Giriniz.");
            }
            else
            {
                bool sonuc = await islem.OtelekleAsync(yetkiliadtxt.Text, yetkilisoyadtxt.Text, firmaunvantxt.Text);
                if(sonuc == true) { guncelliste(); }
                else { MessageBox.Show("Bir Hata Oluþtu"); }
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
                    DialogResult x = MessageBox.Show("Silmek Ýstediðinize Eminmisiniz", "Silme Mesajý!", MessageBoxButtons.YesNo);
                    if(x==DialogResult.Yes) 
                    { 
                        long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["UUID"].Value.ToString());
                        bool sonuc = await islem.Otelsil(id);
                        if(sonuc==true) 
                        { 
                            MessageBox.Show("Kayýt Baþarýlý Bir þekilde Silinmiþtir."); guncelliste();
                        }
                        else
                        {
                            MessageBox.Show("Bir Hata Oluþtu");
                        }
                    }
                  
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                   e.ColumnIndex == 1)
                {
                    long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["UUID"].Value.ToString());
                    OteliletisimEkleForm form = new OteliletisimEkleForm(id);
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
