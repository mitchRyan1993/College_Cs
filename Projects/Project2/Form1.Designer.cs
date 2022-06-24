
namespace Project2
{
    partial class paintEstimate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paintEstimate));
            this.companyName = new System.Windows.Forms.Label();
            this.slogan = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.submitEstimate = new System.Windows.Forms.Button();
            this.paintCostInput = new System.Windows.Forms.TextBox();
            this.jobSizeInput = new System.Windows.Forms.TextBox();
            this.paintCostLBL = new System.Windows.Forms.Label();
            this.instructTwo = new System.Windows.Forms.Label();
            this.jobSizeLBL = new System.Windows.Forms.Label();
            this.instructOne = new System.Windows.Forms.Label();
            this.clearInput = new System.Windows.Forms.Button();
            this.exitForm = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.TextBox();
            this.laborChargeOutput = new System.Windows.Forms.TextBox();
            this.laborHoursOutput = new System.Windows.Forms.TextBox();
            this.paintTotalOutput = new System.Windows.Forms.TextBox();
            this.gallonsOutput = new System.Windows.Forms.TextBox();
            this.totalLBL = new System.Windows.Forms.Label();
            this.laborChargeLBL = new System.Windows.Forms.Label();
            this.laborHoursLBL = new System.Windows.Forms.Label();
            this.paintTotalLBL = new System.Windows.Forms.Label();
            this.gallonsLBL = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.BackColor = System.Drawing.Color.Transparent;
            this.companyName.CausesValidation = false;
            this.companyName.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.Location = new System.Drawing.Point(170, 9);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(453, 49);
            this.companyName.TabIndex = 0;
            this.companyName.Text = "The Paint Chuckers";
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.BackColor = System.Drawing.Color.Transparent;
            this.slogan.CausesValidation = false;
            this.slogan.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.Location = new System.Drawing.Point(192, 59);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(388, 27);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "Hire us to throw paint around!";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.inputGroupBox.CausesValidation = false;
            this.inputGroupBox.Controls.Add(this.submitEstimate);
            this.inputGroupBox.Controls.Add(this.paintCostInput);
            this.inputGroupBox.Controls.Add(this.jobSizeInput);
            this.inputGroupBox.Controls.Add(this.paintCostLBL);
            this.inputGroupBox.Controls.Add(this.instructTwo);
            this.inputGroupBox.Controls.Add(this.jobSizeLBL);
            this.inputGroupBox.Controls.Add(this.instructOne);
            this.inputGroupBox.Location = new System.Drawing.Point(37, 103);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(733, 315);
            this.inputGroupBox.TabIndex = 2;
            this.inputGroupBox.TabStop = false;
            // 
            // submitEstimate
            // 
            this.submitEstimate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitEstimate.BackgroundImage")));
            this.submitEstimate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitEstimate.Location = new System.Drawing.Point(203, 203);
            this.submitEstimate.Name = "submitEstimate";
            this.submitEstimate.Size = new System.Drawing.Size(273, 98);
            this.submitEstimate.TabIndex = 2;
            this.submitEstimate.Text = "PAINT!";
            this.submitEstimate.UseVisualStyleBackColor = true;
            this.submitEstimate.Click += new System.EventHandler(this.submitEstimate_Click);
            // 
            // paintCostInput
            // 
            this.paintCostInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCostInput.Location = new System.Drawing.Point(365, 162);
            this.paintCostInput.Name = "paintCostInput";
            this.paintCostInput.Size = new System.Drawing.Size(290, 30);
            this.paintCostInput.TabIndex = 1;
            // 
            // jobSizeInput
            // 
            this.jobSizeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobSizeInput.Location = new System.Drawing.Point(365, 115);
            this.jobSizeInput.Name = "jobSizeInput";
            this.jobSizeInput.Size = new System.Drawing.Size(290, 30);
            this.jobSizeInput.TabIndex = 0;
            // 
            // paintCostLBL
            // 
            this.paintCostLBL.AutoSize = true;
            this.paintCostLBL.BackColor = System.Drawing.Color.Transparent;
            this.paintCostLBL.CausesValidation = false;
            this.paintCostLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCostLBL.Location = new System.Drawing.Point(67, 162);
            this.paintCostLBL.Name = "paintCostLBL";
            this.paintCostLBL.Size = new System.Drawing.Size(253, 25);
            this.paintCostLBL.TabIndex = 3;
            this.paintCostLBL.Text = "Cost of Paint (per gallon)";
            this.paintCostLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // instructTwo
            // 
            this.instructTwo.AutoSize = true;
            this.instructTwo.BackColor = System.Drawing.Color.Transparent;
            this.instructTwo.CausesValidation = false;
            this.instructTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructTwo.Location = new System.Drawing.Point(137, 39);
            this.instructTwo.Name = "instructTwo";
            this.instructTwo.Size = new System.Drawing.Size(423, 29);
            this.instructTwo.TabIndex = 2;
            this.instructTwo.Text = "job and the cost per gallon of paint.";
            // 
            // jobSizeLBL
            // 
            this.jobSizeLBL.AutoSize = true;
            this.jobSizeLBL.BackColor = System.Drawing.Color.Transparent;
            this.jobSizeLBL.CausesValidation = false;
            this.jobSizeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobSizeLBL.Location = new System.Drawing.Point(93, 116);
            this.jobSizeLBL.Name = "jobSizeLBL";
            this.jobSizeLBL.Size = new System.Drawing.Size(227, 25);
            this.jobSizeLBL.TabIndex = 1;
            this.jobSizeLBL.Text = "Job Size (square feet)";
            this.jobSizeLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // instructOne
            // 
            this.instructOne.AutoSize = true;
            this.instructOne.BackColor = System.Drawing.Color.Transparent;
            this.instructOne.CausesValidation = false;
            this.instructOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructOne.Location = new System.Drawing.Point(105, 10);
            this.instructOne.Name = "instructOne";
            this.instructOne.Size = new System.Drawing.Size(482, 29);
            this.instructOne.TabIndex = 0;
            this.instructOne.Text = "Please enter the square foot size of your";
            // 
            // clearInput
            // 
            this.clearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInput.Location = new System.Drawing.Point(162, 650);
            this.clearInput.Name = "clearInput";
            this.clearInput.Size = new System.Drawing.Size(195, 52);
            this.clearInput.TabIndex = 3;
            this.clearInput.Text = "Clear";
            this.clearInput.UseVisualStyleBackColor = true;
            this.clearInput.Click += new System.EventHandler(this.clearInput_Click);
            // 
            // exitForm
            // 
            this.exitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitForm.Location = new System.Drawing.Point(402, 650);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(195, 52);
            this.exitForm.TabIndex = 4;
            this.exitForm.Text = "Exit";
            this.exitForm.UseVisualStyleBackColor = true;
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.label1);
            this.outputGroupBox.Controls.Add(this.totalCostOutput);
            this.outputGroupBox.Controls.Add(this.laborChargeOutput);
            this.outputGroupBox.Controls.Add(this.laborHoursOutput);
            this.outputGroupBox.Controls.Add(this.paintTotalOutput);
            this.outputGroupBox.Controls.Add(this.gallonsOutput);
            this.outputGroupBox.Controls.Add(this.totalLBL);
            this.outputGroupBox.Controls.Add(this.laborChargeLBL);
            this.outputGroupBox.Controls.Add(this.laborHoursLBL);
            this.outputGroupBox.Controls.Add(this.paintTotalLBL);
            this.outputGroupBox.Controls.Add(this.gallonsLBL);
            this.outputGroupBox.Location = new System.Drawing.Point(37, 410);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(733, 222);
            this.outputGroupBox.TabIndex = 9;
            this.outputGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Based on the information entered your estimate is:";
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.CausesValidation = false;
            this.totalCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutput.Location = new System.Drawing.Point(334, 173);
            this.totalCostOutput.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.ReadOnly = true;
            this.totalCostOutput.Size = new System.Drawing.Size(321, 27);
            this.totalCostOutput.TabIndex = 10;
            this.totalCostOutput.TabStop = false;
            // 
            // laborChargeOutput
            // 
            this.laborChargeOutput.CausesValidation = false;
            this.laborChargeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborChargeOutput.Location = new System.Drawing.Point(334, 139);
            this.laborChargeOutput.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.laborChargeOutput.Name = "laborChargeOutput";
            this.laborChargeOutput.ReadOnly = true;
            this.laborChargeOutput.Size = new System.Drawing.Size(321, 27);
            this.laborChargeOutput.TabIndex = 9;
            this.laborChargeOutput.TabStop = false;
            // 
            // laborHoursOutput
            // 
            this.laborHoursOutput.CausesValidation = false;
            this.laborHoursOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborHoursOutput.Location = new System.Drawing.Point(334, 106);
            this.laborHoursOutput.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.laborHoursOutput.Name = "laborHoursOutput";
            this.laborHoursOutput.ReadOnly = true;
            this.laborHoursOutput.Size = new System.Drawing.Size(321, 27);
            this.laborHoursOutput.TabIndex = 8;
            this.laborHoursOutput.TabStop = false;
            // 
            // paintTotalOutput
            // 
            this.paintTotalOutput.CausesValidation = false;
            this.paintTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintTotalOutput.Location = new System.Drawing.Point(334, 73);
            this.paintTotalOutput.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.paintTotalOutput.Name = "paintTotalOutput";
            this.paintTotalOutput.ReadOnly = true;
            this.paintTotalOutput.Size = new System.Drawing.Size(321, 27);
            this.paintTotalOutput.TabIndex = 7;
            this.paintTotalOutput.TabStop = false;
            // 
            // gallonsOutput
            // 
            this.gallonsOutput.CausesValidation = false;
            this.gallonsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsOutput.Location = new System.Drawing.Point(334, 38);
            this.gallonsOutput.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.gallonsOutput.Name = "gallonsOutput";
            this.gallonsOutput.ReadOnly = true;
            this.gallonsOutput.Size = new System.Drawing.Size(321, 27);
            this.gallonsOutput.TabIndex = 6;
            this.gallonsOutput.TabStop = false;
            // 
            // totalLBL
            // 
            this.totalLBL.AutoSize = true;
            this.totalLBL.CausesValidation = false;
            this.totalLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLBL.Location = new System.Drawing.Point(153, 180);
            this.totalLBL.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(102, 20);
            this.totalLBL.TabIndex = 5;
            this.totalLBL.Text = "Total Cost:";
            this.totalLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // laborChargeLBL
            // 
            this.laborChargeLBL.AutoSize = true;
            this.laborChargeLBL.CausesValidation = false;
            this.laborChargeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborChargeLBL.Location = new System.Drawing.Point(116, 146);
            this.laborChargeLBL.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.laborChargeLBL.Name = "laborChargeLBL";
            this.laborChargeLBL.Size = new System.Drawing.Size(139, 20);
            this.laborChargeLBL.TabIndex = 4;
            this.laborChargeLBL.Text = "Labor Charges:";
            this.laborChargeLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // laborHoursLBL
            // 
            this.laborHoursLBL.AutoSize = true;
            this.laborHoursLBL.CausesValidation = false;
            this.laborHoursLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborHoursLBL.Location = new System.Drawing.Point(113, 113);
            this.laborHoursLBL.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.laborHoursLBL.Name = "laborHoursLBL";
            this.laborHoursLBL.Size = new System.Drawing.Size(142, 20);
            this.laborHoursLBL.TabIndex = 3;
            this.laborHoursLBL.Text = "Hours of Labor:";
            this.laborHoursLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // paintTotalLBL
            // 
            this.paintTotalLBL.AutoSize = true;
            this.paintTotalLBL.CausesValidation = false;
            this.paintTotalLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintTotalLBL.Location = new System.Drawing.Point(82, 80);
            this.paintTotalLBL.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.paintTotalLBL.Name = "paintTotalLBL";
            this.paintTotalLBL.Size = new System.Drawing.Size(173, 20);
            this.paintTotalLBL.TabIndex = 2;
            this.paintTotalLBL.Text = "Total Cost of Paint:";
            this.paintTotalLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gallonsLBL
            // 
            this.gallonsLBL.AutoSize = true;
            this.gallonsLBL.CausesValidation = false;
            this.gallonsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsLBL.Location = new System.Drawing.Point(107, 45);
            this.gallonsLBL.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.gallonsLBL.Name = "gallonsLBL";
            this.gallonsLBL.Size = new System.Drawing.Size(148, 20);
            this.gallonsLBL.TabIndex = 1;
            this.gallonsLBL.Text = "Gallons Needed:";
            this.gallonsLBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // paintEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 729);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.clearInput);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.slogan);
            this.Controls.Add(this.companyName);
            this.Name = "paintEstimate";
            this.Text = "The Paint Chuckers App";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox paintCostInput;
        private System.Windows.Forms.TextBox jobSizeInput;
        private System.Windows.Forms.Label paintCostLBL;
        private System.Windows.Forms.Label instructTwo;
        private System.Windows.Forms.Label jobSizeLBL;
        private System.Windows.Forms.Label instructOne;
        private System.Windows.Forms.Button submitEstimate;
        private System.Windows.Forms.Button clearInput;
        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.TextBox totalCostOutput;
        private System.Windows.Forms.TextBox laborChargeOutput;
        private System.Windows.Forms.TextBox laborHoursOutput;
        private System.Windows.Forms.TextBox paintTotalOutput;
        private System.Windows.Forms.TextBox gallonsOutput;
        private System.Windows.Forms.Label totalLBL;
        private System.Windows.Forms.Label laborChargeLBL;
        private System.Windows.Forms.Label laborHoursLBL;
        private System.Windows.Forms.Label paintTotalLBL;
        private System.Windows.Forms.Label gallonsLBL;
        private System.Windows.Forms.Label label1;
    }
}

