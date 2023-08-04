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
            try
            {
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}