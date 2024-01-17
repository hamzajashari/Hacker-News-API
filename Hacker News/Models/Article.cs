using Hacker_News.Models.Highlight;

namespace Hacker_News.Models
{
    public class Article
    {
        public HighlightResult _HighlightResult { get; set; }
        public List<string> _Tags { get; set; }
        public string Author { get; set; }
        public List<int> Children { get; set; }
        public DateTime Created_at { get; set; }
        public long Created_at_i { get; set; }
        public int Num_comments { get; set; }
        public string ObjectID { get; set; }
        public int? Points { get; set; }
        public int Story_id { get; set; }
        public string Title { get; set; }
        public DateTime Updated_at { get; set; }
        public string Url { get; set; }
    }
}
