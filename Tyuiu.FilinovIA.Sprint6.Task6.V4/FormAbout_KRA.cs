using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.FilinovIA.Sprint6.Task6.V4
{
    public partial class FormAbout_KRA : Form
    {
        public FormAbout_KRA()
        {
            InitializeComponent();
        }

        private void textBoxInfo_KRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_KRA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
