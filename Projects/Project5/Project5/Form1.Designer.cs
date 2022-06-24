
namespace classExample
{
    partial class Automotive
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
            this.OBox = new System.Windows.Forms.GroupBox();
            this.lubeCheck = new System.Windows.Forms.CheckBox();
            this.oilCheck = new System.Windows.Forms.CheckBox();
            this.FBox = new System.Windows.Forms.GroupBox();
            this.transCheck = new System.Windows.Forms.CheckBox();
            this.radCheck = new System.Windows.Forms.CheckBox();
            this.MBox = new System.Windows.Forms.GroupBox();
            this.tireCheck = new System.Windows.Forms.CheckBox();
            this.mufflerCheck = new System.Windows.Forms.CheckBox();
            this.inspectCheck = new System.Windows.Forms.CheckBox();
            this.PBox = new System.Windows.Forms.GroupBox();
            this.laborInput = new System.Windows.Forms.TextBox();
            this.partsInput = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.SBox = new System.Windows.Forms.GroupBox();
            this.totalOutLabel = new System.Windows.Forms.Label();
            this.taxOutLabel = new System.Windows.Forms.Label();
            this.laborOutLabel = new System.Windows.Forms.Label();
            this.partsOutLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.partsOutput = new System.Windows.Forms.TextBox();
            this.laborOutput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.OBox.SuspendLayout();
            this.FBox.SuspendLayout();
            this.MBox.SuspendLayout();
            this.PBox.SuspendLayout();
            this.SBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OBox
            // 
            this.OBox.Controls.Add(this.lubeCheck);
            this.OBox.Controls.Add(this.oilCheck);
            this.OBox.Location = new System.Drawing.Point(93, 170);
            this.OBox.Margin = new System.Windows.Forms.Padding(4);
            this.OBox.Name = "OBox";
            this.OBox.Padding = new System.Windows.Forms.Padding(4);
            this.OBox.Size = new System.Drawing.Size(259, 106);
            this.OBox.TabIndex = 0;
            this.OBox.TabStop = false;
            this.OBox.Text = "Oil and Lube";
            // 
            // lubeCheck
            // 
            this.lubeCheck.AutoSize = true;
            this.lubeCheck.Location = new System.Drawing.Point(40, 79);
            this.lubeCheck.Margin = new System.Windows.Forms.Padding(4);
            this.lubeCheck.Name = "lubeCheck";
            this.lubeCheck.Size = new System.Drawing.Size(147, 21);
            this.lubeCheck.TabIndex = 1;
            this.lubeCheck.Text = "&Lube Job ($18.00)";
            this.lubeCheck.UseVisualStyleBackColor = true;
            // 
            // oilCheck
            // 
            this.oilCheck.AutoSize = true;
            this.oilCheck.Location = new System.Drawing.Point(40, 38);
            this.oilCheck.Margin = new System.Windows.Forms.Padding(4);
            this.oilCheck.Name = "oilCheck";
            this.oilCheck.Size = new System.Drawing.Size(198, 26);
            this.oilCheck.TabIndex = 0;
            this.oilCheck.Text = "&Oil Change ($26.00)";
            this.oilCheck.UseVisualStyleBackColor = true;
            // 
            // FBox
            // 
            this.FBox.Controls.Add(this.transCheck);
            this.FBox.Controls.Add(this.radCheck);
            this.FBox.Location = new System.Drawing.Point(453, 170);
            this.FBox.Margin = new System.Windows.Forms.Padding(4);
            this.FBox.Name = "FBox";
            this.FBox.Padding = new System.Windows.Forms.Padding(4);
            this.FBox.Size = new System.Drawing.Size(299, 106);
            this.FBox.TabIndex = 1;
            this.FBox.TabStop = false;
            this.FBox.Text = "Flushes";
            // 
            // transCheck
            // 
            this.transCheck.AutoSize = true;
            this.transCheck.Location = new System.Drawing.Point(36, 79);
            this.transCheck.Margin = new System.Windows.Forms.Padding(4);
            this.transCheck.Name = "transCheck";
            this.transCheck.Size = new System.Drawing.Size(210, 21);
            this.transCheck.TabIndex = 1;
            this.transCheck.Text = "Transmission &Flush ($80.00)";
            this.transCheck.UseVisualStyleBackColor = true;
            // 
            // radCheck
            // 
            this.radCheck.AutoSize = true;
            this.radCheck.Location = new System.Drawing.Point(36, 38);
            this.radCheck.Margin = new System.Windows.Forms.Padding(4);
            this.radCheck.Name = "radCheck";
            this.radCheck.Size = new System.Drawing.Size(180, 21);
            this.radCheck.TabIndex = 0;
            this.radCheck.Text = "&Radiator Flush ($30.00)";
            this.radCheck.UseVisualStyleBackColor = true;
            // 
            // MBox
            // 
            this.MBox.Controls.Add(this.tireCheck);
            this.MBox.Controls.Add(this.mufflerCheck);
            this.MBox.Controls.Add(this.inspectCheck);
            this.MBox.Location = new System.Drawing.Point(93, 284);
            this.MBox.Margin = new System.Windows.Forms.Padding(4);
            this.MBox.Name = "MBox";
            this.MBox.Padding = new System.Windows.Forms.Padding(4);
            this.MBox.Size = new System.Drawing.Size(259, 144);
            this.MBox.TabIndex = 2;
            this.MBox.TabStop = false;
            this.MBox.Text = "Misc";
            // 
            // tireCheck
            // 
            this.tireCheck.AutoSize = true;
            this.tireCheck.Location = new System.Drawing.Point(40, 102);
            this.tireCheck.Margin = new System.Windows.Forms.Padding(4);
            this.tireCheck.Name = "tireCheck";
            this.tireCheck.Size = new System.Drawing.Size(170, 21);
            this.tireCheck.TabIndex = 2;
            this.tireCheck.Text = "&Tire Rotation ($20.00)";
            this.tireCheck.UseVisualStyleBackColor = true;
            // 
            // mufflerCheck
            // 
            this.mufflerCheck.AutoSize = true;
            this.mufflerCheck.Location = new System.Drawing.Point(40, 63);
            this.mufflerCheck.Margin = new System.Windows.Forms.Padding(4);
            this.mufflerCheck.Name = "mufflerCheck";
            this.mufflerCheck.Size = new System.Drawing.Size(195, 21);
            this.mufflerCheck.TabIndex = 1;
            this.mufflerCheck.Text = "Replace &Muffler ($100.00)";
            this.mufflerCheck.UseVisualStyleBackColor = true;
            // 
            // inspectCheck
            // 
            this.inspectCheck.AutoSize = true;
            this.inspectCheck.Location = new System.Drawing.Point(40, 23);
            this.inspectCheck.Margin = new System.Windows.Forms.Padding(4);
            this.inspectCheck.Name = "inspectCheck";
            this.inspectCheck.Size = new System.Drawing.Size(152, 21);
            this.inspectCheck.TabIndex = 0;
            this.inspectCheck.Text = "&Inspection ($15.00)";
            this.inspectCheck.UseVisualStyleBackColor = true;
            // 
            // PBox
            // 
            this.PBox.Controls.Add(this.laborInput);
            this.PBox.Controls.Add(this.partsInput);
            this.PBox.Controls.Add(this.laborLabel);
            this.PBox.Controls.Add(this.partsLabel);
            this.PBox.Location = new System.Drawing.Point(453, 284);
            this.PBox.Margin = new System.Windows.Forms.Padding(4);
            this.PBox.Name = "PBox";
            this.PBox.Padding = new System.Windows.Forms.Padding(4);
            this.PBox.Size = new System.Drawing.Size(299, 144);
            this.PBox.TabIndex = 2;
            this.PBox.TabStop = false;
            this.PBox.Text = "Parts and Labor";
            // 
            // laborInput
            // 
            this.laborInput.Location = new System.Drawing.Point(136, 76);
            this.laborInput.Margin = new System.Windows.Forms.Padding(4);
            this.laborInput.Name = "laborInput";
            this.laborInput.Size = new System.Drawing.Size(108, 22);
            this.laborInput.TabIndex = 3;
            // 
            // partsInput
            // 
            this.partsInput.Location = new System.Drawing.Point(136, 33);
            this.partsInput.Margin = new System.Windows.Forms.Padding(4);
            this.partsInput.Name = "partsInput";
            this.partsInput.Size = new System.Drawing.Size(108, 22);
            this.partsInput.TabIndex = 2;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(32, 85);
            this.laborLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(67, 17);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "La&bor ($)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(32, 42);
            this.partsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(41, 17);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "&Parts";
            // 
            // SBox
            // 
            this.SBox.Controls.Add(this.totalOutLabel);
            this.SBox.Controls.Add(this.taxOutLabel);
            this.SBox.Controls.Add(this.laborOutLabel);
            this.SBox.Controls.Add(this.partsOutLabel);
            this.SBox.Controls.Add(this.totalOutput);
            this.SBox.Controls.Add(this.taxOutput);
            this.SBox.Controls.Add(this.partsOutput);
            this.SBox.Controls.Add(this.laborOutput);
            this.SBox.Location = new System.Drawing.Point(149, 436);
            this.SBox.Margin = new System.Windows.Forms.Padding(4);
            this.SBox.Name = "SBox";
            this.SBox.Padding = new System.Windows.Forms.Padding(4);
            this.SBox.Size = new System.Drawing.Size(603, 190);
            this.SBox.TabIndex = 2;
            this.SBox.TabStop = false;
            this.SBox.Text = "Summary";
            // 
            // totalOutLabel
            // 
            this.totalOutLabel.AutoSize = true;
            this.totalOutLabel.Location = new System.Drawing.Point(136, 150);
            this.totalOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalOutLabel.Name = "totalOutLabel";
            this.totalOutLabel.Size = new System.Drawing.Size(75, 17);
            this.totalOutLabel.TabIndex = 10;
            this.totalOutLabel.Text = "Total Fees";
            // 
            // taxOutLabel
            // 
            this.taxOutLabel.AutoSize = true;
            this.taxOutLabel.Location = new System.Drawing.Point(116, 118);
            this.taxOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taxOutLabel.Name = "taxOutLabel";
            this.taxOutLabel.Size = new System.Drawing.Size(97, 17);
            this.taxOutLabel.TabIndex = 9;
            this.taxOutLabel.Text = "Tax (on parts)";
            // 
            // laborOutLabel
            // 
            this.laborOutLabel.AutoSize = true;
            this.laborOutLabel.Location = new System.Drawing.Point(87, 54);
            this.laborOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laborOutLabel.Name = "laborOutLabel";
            this.laborOutLabel.Size = new System.Drawing.Size(124, 17);
            this.laborOutLabel.TabIndex = 8;
            this.laborOutLabel.Text = "Service and Labor";
            // 
            // partsOutLabel
            // 
            this.partsOutLabel.AutoSize = true;
            this.partsOutLabel.Location = new System.Drawing.Point(171, 86);
            this.partsOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsOutLabel.Name = "partsOutLabel";
            this.partsOutLabel.Size = new System.Drawing.Size(41, 17);
            this.partsOutLabel.TabIndex = 4;
            this.partsOutLabel.Text = "Parts";
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(236, 142);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(225, 22);
            this.totalOutput.TabIndex = 7;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(236, 110);
            this.taxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.ReadOnly = true;
            this.taxOutput.Size = new System.Drawing.Size(225, 22);
            this.taxOutput.TabIndex = 6;
            // 
            // partsOutput
            // 
            this.partsOutput.Location = new System.Drawing.Point(236, 78);
            this.partsOutput.Margin = new System.Windows.Forms.Padding(4);
            this.partsOutput.Name = "partsOutput";
            this.partsOutput.ReadOnly = true;
            this.partsOutput.Size = new System.Drawing.Size(225, 22);
            this.partsOutput.TabIndex = 5;
            // 
            // laborOutput
            // 
            this.laborOutput.Location = new System.Drawing.Point(236, 46);
            this.laborOutput.Margin = new System.Windows.Forms.Padding(4);
            this.laborOutput.Name = "laborOutput";
            this.laborOutput.ReadOnly = true;
            this.laborOutput.Size = new System.Drawing.Size(225, 22);
            this.laborOutput.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(122, 652);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(144, 34);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(373, 652);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(144, 34);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Cle&ar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(608, 652);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::classExample.Properties.Resources.joes_sign1;
            this.pictureBox1.Location = new System.Drawing.Point(692, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 213);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Print", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(64, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(469, 79);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Job Cost Calculator";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(73, 88);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(542, 60);
            this.instructionLabel.TabIndex = 8;
            this.instructionLabel.Text = "Check all applicable boxes to add to the total.\r\nInput the cost of parts and cost" +
    " of labor as positive numbers.";
            // 
            // Automotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(917, 722);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.SBox);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.FBox);
            this.Controls.Add(this.OBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Automotive";
            this.Text = "Joe\'s Automotive";
            this.OBox.ResumeLayout(false);
            this.OBox.PerformLayout();
            this.FBox.ResumeLayout(false);
            this.FBox.PerformLayout();
            this.MBox.ResumeLayout(false);
            this.MBox.PerformLayout();
            this.PBox.ResumeLayout(false);
            this.PBox.PerformLayout();
            this.SBox.ResumeLayout(false);
            this.SBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox OBox;
        private System.Windows.Forms.GroupBox FBox;
        private System.Windows.Forms.GroupBox MBox;
        private System.Windows.Forms.GroupBox PBox;
        private System.Windows.Forms.GroupBox SBox;
        private System.Windows.Forms.CheckBox lubeCheck;
        private System.Windows.Forms.CheckBox oilCheck;
        private System.Windows.Forms.CheckBox transCheck;
        private System.Windows.Forms.CheckBox radCheck;
        private System.Windows.Forms.CheckBox tireCheck;
        private System.Windows.Forms.CheckBox mufflerCheck;
        private System.Windows.Forms.CheckBox inspectCheck;
        private System.Windows.Forms.TextBox laborInput;
        private System.Windows.Forms.TextBox partsInput;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label totalOutLabel;
        private System.Windows.Forms.Label taxOutLabel;
        private System.Windows.Forms.Label laborOutLabel;
        private System.Windows.Forms.Label partsOutLabel;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox partsOutput;
        private System.Windows.Forms.TextBox laborOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
    }
}

