﻿namespace SalesStatistics
{
    partial class Form3
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
            this.labelStatisticsForDay = new System.Windows.Forms.Label();
            this.startMenuButton = new System.Windows.Forms.Button();
            this.labelForMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatisticsForDay
            // 
            this.labelStatisticsForDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStatisticsForDay.AutoSize = true;
            this.labelStatisticsForDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatisticsForDay.Location = new System.Drawing.Point(3, 9);
            this.labelStatisticsForDay.Name = "labelStatisticsForDay";
            this.labelStatisticsForDay.Size = new System.Drawing.Size(45, 16);
            this.labelStatisticsForDay.TabIndex = 0;
            this.labelStatisticsForDay.Text = "label1";
            // 
            // startMenuButton
            // 
            this.startMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMenuButton.Location = new System.Drawing.Point(651, 12);
            this.startMenuButton.Name = "startMenuButton";
            this.startMenuButton.Size = new System.Drawing.Size(137, 35);
            this.startMenuButton.TabIndex = 1;
            this.startMenuButton.Text = "Главное меню";
            this.startMenuButton.UseVisualStyleBackColor = true;
            this.startMenuButton.Click += new System.EventHandler(this.startMenuButton_Click);
            // 
            // labelForMonth
            // 
            this.labelForMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForMonth.AutoSize = true;
            this.labelForMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForMonth.Location = new System.Drawing.Point(3, 34);
            this.labelForMonth.Name = "labelForMonth";
            this.labelForMonth.Size = new System.Drawing.Size(45, 16);
            this.labelForMonth.TabIndex = 2;
            this.labelForMonth.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelForMonth);
            this.Controls.Add(this.startMenuButton);
            this.Controls.Add(this.labelStatisticsForDay);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatisticsForDay;
        private System.Windows.Forms.Button startMenuButton;
        private System.Windows.Forms.Label labelForMonth;
    }
}