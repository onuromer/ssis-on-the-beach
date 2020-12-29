using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[worker_agent_perfcounter]")]    
    [ControllerDetails("api/v1/WorkerAgentPerfcounter")]    
    public class WorkerAgentPerfcounter
    {
        
        [Map("[WorkerAgentId]")]         
        public Guid Workeragentid { get; set; }
        
        [Map("[PerfCounterName]")]         
        public string Perfcountername { get; set; }
        
        [Map("[PerfCounterValue]")]         
        public double Perfcountervalue { get; set; }
        
        [Map("[TimeStamp]")]         
        public DateTimeOffset Timestamp { get; set; }
    }
}
