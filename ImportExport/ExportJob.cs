using System;
using System.Collections.Generic;
using System.Text;

namespace Masterloop.Core.Types.ImportExport
{
    public class ExportJob
    {
        public DateTime CreatedOn { get; set; }

        public DateTime? CompletedOn { get; set; }

        public DateTime ExpiresOn { get; set; }

        public string Url { get; set; }

        public int NumberOfRows { get; set; }
    }
}
