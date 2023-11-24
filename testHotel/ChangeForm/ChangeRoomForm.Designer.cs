namespace testHotel.AddEntryForm
{
    partial class ChangeRoomForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoomNumBox
            // 
            this.RoomNumBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.RoomNumBox.Location = new System.Drawing.Point(70, 125);
            this.RoomNumBox.Name = "RoomNumBox";
            this.RoomNumBox.Size = new System.Drawing.Size(260, 30);
            this.RoomNumBox.TabIndex = 1;
            // 
            // PriceDayBox
            // 
            this.PriceDayBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.PriceDayBox.Location = new System.Drawing.Point(70, 275);
            this.PriceDayBox.Name = "PriceDayBox";
            this.PriceDayBox.Size = new System.Drawing.Size(260, 30);
            this.PriceDayBox.TabIndex = 4;
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.EmpComboBox.FormattingEnabled = true;
            this.EmpComboBox.Location = new System.Drawing.Point(70, 175);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(260, 31);
            this.EmpComboBox.TabIndex = 2;
            // 
            // CategComboBox
            // 
            this.CategComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategComboBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.CategComboBox.FormattingEnabled = true;
            this.CategComboBox.Location = new System.Drawing.Point(70, 225);
            this.CategComboBox.Name = "CategComboBox";
            this.CategComboBox.Size = new System.Drawing.Size(260, 31);
            this.CategComboBox.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.Location = new System.Drawing.Point(100, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F);
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Изменение комнат";
            // 
            // ChangeRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.CategComboBox);
            this.Controls.Add(this.EmpComboBox);
            this.Controls.Add(this.PriceDayBox);
            this.Controls.Add(this.RoomNumBox);
            this.Name = "ChangeRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomNumBox;
        private System.Windows.Forms.TextBox PriceDayBox;
        private System.Windows.Forms.ComboBox EmpComboBox;
        private System.Windows.Forms.ComboBox CategComboBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}