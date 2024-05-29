using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehir_Tahmin_Oyunu1
{
    public partial class Form1 : Form
    {

        String[] sehirlistesi = { "istanbul", "Ankara","izmir","Adana","Adıyaman" ,"Afyonkarahisar","Ağrı",
        "Aksaray","Amasya","Antalya","Ardahan","Artvin","Aydın", "Balıkesir","Bartın","Batman","Bayburt","Bilecik","Bingöl",
        "Bitlis","Bolu","Burdur","Bursa","Çanakkale","Çankırı","Çorum","DEnizli","Diyarbakır","Düzce",
        "Edirne","Elazığ","Erzincan","Elazığ","Erzincan","Erzurum","Eskişehir","Gaziantep","Giresun","Gümüşhane",
        "Hakkari","Hatay","Iğdır","Isparta","Kahramanmaraş","Karabük","Karaman","Kars","Kastamonu",
        "Kayseri","Kırıkkale","Kırşehir","Kilis","Kocaeli","Konya","Kütahya","Malatya","Manisa",
        "Mardin","Mersin","Muğla","Muş","Nevşehir","Niğde","Ordu","Osmaniye","Rize","Sakarya","Samsun",
        "Siirt","Sinop","Sivas","Şırnak","Tekirdağ","Tokat","Trabzon","Tunceli","Şanlıurfa","Uşak","Van","Yalova",
        "Yozgat","Zonguldak"};

        string bulunacaksehirismi = "";
        int bulunanharfsayisi = 0;
        int kalanhak = 4;
        Random rastgele;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnYeniOyunBaslat_Click(object sender, EventArgs e)
        {
            bulunanharfsayisi = 0;
            BtnHarfGir.Enabled = true;
            BtnTahminEt.Enabled = true;
            LblGirilenHarfler.Text = "";
            kalanhak = 4;

            YeniSehirSec();
            

            GrpOyunAlani.Controls.Clear();
            
            for(int i=0;i<bulunacaksehirismi.Length;i++)
            {
                Label label= new Label();
                label.Location = new Point(20*i+30,20);
                label.Text = bulunacaksehirismi[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                GrpOyunAlani.Controls.Add(label);

            
            }
        }

        private void BtnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfVarmi = false;
            if(TxtHarf.Text.Length!=1)
            {
                MessageBox.Show("lütfen Tek Harf Giriniz");

            }
            else
            {
                if(LblGirilenHarfler.Text.Contains(TxtHarf.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz");
                    TxtHarf.Text = "";
                    TxtHarf.Focus();

                    return;

                }
                foreach(Control item in GrpOyunAlani.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        if(label.Text.ToUpper()==TxtHarf.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor= Color.Lime;
                            harfVarmi = true;bulunanharfsayisi++;



                        }
                    }
                }
            }
            if(!harfVarmi)
            {
                kalanhak--;
                LblKalanHak.Text = kalanhak.ToString();
                if(kalanhak==0)
                {
                    BtnHarfGir.Enabled = false;
                    BtnTahminEt.Enabled = false;
                    MessageBox.Show("Oyun bitti.Kaybettiniz.Yeni Oyun için yeni oyun butonuna tıklayın"+bulunacaksehirismi);
               
                }
            }
            LblGirilenHarfler.Text += TxtHarf.Text + "";
            if(bulunanharfsayisi==bulunacaksehirismi.Length)
            {
                BtnHarfGir.Enabled = true;
                BtnTahminEt.Enabled=true;
                MessageBox.Show("oyun bitti.Tebrikler gayet başarılı bir el geçirdiniz ve oyunu kazandınız.");

            }
            TxtHarf.Text = "";
            TxtHarf.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHarfGir.Enabled = false;
            BtnTahminEt.Enabled = false;
            rastgele = new Random();

            this.AcceptButton = BtnHarfGir;
        }
        private void YeniSehirSec()
        {
            int rastgelesayi = rastgele.Next(0, sehirlistesi.Length);
            bulunacaksehirismi = sehirlistesi[rastgelesayi];
        }

        private void BtnTahminEt_Click(object sender, EventArgs e)
        {
            if(bulunacaksehirismi.ToUpper()== TxtHarf.Text.ToUpper())
            {
                foreach(Control item in GrpOyunAlani.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor=Color.Lime;
                    }
                }
                MessageBox.Show("Oyun Bitti.Tebrikler kazandınız :)");
            }
            else
            {
                MessageBox.Show("Oyun Bitti.Maalesef kaybettiniz."+bulunacaksehirismi);
            }
            BtnHarfGir.Enabled=false;
            BtnTahminEt.Enabled=false;
        }
    }
}
