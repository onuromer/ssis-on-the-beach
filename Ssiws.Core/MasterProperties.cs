using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[master_properties]")]
    public class MasterProperties
    {
        [Map("[property_name]")]
        public string PropertyName { get; set; }
        [Map("[property_value]")]
        public string PropertyValue { get; set; }
    }
}
