using AudioCutter.Classes;

namespace AudioCutter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddAudioFile_Click(object sender, EventArgs e)
        {

            string FilePath = clsFileDialog.Open();
            if (string.IsNullOrWhiteSpace(FilePath))
                return;
            
            lblFilePath.Text = FilePath;
            lblFilePath.Visible = true;
        }
        private bool _IsValidTimeSpan()
        {
            if (tsFrom.TimeSpan < TimeSpan.Zero)
            {
                clsMessage.ErrorMessage("Please select a valid start time.");
                return false;
            }
            if (tsTo.TimeSpan == TimeSpan.Zero)
            {
                clsMessage.ErrorMessage("Please select a valid end time.");
                return false;
            }
            if (tsFrom.TimeSpan >= tsTo.TimeSpan)
            {
                clsMessage.ErrorMessage("Start time must be less than end time.");
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblFilePath.Text))
            {
                clsMessage.ErrorMessage("Please select an audio file to trim.");
                return;
            }
            if (!_IsValidTimeSpan())
                return;

            string SavePath = clsFileDialog.Save();
            if (string.IsNullOrWhiteSpace(SavePath))
            {
                clsMessage.ErrorMessage("Please select a valid save path.");
                return;
            }
            this.Enabled = false;
            if (clsAudioCutter.CutMp3(lblFilePath.Text, SavePath, tsFrom.TimeSpan, tsTo.TimeSpan))
            {
                ni.Icon = SystemIcons.Information;
                ni.BalloonTipIcon = ToolTipIcon.Info;
                ni.BalloonTipText = "Audio file trimmed successfully.";
                ni.BalloonTipTitle = "Success";
                ni.ShowBalloonTip(1000);
            }
            this.Enabled = true;
        }
    }
}
