namespace AudioCutter
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            openFileDialog1 = new OpenFileDialog();
            btnAddAudioFile = new Button();
            lblFilePath = new Label();
            tsFrom = new ctrlTimeSpan();
            gbFrom = new GroupBox();
            gbTo = new GroupBox();
            tsTo = new ctrlTimeSpan();
            btnSave = new Button();
            lblTitle = new Label();
            label1 = new Label();
            ni = new NotifyIcon(components);
            gbFrom.SuspendLayout();
            gbTo.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddAudioFile
            // 
            btnAddAudioFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddAudioFile.BackColor = SystemColors.Highlight;
            btnAddAudioFile.FlatStyle = FlatStyle.Flat;
            btnAddAudioFile.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAudioFile.Location = new Point(12, 347);
            btnAddAudioFile.Name = "btnAddAudioFile";
            btnAddAudioFile.Size = new Size(261, 85);
            btnAddAudioFile.TabIndex = 0;
            btnAddAudioFile.Text = "Click to Add an Audio File";
            btnAddAudioFile.UseVisualStyleBackColor = false;
            btnAddAudioFile.Click += btnAddAudioFile_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilePath.Location = new Point(112, 314);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(0, 17);
            lblFilePath.TabIndex = 1;
            lblFilePath.Visible = false;
            // 
            // tsFrom
            // 
            tsFrom.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsFrom.Location = new Point(26, 22);
            tsFrom.Name = "tsFrom";
            tsFrom.Size = new Size(154, 92);
            tsFrom.TabIndex = 2;
            tsFrom.TimeSpan = TimeSpan.Parse("00:00:00");
            // 
            // gbFrom
            // 
            gbFrom.Controls.Add(tsFrom);
            gbFrom.Location = new Point(12, 141);
            gbFrom.Name = "gbFrom";
            gbFrom.Size = new Size(200, 141);
            gbFrom.TabIndex = 3;
            gbFrom.TabStop = false;
            gbFrom.Text = "From (Time)";
            // 
            // gbTo
            // 
            gbTo.Controls.Add(tsTo);
            gbTo.Location = new Point(433, 141);
            gbTo.Name = "gbTo";
            gbTo.Size = new Size(200, 141);
            gbTo.TabIndex = 4;
            gbTo.TabStop = false;
            gbTo.Text = "To (Time)";
            // 
            // tsTo
            // 
            tsTo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsTo.Location = new Point(26, 22);
            tsTo.Name = "tsTo";
            tsTo.Size = new Size(154, 92);
            tsTo.TabIndex = 2;
            tsTo.TimeSpan = TimeSpan.Parse("00:00:00");
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(372, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(261, 85);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(645, 60);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Audio Cutter Application";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 310);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 7;
            label1.Text = "File Path: ";
            // 
            // ni
            // 
            ni.Text = "ni";
            ni.Visible = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(645, 444);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(gbTo);
            Controls.Add(gbFrom);
            Controls.Add(lblFilePath);
            Controls.Add(btnAddAudioFile);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Audio Cutter";
            gbFrom.ResumeLayout(false);
            gbTo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnAddAudioFile;
        private Label lblFilePath;
        private ctrlTimeSpan tsFrom;
        private GroupBox gbFrom;
        private GroupBox gbTo;
        private ctrlTimeSpan tsTo;
        private Button btnSave;
        private Label lblTitle;
        private Label label1;
        private NotifyIcon ni;
    }
}
