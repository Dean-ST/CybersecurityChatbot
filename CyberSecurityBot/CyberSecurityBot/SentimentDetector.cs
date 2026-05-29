using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot
{
    public class SentimentDetector
    {
        public string Detect(string input)
        {
            if (input.Contains("worried") || input.Contains("scared"))
                return "worried";

            if (input.Contains("frustrated"))
                return "frustrated";

            if (input.Contains("curious"))
                return "curious";

            return "neutral";
        }
    }
}
