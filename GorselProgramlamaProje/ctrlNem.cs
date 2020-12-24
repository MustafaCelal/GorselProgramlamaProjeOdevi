using System;
using System.Linq;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class ctrlNem : UserControl
    {
        int count;
        public ctrlNem()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != SicakliVeNem.nemList.Count)
            {
                listBox1.Items.Add(SicakliVeNem.nemList[SicakliVeNem.nemList.Count - 1]);
                count = SicakliVeNem.nemList.Count;
                chart1.Series[0].Points.DataBindXY(SicakliVeNem.timelist, SicakliVeNem.nemList);
                this.label1.Text = "Ortalama : " + SicakliVeNem.nemList.Average();
                this.label2.Text = "Max : " + SicakliVeNem.nemList.Max();
                this.label3.Text = "Min : " + SicakliVeNem.nemList.Min();
            }
        }

        private void ctrlNem_Load(object sender, EventArgs e)
        {
            count = SicakliVeNem.nemList.Count;
            for (int i = 0; i < SicakliVeNem.nemList.Count; i++)
            {
                listBox1.Items.Add(SicakliVeNem.nemList[i]);
            }
            chart1.DataSource = SicakliVeNem.nemList;
            chart1.Series[0].Points.DataBindXY(SicakliVeNem.timelist, SicakliVeNem.nemList);

        }
    }
}
