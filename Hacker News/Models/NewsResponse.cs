using Hacker_News.Models.Timing;

namespace Hacker_News.Models
{
    public class NewsResponse
    {
        public Exhaustive Exhaustive { get; set; }
        public bool ExhaustiveNbHits { get; set; }
        public bool ExhaustiveTypo { get; set; }
        public List<Article> Hits { get; set; }
        public int Page { get; set; }
        public int NbHits { get; set; }
        public int NbPages { get; set; }
        public int HitsPerPage { get; set; }
        public int ProcessingTimeMS { get; set; }
        public string Query { get; set; }
        public string Params { get; set; }
        public ProcessingTiming ProcessingTimings { get; set; }
        public int ServerTimeMS { get; set; }
    }
}
