namespace AudioCutter
{
    partial class ctrlTimeSpan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudSeconds = new NumericUpDown();
            nudMinutes = new NumericUpDown();
            nudHours = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            SuspendLayout();
            // 
            // nudSeconds
            // 
            nudSeconds.Location = new Point(100, 47);
            nudSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudSeconds.Name = "nudSeconds";
            nudSeconds.Size = new Size(41, 21);
            nudSeconds.TabIndex = 0;
            // 
            // nudMinutes
            // 
            nudMinutes.Location = new Point(53, 47);
            nudMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(41, 21);
            nudMinutes.TabIndex = 1;
            // 
            // nudHours
            // 
            nudHours.Location = new Point(6, 47);
            nudHours.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(41, 21);
            nudHours.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 3;
            label1.Text = "hh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 18);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 4;
            label2.Text = "mm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 18);
            label3.Name = "label3";
            label3.Size = new Size(21, 19);
            label3.TabIndex = 5;
            label3.Text = "ss";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 18);
            label4.Name = "label4";
            label4.Size = new Size(12, 19);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 18);
            label5.Name = "label5";
            label5.Size = new Size(12, 19);
            label5.TabIndex = 7;
            label5.Text = ":";
            // 
            // ctrlTimeSpan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudHours);
            Controls.Add(nudMinutes);
            Controls.Add(nudSeconds);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ctrlTimeSpan";
            Size = new Size(154, 92);
            ((System.ComponentModel.ISupportInitialize)nudSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudSeconds;
        private NumericUpDown nudMinutes;
        private NumericUpDown nudHours;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
