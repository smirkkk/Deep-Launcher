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
        List<Button> Buttons = new List<Button>();

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
                addButton(styleList);
            }
        }

        private void addButton(List<ButtonStyle> styleList)
        {
            Button b = new Button();
            b.Text = styleList[0].Title;
            b.Name = styleList[0].Title;
            b.Size = new Size(50, 50);
            b.ForeColor = styleList[0].Color;
            b.Font = styleList[0].Font;
            b.Location = new Point(3 + (50 * Buttons.Count), 2);
            b.Click += new EventHandler(startLauncher);
            this.Controls.Add(b);
            Buttons.Add(b);
        }

        void startLauncher(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Text);
        }
    }
}
