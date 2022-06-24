
namespace Project6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.teamBox = new System.Windows.Forms.ListBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Castellar", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(210, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(468, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "World Series Winners";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a team from the list to see how many times they\r\nhave won the World Series" +
    " from 1903-2012\r\n\r\nNote: The world series was not played in 1904 or 1994";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(124, 428);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(176, 55);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(326, 370);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(176, 55);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(525, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 55);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // teamBox
            // 
            this.teamBox.FormattingEnabled = true;
            this.teamBox.ItemHeight = 16;
            this.teamBox.Location = new System.Drawing.Point(56, 191);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(323, 164);
            this.teamBox.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(404, 215);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(83, 17);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Placeholder";
            this.outputLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 169);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.teamBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "MainForm";
            this.Text = "WS Records";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox teamBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

