﻿namespace testHotel.ChangeForm
{
    partial class ChangeEmployForm
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
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneNumBox = new System.Windows.Forms.TextBox();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(70, 275);
            this.PositionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(260, 31);
            this.PositionComboBox.TabIndex = 17;
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.PhoneNumBox.Location = new System.Drawing.Point(70, 225);
            this.PhoneNumBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(260, 30);
            this.PhoneNumBox.TabIndex = 16;
            // 
            // SurNameBox
            // 
            this.SurNameBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.SurNameBox.Location = new System.Drawing.Point(70, 175);
            this.SurNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(260, 30);
            this.SurNameBox.TabIndex = 15;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.NameBox.Location = new System.Drawing.Point(70, 125);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(260, 30);
            this.NameBox.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(100, 440);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Изменить запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ChangeEmployForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.SurNameBox);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeEmployForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.TextBox PhoneNumBox;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button btnAdd;
    }
}