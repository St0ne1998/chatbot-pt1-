using System;
using System.IO;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BotUI.DisplayHeader();

                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
                AudioPlayer.PlayVoiceGreeting(audioPath);

                ChatBotEngine bot = new ChatBotEngine();
                bot.StartConversation();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n[CRITICAL ERROR]: {ex.Message}");
                Console.ResetColor();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}