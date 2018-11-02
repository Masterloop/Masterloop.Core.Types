using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Observations
{
    public class IdentifiedObservation
    {
        public int ObservationId { get; set; }
        public Observation Observation { get; set; }
    }
}
