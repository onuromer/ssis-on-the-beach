using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core
{
    public class Auditable
    {
        [Map("created_by_sid")]
        public Byte[] CreatedBySID { get; set; }

        [Map("created_by_name")]
        public string CreatedByName { get; set; }

        [Map("created_time")]
        public DateTimeOffset CreatedTime { get; set; }
    }
}
