namespace testHotel.ChangeForm
{
    partial class ChangeClientForm
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
            this.CheckOutText = new System.Windows.Forms.TextBox();
            this.CheckInText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SurNameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.RoomNumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckOutText
            // 
            this.CheckOutText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.CheckOutText.Location = new System.Drawing.Point(70, 375);
            this.CheckOutText.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutText.Name = "CheckOutText";
            this.CheckOutText.Size = new System.Drawing.Size(265, 30);
            this.CheckOutText.TabIndex = 14;
            // 
            // CheckInText
            // 
            this.CheckInText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.CheckInText.Location = new System.Drawing.Point(70, 325);
            this.CheckInText.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInText.Name = "CheckInText";
            this.CheckInText.Size = new System.Drawing.Size(265, 30);
            this.CheckInText.TabIndex = 13;
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.PhoneText.Location = new System.Drawing.Point(70, 275);
            this.PhoneText.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(265, 30);
            this.PhoneText.TabIndex = 12;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.btnChange.Location = new System.Drawing.Point(100, 440);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(200, 50);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Изменить запись";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // SurNameText
            // 
            this.SurNameText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.SurNameText.Location = new System.Drawing.Point(70, 225);
            this.SurNameText.Margin = new System.Windows.Forms.Padding(4);
            this.SurNameText.Name = "SurNameText";
            this.SurNameText.Size = new System.Drawing.Size(265, 30);
            this.SurNameText.TabIndex = 10;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.NameText.Location = new System.Drawing.Point(70, 175);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(265, 30);
            this.NameText.TabIndex = 9;
            // 
            // RoomNumTextBox
            // 
            this.RoomNumTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.RoomNumTextBox.Location = new System.Drawing.Point(70, 125);
            this.RoomNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoomNumTextBox.Name = "RoomNumTextBox";
            this.RoomNumTextBox.Size = new System.Drawing.Size(265, 30);
            this.RoomNumTextBox.TabIndex = 8;
            // 
            // ChangeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.CheckOutText);
            this.Controls.Add(this.CheckInText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.SurNameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.RoomNumTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CheckOutText;
        private System.Windows.Forms.TextBox CheckInText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox SurNameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox RoomNumTextBox;
    }
}