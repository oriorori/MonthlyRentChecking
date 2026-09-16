namespace BongcheonMonthlyRent
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MonthlyRentButton = new Button();
            SuspendLayout();
            // 
            // MonthlyRentButton
            // 
            MonthlyRentButton.Location = new Point(198, 95);
            MonthlyRentButton.Name = "MonthlyRentButton";
            MonthlyRentButton.Size = new Size(143, 68);
            MonthlyRentButton.TabIndex = 0;
            MonthlyRentButton.Text = "월세납부현황보기";
            MonthlyRentButton.UseVisualStyleBackColor = true;
            MonthlyRentButton.Click += this.MonthlyRentButton_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MonthlyRentButton);
            Name = "Main_Form";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button MonthlyRentButton;
    }
}
