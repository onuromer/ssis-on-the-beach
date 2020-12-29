using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[job_worker_agents_history]")]    
    [ControllerDetails("api/v1/JobWorkerAgentsHistory",typeof(Guid))]    
    public class JobWorkerAgentsHistory
    {
        [Key]
        [Map("[WorkerAgentId]")]         
        public Guid Workeragentid { get; set; }
        [Key]
        [Map("[JobId]")]         
        public Guid Jobid { get; set; }
    }
}
