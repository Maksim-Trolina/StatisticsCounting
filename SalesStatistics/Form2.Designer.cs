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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
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
            this.enterDataButton.Click += new System.EventHandler(this.enterDataButton_Click);
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
            // calendar
            // 
            this.calendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calendar.Location = new System.Drawing.Point(609, 97);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 3;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(346, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите прибыль:";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(239, 118);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 16);
            this.dateLabel.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar);
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
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
    }
}