
namespace SpaceGame
{
    partial class Planet3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRiddle = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.lblRiddle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.moneyOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Riddles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer the following riddle:";
            // 
            // txtBoxRiddle
            // 
            this.txtBoxRiddle.Location = new System.Drawing.Point(167, 264);
            this.txtBoxRiddle.Name = "txtBoxRiddle";
            this.txtBoxRiddle.Size = new System.Drawing.Size(165, 20);
            this.txtBoxRiddle.TabIndex = 3;
            this.txtBoxRiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(168, 316);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(258, 316);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(109, 23);
            this.btnHint.TabIndex = 5;
            this.btnHint.Text = "Hint (10 gold)";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblRiddle
            // 
            this.lblRiddle.AutoSize = true;
            this.lblRiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiddle.Location = new System.Drawing.Point(131, 194);
            this.lblRiddle.Name = "lblRiddle";
            this.lblRiddle.Size = new System.Drawing.Size(236, 16);
            this.lblRiddle.TabIndex = 6;
            this.lblRiddle.Text = "What goes up when rain comes down?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(211, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // moneyOutputLabel
            // 
            this.moneyOutputLabel.AutoSize = true;
            this.moneyOutputLabel.Location = new System.Drawing.Point(52, 271);
            this.moneyOutputLabel.Name = "moneyOutputLabel";
            this.moneyOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.moneyOutputLabel.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Gold: ";
            // 
            // Planet3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.moneyOutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRiddle);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxRiddle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Planet3";
            this.Text = "Planet3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRiddle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label lblRiddle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label moneyOutputLabel;
        private System.Windows.Forms.Label label1;
    }
}