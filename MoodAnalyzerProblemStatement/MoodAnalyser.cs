using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblemStatement
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }
        public string Analyser(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
