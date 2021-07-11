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
        public IEnumerable<string> PositiveTerms { get; set; }
        public IEnumerable<string> NegativeTerms { get; set; }
    }
}
