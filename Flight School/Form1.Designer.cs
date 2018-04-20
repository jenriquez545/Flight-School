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
            this.changeCustAuthButton = new System.Windows.Forms.Button();
            this.custToInstButton = new System.Windows.Forms.Button();
            this.payEmployeeButton = new System.Windows.Forms.Button();
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
            this.enterFlightButton.Location = new System.Drawing.Point(53, 54);
            this.enterFlightButton.Name = "enterFlightButton";
            this.enterFlightButton.Size = new System.Drawing.Size(168, 23);
            this.enterFlightButton.TabIndex = 2;
            this.enterFlightButton.Text = "Enter a flight";
            this.enterFlightButton.UseVisualStyleBackColor = true;
            this.enterFlightButton.Click += new System.EventHandler(this.enterFlightButton_Click);
            // 
            // changeCustAuthButton
            // 
            this.changeCustAuthButton.Location = new System.Drawing.Point(53, 83);
            this.changeCustAuthButton.Name = "changeCustAuthButton";
            this.changeCustAuthButton.Size = new System.Drawing.Size(168, 23);
            this.changeCustAuthButton.TabIndex = 3;
            this.changeCustAuthButton.Text = "Change Customer Authorization";
            this.changeCustAuthButton.UseVisualStyleBackColor = true;
            this.changeCustAuthButton.Click += new System.EventHandler(this.changeCustAuthButton_Click);
            // 
            // custToInstButton
            // 
            this.custToInstButton.Location = new System.Drawing.Point(53, 112);
            this.custToInstButton.Name = "custToInstButton";
            this.custToInstButton.Size = new System.Drawing.Size(168, 23);
            this.custToInstButton.TabIndex = 4;
            this.custToInstButton.Text = "Make Customer An Instructor";
            this.custToInstButton.UseVisualStyleBackColor = true;
            this.custToInstButton.Click += new System.EventHandler(this.custToInstButton_Click);
            // 
            // payEmployeeButton
            // 
            this.payEmployeeButton.Location = new System.Drawing.Point(53, 141);
            this.payEmployeeButton.Name = "payEmployeeButton";
            this.payEmployeeButton.Size = new System.Drawing.Size(168, 23);
            this.payEmployeeButton.TabIndex = 5;
            this.payEmployeeButton.Text = "Pay Employee";
            this.payEmployeeButton.UseVisualStyleBackColor = true;
            this.payEmployeeButton.Click += new System.EventHandler(this.payEmployeeButton_Click);
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
            this.Controls.Add(this.payEmployeeButton);
            this.Controls.Add(this.custToInstButton);
            this.Controls.Add(this.changeCustAuthButton);
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
        private System.Windows.Forms.Button changeCustAuthButton;
        private System.Windows.Forms.Button custToInstButton;
        private System.Windows.Forms.Button payEmployeeButton;
        private System.Windows.Forms.Button exitProgram;
    }
}

