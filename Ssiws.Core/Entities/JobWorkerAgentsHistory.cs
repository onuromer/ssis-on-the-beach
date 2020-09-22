using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[job_worker_agents_history]")]
    public class JobWorkerAgentsHistory
    {
        [Map("[WorkerAgentId]")]
        public Guid Workeragentid { get; set; }
        [Map("[JobId]")]
        public Guid Jobid { get; set; }
    }
}
