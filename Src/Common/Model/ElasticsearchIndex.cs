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
        public abstract string IndexName
        {
            get;
        }

        [Number(NumberType.Integer)]
        public int Id { get; set; }
    }
}
