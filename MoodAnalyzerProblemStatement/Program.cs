namespace MoodAnalyzerProblemStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string message = moodAnalyser.Analyser();
        }
    }
}