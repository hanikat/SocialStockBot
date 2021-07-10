using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class StopLossExitCondition
    {
        [Number(NumberType.Double, Name = "Price")]
        public double Price { get; set; }
    }
}
