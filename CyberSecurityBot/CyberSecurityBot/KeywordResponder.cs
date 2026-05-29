using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot
{

    public class KeywordResponder
    {
        private Random random = new Random();

        private Dictionary<string, List<string>> responses = new()
    {
        {
            "password",
            new List<string>
            {
                "Use strong passwords with symbols.",
                "Never reuse passwords.",
                "Use a password manager."
            }
        },
        {
            "phishing",
            new List<string>
            {
                "Don’t click suspicious links.",
                "Check email senders carefully.",
                "Scammers imitate real companies."
            }
        },
        {
            "privacy",
            new List<string>
            {
                "Review your privacy settings often.",
                "Don’t overshare personal info.",
                "Enable 2FA for better security."
            }
        }
    };

        public string GetResponse(string input)
        {
            foreach (var key in responses.Keys)
            {
                if (input.Contains(key))
                {
                    var list = responses[key];
                    return list[random.Next(list.Count)];
                }
            }

            return "I’m not sure I understand. Can you rephrase?";
        }
    }
}
