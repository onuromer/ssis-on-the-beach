using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[machine_properties]")]
    public class MachineProperties
    {
        [Map("[WorkerAgentId]")]
        public Guid Workeragentid { get; set; }
        [Map("[PropertyName]")]
        public string Propertyname { get; set; }
        [Map("[PropertyValue]")]
        public string Propertyvalue { get; set; }
    }
}
