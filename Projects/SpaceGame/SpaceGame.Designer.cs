
namespace SpaceGame
{
    partial class SpaceGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceGame));
            this.shipIMG = new System.Windows.Forms.PictureBox();
            this.titleLBL = new System.Windows.Forms.Label();
            this.instructionsLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shipIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // shipIMG
            // 
            this.shipIMG.Image = ((System.Drawing.Image)(resources.GetObject("shipIMG.Image")));
            this.shipIMG.Location = new System.Drawing.Point(236, 317);
            this.shipIMG.Margin = new System.Windows.Forms.Padding(2);
            this.shipIMG.Name = "shipIMG";
            this.shipIMG.Size = new System.Drawing.Size(148, 97);
            this.shipIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shipIMG.TabIndex = 7;
            this.shipIMG.TabStop = false;
            this.shipIMG.Click += new System.EventHandler(this.shipIMG_Click);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.BackColor = System.Drawing.Color.Transparent;
            this.titleLBL.Font = new System.Drawing.Font("Segoe Print", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.White;
            this.titleLBL.Location = new System.Drawing.Point(98, 62);
            this.titleLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(474, 54);
            this.titleLBL.TabIndex = 8;
            this.titleLBL.Text = "SPACE GAME ACTUAL TITLE";
            // 
            // instructionsLBL
            // 
            this.instructionsLBL.AutoSize = true;
            this.instructionsLBL.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLBL.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLBL.ForeColor = System.Drawing.Color.White;
            this.instructionsLBL.Location = new System.Drawing.Point(200, 266);
            this.instructionsLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLBL.Name = "instructionsLBL";
            this.instructionsLBL.Size = new System.Drawing.Size(223, 38);
            this.instructionsLBL.TabIndex = 9;
            this.instructionsLBL.Text = "Click Ship to Start";
            // 
            // SpaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 478);
            this.Controls.Add(this.instructionsLBL);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.shipIMG);
            this.Name = "SpaceGame";
            this.Text = "SpaceGame";
            ((System.ComponentModel.ISupportInitialize)(this.shipIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox shipIMG;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label instructionsLBL;
    }
}

