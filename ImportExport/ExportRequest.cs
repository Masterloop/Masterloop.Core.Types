using Masterloop.Core.Types.Observations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.ImportExport
{
    public class ExportRequest
    {
        /// <summary>
        /// Selected Device/Observation items.
        /// </summary>
        public ExportItem[] ExportItems { get; set; }

        /// <summary>
        /// Start date for export, or null for DateTime.Min.
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// End date for export, or null for up to DateTime.Max.
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// Export format encoded as MIME string.
        /// </summary>
        public ExportFormatType Format { get; set; }

        /// <summary>
        /// Set to True will also include timeslot rows without any observations, False will skip those.
        /// </summary>
        public bool IncludeEmptyTimeslots { get; set; }
    }
}
