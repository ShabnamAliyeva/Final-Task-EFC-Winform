namespace Final_Task___Winform.Forms
{
    partial class FormGames
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
            dataGridViewGames = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGames
            // 
            dataGridViewGames.BackgroundColor = Color.FromArgb(28, 28, 28);
            dataGridViewGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGames.Dock = DockStyle.Fill;
            dataGridViewGames.Location = new Point(0, 0);
            dataGridViewGames.Name = "dataGridViewGames";
            dataGridViewGames.RowHeadersWidth = 51;
            dataGridViewGames.Size = new Size(782, 453);
            dataGridViewGames.TabIndex = 0;
            dataGridViewGames.CellContentClick += dataGridViewGames_CellContentClick;
            // 
            // FormGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            ClientSize = new Size(782, 453);
            Controls.Add(dataGridViewGames);
            Name = "FormGames";
            Text = "Games";
            Load += FormGames_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewGames;
    }
}