using Common.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public double MentionedPrice { get; set; }
        public IEnumerable<Keyword> PositiveTerms { get; set; }
        public IEnumerable<Keyword> NegativeTerms { get; set; }
    }
}
