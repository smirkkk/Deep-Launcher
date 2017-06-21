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
    public partial class configForm : Form
    {
        private List<ButtonStyle> styleList;

        public configForm(List<ButtonStyle> styleList)
        {
            InitializeComponent();
            this.styleList = styleList;
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

        private void configForm_Load(object sender, EventArgs e)
        {
            var collection = colorComboBox.Items;
            var type = typeof(Color);
            var props = type.GetProperties();

            var save = from prop in props
                       where prop.PropertyType == typeof(Color)
                       select prop.GetValue(null);

            collection.AddRange(save.ToArray());

            colorComboBox.SelectedIndex = 8;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            styleList.Add(new ButtonStyle { Title = previewButton.Text, Path = directoryTextbox.Text, Color = previewButton.ForeColor, Font = previewButton.Font });
        }
    }
}
