namespace Deep_Launcher
{
    partial class MainForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::Deep_Launcher.Properties.Resources.exit;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(261, 34);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // configButton
            // 
            this.configButton.BackColor = System.Drawing.Color.Transparent;
            this.configButton.BackgroundImage = global::Deep_Launcher.Properties.Resources.settings;
            this.configButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configButton.FlatAppearance.BorderSize = 0;
            this.configButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configButton.ForeColor = System.Drawing.Color.Black;
            this.configButton.Location = new System.Drawing.Point(261, 3);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(25, 25);
            this.configButton.TabIndex = 0;
            this.configButton.UseVisualStyleBackColor = false;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(289, 62);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.configButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "mainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button exitButton;
    }
}

