using System;
using System.Windows.Forms;

namespace AudioCutter.Classes
{
    internal static class clsFileDialog
    {
        public static string Open()
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Select an audio file",
                Filter = "Audio Files|*.mp3;*.m4a;*.wav;*.flac;*.aac;*.ogg;*.wma|All Files|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false
            };

            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }
        public static string Save(enAudioFileType defaultExtension = enAudioFileType.mp3)
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Save trimmed audio file",
                Filter = "WAV File|*.wav|MP3 File|*.mp3|All Files|*.*",
                DefaultExt = defaultExtension.ToString(),
                AddExtension = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                OverwritePrompt = true,
                FileName = $"TrimmedAudio_{DateTime.Now:yyyyMMdd_HHmmss}.{defaultExtension}"
            };

            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }
    }
}
