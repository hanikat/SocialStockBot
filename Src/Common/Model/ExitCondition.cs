using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public class ExitCondition
    {
        [Object]
        public PriceTargetExitCondition PriceTarget { get; set; }
        [Object]
        public StopLossExitCondition StopLoss { get; set; }
        [Object]
        public TimeBasedExitCondition TimeBased { get; set; }
    }
}
