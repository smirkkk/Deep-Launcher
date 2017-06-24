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
            this.editFontColorComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editFontSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.editButtonNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.editOpenFileButton = new System.Windows.Forms.Button();
            this.editSelectedFileTextBox = new System.Windows.Forms.TextBox();
            this.editPreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editPreviewButton = new System.Windows.Forms.Button();
            this.buttonComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.editTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFontSizeNumericUpDown)).BeginInit();
            this.editPreviewGroupBox.SuspendLayout();
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
            this.OKbutton.Text = "Add";
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
            this.label4.Location = new System.Drawing.Point(70, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "클릭 안되서 채워 놓음";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 32);
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
            this.previewButton.Size = new System.Drawing.Size(58, 58);
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
            this.editTab.Controls.Add(this.editFontColorComboBox);
            this.editTab.Controls.Add(this.label10);
            this.editTab.Controls.Add(this.editFontSizeNumericUpDown);
            this.editTab.Controls.Add(this.label11);
            this.editTab.Controls.Add(this.editButtonNameTextBox);
            this.editTab.Controls.Add(this.label12);
            this.editTab.Controls.Add(this.label13);
            this.editTab.Controls.Add(this.editOpenFileButton);
            this.editTab.Controls.Add(this.editSelectedFileTextBox);
            this.editTab.Controls.Add(this.editPreviewGroupBox);
            this.editTab.Location = new System.Drawing.Point(4, 22);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(371, 352);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "Edit";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // editFontColorComboBox
            // 
            this.editFontColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editFontColorComboBox.FormattingEnabled = true;
            this.editFontColorComboBox.Location = new System.Drawing.Point(208, 268);
            this.editFontColorComboBox.Name = "editFontColorComboBox";
            this.editFontColorComboBox.Size = new System.Drawing.Size(146, 20);
            this.editFontColorComboBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Font Color";
            // 
            // editFontSizeNumericUpDown
            // 
            this.editFontSizeNumericUpDown.Location = new System.Drawing.Point(17, 268);
            this.editFontSizeNumericUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.editFontSizeNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.editFontSizeNumericUpDown.Name = "editFontSizeNumericUpDown";
            this.editFontSizeNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.editFontSizeNumericUpDown.TabIndex = 17;
            this.editFontSizeNumericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "Font Size";
            // 
            // editButtonNameTextBox
            // 
            this.editButtonNameTextBox.Location = new System.Drawing.Point(17, 217);
            this.editButtonNameTextBox.Name = "editButtonNameTextBox";
            this.editButtonNameTextBox.Size = new System.Drawing.Size(337, 21);
            this.editButtonNameTextBox.TabIndex = 15;
            this.editButtonNameTextBox.Text = "untitled";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "Input Launcher Button Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "Select File";
            // 
            // editOpenFileButton
            // 
            this.editOpenFileButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editOpenFileButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editOpenFileButton.Location = new System.Drawing.Point(279, 166);
            this.editOpenFileButton.Name = "editOpenFileButton";
            this.editOpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.editOpenFileButton.TabIndex = 11;
            this.editOpenFileButton.Text = "Open File";
            this.editOpenFileButton.UseVisualStyleBackColor = false;
            this.editOpenFileButton.Click += new System.EventHandler(this.editOpenFileButton_Click);
            // 
            // editSelectedFileTextBox
            // 
            this.editSelectedFileTextBox.BackColor = System.Drawing.Color.White;
            this.editSelectedFileTextBox.Location = new System.Drawing.Point(17, 167);
            this.editSelectedFileTextBox.Name = "editSelectedFileTextBox";
            this.editSelectedFileTextBox.ReadOnly = true;
            this.editSelectedFileTextBox.Size = new System.Drawing.Size(256, 21);
            this.editSelectedFileTextBox.TabIndex = 12;
            // 
            // editPreviewGroupBox
            // 
            this.editPreviewGroupBox.Controls.Add(this.buttonComboBox);
            this.editPreviewGroupBox.Controls.Add(this.label9);
            this.editPreviewGroupBox.Controls.Add(this.label8);
            this.editPreviewGroupBox.Controls.Add(this.label7);
            this.editPreviewGroupBox.Controls.Add(this.editPreviewButton);
            this.editPreviewGroupBox.Location = new System.Drawing.Point(17, 12);
            this.editPreviewGroupBox.Name = "editPreviewGroupBox";
            this.editPreviewGroupBox.Size = new System.Drawing.Size(337, 128);
            this.editPreviewGroupBox.TabIndex = 0;
            this.editPreviewGroupBox.TabStop = false;
            this.editPreviewGroupBox.Text = "Preview";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Select Button";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "클릭";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Linked File";
            // 
            // editPreviewButton
            // 
            this.editPreviewButton.Location = new System.Drawing.Point(18, 53);
            this.editPreviewButton.Name = "editPreviewButton";
            this.editPreviewButton.Size = new System.Drawing.Size(58, 58);
            this.editPreviewButton.TabIndex = 0;
            this.editPreviewButton.Text = "button1";
            this.editPreviewButton.UseVisualStyleBackColor = true;
            // 
            // buttonComboBox
            // 
            this.buttonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buttonComboBox.FormattingEnabled = true;
            this.buttonComboBox.Location = new System.Drawing.Point(191, 20);
            this.buttonComboBox.Name = "buttonComboBox";
            this.buttonComboBox.Size = new System.Drawing.Size(121, 20);
            this.buttonComboBox.TabIndex = 4;
            this.buttonComboBox.SelectedIndexChanged += new System.EventHandler(this.buttonComboBox_SelectedIndexChanged);
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
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editFontSizeNumericUpDown)).EndInit();
            this.editPreviewGroupBox.ResumeLayout(false);
            this.editPreviewGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox editPreviewGroupBox;
        private System.Windows.Forms.Button editPreviewButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox editFontColorComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown editFontSizeNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox editButtonNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button editOpenFileButton;
        private System.Windows.Forms.TextBox editSelectedFileTextBox;
        private System.Windows.Forms.ComboBox buttonComboBox;
    }
}