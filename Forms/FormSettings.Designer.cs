
namespace Final_Task___Winform.Forms
{
    partial class FormSettings
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txt_GameName = new TextBox();
            txt_Price = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Add = new Button();
            Delete = new Button();
            Update = new Button();
            comboBoxCategory = new ComboBox();
            comboBoxSubtitle = new ComboBox();
            dataGridViewSettings = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSettings).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 15;
            label1.Text = "Game Name";
            // 
            // txt_GameName
            // 
            txt_GameName.BackColor = Color.FromArgb(31, 31, 31);
            txt_GameName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_GameName.ForeColor = Color.White;
            txt_GameName.Location = new Point(12, 79);
            txt_GameName.Name = "txt_GameName";
            txt_GameName.Size = new Size(230, 27);
            txt_GameName.TabIndex = 16;
            txt_GameName.TextChanged += txt_GameName_TextChanged;
            // 
            // txt_Price
            // 
            txt_Price.BackColor = Color.FromArgb(31, 31, 31);
            txt_Price.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Price.ForeColor = Color.White;
            txt_Price.Location = new Point(12, 173);
            txt_Price.Name = "txt_Price";
            txt_Price.Size = new Size(230, 27);
            txt_Price.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(67, 31);
            label2.TabIndex = 17;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 19;
            label3.Text = "Category ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(12, 333);
            label4.Name = "label4";
            label4.Size = new Size(99, 31);
            label4.TabIndex = 21;
            label4.Text = "Subtitle";
            // 
            // Add
            // 
            Add.BackColor = SystemColors.MenuHighlight;
            Add.FlatAppearance.BorderColor = Color.Black;
            Add.FlatAppearance.BorderSize = 0;
            Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = Color.Transparent;
            Add.Location = new Point(291, 373);
            Add.Name = "Add";
            Add.Size = new Size(162, 49);
            Add.TabIndex = 23;
            Add.Text = "ADD";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.FlatAppearance.BorderColor = Color.Black;
            Delete.FlatAppearance.BorderSize = 0;
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.ForeColor = Color.Transparent;
            Delete.Location = new Point(505, 373);
            Delete.Name = "Delete";
            Delete.Size = new Size(153, 49);
            Delete.TabIndex = 24;
            Delete.Text = "DELETE";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.Green;
            Update.FlatAppearance.BorderColor = Color.Black;
            Update.FlatAppearance.BorderSize = 0;
            Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = Color.Transparent;
            Update.Location = new Point(709, 373);
            Update.Name = "Update";
            Update.Size = new Size(153, 49);
            Update.TabIndex = 25;
            Update.Text = "UPDATE";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.FromArgb(31, 31, 31);
            comboBoxCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCategory.ForeColor = Color.White;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.ItemHeight = 20;
            comboBoxCategory.Location = new Point(12, 279);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(230, 28);
            comboBoxCategory.TabIndex = 27;
            // 
            // comboBoxSubtitle
            // 
            comboBoxSubtitle.BackColor = Color.FromArgb(31, 31, 31);
            comboBoxSubtitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSubtitle.ForeColor = Color.White;
            comboBoxSubtitle.FormattingEnabled = true;
            comboBoxSubtitle.ItemHeight = 20;
            comboBoxSubtitle.Location = new Point(12, 394);
            comboBoxSubtitle.Name = "comboBoxSubtitle";
            comboBoxSubtitle.Size = new Size(230, 28);
            comboBoxSubtitle.TabIndex = 28;
            // 
            // dataGridViewSettings
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewSettings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSettings.BackgroundColor = Color.FromArgb(28, 28, 28);
            dataGridViewSettings.ColumnHeadersHeight = 29;
            dataGridViewSettings.Location = new Point(291, 35);
            dataGridViewSettings.Name = "dataGridViewSettings";
            dataGridViewSettings.RowHeadersWidth = 51;
            dataGridViewSettings.Size = new Size(571, 312);
            dataGridViewSettings.TabIndex = 0;
            dataGridViewSettings.CellContentClick += dataGridViewSettings_CellContentClick;
            dataGridViewSettings.CellMouseClick += dataGridViewSettings_CellMouseClick;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            ClientSize = new Size(882, 503);
            Controls.Add(dataGridViewSettings);
            Controls.Add(comboBoxSubtitle);
            Controls.Add(comboBoxCategory);
            Controls.Add(Update);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Price);
            Controls.Add(label2);
            Controls.Add(txt_GameName);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "FormSettings";
            Text = "Settings";
            Load += FormSettings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSettings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        //private DataGridView dataGridViewSettings;
        private Label label1;
        private TextBox txt_GameName;
        private TextBox txt_Price;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Add;
        private Button Delete;
        private Button Update;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxSubtitle;
        private DataGridView dataGridViewSettings;
    }
}