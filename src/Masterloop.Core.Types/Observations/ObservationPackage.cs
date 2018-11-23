using Masterloop.Core.Types.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Masterloop.Core.Types.Observations
{
    public class ObservationPackage
    {
        public IdentifiedObservations[] Observations { get; set; }

        public UInt32 GetTotalObservations()
        {
            if (Observations != null)
            {
                UInt32 counter = 0;
                foreach (IdentifiedObservations ios in Observations)
                {
                    counter += (UInt32)ios.Observations.Length;
                }
                return counter;
            }
            else
            {
                return 0;
            }
        }
    }
}
