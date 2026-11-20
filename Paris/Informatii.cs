using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paris
{
    public partial class Informatii : Form
    {
        public Informatii()
        {
            this.SetStyle(
               System.Windows.Forms.ControlStyles.UserPaint |
               System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
               System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
               true);
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }
        void hide()
        {
            istorie_text.Hide();
            etimologie_text.Hide();
            administratie_text.Hide();
            geografie_text.Hide();
            evenimente_text.Hide();
            close_text.Hide();
            istorie_poza.Hide();
            etimologie_poza.Hide();
            administratie_poza.Hide();
            geografie_poza.Hide();
            atractii_poza.Hide();
            evenimente_poza.Hide();
        }
        private void Informatii_Load(object sender, EventArgs e)
        {
            hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa iesi din aplicatie?", "Atenție", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Paris home = new Paris();
            home.Show();
            Hide();
        }

        private void istorie_btn_Click(object sender, EventArgs e)
        {
            hide();
            istorie_text.Show();
            close_text.Show();
            istorie_text.Select(0, 17);
            istorie_text.SelectionFont = new Font("Arial", 25, FontStyle.Bold);
            istorie_text.Select(istorie_text.Text.IndexOf("Populație istorică"), "Populație istorică".Length);
            istorie_text.SelectionFont = new Font("Arial", 20, FontStyle.Bold);
        }

        private void close_text_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void etimologie_btn_Click(object sender, EventArgs e)
        {
            hide();
            etimologie_text.Show();
            close_text.Show();
            etimologie_text.Select(etimologie_text.Text.IndexOf("Etimologie"), "Etimologie".Length);
            etimologie_text.SelectionFont = new Font("Arial", 25, FontStyle.Bold);
        }

        private void administratie_btn_Click(object sender, EventArgs e)
        {
            hide();
            administratie_text.Show();
            close_text.Show();
            administratie_text.Select(administratie_text.Text.IndexOf("Administratie"), "Administratie".Length);
            administratie_text.SelectionFont = new Font("Arial", 25, FontStyle.Bold);
        }

        private void geografie_btn_Click(object sender, EventArgs e)
        {
            hide();
            geografie_text.Show();
            close_text.Show();
            geografie_text.Select(geografie_text.Text.IndexOf("Geografie"), "Geografie".Length);
            geografie_text.SelectionFont = new Font("Arial", 25, FontStyle.Bold);
        }

        private void evenimente_btn_Click(object sender, EventArgs e)
        {
            hide();
            evenimente_text.Show();
            close_text.Show();
            evenimente_text.Select(evenimente_text.Text.IndexOf("Evenimente"), "Evenimente".Length);
            evenimente_text.SelectionFont = new Font("Arial", 25, FontStyle.Bold);
        }

        private void istorie_btn_MouseHover(object sender, EventArgs e)
        {
            hide();
            istorie_poza.Show();
        }

        private void etimologie_btn_MouseHover(object sender, EventArgs e)
        {
            hide();
            etimologie_poza.Show();
        }

        private void administratie_btn_MouseHover(object sender, EventArgs e)
        {
            hide();
            administratie_poza.Show();
        }

        private void geografie_btn_MouseHover(object sender, EventArgs e)
        {
            hide();
            geografie_poza.Show();
        }

        private void atractii_btn_MouseHover(object sender, EventArgs e)
        {
            hide();
            atractii_poza.Show();
        }

        private void evenimente_btn_MouseHover(object sender, EventArgs e)
        {
            hide();
            evenimente_poza.Show();
        }

        private void atractii_btn_Click(object sender, EventArgs e)
        {
            Atractii atractii = new Atractii();
            atractii.Show();
            Hide();
        }
    }
}
