namespace BongcheonMonthlyRent
{
    partial class MonthlyRent_Form
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
            dataGridView1 = new DataGridView();
            GetBankStatementButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(375, 215);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // GetBankStatementButton
            // 
            GetBankStatementButton.Location = new Point(528, 148);
            GetBankStatementButton.Name = "GetBankStatementButton";
            GetBankStatementButton.Size = new Size(167, 79);
            GetBankStatementButton.TabIndex = 1;
            GetBankStatementButton.Text = "거래내역서 불러오기";
            GetBankStatementButton.UseVisualStyleBackColor = true;
            GetBankStatementButton.Click += GetBankStatementButton_Click;
            // 
            // MonthlyRent_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GetBankStatementButton);
            Controls.Add(dataGridView1);
            Name = "MonthlyRent_Form";
            Text = "MonthlyRent_Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button GetBankStatementButton;
    }
}