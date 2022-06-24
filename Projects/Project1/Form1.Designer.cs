
namespace Project1
{
    partial class fiveCardHand
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
            this.cardFive = new System.Windows.Forms.PictureBox();
            this.cardFour = new System.Windows.Forms.PictureBox();
            this.cardThree = new System.Windows.Forms.PictureBox();
            this.cardTwo = new System.Windows.Forms.PictureBox();
            this.cardOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOne)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFive
            // 
            this.cardFive.BackgroundImage = global::Project1.Properties.Resources.Queen_Diamonds;
            this.cardFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardFive.Location = new System.Drawing.Point(584, 8);
            this.cardFive.Name = "cardFive";
            this.cardFive.Size = new System.Drawing.Size(138, 181);
            this.cardFive.TabIndex = 4;
            this.cardFive.TabStop = false;
            this.cardFive.Click += new System.EventHandler(this.cardFive_Click);
            // 
            // cardFour
            // 
            this.cardFour.BackgroundImage = global::Project1.Properties.Resources._2_Clubs;
            this.cardFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardFour.Location = new System.Drawing.Point(440, 8);
            this.cardFour.Name = "cardFour";
            this.cardFour.Size = new System.Drawing.Size(138, 181);
            this.cardFour.TabIndex = 3;
            this.cardFour.TabStop = false;
            this.cardFour.Click += new System.EventHandler(this.cardFour_Click);
            // 
            // cardThree
            // 
            this.cardThree.BackgroundImage = global::Project1.Properties.Resources._10_Hearts;
            this.cardThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardThree.Location = new System.Drawing.Point(296, 8);
            this.cardThree.Name = "cardThree";
            this.cardThree.Size = new System.Drawing.Size(138, 181);
            this.cardThree.TabIndex = 2;
            this.cardThree.TabStop = false;
            this.cardThree.Click += new System.EventHandler(this.cardThree_Click);
            // 
            // cardTwo
            // 
            this.cardTwo.BackgroundImage = global::Project1.Properties.Resources._5_Diamonds;
            this.cardTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardTwo.Location = new System.Drawing.Point(152, 8);
            this.cardTwo.Name = "cardTwo";
            this.cardTwo.Size = new System.Drawing.Size(138, 181);
            this.cardTwo.TabIndex = 1;
            this.cardTwo.TabStop = false;
            this.cardTwo.Click += new System.EventHandler(this.cardTwo_Click);
            // 
            // cardOne
            // 
            this.cardOne.BackgroundImage = global::Project1.Properties.Resources._9_Spades;
            this.cardOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardOne.Location = new System.Drawing.Point(8, 8);
            this.cardOne.Name = "cardOne";
            this.cardOne.Size = new System.Drawing.Size(138, 181);
            this.cardOne.TabIndex = 0;
            this.cardOne.TabStop = false;
            this.cardOne.Click += new System.EventHandler(this.cardOne_Click);
            // 
            // fiveCardHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(732, 198);
            this.Controls.Add(this.cardFive);
            this.Controls.Add(this.cardFour);
            this.Controls.Add(this.cardThree);
            this.Controls.Add(this.cardTwo);
            this.Controls.Add(this.cardOne);
            this.Name = "fiveCardHand";
            this.Text = "fiveCardHand";
            ((System.ComponentModel.ISupportInitialize)(this.cardFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardOne;
        private System.Windows.Forms.PictureBox cardTwo;
        private System.Windows.Forms.PictureBox cardThree;
        private System.Windows.Forms.PictureBox cardFour;
        private System.Windows.Forms.PictureBox cardFive;
    }
}

