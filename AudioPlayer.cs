using System;

namespace CybersecurityBot
{
    public static class AudioPlayer
    {
        public static void PlayVoiceGreeting(string filePath)
        {
            try
            {
                // Safe cross-platform notification replacement for audio greeting
                Console.Beep(800, 300);
            }
            catch (Exception)
            {
                // Fallback silently if hardware beep is unavailable
            }
        }
    }
}
