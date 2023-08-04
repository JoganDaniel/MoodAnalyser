using MoodAnalyser;
using System.Security.Cryptography.X509Certificates;

namespace MoodAnalyserTest
{
    public class Tests
    {
        
        
        [Test]
        public void GivenSadMessage_AfterAnalysing_ReturnSad()
        {
            
            string message = "I am in Sad mood";
            MoodAnalyse analyser = new MoodAnalyse(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual, "SAD");
        }

        [Test]
        public void GivenAnyMessage_AfterAnalysing_ReturnHappy()
        {
            string message = "I am in Any mood";
            MoodAnalyse analyser = new MoodAnalyse(message);
            string actual = analyser.AnalyseMood();
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}