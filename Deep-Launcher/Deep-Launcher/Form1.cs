using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deep_Launcher
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            var styleList = new List<ButtonStyle>();

            configForm cf = new configForm(styleList);
            if(cf.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("hello");
            }
        }
    }
}
