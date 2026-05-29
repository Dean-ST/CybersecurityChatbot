using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot
{
    public class ChatBot
    {
        private KeywordResponder keywordResponder = new KeywordResponder();
        private SentimentDetector sentimentDetector = new SentimentDetector();
        private MemoryStore memory = new MemoryStore();

        public string GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Type something so I can help you.";

            input = input.ToLower();

            // 🔥 STEP 1: NAME DETECTION
            if (input.StartsWith("my name is"))
            {
                string name = input.Replace("my name is", "").Trim();
                memory.UserName = name;

                return $"Got it. I'll remember you as {name}.";
            }

            // 🔥 STEP 2: PERSONAL GREETING
            if (input.Contains("hello") || input.Contains("hi"))
            {
                if (memory.HasName)
                    return $"Yo {memory.UserName}, what’s up? Let’s secure your digital life.";
                else
                    return "Hey! What’s your name?";
            }

            // 🔥 STEP 3: SENTIMENT
            string sentiment = sentimentDetector.Detect(input);

            if (sentiment == "worried")
            {
                return "I understand you're concerned. Stay sharp online. " +
                       keywordResponder.GetResponse(input);
            }

            // 🔥 STEP 4: NORMAL RESPONSE
            return keywordResponder.GetResponse(input);
        }
    }
}

