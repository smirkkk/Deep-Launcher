using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        List<ButtonStyle> ButtonStyles = new List<ButtonStyle>();
        Settings settings => Settings.Default;

        public MainForm()
        {
            InitializeComponent();
            ButtonStyles = JsonConvert.DeserializeObject<List<ButtonStyle>>(settings.Json) ?? new List<ButtonStyle>();
            
            foreach (var item in ButtonStyles)
            {
                addButton(item);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            ConfigurationForm form = new ConfigurationForm(ButtonStyles);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                addButton(ButtonStyles[ButtonStyles.Count - 1]);
            }
            else if(result == DialogResult.Yes)
            {
                editButton(ButtonStyles[ConfigurationForm.editIndex]);
            }
        }
        
        private void addButton(ButtonStyle style)
        {
            Button button = new Button
            {
                Text = style.Title,
                Name = style.Title,
                Size = new Size(58, 58),
                ForeColor = style.Color,
                Font = style.Font,
                Location = new Point(3 + (58 * Buttons.Count), 2),
                Tag = new[] { style.Path }
            };

            button.Click += startLauncher;

            this.Controls.Add(button);
            Buttons.Add(button);
        }

        private void editButton(ButtonStyle style)
        {
            int index = ConfigurationForm.editIndex;
            Buttons[index].Text = style.Title;
            Buttons[index].Name = style.Title;
            Buttons[index].Font = style.Font;
            Buttons[index].ForeColor = style.Color;
            Buttons[index].Tag = style.Path;

            Console.WriteLine(Buttons[index].Tag);
        }

            void startLauncher(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string[] tag = button.Tag as string[];

            try
            {
                System.Diagnostics.Process.Start(tag[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(tag[0]+"\n파일을 찾을 수 없습니다!");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.Json = JsonConvert.SerializeObject(ButtonStyles);
            settings.Save();
        }
    }
}
