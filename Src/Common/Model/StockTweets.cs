using Common.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StockTweets
    {
        public Keyword StockTicker { get; set; }
        public DateTime Timestamp { get; set; }
        public byte MentionRating { get; set; }
        public Tweet Tweet { get; set; }
        public int TweetId { get; set; }
    }
}
