using AudioCutter.Classes;
using NAudio.Wave;

public static class clsAudioCutter
{
    public static bool CutMp3(string inputPath, string outputPath, TimeSpan start, TimeSpan end)
    {
        try
        {
            using var reader = new AudioFileReader(inputPath);
            using var writer = new WaveFileWriter(outputPath, reader.WaveFormat);

            reader.CurrentTime = start;

            var buffer = new float[reader.WaveFormat.SampleRate * reader.WaveFormat.Channels];
            while (reader.CurrentTime < end)
            {
                int samplesRead = reader.Read(buffer, 0, buffer.Length);
                if (samplesRead == 0)
                    break;

                writer.WriteSamples(buffer, 0, samplesRead);
            }

            return true;
        }
        catch (Exception ex)
        {
            clsMessage.ErrorMessage($"Error cutting audio: {ex.Message}");
            return false;
        }
    }
}
