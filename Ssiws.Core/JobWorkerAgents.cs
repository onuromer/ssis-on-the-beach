using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[job_worker_agents]")]
    public class JobWorkerAgents
    {
        [Map("[WorkerAgentId]")]
        public Guid Workeragentid { get; set; }
        [Map("[JobId]")]
        public Guid Jobid { get; set; }
    }
}
