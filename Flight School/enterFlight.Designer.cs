namespace Flight_School
{
    partial class enterFlight
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
            this.backToMainButton = new System.Windows.Forms.Button();
            this.submitFlightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hobbsHrsTextBox = new System.Windows.Forms.TextBox();
            this.pilotListBox = new System.Windows.Forms.ListBox();
            this.instructorListBox = new System.Windows.Forms.ListBox();
            this.planeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backToMainButton
            // 
            this.backToMainButton.Location = new System.Drawing.Point(143, 300);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(83, 23);
            this.backToMainButton.TabIndex = 0;
            this.backToMainButton.Text = "Back to Main";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // submitFlightButton
            // 
            this.submitFlightButton.Location = new System.Drawing.Point(313, 300);
            this.submitFlightButton.Name = "submitFlightButton";
            this.submitFlightButton.Size = new System.Drawing.Size(75, 23);
            this.submitFlightButton.TabIndex = 2;
            this.submitFlightButton.Text = "Submit Flight";
            this.submitFlightButton.UseVisualStyleBackColor = true;
            this.submitFlightButton.Click += new System.EventHandler(this.submitFlightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pilot First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instructor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plane Flown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hobbs Hours Flown";
            // 
            // hobbsHrsTextBox
            // 
            this.hobbsHrsTextBox.Location = new System.Drawing.Point(368, 143);
            this.hobbsHrsTextBox.Name = "hobbsHrsTextBox";
            this.hobbsHrsTextBox.Size = new System.Drawing.Size(120, 20);
            this.hobbsHrsTextBox.TabIndex = 10;
            // 
            // pilotListBox
            // 
            this.pilotListBox.FormattingEnabled = true;
            this.pilotListBox.Location = new System.Drawing.Point(117, 22);
            this.pilotListBox.Name = "pilotListBox";
            this.pilotListBox.Size = new System.Drawing.Size(120, 95);
            this.pilotListBox.TabIndex = 11;
            // 
            // instructorListBox
            // 
            this.instructorListBox.FormattingEnabled = true;
            this.instructorListBox.Location = new System.Drawing.Point(117, 146);
            this.instructorListBox.Name = "instructorListBox";
            this.instructorListBox.Size = new System.Drawing.Size(120, 95);
            this.instructorListBox.TabIndex = 12;
            // 
            // planeListBox
            // 
            this.planeListBox.FormattingEnabled = true;
            this.planeListBox.Location = new System.Drawing.Point(368, 22);
            this.planeListBox.Name = "planeListBox";
            this.planeListBox.Size = new System.Drawing.Size(120, 95);
            this.planeListBox.TabIndex = 13;
            // 
            // enterFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 335);
            this.Controls.Add(this.planeListBox);
            this.Controls.Add(this.instructorListBox);
            this.Controls.Add(this.pilotListBox);
            this.Controls.Add(this.hobbsHrsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitFlightButton);
            this.Controls.Add(this.backToMainButton);
            this.Name = "enterFlight";
            this.Text = "Enter Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.Button submitFlightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hobbsHrsTextBox;
        private System.Windows.Forms.ListBox pilotListBox;
        private System.Windows.Forms.ListBox instructorListBox;
        private System.Windows.Forms.ListBox planeListBox;
    }
}