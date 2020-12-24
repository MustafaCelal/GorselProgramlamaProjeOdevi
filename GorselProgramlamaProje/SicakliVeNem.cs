using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{

    public partial class SicakliVeNem : Form
    {
        public static List<int> nemList = new List<int>();
        public static List<int> sicakList = new List<int>();
        public static List<string> timelist = new List<string>();
        Random rnd = new Random();
        
        public SicakliVeNem()
        {
            InitializeComponent();
        }

        private void btnSicaklik_Click(object sender, EventArgs e)
        {
            this.ctrlSicaklik1.BringToFront();
        }

        private void btnNem_Click(object sender, EventArgs e)
        {
            this.ctrlNem1.BringToFront();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;  // başlat butonuna tıklandığında timer aktif ediliyor
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //durdur butonuna tıklandığında timer kapatılıyor
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sicakList.Add(rnd.Next(10, 20));    //sıcaklık her saniye 10 ile 20 arasında rastgele bir değer alıyor
            nemList.Add(rnd.Next(0, 100));      //nem değeri her saniye 0 ile 100 arasında rastgele değer alıyor
            timelist.Add(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")); //zaman timer'ın çalıştığı her saniye zaman listesine ekleniyor
        }
    }
}
