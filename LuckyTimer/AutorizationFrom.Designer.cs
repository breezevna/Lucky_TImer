namespace LuckyTimer
{
    partial class AutorizationFrom
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationFrom));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AutorizationLabel = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.lockImage = new System.Windows.Forms.PictureBox();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.signIn_button = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SignUpBox = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.AutorizationLabel);
            this.TopPanel.Location = new System.Drawing.Point(-1, -2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(449, 87);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // AutorizationLabel
            // 
            this.AutorizationLabel.AutoSize = true;
            this.AutorizationLabel.Font = new System.Drawing.Font("Pixeloid Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorizationLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.AutorizationLabel.Location = new System.Drawing.Point(41, 26);
            this.AutorizationLabel.Name = "AutorizationLabel";
            this.AutorizationLabel.Size = new System.Drawing.Size(352, 61);
            this.AutorizationLabel.TabIndex = 0;
            this.AutorizationLabel.Text = "Autorization";
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(129, 146);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(308, 41);
            this.loginField.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(129, 265);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(308, 36);
            this.passwordField.TabIndex = 3;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // lockImage
            // 
            this.lockImage.Image = global::LuckyTimer.Properties.Resources.userLock1;
            this.lockImage.Location = new System.Drawing.Point(27, 243);
            this.lockImage.Name = "lockImage";
            this.lockImage.Size = new System.Drawing.Size(74, 74);
            this.lockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockImage.TabIndex = 1;
            this.lockImage.TabStop = false;
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.Transparent;
            this.userImage.Image = global::LuckyTimer.Properties.Resources.user1;
            this.userImage.Location = new System.Drawing.Point(27, 129);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(74, 74);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // signIn_button
            // 
            this.signIn_button.BackColor = System.Drawing.Color.Transparent;
            this.signIn_button.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.signIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn_button.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_button.ForeColor = System.Drawing.SystemColors.Info;
            this.signIn_button.Location = new System.Drawing.Point(163, 336);
            this.signIn_button.Name = "signIn_button";
            this.signIn_button.Size = new System.Drawing.Size(143, 44);
            this.signIn_button.TabIndex = 4;
            this.signIn_button.Text = "SIgn In";
            this.signIn_button.UseVisualStyleBackColor = false;
            this.signIn_button.Click += new System.EventHandler(this.signIn_button_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomPanel.Controls.Add(this.SignUpBox);
            this.BottomPanel.Controls.Add(this.signIn_button);
            this.BottomPanel.Controls.Add(this.userImage);
            this.BottomPanel.Controls.Add(this.lockImage);
            this.BottomPanel.Controls.Add(this.passwordField);
            this.BottomPanel.Controls.Add(this.loginField);
            this.BottomPanel.Location = new System.Drawing.Point(-16, 9);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(464, 537);
            this.BottomPanel.TabIndex = 0;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            // 
            // SignUpBox
            // 
            this.SignUpBox.Image = global::LuckyTimer.Properties.Resources.signup;
            this.SignUpBox.Location = new System.Drawing.Point(114, 386);
            this.SignUpBox.Name = "SignUpBox";
            this.SignUpBox.Size = new System.Drawing.Size(248, 29);
            this.SignUpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignUpBox.TabIndex = 5;
            this.SignUpBox.TabStop = false;
            this.SignUpBox.Click += new System.EventHandler(this.SignUpBox_Click);
            // 
            // AutorizationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LuckyTimer.Properties.Resources._8bitm__1_;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorizationFrom";
            this.Text = "Autorization";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label AutorizationLabel;
        public System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox lockImage;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Button signIn_button;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox SignUpBox;
    }
}

