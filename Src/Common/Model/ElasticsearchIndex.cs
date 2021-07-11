using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public abstract class ElasticsearchIndex
    {
        [Ignore]
        public abstract string IndexName
        {
            get;
        }

        [Number(NumberType.Integer, Name = "Id")]
        public int Id { get; set; }

        [Date(Format = "date_time", Name = "UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
