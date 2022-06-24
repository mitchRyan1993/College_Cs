
namespace Project7
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.subtitleLbl = new System.Windows.Forms.Label();
            this.firstIMG = new System.Windows.Forms.PictureBox();
            this.secondIMG = new System.Windows.Forms.PictureBox();
            this.thirdIMG = new System.Windows.Forms.PictureBox();
            this.addOneDollar = new System.Windows.Forms.Button();
            this.addFiveDollars = new System.Windows.Forms.Button();
            this.addTenDollars = new System.Windows.Forms.Button();
            this.addTwentyDollars = new System.Windows.Forms.Button();
            this.addFortyDollars = new System.Windows.Forms.Button();
            this.addSixtyDollars = new System.Windows.Forms.Button();
            this.spinBttn = new System.Windows.Forms.Button();
            this.clearBttn = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.betText = new System.Windows.Forms.TextBox();
            this.betLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Gold;
            this.titleLbl.Location = new System.Drawing.Point(64, 19);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(493, 51);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Not Quite Vegas Slots!";
            // 
            // subtitleLbl
            // 
            this.subtitleLbl.AutoSize = true;
            this.subtitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLbl.ForeColor = System.Drawing.Color.White;
            this.subtitleLbl.Location = new System.Drawing.Point(30, 70);
            this.subtitleLbl.Name = "subtitleLbl";
            this.subtitleLbl.Size = new System.Drawing.Size(537, 120);
            this.subtitleLbl.TabIndex = 1;
            this.subtitleLbl.Text = resources.GetString("subtitleLbl.Text");
            this.subtitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstIMG
            // 
            this.firstIMG.BackColor = System.Drawing.Color.Transparent;
            this.firstIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstIMG.Image = ((System.Drawing.Image)(resources.GetObject("firstIMG.Image")));
            this.firstIMG.Location = new System.Drawing.Point(49, 249);
            this.firstIMG.Name = "firstIMG";
            this.firstIMG.Size = new System.Drawing.Size(160, 160);
            this.firstIMG.TabIndex = 2;
            this.firstIMG.TabStop = false;
            // 
            // secondIMG
            // 
            this.secondIMG.BackColor = System.Drawing.Color.Transparent;
            this.secondIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondIMG.Image = ((System.Drawing.Image)(resources.GetObject("secondIMG.Image")));
            this.secondIMG.Location = new System.Drawing.Point(256, 249);
            this.secondIMG.Name = "secondIMG";
            this.secondIMG.Size = new System.Drawing.Size(160, 160);
            this.secondIMG.TabIndex = 3;
            this.secondIMG.TabStop = false;
            // 
            // thirdIMG
            // 
            this.thirdIMG.BackColor = System.Drawing.Color.Transparent;
            this.thirdIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdIMG.Image = ((System.Drawing.Image)(resources.GetObject("thirdIMG.Image")));
            this.thirdIMG.Location = new System.Drawing.Point(460, 249);
            this.thirdIMG.Name = "thirdIMG";
            this.thirdIMG.Size = new System.Drawing.Size(160, 160);
            this.thirdIMG.TabIndex = 4;
            this.thirdIMG.TabStop = false;
            // 
            // addOneDollar
            // 
            this.addOneDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOneDollar.ForeColor = System.Drawing.Color.Green;
            this.addOneDollar.Location = new System.Drawing.Point(21, 444);
            this.addOneDollar.Name = "addOneDollar";
            this.addOneDollar.Size = new System.Drawing.Size(187, 38);
            this.addOneDollar.TabIndex = 1;
            this.addOneDollar.Text = "&$1";
            this.addOneDollar.UseVisualStyleBackColor = true;
            this.addOneDollar.Click += new System.EventHandler(this.addOneDollar_Click);
            // 
            // addFiveDollars
            // 
            this.addFiveDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFiveDollars.ForeColor = System.Drawing.Color.Green;
            this.addFiveDollars.Location = new System.Drawing.Point(242, 444);
            this.addFiveDollars.Name = "addFiveDollars";
            this.addFiveDollars.Size = new System.Drawing.Size(187, 38);
            this.addFiveDollars.TabIndex = 2;
            this.addFiveDollars.Text = "$&5";
            this.addFiveDollars.UseVisualStyleBackColor = true;
            this.addFiveDollars.Click += new System.EventHandler(this.addFiveDollars_Click);
            // 
            // addTenDollars
            // 
            this.addTenDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTenDollars.ForeColor = System.Drawing.Color.Green;
            this.addTenDollars.Location = new System.Drawing.Point(460, 444);
            this.addTenDollars.Name = "addTenDollars";
            this.addTenDollars.Size = new System.Drawing.Size(187, 38);
            this.addTenDollars.TabIndex = 3;
            this.addTenDollars.Text = "$&10";
            this.addTenDollars.UseVisualStyleBackColor = true;
            this.addTenDollars.Click += new System.EventHandler(this.addTenDollars_Click);
            // 
            // addTwentyDollars
            // 
            this.addTwentyDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTwentyDollars.ForeColor = System.Drawing.Color.Green;
            this.addTwentyDollars.Location = new System.Drawing.Point(22, 498);
            this.addTwentyDollars.Name = "addTwentyDollars";
            this.addTwentyDollars.Size = new System.Drawing.Size(187, 38);
            this.addTwentyDollars.TabIndex = 4;
            this.addTwentyDollars.Text = "$&20";
            this.addTwentyDollars.UseVisualStyleBackColor = true;
            this.addTwentyDollars.Click += new System.EventHandler(this.addTwentyDollars_Click);
            // 
            // addFortyDollars
            // 
            this.addFortyDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFortyDollars.ForeColor = System.Drawing.Color.Green;
            this.addFortyDollars.Location = new System.Drawing.Point(242, 498);
            this.addFortyDollars.Name = "addFortyDollars";
            this.addFortyDollars.Size = new System.Drawing.Size(187, 38);
            this.addFortyDollars.TabIndex = 5;
            this.addFortyDollars.Text = "$&40";
            this.addFortyDollars.UseVisualStyleBackColor = true;
            this.addFortyDollars.Click += new System.EventHandler(this.addFortyDollars_Click);
            // 
            // addSixtyDollars
            // 
            this.addSixtyDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSixtyDollars.ForeColor = System.Drawing.Color.Green;
            this.addSixtyDollars.Location = new System.Drawing.Point(460, 498);
            this.addSixtyDollars.Name = "addSixtyDollars";
            this.addSixtyDollars.Size = new System.Drawing.Size(187, 38);
            this.addSixtyDollars.TabIndex = 6;
            this.addSixtyDollars.Text = "$&60";
            this.addSixtyDollars.UseVisualStyleBackColor = true;
            this.addSixtyDollars.Click += new System.EventHandler(this.addSixtyDollars_Click);
            // 
            // spinBttn
            // 
            this.spinBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBttn.ForeColor = System.Drawing.Color.Black;
            this.spinBttn.Location = new System.Drawing.Point(22, 607);
            this.spinBttn.Name = "spinBttn";
            this.spinBttn.Size = new System.Drawing.Size(625, 38);
            this.spinBttn.TabIndex = 7;
            this.spinBttn.Text = "&SPIN!";
            this.spinBttn.UseVisualStyleBackColor = true;
            this.spinBttn.Click += new System.EventHandler(this.spinBttn_Click);
            // 
            // clearBttn
            // 
            this.clearBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBttn.Location = new System.Drawing.Point(21, 667);
            this.clearBttn.Name = "clearBttn";
            this.clearBttn.Size = new System.Drawing.Size(187, 38);
            this.clearBttn.TabIndex = 8;
            this.clearBttn.Text = "&Clear Bet";
            this.clearBttn.UseVisualStyleBackColor = true;
            this.clearBttn.Click += new System.EventHandler(this.clearBttn_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(460, 667);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(187, 38);
            this.exitBttn.TabIndex = 9;
            this.exitBttn.Text = "Cash Out and E&xit";
            this.exitBttn.UseVisualStyleBackColor = true;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // betText
            // 
            this.betText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betText.Location = new System.Drawing.Point(341, 556);
            this.betText.Name = "betText";
            this.betText.Size = new System.Drawing.Size(307, 27);
            this.betText.TabIndex = 0;
            // 
            // betLbl
            // 
            this.betLbl.AutoSize = true;
            this.betLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLbl.ForeColor = System.Drawing.Color.Gold;
            this.betLbl.Location = new System.Drawing.Point(238, 559);
            this.betLbl.Name = "betLbl";
            this.betLbl.Size = new System.Drawing.Size(88, 20);
            this.betLbl.TabIndex = 15;
            this.betLbl.Text = "Your Bet:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 733);
            this.Controls.Add(this.firstIMG);
            this.Controls.Add(this.secondIMG);
            this.Controls.Add(this.betLbl);
            this.Controls.Add(this.thirdIMG);
            this.Controls.Add(this.betText);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.clearBttn);
            this.Controls.Add(this.spinBttn);
            this.Controls.Add(this.addSixtyDollars);
            this.Controls.Add(this.addFortyDollars);
            this.Controls.Add(this.addTwentyDollars);
            this.Controls.Add(this.addTenDollars);
            this.Controls.Add(this.addFiveDollars);
            this.Controls.Add(this.addOneDollar);
            this.Controls.Add(this.subtitleLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "MainForm";
            this.Text = "NQV Slots";
            ((System.ComponentModel.ISupportInitialize)(this.firstIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label subtitleLbl;
        private System.Windows.Forms.PictureBox firstIMG;
        private System.Windows.Forms.PictureBox secondIMG;
        private System.Windows.Forms.PictureBox thirdIMG;
        private System.Windows.Forms.Button addOneDollar;
        private System.Windows.Forms.Button addFiveDollars;
        private System.Windows.Forms.Button addTenDollars;
        private System.Windows.Forms.Button addTwentyDollars;
        private System.Windows.Forms.Button addFortyDollars;
        private System.Windows.Forms.Button addSixtyDollars;
        private System.Windows.Forms.Button spinBttn;
        private System.Windows.Forms.Button clearBttn;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.TextBox betText;
        private System.Windows.Forms.Label betLbl;
    }
}

