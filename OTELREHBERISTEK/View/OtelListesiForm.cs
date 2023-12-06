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
                MessageBox.Show("Firma �nvan�n� Giriniz.");
            }
            else if (yetkiliadtxt.Text == string.Empty)
            {
                MessageBox.Show("Yetkili Ad�n� Giriniz.");
            }
            else if (yetkilisoyadtxt.Text == string.Empty)
            {
                MessageBox.Show("Yetkili Soyad�n� Giriniz.");
            }
            else
            {
                bool sonuc = await islem.OtelekleAsync(yetkiliadtxt.Text, yetkilisoyadtxt.Text, firmaunvantxt.Text);
                if(sonuc == true) { guncelliste(); }
                else { MessageBox.Show("Bir Hata Olu�tu"); }
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
                    DialogResult x = MessageBox.Show("Silmek �stedi�inize Eminmisiniz", "Silme Mesaj�!", MessageBoxButtons.YesNo);
                    if(x==DialogResult.Yes) 
                    { 
                        long id = Convert.ToInt64(dataGridView1.CurrentRow.Cells["UUID"].Value.ToString());
                        bool sonuc = await islem.Otelsil(id);
                        if(sonuc==true) 
                        { 
                            MessageBox.Show("Kay�t Ba�ar�l� Bir �ekilde Silinmi�tir."); guncelliste();
                        }
                        else
                        {
                            MessageBox.Show("Bir Hata Olu�tu");
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
