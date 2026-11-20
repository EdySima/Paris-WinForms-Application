using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paris
{
    public partial class Test : Form
    {
        public Test()
        {
            this.SetStyle(
              System.Windows.Forms.ControlStyles.UserPaint |
              System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
              System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
              true);
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            finalizare_btn.Hide();
            timp_text.Hide(); minute.Hide(); puncte2.Hide(); secunde.Hide();
            groupBox1.Hide(); groupBox2.Hide(); groupBox3.Hide(); groupBox4.Hide();
            groupBox5.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Atentie, iti vei pierde progresul! Esti sigur ca vrei sa inchizi?", "Atenție", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Paris paris = new Paris();
                paris.Show();
                Hide();
                timer1.Stop();
            }
        }
        int m, s, nr;
        private void test_btn_Click(object sender, EventArgs e)
        {
            test_btn.Hide(); finalizare_btn.Show();
            timp_text.Show(); minute.Show(); puncte2.Show(); secunde.Show();
            groupBox1.Show(); groupBox2.Show(); groupBox3.Show(); groupBox4.Show();
            groupBox5.Show();
            minute.Text = "05";
            secunde.Text = "00";
            m = Convert.ToInt32(minute.Text);
            s = Convert.ToInt32(secunde.Text);
            timer1.Start();
            nr = 0;
        }
        private void finalizare_btn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            radioButton2.BackColor = Color.LimeGreen;
            radioButton5.BackColor = Color.LimeGreen;
            radioButton12.BackColor = Color.LimeGreen;
            radioButton16.BackColor = Color.LimeGreen;
            radioButton18.BackColor = Color.LimeGreen;
            if (radioButton1.Checked == true) radioButton1.BackColor = Color.Red;
            if (radioButton2.Checked == true) nr++;
            if (radioButton3.Checked == true) radioButton3.BackColor = Color.Red;
            if (radioButton4.Checked == true) radioButton4.BackColor = Color.Red;
            if (radioButton5.Checked == true) nr++;
            if (radioButton6.Checked == true) radioButton6.BackColor = Color.Red;
            if (radioButton7.Checked == true) radioButton7.BackColor = Color.Red;
            if (radioButton8.Checked == true) radioButton8.BackColor = Color.Red;
            if (radioButton9.Checked == true) radioButton9.BackColor = Color.Red;
            if (radioButton10.Checked == true) radioButton10.BackColor = Color.Red;
            if (radioButton11.Checked == true) radioButton11.BackColor = Color.Red;
            if (radioButton12.Checked == true) nr++;
            if (radioButton13.Checked == true) radioButton13.BackColor = Color.Red;
            if (radioButton14.Checked == true) radioButton14.BackColor = Color.Red;
            if (radioButton15.Checked == true) radioButton15.BackColor = Color.Red;
            if (radioButton16.Checked == true) nr++;
            if (radioButton17.Checked == true) radioButton17.BackColor = Color.Red;
            if (radioButton18.Checked == true) nr++;
            if (radioButton19.Checked == true) radioButton19.BackColor = Color.Red;
            if (radioButton20.Checked == true) radioButton20.BackColor = Color.Red;
            if (MessageBox.Show("Scorul tau este " + nr.ToString() + " din 5", "Scor", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Paris paris = new Paris();
                paris.Show();
                Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s--;
            if (s == -1)
            {
                m--;
                s = 59;
            }
            if (m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Timpul a expirat!");
                Paris paris = new Paris();
                paris.Show();
                Hide();
            }
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);
            minute.Text = "0" + mm;
            if(s >= 0 && s <= 9)
                secunde.Text = "0" + ss;
            else secunde.Text = ss;
        }

    }
}
