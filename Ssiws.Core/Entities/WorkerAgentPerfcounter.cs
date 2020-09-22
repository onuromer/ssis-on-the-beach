using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[worker_agent_perfcounter]")]
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
