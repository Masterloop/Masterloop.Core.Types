using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.Observations
{
    public class ObservationPackageBuilder
    {
        public class IdentifiedObservationsItem
        {
            public int Id { get; set; }
            public List<Observation> Observations { get; set; }

            public IdentifiedObservationsItem(int observationId)
            {
                Id = observationId;
                Observations = new List<Observation>();
            }
        }

        public List<IdentifiedObservationsItem> IdentifiedObservations { get; set; }

        public ObservationPackageBuilder()
        {
            IdentifiedObservations = new List<IdentifiedObservationsItem>();
        }

        public void Clear()
        {
            IdentifiedObservations.Clear();
        }

        public void Append(int observationId, Observation observation)
        {
            foreach (IdentifiedObservationsItem ioi in IdentifiedObservations)
            {
                if (ioi.Id == observationId)
                {
                    ioi.Observations.Add(observation);
                    return;
                }
            }
            IdentifiedObservationsItem newItem = new IdentifiedObservationsItem(observationId);
            newItem.Observations.Add(observation);
            IdentifiedObservations.Add(newItem);
        }

        public void Append(IdentifiedObservation observation)
        {
            foreach (IdentifiedObservationsItem ioi in IdentifiedObservations)
            {
                if (ioi.Id == observation.ObservationId)
                {
                    ioi.Observations.Add(observation.Observation);
                    return;
                }
            }
            IdentifiedObservationsItem newItem = new IdentifiedObservationsItem(observation.ObservationId);
            newItem.Observations.Add(observation.Observation);
            IdentifiedObservations.Add(newItem);
        }

        public void Append(IdentifiedObservations observations)
        {
            foreach (IdentifiedObservationsItem ioi in IdentifiedObservations)
            {
                if (ioi.Id == observations.ObservationId)
                {
                    ioi.Observations.AddRange(observations.Observations);
                    return;
                }
            }
            IdentifiedObservationsItem newItem = new IdentifiedObservationsItem(observations.ObservationId);
            newItem.Observations.AddRange(observations.Observations);
            IdentifiedObservations.Add(newItem);
        }

        public ObservationPackage GetAsObservationPackage()
        {
            //TODO: Consider sorting on identifier and timestamp
            List<IdentifiedObservations> identifiedObservations = new List<IdentifiedObservations>();
            foreach (IdentifiedObservationsItem io in IdentifiedObservations)
            {
                IdentifiedObservations IO = new IdentifiedObservations()
                {
                    ObservationId = io.Id,
                    Observations = io.Observations.ToArray()
                };
                identifiedObservations.Add(IO);
            }
            ObservationPackage package = new ObservationPackage()
            {
                Observations = identifiedObservations.ToArray()
            };
            return package;
        }
    }
}
