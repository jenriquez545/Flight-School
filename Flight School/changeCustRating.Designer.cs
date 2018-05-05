namespace Flight_School
{
    partial class changeCustRating
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
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.authTextBox = new System.Windows.Forms.TextBox();
            this.backToMainButton = new System.Windows.Forms.Button();
            this.submitChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter new rating";
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(121, 20);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(120, 95);
            this.customerListBox.TabIndex = 2;
            // 
            // authTextBox
            // 
            this.authTextBox.Location = new System.Drawing.Point(121, 134);
            this.authTextBox.Name = "authTextBox";
            this.authTextBox.Size = new System.Drawing.Size(120, 20);
            this.authTextBox.TabIndex = 3;
            // 
            // backToMainButton
            // 
            this.backToMainButton.Location = new System.Drawing.Point(23, 192);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(87, 23);
            this.backToMainButton.TabIndex = 4;
            this.backToMainButton.Text = "Back to Main";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // submitChangeButton
            // 
            this.submitChangeButton.Location = new System.Drawing.Point(130, 192);
            this.submitChangeButton.Name = "submitChangeButton";
            this.submitChangeButton.Size = new System.Drawing.Size(99, 23);
            this.submitChangeButton.TabIndex = 5;
            this.submitChangeButton.Text = "Submit Change";
            this.submitChangeButton.UseVisualStyleBackColor = true;
            this.submitChangeButton.Click += new System.EventHandler(this.submitChangeButton_Click);
            // 
            // changeCustRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 227);
            this.Controls.Add(this.submitChangeButton);
            this.Controls.Add(this.backToMainButton);
            this.Controls.Add(this.authTextBox);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "changeCustRating";
            this.Text = "Change Customer Rating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.TextBox authTextBox;
        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.Button submitChangeButton;
    }
}