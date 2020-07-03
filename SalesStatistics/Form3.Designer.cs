namespace SalesStatistics
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
            this.numericUpDownDayNumber = new System.Windows.Forms.NumericUpDown();
            this.labelForDayNumber = new System.Windows.Forms.Label();
            this.buttonForDayNumber = new System.Windows.Forms.Button();
            this.labelDayNumber = new System.Windows.Forms.Label();
            this.domainUpDownDayOfWeek = new System.Windows.Forms.DomainUpDown();
            this.buttonForDayOfWeek = new System.Windows.Forms.Button();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.labelForDayOfWeek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayNumber)).BeginInit();
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
            // numericUpDownDayNumber
            // 
            this.numericUpDownDayNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDayNumber.Location = new System.Drawing.Point(62, 207);
            this.numericUpDownDayNumber.Name = "numericUpDownDayNumber";
            this.numericUpDownDayNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDayNumber.TabIndex = 3;
            this.numericUpDownDayNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelForDayNumber
            // 
            this.labelForDayNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForDayNumber.AutoSize = true;
            this.labelForDayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForDayNumber.Location = new System.Drawing.Point(59, 183);
            this.labelForDayNumber.Name = "labelForDayNumber";
            this.labelForDayNumber.Size = new System.Drawing.Size(0, 16);
            this.labelForDayNumber.TabIndex = 4;
            // 
            // buttonForDayNumber
            // 
            this.buttonForDayNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForDayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForDayNumber.Location = new System.Drawing.Point(62, 266);
            this.buttonForDayNumber.Name = "buttonForDayNumber";
            this.buttonForDayNumber.Size = new System.Drawing.Size(120, 23);
            this.buttonForDayNumber.TabIndex = 5;
            this.buttonForDayNumber.Text = "Посчитать";
            this.buttonForDayNumber.UseVisualStyleBackColor = true;
            this.buttonForDayNumber.Click += new System.EventHandler(this.buttonForDayNumber_Click);
            // 
            // labelDayNumber
            // 
            this.labelDayNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDayNumber.AutoSize = true;
            this.labelDayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayNumber.Location = new System.Drawing.Point(59, 150);
            this.labelDayNumber.Name = "labelDayNumber";
            this.labelDayNumber.Size = new System.Drawing.Size(250, 16);
            this.labelDayNumber.TabIndex = 6;
            this.labelDayNumber.Text = "Посчитать среднее за день в месяце";
            // 
            // domainUpDownDayOfWeek
            // 
            this.domainUpDownDayOfWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.domainUpDownDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainUpDownDayOfWeek.Location = new System.Drawing.Point(464, 209);
            this.domainUpDownDayOfWeek.Name = "domainUpDownDayOfWeek";
            this.domainUpDownDayOfWeek.Size = new System.Drawing.Size(120, 22);
            this.domainUpDownDayOfWeek.TabIndex = 7;
            this.domainUpDownDayOfWeek.Text = "Понедельник";
            // 
            // buttonForDayOfWeek
            // 
            this.buttonForDayOfWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForDayOfWeek.Location = new System.Drawing.Point(464, 266);
            this.buttonForDayOfWeek.Name = "buttonForDayOfWeek";
            this.buttonForDayOfWeek.Size = new System.Drawing.Size(120, 23);
            this.buttonForDayOfWeek.TabIndex = 8;
            this.buttonForDayOfWeek.Text = "Посчитать";
            this.buttonForDayOfWeek.UseVisualStyleBackColor = true;
            this.buttonForDayOfWeek.Click += new System.EventHandler(this.buttonForDayOfWeek_Click);
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayOfWeek.Location = new System.Drawing.Point(461, 153);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(240, 16);
            this.labelDayOfWeek.TabIndex = 9;
            this.labelDayOfWeek.Text = "Посчитать среднее за день недели";
            // 
            // labelForDayOfWeek
            // 
            this.labelForDayOfWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForDayOfWeek.AutoSize = true;
            this.labelForDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForDayOfWeek.Location = new System.Drawing.Point(461, 183);
            this.labelForDayOfWeek.Name = "labelForDayOfWeek";
            this.labelForDayOfWeek.Size = new System.Drawing.Size(0, 16);
            this.labelForDayOfWeek.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelForDayOfWeek);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.buttonForDayOfWeek);
            this.Controls.Add(this.domainUpDownDayOfWeek);
            this.Controls.Add(this.labelDayNumber);
            this.Controls.Add(this.buttonForDayNumber);
            this.Controls.Add(this.labelForDayNumber);
            this.Controls.Add(this.numericUpDownDayNumber);
            this.Controls.Add(this.labelForMonth);
            this.Controls.Add(this.startMenuButton);
            this.Controls.Add(this.labelStatisticsForDay);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDayNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatisticsForDay;
        private System.Windows.Forms.Button startMenuButton;
        private System.Windows.Forms.Label labelForMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDayNumber;
        private System.Windows.Forms.Label labelForDayNumber;
        private System.Windows.Forms.Button buttonForDayNumber;
        private System.Windows.Forms.Label labelDayNumber;
        private System.Windows.Forms.DomainUpDown domainUpDownDayOfWeek;
        private System.Windows.Forms.Button buttonForDayOfWeek;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Label labelForDayOfWeek;
    }
}