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
    public partial class Paris : Form
    {
        public Paris()
        {
            this.SetStyle(
               System.Windows.Forms.ControlStyles.UserPaint |
               System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
               System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
               true);
            InitializeComponent();
            this.TransparencyKey = (BackColor);
        }

        private void Paris_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_StyleChanged(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa iesi din aplicatie?", "Atenție", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            Informatii info = new Informatii();
            info.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            Hide();
        }
    }
}
