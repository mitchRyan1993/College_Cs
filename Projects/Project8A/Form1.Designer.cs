
namespace Project8A
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
            this.nameInfoList = new System.Windows.Forms.ListBox();
            this.nameInfoListLbl = new System.Windows.Forms.Label();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.outputList = new System.Windows.Forms.ListBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.yearInputLbl = new System.Windows.Forms.Label();
            this.yearInputText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.collegeIMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.collegeIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(148, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(460, 36);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Student Names and Birth Years";
            // 
            // nameInfoList
            // 
            this.nameInfoList.FormattingEnabled = true;
            this.nameInfoList.ItemHeight = 16;
            this.nameInfoList.Location = new System.Drawing.Point(607, 195);
            this.nameInfoList.Name = "nameInfoList";
            this.nameInfoList.Size = new System.Drawing.Size(249, 420);
            this.nameInfoList.TabIndex = 1;
            // 
            // nameInfoListLbl
            // 
            this.nameInfoListLbl.AutoSize = true;
            this.nameInfoListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInfoListLbl.Location = new System.Drawing.Point(603, 168);
            this.nameInfoListLbl.Name = "nameInfoListLbl";
            this.nameInfoListLbl.Size = new System.Drawing.Size(106, 24);
            this.nameInfoListLbl.TabIndex = 2;
            this.nameInfoListLbl.Text = "Student List";
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.Location = new System.Drawing.Point(178, 69);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(411, 80);
            this.instructionsLbl.TabIndex = 3;
            this.instructionsLbl.Text = "To find all students born in a particular year, type\r\nthe year into the text box " +
    "and press the Submit button.\r\nIf no students were born in the selected year\r\n\"No" +
    " Students Found\" will be displayed.";
            this.instructionsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputList
            // 
            this.outputList.FormattingEnabled = true;
            this.outputList.ItemHeight = 16;
            this.outputList.Location = new System.Drawing.Point(62, 301);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(197, 196);
            this.outputList.TabIndex = 4;
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(58, 268);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(192, 24);
            this.outputLbl.TabIndex = 5;
            this.outputLbl.Text = "Students born in 2000";
            this.outputLbl.Visible = false;
            // 
            // yearInputLbl
            // 
            this.yearInputLbl.AutoSize = true;
            this.yearInputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInputLbl.Location = new System.Drawing.Point(59, 208);
            this.yearInputLbl.Name = "yearInputLbl";
            this.yearInputLbl.Size = new System.Drawing.Size(91, 18);
            this.yearInputLbl.TabIndex = 6;
            this.yearInputLbl.Text = "Enter a year:";
            // 
            // yearInputText
            // 
            this.yearInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearInputText.Location = new System.Drawing.Point(154, 205);
            this.yearInputText.Name = "yearInputText";
            this.yearInputText.Size = new System.Drawing.Size(268, 24);
            this.yearInputText.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(282, 301);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(168, 52);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(282, 371);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(168, 52);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(282, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 52);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // collegeIMG
            // 
            this.collegeIMG.Image = ((System.Drawing.Image)(resources.GetObject("collegeIMG.Image")));
            this.collegeIMG.Location = new System.Drawing.Point(62, 530);
            this.collegeIMG.Name = "collegeIMG";
            this.collegeIMG.Size = new System.Drawing.Size(388, 85);
            this.collegeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.collegeIMG.TabIndex = 7;
            this.collegeIMG.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(882, 674);
            this.Controls.Add(this.collegeIMG);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.yearInputText);
            this.Controls.Add(this.yearInputLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.instructionsLbl);
            this.Controls.Add(this.nameInfoListLbl);
            this.Controls.Add(this.nameInfoList);
            this.Controls.Add(this.titleLbl);
            this.Name = "MainForm";
            this.Text = "Student | DOB";
            ((System.ComponentModel.ISupportInitialize)(this.collegeIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ListBox nameInfoList;
        private System.Windows.Forms.Label nameInfoListLbl;
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label yearInputLbl;
        private System.Windows.Forms.TextBox yearInputText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox collegeIMG;
    }
}

