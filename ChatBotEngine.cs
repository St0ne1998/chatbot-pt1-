using System;

namespace CybersecurityBot
{
    public class ChatBotEngine
    {
        private string userName = "User";

        public void StartConversation()
        {
            BotUI.PrintDivider();
            BotUI.TypeWriterEffect("WEchatBot: Hello! Welcome to the WEchat Cybersecurity Awareness Bot.", ConsoleColor.Green);
            BotUI.TypeWriterEffect("WEchatBot: What is your name?", ConsoleColor.Green);

            Console.Write("\nYour Name: ");
            string inputName = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(inputName))
            {
                userName = inputName.Trim();
            }

            BotUI.TypeWriterEffect($"\nWEchatBot: Great to meet you, {userName}! I'm here to help you stay safe online.", ConsoleColor.Green);
            BotUI.TypeWriterEffect("WEchatBot: You can ask me about password safety, phishing, safe browsing, or type 'exit' to quit.", ConsoleColor.Green);
            BotUI.PrintDivider();

            RunChatLoop();
        }

        private void RunChatLoop()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write($"\n{userName}: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    BotUI.TypeWriterEffect("WEchatBot: I didn't quite understand that. Could you rephrase?", ConsoleColor.Yellow);
                    continue;
                }

                string query = userInput.ToLower().Trim();

                if (query == "exit" || query == "quit")
                {
                    BotUI.TypeWriterEffect($"WEchatBot: Stay safe online, {userName}! Goodbye.", ConsoleColor.Cyan);
                    keepRunning = false;
                }
                else
                {
                    ProcessUserQuery(query);
                }
            }
        }

        private void ProcessUserQuery(string query)
        {
            string response;

            if (query.Contains("how are you"))
            {
                response = $"I'm chirping along smoothly and ready to protect, {userName}!";
            }
            else if (query.Contains("purpose") || query.Contains("who are you"))
            {
                response = "My primary purpose is to educate users on essential cybersecurity habits and digital safety practices via WEchat.";
            }
            else if (query.Contains("what can i ask") || query.Contains("help"))
            {
                response = "You can ask me about: \n - Password safety & strength\n - Phishing emails and scams\n - Safe browsing habits";
            }
            else if (query.Contains("password") || query.Contains("passwords"))
            {
                response = "Password Safety Tip: Use long, complex passwords containing a mix of letters, numbers, and symbols. Never reuse passwords across multiple sites!";
            }
            else if (query.Contains("phishing") || query.Contains("scam"))
            {
                response = "Phishing Alert: Be wary of unexpected messages asking for personal details, urgent wire transfers, or containing suspicious links.";
            }
            else if (query.Contains("browsing") || query.Contains("safe browsing") || query.Contains("url"))
            {
                response = "Safe Browsing Tip: Always verify that website URLs begin with 'https://' and look out for spelling errors in domain names.";
            }
            else
            {
                response = "I didn't quite understand that. Could you rephrase?";
            }

            BotUI.TypeWriterEffect($"WEchatBot: {response}", ConsoleColor.Green);
        }
    }
}
