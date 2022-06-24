
namespace Project3
{
    partial class convertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(convertForm));
            this.inputList = new System.Windows.Forms.ListBox();
            this.outputList = new System.Windows.Forms.ListBox();
            this.rulerPicture = new System.Windows.Forms.PictureBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.Label();
            this.outputTextLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rulerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // inputList
            // 
            this.inputList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputList.FormattingEnabled = true;
            this.inputList.ItemHeight = 22;
            this.inputList.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.inputList.Location = new System.Drawing.Point(122, 184);
            this.inputList.Name = "inputList";
            this.inputList.Size = new System.Drawing.Size(225, 70);
            this.inputList.TabIndex = 1;
            // 
            // outputList
            // 
            this.outputList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.FormattingEnabled = true;
            this.outputList.ItemHeight = 22;
            this.outputList.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.outputList.Location = new System.Drawing.Point(122, 308);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(225, 70);
            this.outputList.TabIndex = 2;
            // 
            // rulerPicture
            // 
            this.rulerPicture.BackgroundImage = global::Project3.Properties.Resources.logo;
            this.rulerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rulerPicture.Location = new System.Drawing.Point(12, 12);
            this.rulerPicture.Name = "rulerPicture";
            this.rulerPicture.Size = new System.Drawing.Size(100, 600);
            this.rulerPicture.TabIndex = 3;
            this.rulerPicture.TabStop = false;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.CausesValidation = false;
            this.inputLabel.Enabled = false;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(118, 157);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(205, 24);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Select the unit for input:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.CausesValidation = false;
            this.outputLabel.Enabled = false;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(118, 281);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(216, 24);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Select the unit for output:";
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(122, 87);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(225, 28);
            this.inputText.TabIndex = 0;
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.CausesValidation = false;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(118, 12);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(377, 72);
            this.instructions.TabIndex = 6;
            this.instructions.Text = "This tool can help convert units of\r\nmeasurement. Please enter a measurement\r\nand" +
    " select units for input and output.";
            // 
            // outputTextLabel
            // 
            this.outputTextLabel.AutoSize = true;
            this.outputTextLabel.CausesValidation = false;
            this.outputTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextLabel.Location = new System.Drawing.Point(118, 409);
            this.outputTextLabel.Name = "outputTextLabel";
            this.outputTextLabel.Size = new System.Drawing.Size(71, 24);
            this.outputTextLabel.TabIndex = 8;
            this.outputTextLabel.Text = "Output:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(118, 564);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 48);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(299, 564);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 48);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(118, 499);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(322, 48);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputText
            // 
            this.outputText.CausesValidation = false;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(122, 436);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(225, 28);
            this.outputText.TabIndex = 9;
            this.outputText.TabStop = false;
            // 
            // convertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 639);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTextLabel);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.rulerPicture);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.inputList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "convertForm";
            this.Text = "Measurement Converter";
            ((System.ComponentModel.ISupportInitialize)(this.rulerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputList;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.PictureBox rulerPicture;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label outputTextLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox outputText;
    }
}

