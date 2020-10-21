using System;

namespace Masterloop.Core.Types.Base
{
    public class DescriptiveStatistics
    {
        public int Count { get; set; }
        public double Mean { get; set; }
        public double Minimum { get; set; }
        public double Maximum { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public double? StdDev { get; set; }
        public double? Median { get; set; }
    }
}