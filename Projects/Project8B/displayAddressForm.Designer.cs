
namespace Project8B
{
    partial class displayAddressForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.phoneOutput = new System.Windows.Forms.Label();
            this.emailOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Papyrus", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(88, 26);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(115, 58);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Papyrus", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(92, 116);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(192, 38);
            this.phoneLbl.TabIndex = 12;
            this.phoneLbl.Text = "Phone Number:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Papyrus", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(94, 217);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(194, 38);
            this.emailLbl.TabIndex = 13;
            this.emailLbl.Text = "Email Address:";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(73, 319);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(418, 88);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // phoneOutput
            // 
            this.phoneOutput.AutoSize = true;
            this.phoneOutput.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneOutput.Location = new System.Drawing.Point(95, 154);
            this.phoneOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneOutput.Name = "phoneOutput";
            this.phoneOutput.Size = new System.Drawing.Size(190, 31);
            this.phoneOutput.TabIndex = 15;
            this.phoneOutput.Text = "XXX-XXX-XXXX";
            // 
            // emailOutput
            // 
            this.emailOutput.AutoSize = true;
            this.emailOutput.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailOutput.Location = new System.Drawing.Point(93, 264);
            this.emailOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailOutput.Name = "emailOutput";
            this.emailOutput.Size = new System.Drawing.Size(297, 31);
            this.emailOutput.TabIndex = 16;
            this.emailOutput.Text = "EmailAddress@Address.com";
            // 
            // displayAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(532, 427);
            this.Controls.Add(this.emailOutput);
            this.Controls.Add(this.phoneOutput);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.titleLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "displayAddressForm";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label phoneOutput;
        private System.Windows.Forms.Label emailOutput;
    }
}