using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMutlak_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayi.Text); // sayısal olarak texti çrvirdik

             //işlemler
             double sayiMutlak = Math.Abs(sayi);
             double sayiUst = Math.Pow(sayi,2);
             double sayiKareKok = Math.Sqrt(sayi);
             double sayiYuvarla = Math.Ceiling(sayi);




            //sonucları yazdır
            lblMutlak.Text = "sayının mutlak değeri:" + sayiMutlak.ToString();
            lblUst.Text = "sayının kuvveti:" + sayiUst.ToString();
            lblKok.Text = "sayının kare kökü:" + sayiKareKok.ToString();
            lblYukariYuvarla.Text = "sayıyı yukarı yuvarla:" + sayiYuvarla.ToString();

        }
    }
}
