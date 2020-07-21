using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ssiws.Core
{
    [Map("[catalog].[catalog_properties]")]
    public class CatalogProperty
    {
        [Map("property_name")]
        public string PropertyName { get; set; }
        [Map("property_value")]
        public string PropertyValue { get; set; }
    }
}
