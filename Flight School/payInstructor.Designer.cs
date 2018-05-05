namespace Flight_School
{
    partial class payInstructor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.instructorListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amtPaidTextBox = new System.Windows.Forms.TextBox();
            this.backToMainButton = new System.Windows.Forms.Button();
            this.submitChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Instructor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount Owed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Paid";
            // 
            // instructorListBox
            // 
            this.instructorListBox.FormattingEnabled = true;
            this.instructorListBox.Location = new System.Drawing.Point(139, 29);
            this.instructorListBox.Name = "instructorListBox";
            this.instructorListBox.Size = new System.Drawing.Size(138, 95);
            this.instructorListBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(136, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "(Would show amount owed)";
            // 
            // amtPaidTextBox
            // 
            this.amtPaidTextBox.Location = new System.Drawing.Point(136, 185);
            this.amtPaidTextBox.Name = "amtPaidTextBox";
            this.amtPaidTextBox.Size = new System.Drawing.Size(141, 20);
            this.amtPaidTextBox.TabIndex = 5;
            // 
            // backToMainButton
            // 
            this.backToMainButton.Location = new System.Drawing.Point(55, 228);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(81, 23);
            this.backToMainButton.TabIndex = 6;
            this.backToMainButton.Text = "Back to Main";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // submitChangeButton
            // 
            this.submitChangeButton.Location = new System.Drawing.Point(176, 228);
            this.submitChangeButton.Name = "submitChangeButton";
            this.submitChangeButton.Size = new System.Drawing.Size(92, 23);
            this.submitChangeButton.TabIndex = 7;
            this.submitChangeButton.Text = "Submit Change";
            this.submitChangeButton.UseVisualStyleBackColor = true;
            this.submitChangeButton.Click += new System.EventHandler(this.submitChangeButton_Click);
            // 
            // payInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 263);
            this.Controls.Add(this.submitChangeButton);
            this.Controls.Add(this.backToMainButton);
            this.Controls.Add(this.amtPaidTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instructorListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "payInstructor";
            this.Text = "Pay Instructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox instructorListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amtPaidTextBox;
        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.Button submitChangeButton;
    }
}