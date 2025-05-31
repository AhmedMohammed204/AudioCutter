using NAudio.Wave;
using AudioCutter.Classes;
using System.IO;

public static class clsAudioCutter
{
    public static bool CutMp3(string inputPath, string outputPath, TimeSpan startTime, TimeSpan endTime)
    {
        try
        {
            using var reader = new Mp3FileReader(inputPath);
            using var writer = File.Create(outputPath);

            Mp3Frame frame;
            while ((frame = reader.ReadNextFrame()) != null)
            {
                if (reader.CurrentTime >= endTime)
                    break;

                if (reader.CurrentTime >= startTime)
                    writer.Write(frame.RawData, 0, frame.RawData.Length);
            }

            return true;
        }
        catch (Exception ex)
        {
            clsMessage.ErrorMessage($"Error cutting MP3: {ex.Message}");
            return false;
        }
    }
}
