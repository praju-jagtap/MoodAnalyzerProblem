using MoodAnalyzerProblemStatement;

namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenIAmInSadMessageInConstructor_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "SAD");
        }
        [TestMethod]
        public void GivenIAmInHappyMessageInConstructor_ShouldReturnHappy()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}