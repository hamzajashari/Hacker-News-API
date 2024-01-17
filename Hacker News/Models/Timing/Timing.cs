namespace Hacker_News.Models.Timing
{
    public class ProcessingTiming
    {
        public RequestTiming _request { get; set; }
        public int Total { get; set; }
    }
    public class RequestTiming
    {
        public int RoundTrip { get; set; }
    }
}
