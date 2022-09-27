using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Burda form1 -de timer.Enabled=ture deyerek ise saliriq
            timer1.Enabled = true;
            //Demeli vaxt baslayaraq ilk proses button1 - i qirmizi etmek ve label2- de qirmizi rengde dayan yazmaq
            button1.BackColor = Color.Red;
            label2.Text = "Dayan";
            label2.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Burda vaxt adinda deyisen verirem ki , bu bir bir artaraq zaman intervalinda dovr etsin
            //interger deyisenine idxal ederek label1-de gorsenmesini yaziriq
            int vaxt = int.Parse(label1.Text);
            vaxt++;
            label1.Text = vaxt.ToString();
            //Biz evvelden Form1 daxilinde qirmizi rengi vermisdik. Burada sert olaraq yaziriq ki,eger 30-cu saniye catsa button3 sari olsun
            if (vaxt == 30)
            {
                button3.BackColor = Color.Yellow;
            }
            //Sonra 40-ci saniye yaaziriq ve bu prosesden 10 saniye kecir. Hemin 10 saniye muddetinde sari isiq yanir.
            //Artiq 40-ci saniyede button1 ve button3 iqilari sonur yeni boz rengde olur.Button4 yasil reng olur ve label2-de davam et yazilir 
            //label2-deki davam et duymesi yasil rengde verilir
            if (vaxt == 40)
            {
                button1.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Green;
                label2.Text = "Davam Et";
                label2.ForeColor = Color.Green;
            }
            //Belelikle yasil rengin yanmasina 30 saniye verilir qirmizi rengde olugu kimi
            // sonra dovr yeniden baslayir. Ona gorede vaxt=0 yaziriq ki , yeniden hemin proses yazilsin
            //Yeniden button1 qirmizi yaziriq, buton3 -e sari yazmaq ehtiyyac yoxdur cunki yuxarida qeyd olunub ki, 30-cu saniye intervalinda olsun
            //button4-e ise gray deyilir
            // Hemin qaydada lebel2-e dayan yazilir ve qirmizi rengde gorsenir
            // Asagidaki proses verilen emrin tekrar ve tekar emel edilmesini sazlayir
            if (vaxt == 70)
            {
                vaxt = 0;
                label1.Text = vaxt.ToString();
                button1.BackColor = Color.Red;
                label2.Text = "Dayan";
                label2.ForeColor = Color.Red;
                
                button4.BackColor = Color.Gray;

            }
        }
    }
}
