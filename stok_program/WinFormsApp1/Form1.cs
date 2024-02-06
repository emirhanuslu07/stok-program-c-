using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Class_islemler urunislem = new Class_islemler();
        int secilen_index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class_veri urun = new Class_veri();
            urun.sahibi = txtSahibi.Text;
            urun.turu = txtTuru.Text;
            urun.miktari = Convert.ToInt32(txtMiktari.Text);
            urun.tarihi = txtTarihi.Text;

            urunislem.yeniKayit(urun);
            var source = new BindingSource();
            source.DataSource = urunislem.urunler;
            dataGridView1.DataSource = source;
        }

        private void btnKayitMenu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnG�ncelleMenu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            urunislem.kayitSil(secilen_index);
            dataGridView1.Refresh();
            var source = new BindingSource();
            source.DataSource = urunislem.urunler;
            dataGridView1.DataSource = source;
        }
        private void btnG�ncelle_Click(object sender, EventArgs e)
        {
            Class_veri urung�ncelleme = new Class_veri();
            urung�ncelleme.sahibi = G_txtSahibi.Text;
            urung�ncelleme.turu = G_txtTuru.Text;
            urung�ncelleme.miktari = Convert.ToInt32(G_txtMiktari.Text);
            urung�ncelleme.tarihi = G_txtTarihi.Text;

            urunislem.kayitG�ncelleme(secilen_index, urung�ncelleme);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            groupBox1.Enabled = true;

            secilen_index = e.RowIndex;
            Class_veri secilenUrun = urunislem.urunler[secilen_index];
            G_txtMiktari.Text = secilenUrun.miktari.ToString();
            G_txtSahibi.Text = secilenUrun.sahibi;
            G_txtTarihi.Text = secilenUrun.tarihi;
            G_txtTuru.Text = secilenUrun.turu;
        }
    }
}