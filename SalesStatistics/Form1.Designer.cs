namespace SalesStatistics
{
    partial class Form1
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
            this.writeDataButton = new System.Windows.Forms.Button();
            this.statisticsCalculationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeDataButton
            // 
            this.writeDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.writeDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeDataButton.Location = new System.Drawing.Point(247, 200);
            this.writeDataButton.Name = "writeDataButton";
            this.writeDataButton.Size = new System.Drawing.Size(113, 44);
            this.writeDataButton.TabIndex = 0;
            this.writeDataButton.Text = "Записать данные";
            this.writeDataButton.UseVisualStyleBackColor = true;
            this.writeDataButton.Click += new System.EventHandler(this.writeDataButton_Click);
            // 
            // statisticsCalculationButton
            // 
            this.statisticsCalculationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statisticsCalculationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsCalculationButton.Location = new System.Drawing.Point(454, 200);
            this.statisticsCalculationButton.Name = "statisticsCalculationButton";
            this.statisticsCalculationButton.Size = new System.Drawing.Size(113, 44);
            this.statisticsCalculationButton.TabIndex = 1;
            this.statisticsCalculationButton.Text = "Посчитать статистику";
            this.statisticsCalculationButton.UseVisualStyleBackColor = true;
            this.statisticsCalculationButton.Click += new System.EventHandler(this.statisticsCalculationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statisticsCalculationButton);
            this.Controls.Add(this.writeDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeDataButton;
        private System.Windows.Forms.Button statisticsCalculationButton;
    }
}

