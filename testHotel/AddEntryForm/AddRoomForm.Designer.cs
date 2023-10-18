namespace testHotel.AddEntryForm
{
    partial class AddRoomForm
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
            this.RoomNumBox = new System.Windows.Forms.TextBox();
            this.PriceDayBox = new System.Windows.Forms.TextBox();
            this.EmpComboBox = new System.Windows.Forms.ComboBox();
            this.CategComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomNumBox
            // 
            this.RoomNumBox.Location = new System.Drawing.Point(315, 34);
            this.RoomNumBox.Name = "RoomNumBox";
            this.RoomNumBox.Size = new System.Drawing.Size(100, 22);
            this.RoomNumBox.TabIndex = 0;
            // 
            // PriceDayBox
            // 
            this.PriceDayBox.Location = new System.Drawing.Point(315, 264);
            this.PriceDayBox.Name = "PriceDayBox";
            this.PriceDayBox.Size = new System.Drawing.Size(100, 22);
            this.PriceDayBox.TabIndex = 4;
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpComboBox.FormattingEnabled = true;
            this.EmpComboBox.Location = new System.Drawing.Point(315, 85);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(121, 24);
            this.EmpComboBox.TabIndex = 5;
            // 
            // CategComboBox
            // 
            this.CategComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategComboBox.FormattingEnabled = true;
            this.CategComboBox.Location = new System.Drawing.Point(315, 162);
            this.CategComboBox.Name = "CategComboBox";
            this.CategComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CategComboBox);
            this.Controls.Add(this.EmpComboBox);
            this.Controls.Add(this.PriceDayBox);
            this.Controls.Add(this.RoomNumBox);
            this.Name = "AddRoomForm";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomNumBox;
        private System.Windows.Forms.TextBox PriceDayBox;
        private System.Windows.Forms.ComboBox EmpComboBox;
        private System.Windows.Forms.ComboBox CategComboBox;
        private System.Windows.Forms.Button button1;
    }
}