using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deep_Launcher
{
    public partial class ConfigurationForm : Form
    {
        private List<ButtonStyle> styleList;
        public static int editIndex = 0;
        public static int delIndex = 0;

        public ConfigurationForm(List<ButtonStyle> styleList)
        {
            InitializeComponent();
            this.styleList = styleList;

            var collection = colorComboBox.Items;
            var editCollection = editFontColorComboBox.Items;
            var type = typeof(Color);
            var props = type.GetProperties();

            var save = from prop in props
                       where prop.PropertyType == typeof(Color)
                       select prop.GetValue(null);

            collection.AddRange(save.ToArray());
            editCollection.AddRange(save.ToArray());

            colorComboBox.SelectedIndex = 8;
            
            if (styleList.Count != 0)
            {
                editFontColorComboBox.SelectedText = styleList[0].Color.Name;
                editFontSizeNumericUpDown.Value = (decimal)styleList[0].Font.Size;
                
                editPreviewButton.Text = styleList[0].Title;
                editPreviewButton.ForeColor = styleList[0].Color;
                editPreviewButton.Font = styleList[0].Font;
                editSelectedFileTextBox.Text = styleList[0].Path;
                editButtonNameTextBox.Text = styleList[0].Title;
                label8.Text = styleList[0].Filename;
                
                foreach(var data in styleList)
                {
                    buttonComboBox.Items.Add(data.Title);
                }
                buttonComboBox.SelectedIndex = 0;
            }


        }

        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                directoryTextbox.Text = openFileDialog.FileName;
                label4.Text = openFileDialog.SafeFileName;
            }
        }

        private void buttonNameTextBox_TextChanged(object sender, EventArgs e)
        {
            previewButton.Text = buttonNameTextBox.Text;
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var color = (Color)combo.SelectedItem;

            previewButton.ForeColor = color;
        }

        private void fontNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var updown = sender as NumericUpDown;

            var font = new Font("Gulim", (float)updown.Value, FontStyle.Regular, GraphicsUnit.Point, 129);

            previewButton.Font = font;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
                styleList.Add(new ButtonStyle { Title = previewButton.Text, Path = directoryTextbox.Text, Color = previewButton.ForeColor, Font = previewButton.Font, Filename = label4.Text });
        }

        private void directoryTextbox_TextChanged(object sender, EventArgs e)
        {
            OKbutton.Enabled = true;
        }

        private void editOpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                editSelectedFileTextBox.Text = openFileDialog.FileName;
                label8.Text = openFileDialog.SafeFileName;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var updown = sender as NumericUpDown;

        }

        private void buttonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;

            int selected = combobox.SelectedIndex;

            editPreviewButton.Text = styleList[selected].Title;
            editPreviewButton.ForeColor = styleList[selected].Color;
            editPreviewButton.Font = styleList[selected].Font;
            editSelectedFileTextBox.Text = styleList[selected].Path;
            editButtonNameTextBox.Text = styleList[selected].Title;
            label8.Text = styleList[selected].Filename;
            editFontColorComboBox.SelectedValue = styleList[selected].Color;
            editFontSizeNumericUpDown.Value = (decimal)styleList[selected].Font.Size;


        }

        private void editFontSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var updown = sender as NumericUpDown;

            var font = new Font("Gulim", (float)updown.Value, FontStyle.Regular, GraphicsUnit.Point, 129);

            editPreviewButton.Font = font;
        }

        private void editFontColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            var color = (Color)combo.SelectedItem;

            editPreviewButton.ForeColor = color;
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            editIndex = buttonComboBox.SelectedIndex;
            styleList[editIndex].Title = editPreviewButton.Text;
            styleList[editIndex].Path = editSelectedFileTextBox.Text;
            styleList[editIndex].Color = editPreviewButton.ForeColor;
            styleList[editIndex].Font = editPreviewButton.Font;
            styleList[editIndex].Filename = label8.Text;
        }

        private void editButtonNameTextBox_TextChanged(object sender, EventArgs e)
        {
            editPreviewButton.Text = editButtonNameTextBox.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            editIndex = buttonComboBox.SelectedIndex;
            styleList.RemoveAt(editIndex);
        }
    }
}
