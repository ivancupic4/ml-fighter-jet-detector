namespace MLFighterJetDetector_WebApi1
{
    public class FinalResult
    {
        public IOrderedEnumerable<KeyValuePair<string, float>> Scores { get; set; }
        public double TimeInMs { get; set; }
    }
}
