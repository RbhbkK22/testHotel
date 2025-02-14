﻿namespace testHotel.ChangeForm
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
            this.RoomNumComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckOutText
            // 
            this.CheckOutText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.CheckOutText.Location = new System.Drawing.Point(70, 375);
            this.CheckOutText.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutText.Name = "CheckOutText";
            this.CheckOutText.Size = new System.Drawing.Size(265, 30);
            this.CheckOutText.TabIndex = 6;
            // 
            // CheckInText
            // 
            this.CheckInText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.CheckInText.Location = new System.Drawing.Point(70, 325);
            this.CheckInText.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInText.Name = "CheckInText";
            this.CheckInText.Size = new System.Drawing.Size(265, 30);
            this.CheckInText.TabIndex = 5;
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.PhoneText.Location = new System.Drawing.Point(70, 275);
            this.PhoneText.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(265, 30);
            this.PhoneText.TabIndex = 4;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.btnChange.Location = new System.Drawing.Point(100, 440);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(200, 50);
            this.btnChange.TabIndex = 0;
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
            this.SurNameText.TabIndex = 3;
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.NameText.Location = new System.Drawing.Point(70, 175);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(265, 30);
            this.NameText.TabIndex = 2;
            // 
            // RoomNumComboBox
            // 
            this.RoomNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNumComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.RoomNumComboBox.FormattingEnabled = true;
            this.RoomNumComboBox.Location = new System.Drawing.Point(70, 125);
            this.RoomNumComboBox.Name = "RoomNumComboBox";
            this.RoomNumComboBox.Size = new System.Drawing.Size(265, 31);
            this.RoomNumComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F);
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "Изменение Клиента";
            // 
            // ChangeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomNumComboBox);
            this.Controls.Add(this.CheckOutText);
            this.Controls.Add(this.CheckInText);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.SurNameText);
            this.Controls.Add(this.NameText);
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
        private System.Windows.Forms.ComboBox RoomNumComboBox;
        private System.Windows.Forms.Label label1;
    }
}