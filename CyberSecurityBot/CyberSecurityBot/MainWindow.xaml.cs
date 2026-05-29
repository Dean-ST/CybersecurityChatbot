using CyberSecurityBot;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace CybersecurityChatbot
{
    public partial class MainWindow : Window
    {
        private ChatBot bot = new ChatBot();

        public MainWindow()
        {

            InitializeComponent();

            AudioPlayer.PlayGreeting();

            ChatList.Items.Add("Bot: Welcome to the Cybersecurity Awareness Bot.");
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = UserInputTextBox.Text;

            string response = bot.GetResponse(userInput);

            ChatList.Items.Add("You: " + userInput);
            ChatList.Items.Add("Bot: " + response);
            ChatList.Items.Add("");

            UserInputTextBox.Clear();
        }

       
private async Task TypeBotMessage(string message)
        {
            string current = "";

            foreach (char c in message)
            {
                current += c;

                if (ChatList.Items.Count > 0 &&
                    ChatList.Items[ChatList.Items.Count - 1].ToString().StartsWith("Bot:"))
                {
                    ChatList.Items.RemoveAt(ChatList.Items.Count - 1);
                }

                ChatList.Items.Add("Bot: " + current);

                await Task.Delay(20);
            }
        }

    }
}