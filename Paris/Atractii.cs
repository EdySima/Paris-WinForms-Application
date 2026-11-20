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
    public partial class Atractii : Form
    {
        public Atractii()
        {
            this.SetStyle(
               System.Windows.Forms.ControlStyles.UserPaint |
               System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
               System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
               true);
            InitializeComponent();
        }
        void hide()
        {
            pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox2.Hide();
            pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
            pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide(); pictureBox11.Hide();
            pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide();
            pictureBox16.Hide(); pictureBox17.Hide(); pictureBox18.Hide(); pictureBox19.Hide();
            pictureBox20.Hide(); pictureBox21.Hide(); pictureBox22.Hide();
        }
        private void Atractii_Load(object sender, EventArgs e)
        {
            hide();
            pictureBox1.Show();
            titlu.Text = "Turnul Eiffel";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 1:
                    hide();
                    pictureBox1.Show();
                    titlu.Text = "Turnul Eiffel";
                    break;
                case 2:
                    hide();
                    pictureBox2.Show();
                    titlu.Text = "Arcul de Triumf";
                    break;
                case 3:
                    hide();
                    pictureBox3.Show();
                    titlu.Text = "Biserica Madeleine";
                    break;
                case 4:
                    hide();
                    pictureBox4.Show();
                    titlu.Text = "Centrul Georges-Pompidou";
                    break;
                case 5:
                    hide();
                    pictureBox5.Show();
                    titlu.Text = "Montmartre";
                    break;
                case 6:
                    hide();
                    pictureBox6.Show();
                    titlu.Text = "Opéra Garnier";
                    break;
                case 7:
                    hide();
                    pictureBox7.Show();
                    titlu.Text = "Muzeul Luvru";
                    break;
                case 8:
                    hide();
                    pictureBox8.Show();
                    titlu.Text = "Bulevardul Champs-Élysées";
                    break;
                case 9:
                    hide();
                    pictureBox9.Show();
                    titlu.Text = "Catedrala Notre-Dame";
                    break;
                case 10:
                    hide();
                    pictureBox10.Show();
                    titlu.Text = "La Défense";
                    break;
                case 11:
                    hide();
                    pictureBox11.Show();
                    titlu.Text = "Moulin Rouge";
                    break;
                case 12:
                    hide();
                    pictureBox12.Show();
                    titlu.Text = "Muzeul Orsay";
                    break;
                case 13:
                    hide();
                    pictureBox13.Show();
                    titlu.Text = "Disneyland Paris";
                    break;
                case 14:
                    hide();
                    pictureBox14.Show();
                    titlu.Text = "Les Invalides";
                    break;
                case 15:
                    hide();
                    pictureBox15.Show();
                    titlu.Text = "Palatul Versailles";
                    break;
                case 16:
                    hide();
                    pictureBox16.Show();
                    titlu.Text = "Place de la Concorde";
                    break;
                case 17:
                    hide();
                    pictureBox17.Show();
                    titlu.Text = "Muzeul Rodin";
                    break;
                case 18:
                    hide();
                    pictureBox18.Show();
                    titlu.Text = "Panteonul Paris";
                    break;
                case 19:
                    hide();
                    pictureBox19.Show();
                    titlu.Text = "Place des Vosges";
                    break;
                case 20:
                    hide();
                    pictureBox20.Show();
                    titlu.Text = "Sainte-Chapelle";
                    break;
                case 21:
                    hide();
                    pictureBox21.Show();
                    titlu.Text = "Catedrala din Saint-Denis";
                    break;
                case 22:
                    hide();
                    pictureBox22.Show();
                    titlu.Text = "Sorbonne";
                    break;
            }
        }

        private void botton_stanga_Click(object sender, EventArgs e)
        {
            if(trackBar1.Value > 1)
                trackBar1.Value--; 
        }

        private void button_dreapta_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 22)
                trackBar1.Value++;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa iesi din aplicatie?", "Atenție", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Informatii info = new Informatii();
            info.Show();
            Hide();
        }
    }
}
