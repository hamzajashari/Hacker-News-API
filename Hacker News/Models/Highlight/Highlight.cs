namespace Hacker_News.Models.Highlight
{
    public class HighlightResult
    {
        public HighlightValue Title { get; set; }
        public HighlightValue Url { get; set; }
        public HighlightValue Author { get; set; }
    }

    public class HighlightValue
    {
        public string MatchLevel { get; set; }
        public List<string> MatchedWords { get; set; }
        public string Value { get; set; }
    }
}
