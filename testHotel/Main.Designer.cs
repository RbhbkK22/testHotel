namespace testHotel
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CountBtn = new System.Windows.Forms.Button();
            this.serchTextBox = new System.Windows.Forms.TextBox();
            this.serchBtn = new System.Windows.Forms.Button();
            this.columComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Клиенты",
            "Комнаты",
            "Категории номеров",
            "Работники",
            "Должности"});
            this.comboBox1.Location = new System.Drawing.Point(16, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(16, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1312, 492);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.Ivory;
            this.btnAddEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddEntry.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddEntry.Location = new System.Drawing.Point(16, 565);
            this.btnAddEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(160, 43);
            this.btnAddEntry.TabIndex = 4;
            this.btnAddEntry.Text = "Добавить запись";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Ivory;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(352, 565);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(16, 635);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(325, 22);
            this.IdTextBox.TabIndex = 6;
            this.IdTextBox.TabStop = false;
            // 
            // CountBtn
            // 
            this.CountBtn.BackColor = System.Drawing.Color.Ivory;
            this.CountBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.CountBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.CountBtn.Location = new System.Drawing.Point(185, 565);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(160, 43);
            this.CountBtn.TabIndex = 8;
            this.CountBtn.Text = "Посчитать";
            this.CountBtn.UseVisualStyleBackColor = false;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // serchTextBox
            // 
            this.serchTextBox.Location = new System.Drawing.Point(1021, 15);
            this.serchTextBox.Name = "serchTextBox";
            this.serchTextBox.Size = new System.Drawing.Size(117, 22);
            this.serchTextBox.TabIndex = 9;
            // 
            // serchBtn
            // 
            this.serchBtn.Location = new System.Drawing.Point(1144, 15);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(75, 23);
            this.serchBtn.TabIndex = 10;
            this.serchBtn.Text = "поиск";
            this.serchBtn.UseVisualStyleBackColor = true;
            this.serchBtn.Click += new System.EventHandler(this.serchBtn_Click);
            // 
            // columComboBox
            // 
            this.columComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columComboBox.FormattingEnabled = true;
            this.columComboBox.Location = new System.Drawing.Point(877, 15);
            this.columComboBox.Name = "columComboBox";
            this.columComboBox.Size = new System.Drawing.Size(138, 24);
            this.columComboBox.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 663);
            this.Controls.Add(this.columComboBox);
            this.Controls.Add(this.serchBtn);
            this.Controls.Add(this.serchTextBox);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hotel management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEntry;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.TextBox serchTextBox;
        private System.Windows.Forms.Button serchBtn;
        private System.Windows.Forms.ComboBox columComboBox;
    }
}

