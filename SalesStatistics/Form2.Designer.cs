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
            this.startMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForWritingData
            // 
            this.textBoxForWritingData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxForWritingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxForWritingData.Location = new System.Drawing.Point(223, 168);
            this.textBoxForWritingData.Name = "textBoxForWritingData";
            this.textBoxForWritingData.Size = new System.Drawing.Size(363, 29);
            this.textBoxForWritingData.TabIndex = 0;
            this.textBoxForWritingData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxForWritingData_KeyPress);
            // 
            // enterDataButton
            // 
            this.enterDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterDataButton.Location = new System.Drawing.Point(366, 209);
            this.enterDataButton.Name = "enterDataButton";
            this.enterDataButton.Size = new System.Drawing.Size(75, 23);
            this.enterDataButton.TabIndex = 1;
            this.enterDataButton.Text = "Ввод";
            this.enterDataButton.UseVisualStyleBackColor = true;
            // 
            // startMenuButton
            // 
            this.startMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMenuButton.Location = new System.Drawing.Point(651, 12);
            this.startMenuButton.Name = "startMenuButton";
            this.startMenuButton.Size = new System.Drawing.Size(137, 35);
            this.startMenuButton.TabIndex = 2;
            this.startMenuButton.Text = "Главное меню";
            this.startMenuButton.UseVisualStyleBackColor = true;
            this.startMenuButton.Click += new System.EventHandler(this.startMenuButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startMenuButton);
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
        private System.Windows.Forms.Button startMenuButton;
    }
}