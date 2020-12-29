using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[machine_properties]")]    
    [ControllerDetails("api/v1/MachineProperties",typeof(Guid))]    
    public class MachineProperties
    {
        [Key]
        [Map("[WorkerAgentId]")]         
        public Guid Workeragentid { get; set; }
        [Key]
        [Map("[PropertyName]")]         
        public string Propertyname { get; set; }
        
        [Map("[PropertyValue]")]         
        public string Propertyvalue { get; set; }
    }
}
