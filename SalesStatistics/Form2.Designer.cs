namespace SalesStatistics
{
    partial class Form2
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
            this.textBoxForWritingData = new System.Windows.Forms.TextBox();
            this.enterDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForWritingData
            // 
            this.textBoxForWritingData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxForWritingData.Location = new System.Drawing.Point(305, 183);
            this.textBoxForWritingData.Name = "textBoxForWritingData";
            this.textBoxForWritingData.Size = new System.Drawing.Size(170, 20);
            this.textBoxForWritingData.TabIndex = 0;
            // 
            // enterDataButton
            // 
            this.enterDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterDataButton.Location = new System.Drawing.Point(353, 209);
            this.enterDataButton.Name = "enterDataButton";
            this.enterDataButton.Size = new System.Drawing.Size(75, 23);
            this.enterDataButton.TabIndex = 1;
            this.enterDataButton.Text = "Ввод";
            this.enterDataButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterDataButton);
            this.Controls.Add(this.textBoxForWritingData);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForWritingData;
        private System.Windows.Forms.Button enterDataButton;
    }
}