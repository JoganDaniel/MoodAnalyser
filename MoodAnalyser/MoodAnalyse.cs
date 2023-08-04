namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        string message;
        public MoodAnalyse(string message) {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            return "HAPPY";
        }
    }
}