
namespace Generator_Training_Images
{
    partial class Form1
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
            this.OpenButton = new System.Windows.Forms.Button();
            this.BigPictureBox = new System.Windows.Forms.PictureBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.BlackButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.SmallPictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseFolderButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // BigPictureBox
            // 
            this.BigPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BigPictureBox.Location = new System.Drawing.Point(55, 48);
            this.BigPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.BigPictureBox.Name = "BigPictureBox";
            this.BigPictureBox.Size = new System.Drawing.Size(120, 120);
            this.BigPictureBox.TabIndex = 1;
            this.BigPictureBox.TabStop = false;
            // 
            // UpButton
            // 
            this.UpButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.up;
            this.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpButton.Location = new System.Drawing.Point(199, 12);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(50, 50);
            this.UpButton.TabIndex = 2;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.down;
            this.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownButton.Location = new System.Drawing.Point(255, 12);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(50, 50);
            this.DownButton.TabIndex = 3;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.left;
            this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftButton.Location = new System.Drawing.Point(199, 68);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(50, 50);
            this.LeftButton.TabIndex = 4;
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.right;
            this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightButton.Location = new System.Drawing.Point(255, 68);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(50, 50);
            this.RightButton.TabIndex = 5;
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // DownRightButton
            // 
            this.DownRightButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.downright;
            this.DownRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownRightButton.Location = new System.Drawing.Point(255, 180);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(50, 50);
            this.DownRightButton.TabIndex = 9;
            this.DownRightButton.UseVisualStyleBackColor = true;
            this.DownRightButton.Click += new System.EventHandler(this.DownRightButton_Click);
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.downleft;
            this.DownLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownLeftButton.Location = new System.Drawing.Point(199, 180);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(50, 50);
            this.DownLeftButton.TabIndex = 8;
            this.DownLeftButton.UseVisualStyleBackColor = true;
            this.DownLeftButton.Click += new System.EventHandler(this.DownLeftButton_Click);
            // 
            // UpRightButton
            // 
            this.UpRightButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.upright;
            this.UpRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpRightButton.Location = new System.Drawing.Point(255, 124);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(50, 50);
            this.UpRightButton.TabIndex = 7;
            this.UpRightButton.UseVisualStyleBackColor = true;
            this.UpRightButton.Click += new System.EventHandler(this.UpRightButton_Click);
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.upleft;
            this.UpLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpLeftButton.Location = new System.Drawing.Point(199, 124);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(50, 50);
            this.UpLeftButton.TabIndex = 6;
            this.UpLeftButton.UseVisualStyleBackColor = true;
            this.UpLeftButton.Click += new System.EventHandler(this.UpLeftButton_Click);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.white;
            this.WhiteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WhiteButton.Location = new System.Drawing.Point(255, 236);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(50, 50);
            this.WhiteButton.TabIndex = 11;
            this.WhiteButton.UseVisualStyleBackColor = true;
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // BlackButton
            // 
            this.BlackButton.BackgroundImage = global::Generator_Training_Images.Properties.Resources.black;
            this.BlackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlackButton.Location = new System.Drawing.Point(199, 236);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(50, 50);
            this.BlackButton.TabIndex = 10;
            this.BlackButton.UseVisualStyleBackColor = true;
            this.BlackButton.Click += new System.EventHandler(this.BlackButton_Click);
            // 
            // SkipButton
            // 
            this.SkipButton.Location = new System.Drawing.Point(118, 186);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(75, 50);
            this.SkipButton.TabIndex = 12;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // SmallPictureBox
            // 
            this.SmallPictureBox.Location = new System.Drawing.Point(12, 60);
            this.SmallPictureBox.Name = "SmallPictureBox";
            this.SmallPictureBox.Size = new System.Drawing.Size(8, 8);
            this.SmallPictureBox.TabIndex = 13;
            this.SmallPictureBox.TabStop = false;
            // 
            // ChooseFolderButton
            // 
            this.ChooseFolderButton.Location = new System.Drawing.Point(12, 186);
            this.ChooseFolderButton.Name = "ChooseFolderButton";
            this.ChooseFolderButton.Size = new System.Drawing.Size(100, 50);
            this.ChooseFolderButton.TabIndex = 14;
            this.ChooseFolderButton.Text = "Choose save folder";
            this.ChooseFolderButton.UseVisualStyleBackColor = true;
            this.ChooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(9, 239);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(41, 17);
            this.PathLabel.TabIndex = 15;
            this.PathLabel.Text = "Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 298);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ChooseFolderButton);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.BlackButton);
            this.Controls.Add(this.DownRightButton);
            this.Controls.Add(this.DownLeftButton);
            this.Controls.Add(this.UpRightButton);
            this.Controls.Add(this.UpLeftButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SmallPictureBox);
            this.Controls.Add(this.BigPictureBox);
            this.Name = "Form1";
            this.Text = "Generator training images";
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.PictureBox BigPictureBox;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownRightButton;
        private System.Windows.Forms.Button DownLeftButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button UpLeftButton;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Button BlackButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.PictureBox SmallPictureBox;
        private System.Windows.Forms.Button ChooseFolderButton;
        private System.Windows.Forms.Label PathLabel;
    }
}

