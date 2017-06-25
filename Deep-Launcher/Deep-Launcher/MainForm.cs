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
        int currentPageIndex = 0;

        public MainForm()
        {
            InitializeComponent();
            ButtonStyles = JsonConvert.DeserializeObject<List<ButtonStyle>>(settings.Json) ?? new List<ButtonStyle>();
            
            foreach (var item in ButtonStyles)
            {
                addButton(item);
            }

            setPrevNextButton();
        }

        private void setPrevNextButton()
        {
            if (currentPageIndex != 0)
            {
                prevButton.Enabled = true;
            }
            else
            {
                prevButton.Enabled = false;
            }

            if ((Buttons.Count - currentPageIndex) > 4)
            {
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
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
                setPrevNextButton();
            }
            else if(result == DialogResult.Yes)
            {
                editButton(ButtonStyles[ConfigurationForm.editIndex]);
            }
            else if(result == DialogResult.Retry)
            {
                settings.Json = JsonConvert.SerializeObject(ButtonStyles);
                settings.Save();
                delButton(ConfigurationForm.editIndex);
            }

            settings.Json = JsonConvert.SerializeObject(ButtonStyles);
            settings.Save();
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
                Location = new Point(58 * (Buttons.Count % 4), 0),
                Tag = new[] { style.Path }
            };

            button.Click += startLauncher;
            buttonToolTip.SetToolTip(button, style.Filename);
            Buttons.Add(button);
            if (Buttons.Count < 5)
            {
                buttonPanel.Controls.Add(button);
            }
            else
            {
                return;
            }
        }

        private void editButton(ButtonStyle style)
        {
            int index = ConfigurationForm.editIndex;
            Buttons[index].Text = style.Title;
            Buttons[index].Name = style.Title;
            Buttons[index].Font = style.Font;
            Buttons[index].ForeColor = style.Color;
            Buttons[index].Tag = style.Path;
            buttonToolTip.SetToolTip(Buttons[index], style.Filename);
        }

        private void delButton(int index)
        {
            currentPageIndex = 0;
            buttonPanel.Controls.Clear();
            Buttons.Clear();

            ButtonStyles = JsonConvert.DeserializeObject<List<ButtonStyle>>(settings.Json) ?? new List<ButtonStyle>();

            foreach (var item in ButtonStyles)
            {
                addButton(item);
            }

            prevButton.Enabled = false;

            if (Buttons.Count < 5)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
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
                Console.WriteLine("\n\n" + ex.Message);

                if (ex.Message.Equals("지정된 파일을 찾을 수 없습니다"))
                {
                    MessageBox.Show(tag[0] + "\n" + ex.Message);
                }
                else /*if(ex.Message.Equals("시스템이 지정된 드라이브를 찾을 수 없습니다"))*/
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.Json = JsonConvert.SerializeObject(ButtonStyles);
            settings.Save();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Controls.Clear();
            currentPageIndex += 4;
            
            for (int i = 0; i < 4; i++)
            {
                buttonPanel.Controls.Add(Buttons[i+ currentPageIndex]);

                if(i + currentPageIndex == Buttons.Count-1)
                {
                    break;
                }
            }
            setPrevNextButton();
            return;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Controls.Clear();
            currentPageIndex -= 4;

            for (int i = 0; i < 4; i++)
            {
                buttonPanel.Controls.Add(Buttons[i + currentPageIndex]);
            }
            setPrevNextButton();
            return;
        }
    }
}