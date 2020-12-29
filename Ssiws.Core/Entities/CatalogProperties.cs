using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[catalog_properties]")]    
    [ControllerDetails("api/v1/CatalogProperties",typeof(string))]    
    public class CatalogProperties
    {
        [Key]
        [Map("[property_name]")]         
        public string PropertyName { get; set; }
        
        [Map("[property_value]")]         
        public string PropertyValue { get; set; }
    }
}
