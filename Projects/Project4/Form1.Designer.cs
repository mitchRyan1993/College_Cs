
namespace Project4
{
    partial class diceGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diceGame));
            this.mainTitle = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.p1Box = new System.Windows.Forms.GroupBox();
            this.p1TotalPointsText = new System.Windows.Forms.TextBox();
            this.p1PointsGainedText = new System.Windows.Forms.TextBox();
            this.p1TotalScoreLabel = new System.Windows.Forms.Label();
            this.p1PointsGainedLabel = new System.Windows.Forms.Label();
            this.p1SecondDie = new System.Windows.Forms.PictureBox();
            this.p1FirstDie = new System.Windows.Forms.PictureBox();
            this.p1RollButton = new System.Windows.Forms.Button();
            this.p1Label = new System.Windows.Forms.Label();
            this.p2Box = new System.Windows.Forms.GroupBox();
            this.p2TotalScoreText = new System.Windows.Forms.TextBox();
            this.p2PointsGainedText = new System.Windows.Forms.TextBox();
            this.p2TotalScoreLabel = new System.Windows.Forms.Label();
            this.p2PointsGainedLabel = new System.Windows.Forms.Label();
            this.p2SecondDie = new System.Windows.Forms.PictureBox();
            this.p2FirstDie = new System.Windows.Forms.PictureBox();
            this.p2RollButton = new System.Windows.Forms.Button();
            this.p2Label = new System.Windows.Forms.Label();
            this.p1Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1SecondDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1FirstDie)).BeginInit();
            this.p2Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2SecondDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2FirstDie)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(311, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(236, 32);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Game of Chance!";
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.Location = new System.Drawing.Point(354, 41);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(149, 20);
            this.subTitle.TabIndex = 1;
            this.subTitle.Text = "Yeah, it\'s gambling";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(317, 148);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(230, 54);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(206, 619);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(230, 54);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "&New Game";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(442, 619);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(230, 54);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit Game";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(182, 70);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(511, 60);
            this.rulesLabel.TabIndex = 3;
            this.rulesLabel.Text = resources.GetString("rulesLabel.Text");
            this.rulesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p1Box
            // 
            this.p1Box.Controls.Add(this.p1TotalPointsText);
            this.p1Box.Controls.Add(this.p1PointsGainedText);
            this.p1Box.Controls.Add(this.p1TotalScoreLabel);
            this.p1Box.Controls.Add(this.p1PointsGainedLabel);
            this.p1Box.Controls.Add(this.p1SecondDie);
            this.p1Box.Controls.Add(this.p1FirstDie);
            this.p1Box.Controls.Add(this.p1RollButton);
            this.p1Box.Controls.Add(this.p1Label);
            this.p1Box.Location = new System.Drawing.Point(15, 211);
            this.p1Box.Name = "p1Box";
            this.p1Box.Size = new System.Drawing.Size(417, 393);
            this.p1Box.TabIndex = 4;
            this.p1Box.TabStop = false;
            // 
            // p1TotalPointsText
            // 
            this.p1TotalPointsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1TotalPointsText.Location = new System.Drawing.Point(216, 314);
            this.p1TotalPointsText.Name = "p1TotalPointsText";
            this.p1TotalPointsText.ReadOnly = true;
            this.p1TotalPointsText.Size = new System.Drawing.Size(195, 27);
            this.p1TotalPointsText.TabIndex = 7;
            this.p1TotalPointsText.TabStop = false;
            // 
            // p1PointsGainedText
            // 
            this.p1PointsGainedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1PointsGainedText.Location = new System.Drawing.Point(216, 278);
            this.p1PointsGainedText.Name = "p1PointsGainedText";
            this.p1PointsGainedText.ReadOnly = true;
            this.p1PointsGainedText.Size = new System.Drawing.Size(195, 27);
            this.p1PointsGainedText.TabIndex = 6;
            this.p1PointsGainedText.TabStop = false;
            // 
            // p1TotalScoreLabel
            // 
            this.p1TotalScoreLabel.AutoSize = true;
            this.p1TotalScoreLabel.CausesValidation = false;
            this.p1TotalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1TotalScoreLabel.Location = new System.Drawing.Point(101, 321);
            this.p1TotalScoreLabel.Name = "p1TotalScoreLabel";
            this.p1TotalScoreLabel.Size = new System.Drawing.Size(100, 20);
            this.p1TotalScoreLabel.TabIndex = 5;
            this.p1TotalScoreLabel.Text = "Total Score:";
            this.p1TotalScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p1PointsGainedLabel
            // 
            this.p1PointsGainedLabel.AutoSize = true;
            this.p1PointsGainedLabel.CausesValidation = false;
            this.p1PointsGainedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1PointsGainedLabel.Location = new System.Drawing.Point(82, 285);
            this.p1PointsGainedLabel.Name = "p1PointsGainedLabel";
            this.p1PointsGainedLabel.Size = new System.Drawing.Size(119, 20);
            this.p1PointsGainedLabel.TabIndex = 4;
            this.p1PointsGainedLabel.Text = "Points Gained:";
            this.p1PointsGainedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p1SecondDie
            // 
            this.p1SecondDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p1SecondDie.Location = new System.Drawing.Point(216, 122);
            this.p1SecondDie.Name = "p1SecondDie";
            this.p1SecondDie.Size = new System.Drawing.Size(195, 148);
            this.p1SecondDie.TabIndex = 3;
            this.p1SecondDie.TabStop = false;
            // 
            // p1FirstDie
            // 
            this.p1FirstDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p1FirstDie.Location = new System.Drawing.Point(6, 122);
            this.p1FirstDie.Name = "p1FirstDie";
            this.p1FirstDie.Size = new System.Drawing.Size(195, 148);
            this.p1FirstDie.TabIndex = 2;
            this.p1FirstDie.TabStop = false;
            // 
            // p1RollButton
            // 
            this.p1RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1RollButton.Location = new System.Drawing.Point(113, 27);
            this.p1RollButton.Name = "p1RollButton";
            this.p1RollButton.Size = new System.Drawing.Size(182, 59);
            this.p1RollButton.TabIndex = 1;
            this.p1RollButton.Text = "P&1 Roll";
            this.p1RollButton.UseVisualStyleBackColor = true;
            this.p1RollButton.Click += new System.EventHandler(this.p1RollButton_Click);
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Label.Location = new System.Drawing.Point(167, 0);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(77, 24);
            this.p1Label.TabIndex = 0;
            this.p1Label.Text = "Player 1";
            // 
            // p2Box
            // 
            this.p2Box.Controls.Add(this.p2TotalScoreText);
            this.p2Box.Controls.Add(this.p2PointsGainedText);
            this.p2Box.Controls.Add(this.p2TotalScoreLabel);
            this.p2Box.Controls.Add(this.p2PointsGainedLabel);
            this.p2Box.Controls.Add(this.p2SecondDie);
            this.p2Box.Controls.Add(this.p2FirstDie);
            this.p2Box.Controls.Add(this.p2RollButton);
            this.p2Box.Controls.Add(this.p2Label);
            this.p2Box.Location = new System.Drawing.Point(442, 211);
            this.p2Box.Name = "p2Box";
            this.p2Box.Size = new System.Drawing.Size(417, 393);
            this.p2Box.TabIndex = 8;
            this.p2Box.TabStop = false;
            // 
            // p2TotalScoreText
            // 
            this.p2TotalScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2TotalScoreText.Location = new System.Drawing.Point(216, 314);
            this.p2TotalScoreText.Name = "p2TotalScoreText";
            this.p2TotalScoreText.ReadOnly = true;
            this.p2TotalScoreText.Size = new System.Drawing.Size(195, 27);
            this.p2TotalScoreText.TabIndex = 7;
            this.p2TotalScoreText.TabStop = false;
            // 
            // p2PointsGainedText
            // 
            this.p2PointsGainedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2PointsGainedText.Location = new System.Drawing.Point(216, 278);
            this.p2PointsGainedText.Name = "p2PointsGainedText";
            this.p2PointsGainedText.ReadOnly = true;
            this.p2PointsGainedText.Size = new System.Drawing.Size(195, 27);
            this.p2PointsGainedText.TabIndex = 6;
            this.p2PointsGainedText.TabStop = false;
            // 
            // p2TotalScoreLabel
            // 
            this.p2TotalScoreLabel.AutoSize = true;
            this.p2TotalScoreLabel.CausesValidation = false;
            this.p2TotalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2TotalScoreLabel.Location = new System.Drawing.Point(101, 321);
            this.p2TotalScoreLabel.Name = "p2TotalScoreLabel";
            this.p2TotalScoreLabel.Size = new System.Drawing.Size(100, 20);
            this.p2TotalScoreLabel.TabIndex = 5;
            this.p2TotalScoreLabel.Text = "Total Score:";
            this.p2TotalScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p2PointsGainedLabel
            // 
            this.p2PointsGainedLabel.AutoSize = true;
            this.p2PointsGainedLabel.CausesValidation = false;
            this.p2PointsGainedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2PointsGainedLabel.Location = new System.Drawing.Point(82, 285);
            this.p2PointsGainedLabel.Name = "p2PointsGainedLabel";
            this.p2PointsGainedLabel.Size = new System.Drawing.Size(119, 20);
            this.p2PointsGainedLabel.TabIndex = 4;
            this.p2PointsGainedLabel.Text = "Points Gained:";
            this.p2PointsGainedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // p2SecondDie
            // 
            this.p2SecondDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p2SecondDie.Location = new System.Drawing.Point(216, 122);
            this.p2SecondDie.Name = "p2SecondDie";
            this.p2SecondDie.Size = new System.Drawing.Size(195, 148);
            this.p2SecondDie.TabIndex = 3;
            this.p2SecondDie.TabStop = false;
            // 
            // p2FirstDie
            // 
            this.p2FirstDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p2FirstDie.Location = new System.Drawing.Point(6, 122);
            this.p2FirstDie.Name = "p2FirstDie";
            this.p2FirstDie.Size = new System.Drawing.Size(195, 148);
            this.p2FirstDie.TabIndex = 2;
            this.p2FirstDie.TabStop = false;
            // 
            // p2RollButton
            // 
            this.p2RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2RollButton.Location = new System.Drawing.Point(113, 27);
            this.p2RollButton.Name = "p2RollButton";
            this.p2RollButton.Size = new System.Drawing.Size(182, 59);
            this.p2RollButton.TabIndex = 2;
            this.p2RollButton.Text = "P&2 Roll";
            this.p2RollButton.UseVisualStyleBackColor = true;
            this.p2RollButton.Click += new System.EventHandler(this.p2RollButton_Click);
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Label.Location = new System.Drawing.Point(167, 0);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(77, 24);
            this.p2Label.TabIndex = 0;
            this.p2Label.Text = "Player 2";
            // 
            // diceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 683);
            this.Controls.Add(this.p2Box);
            this.Controls.Add(this.p1Box);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.mainTitle);
            this.Name = "diceGame";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.diceGame_Load);
            this.p1Box.ResumeLayout(false);
            this.p1Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1SecondDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1FirstDie)).EndInit();
            this.p2Box.ResumeLayout(false);
            this.p2Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2SecondDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2FirstDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.GroupBox p1Box;
        private System.Windows.Forms.Label p1PointsGainedLabel;
        private System.Windows.Forms.PictureBox p1SecondDie;
        private System.Windows.Forms.PictureBox p1FirstDie;
        private System.Windows.Forms.Button p1RollButton;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.Label p1TotalScoreLabel;
        private System.Windows.Forms.TextBox p1TotalPointsText;
        private System.Windows.Forms.TextBox p1PointsGainedText;
        private System.Windows.Forms.GroupBox p2Box;
        private System.Windows.Forms.TextBox p2TotalScoreText;
        private System.Windows.Forms.TextBox p2PointsGainedText;
        private System.Windows.Forms.Label p2TotalScoreLabel;
        private System.Windows.Forms.Label p2PointsGainedLabel;
        private System.Windows.Forms.PictureBox p2SecondDie;
        private System.Windows.Forms.PictureBox p2FirstDie;
        private System.Windows.Forms.Button p2RollButton;
        private System.Windows.Forms.Label p2Label;
    }
}

