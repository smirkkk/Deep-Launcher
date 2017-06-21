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
    public partial class MainForm : Form
    {
        public MainForm()
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

            ConfigurationForm cf = new ConfigurationForm(styleList);
            if(cf.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("hello");
            }
        }
    }
}
