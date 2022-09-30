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
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "SAD");
        }
        [TestMethod]
        public void GivenIAmInHappyMessageInConstructor_ShouldReturnHappy()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMessage_ShouldReturnHappy()
        {
            string message = "null";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMessage_WhenAnalyde_ShouldReturnHappy()
        {
            string message = "null";
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                string actual = mood.Analyser();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [TestMethod]
        public void GivenEmptylMessage_WhenAnalyde_ShouldReturnHappy()
        {
            string message = string.Empty;
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                string actual = mood.Analyser();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
    }
}