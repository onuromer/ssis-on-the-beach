using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[job_worker_agents]")]    
    [ControllerDetails("api/SSISDB/JobWorkerAgents")]    
    public class JobWorkerAgents
    {
        [Key]
        [Map("[WorkerAgentId]")]         
        public Guid Workeragentid { get; set; }
        [Key]
        [Map("[JobId]")]         
        public Guid Jobid { get; set; }
    }
}
