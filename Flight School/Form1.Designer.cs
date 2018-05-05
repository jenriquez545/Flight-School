namespace Flight_School
{
    partial class mainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCustButton = new System.Windows.Forms.Button();
            this.enterFlightButton = new System.Windows.Forms.Button();
            this.changeCustRatingButton = new System.Windows.Forms.Button();
            this.payInstructorButton = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to do?";
            // 
            // addCustButton
            // 
            this.addCustButton.Location = new System.Drawing.Point(53, 25);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(168, 23);
            this.addCustButton.TabIndex = 1;
            this.addCustButton.Text = "Add Customer";
            this.addCustButton.UseVisualStyleBackColor = true;
            this.addCustButton.Click += new System.EventHandler(this.addCustButton_Click);
            // 
            // enterFlightButton
            // 
            this.enterFlightButton.Location = new System.Drawing.Point(53, 75);
            this.enterFlightButton.Name = "enterFlightButton";
            this.enterFlightButton.Size = new System.Drawing.Size(168, 23);
            this.enterFlightButton.TabIndex = 2;
            this.enterFlightButton.Text = "Enter a flight";
            this.enterFlightButton.UseVisualStyleBackColor = true;
            this.enterFlightButton.Click += new System.EventHandler(this.enterFlightButton_Click);
            // 
            // changeCustRatingButton
            // 
            this.changeCustRatingButton.Location = new System.Drawing.Point(53, 127);
            this.changeCustRatingButton.Name = "changeCustRatingButton";
            this.changeCustRatingButton.Size = new System.Drawing.Size(168, 23);
            this.changeCustRatingButton.TabIndex = 3;
            this.changeCustRatingButton.Text = "Change Customer Rating";
            this.changeCustRatingButton.UseVisualStyleBackColor = true;
            this.changeCustRatingButton.Click += new System.EventHandler(this.changeCustRatingButton_Click_1);
            // 
            // payInstructorButton
            // 
            this.payInstructorButton.Location = new System.Drawing.Point(53, 178);
            this.payInstructorButton.Name = "payInstructorButton";
            this.payInstructorButton.Size = new System.Drawing.Size(168, 23);
            this.payInstructorButton.TabIndex = 5;
            this.payInstructorButton.Text = "Pay Instructor";
            this.payInstructorButton.UseVisualStyleBackColor = true;
            this.payInstructorButton.Click += new System.EventHandler(this.payEmployeeButton_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Location = new System.Drawing.Point(92, 226);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(75, 23);
            this.exitProgram.TabIndex = 6;
            this.exitProgram.Text = "Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 261);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.payInstructorButton);
            this.Controls.Add(this.changeCustRatingButton);
            this.Controls.Add(this.enterFlightButton);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.label1);
            this.Name = "mainMenuForm";
            this.Text = "Flight School Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.Button enterFlightButton;
        private System.Windows.Forms.Button changeCustRatingButton;
        private System.Windows.Forms.Button payInstructorButton;
        private System.Windows.Forms.Button exitProgram;
    }
}

