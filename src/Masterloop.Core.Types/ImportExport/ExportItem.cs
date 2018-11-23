using Masterloop.Core.Types.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.ImportExport
{
    public class ExportItem
    {
        public string MID { get; set; }

        public int ObservationId { get; set; }

        public DataType DataType { get; set; }

        public string Name { get; set; }
    }
}
