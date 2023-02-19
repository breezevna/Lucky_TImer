namespace LuckyTimer
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.TimerResult = new System.Windows.Forms.TextBox();
            this.betButton = new System.Windows.Forms.Button();
            this.PickUpButton = new System.Windows.Forms.Button();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.points = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.tRexRunning = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRexRunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerResult
            // 
            this.TimerResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.TimerResult.Font = new System.Drawing.Font("Pixeloid Sans", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerResult.Location = new System.Drawing.Point(149, 82);
            this.TimerResult.Multiline = true;
            this.TimerResult.Name = "TimerResult";
            this.TimerResult.ReadOnly = true;
            this.TimerResult.Size = new System.Drawing.Size(229, 69);
            this.TimerResult.TabIndex = 1;
            this.TimerResult.Text = "00:00";
            this.TimerResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.betButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.betButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betButton.Font = new System.Drawing.Font("Pixeloid Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.betButton.Location = new System.Drawing.Point(333, 270);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(150, 60);
            this.betButton.TabIndex = 2;
            this.betButton.Text = "BET";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // PickUpButton
            // 
            this.PickUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.PickUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PickUpButton.Font = new System.Drawing.Font("Pixeloid Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickUpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PickUpButton.Location = new System.Drawing.Point(122, 351);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(278, 60);
            this.PickUpButton.TabIndex = 3;
            this.PickUpButton.Text = "PICK UP";
            this.PickUpButton.UseVisualStyleBackColor = false;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // BetTextBox
            // 
            this.BetTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.BetTextBox.Font = new System.Drawing.Font("Pixeloid Sans", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BetTextBox.Location = new System.Drawing.Point(25, 270);
            this.BetTextBox.Multiline = true;
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.Size = new System.Drawing.Size(271, 60);
            this.BetTextBox.TabIndex = 4;
            // 
            // points
            // 
            this.points.Font = new System.Drawing.Font("Pixeloid Sans", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points.Location = new System.Drawing.Point(149, 157);
            this.points.Multiline = true;
            this.points.Name = "points";
            this.points.ReadOnly = true;
            this.points.Size = new System.Drawing.Size(229, 60);
            this.points.TabIndex = 5;
            this.points.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(189)))), ((int)(((byte)(217)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Pixeloid Mono", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.Location = new System.Drawing.Point(12, 6);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(284, 39);
            this.Username.TabIndex = 6;
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(189)))), ((int)(((byte)(217)))));
            this.Question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Question.Image = global::LuckyTimer.Properties.Resources.questionmark;
            this.Question.Location = new System.Drawing.Point(455, -7);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(59, 57);
            this.Question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Question.TabIndex = 10;
            this.Question.TabStop = false;
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(189)))), ((int)(((byte)(217)))));
            this.pictureBox2.Image = global::LuckyTimer.Properties.Resources.coin;
            this.pictureBox2.Location = new System.Drawing.Point(91, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(149, 141);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(229, 10);
            this.floor.TabIndex = 8;
            this.floor.TabStop = false;
            // 
            // tRexRunning
            // 
            this.tRexRunning.BackColor = System.Drawing.Color.LavenderBlush;
            this.tRexRunning.Image = global::LuckyTimer.Properties.Resources.dead;
            this.tRexRunning.Location = new System.Drawing.Point(149, 86);
            this.tRexRunning.Name = "tRexRunning";
            this.tRexRunning.Size = new System.Drawing.Size(52, 55);
            this.tRexRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tRexRunning.TabIndex = 7;
            this.tRexRunning.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LuckyTimer.Properties.Resources.wall;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.tRexRunning);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.points);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.PickUpButton);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.TimerResult);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "LuckyTimer!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRexRunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TimerResult;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button PickUpButton;
        private System.Windows.Forms.TextBox BetTextBox;
        private System.Windows.Forms.TextBox points;
        public System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.PictureBox tRexRunning;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Question;
    }
}