using System;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
