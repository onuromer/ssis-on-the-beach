using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[catalog_properties]")]
    public class CatalogProperties
    {
        [Map("[property_name]")]
        public string PropertyName { get; set; }
        [Map("[property_value]")]
        public string PropertyValue { get; set; }
    }
}
