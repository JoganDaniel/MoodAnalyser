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
             
            if(this.message == (string.Empty))
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Message is empty");
            }
            try
            {

                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }catch(NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD,"Message is null");
            }
        }
    }
}