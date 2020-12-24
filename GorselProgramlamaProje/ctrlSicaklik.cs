using System;
using System.Linq;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class ctrlSicaklik : UserControl
    {
        public ctrlSicaklik()
        {
            InitializeComponent();
        }
        
        int count;


        private void ctrlSicaklik_Load(object sender, EventArgs e)
        {
            count = SicakliVeNem.sicakList.Count;
            for (int i = 0; i < SicakliVeNem.sicakList.Count; i++)
            {
                listBox1.Items.Add(SicakliVeNem.sicakList[i]);
                chart1.DataSource = SicakliVeNem.sicakList;
                chart1.Series[0].Points.DataBindXY(SicakliVeNem.timelist, SicakliVeNem.sicakList);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (count != SicakliVeNem.sicakList.Count)
            {
                listBox1.Items.Add(SicakliVeNem.sicakList[SicakliVeNem.sicakList.Count - 1]);
                count = SicakliVeNem.sicakList.Count;
                chart1.Series[0].Points.DataBindXY(SicakliVeNem.timelist, SicakliVeNem.sicakList);
                label1.Text = "Ortalama : " + SicakliVeNem.sicakList.Average();
                label2.Text = "Max : " + SicakliVeNem.sicakList.Max();
                label3.Text = "Min : " + SicakliVeNem.sicakList.Min();
            }

        }
    }
}
