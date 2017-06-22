namespace Deep_Launcher
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.directoryTextbox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fontNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.buttonNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileOpenButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fileOpenButton.Location = new System.Drawing.Point(279, 45);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(75, 23);
            this.fileOpenButton.TabIndex = 0;
            this.fileOpenButton.Text = "Open File";
            this.fileOpenButton.UseVisualStyleBackColor = false;
            this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
            // 
            // directoryTextbox
            // 
            this.directoryTextbox.BackColor = System.Drawing.Color.White;
            this.directoryTextbox.Location = new System.Drawing.Point(17, 47);
            this.directoryTextbox.Name = "directoryTextbox";
            this.directoryTextbox.ReadOnly = true;
            this.directoryTextbox.Size = new System.Drawing.Size(256, 21);
            this.directoryTextbox.TabIndex = 1;
            this.directoryTextbox.TextChanged += new System.EventHandler(this.directoryTextbox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.editTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 378);
            this.tabControl1.TabIndex = 1;
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.White;
            this.addTab.Controls.Add(this.colorComboBox);
            this.addTab.Controls.Add(this.label6);
            this.addTab.Controls.Add(this.fontNumericUpDown);
            this.addTab.Controls.Add(this.label5);
            this.addTab.Controls.Add(this.OKbutton);
            this.addTab.Controls.Add(this.groupBox1);
            this.addTab.Controls.Add(this.buttonNameTextBox);
            this.addTab.Controls.Add(this.label2);
            this.addTab.Controls.Add(this.label1);
            this.addTab.Controls.Add(this.fileOpenButton);
            this.addTab.Controls.Add(this.directoryTextbox);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(371, 352);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(208, 148);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 20);
            this.colorComboBox.TabIndex = 10;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Font Color";
            // 
            // fontNumericUpDown
            // 
            this.fontNumericUpDown.Location = new System.Drawing.Point(17, 148);
            this.fontNumericUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.fontNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontNumericUpDown.Name = "fontNumericUpDown";
            this.fontNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.fontNumericUpDown.TabIndex = 8;
            this.fontNumericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.fontNumericUpDown.ValueChanged += new System.EventHandler(this.fontNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Font Size";
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Enabled = false;
            this.OKbutton.Location = new System.Drawing.Point(279, 313);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.previewButton);
            this.groupBox1.Location = new System.Drawing.Point(17, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "클릭 안되서 채워 놓음";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Linked File";
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.previewButton.ForeColor = System.Drawing.Color.Black;
            this.previewButton.Location = new System.Drawing.Point(6, 20);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(50, 50);
            this.previewButton.TabIndex = 0;
            this.previewButton.Text = "untitled";
            this.previewButton.UseVisualStyleBackColor = true;
            // 
            // buttonNameTextBox
            // 
            this.buttonNameTextBox.Location = new System.Drawing.Point(17, 97);
            this.buttonNameTextBox.Name = "buttonNameTextBox";
            this.buttonNameTextBox.Size = new System.Drawing.Size(337, 21);
            this.buttonNameTextBox.TabIndex = 4;
            this.buttonNameTextBox.Text = "untitled";
            this.buttonNameTextBox.TextChanged += new System.EventHandler(this.buttonNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Launcher Button Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select File";
            // 
            // editTab
            // 
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(371, 352);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConfigurationForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.configForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox directoryTextbox;
        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.TextBox buttonNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.NumericUpDown fontNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox colorComboBox;
    }
}