using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Observations
{
    public class IdentifiedObservations
    {
        public int ObservationId { get; set; }
        public Observation[] Observations { get; set; }
    }
}
