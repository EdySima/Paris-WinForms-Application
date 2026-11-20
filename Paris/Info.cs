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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            bibliografie_text.Select(bibliografie_text.Text.IndexOf("Bibliografie"), "Bibliografie".Length);
            bibliografie_text.SelectionFont = new Font("Arial", 25, FontStyle.Bold);
        }
    }
}
