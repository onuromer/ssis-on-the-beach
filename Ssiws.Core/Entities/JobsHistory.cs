using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[jobs_history]")]    
    [ControllerDetails("api/v1/JobsHistory",typeof(Guid))]    
    public class JobsHistory
    {
        [Key]
        [Map("[JobId]")]         
        public Guid Jobid { get; set; }
        
        [Map("[IsCancelled]")]         
        public bool Iscancelled { get; set; }
        
        [Map("[CreatedTime]")]         
        public DateTimeOffset Createdtime { get; set; }
        
        [Map("[JobType]")]         
        public int Jobtype { get; set; }
        
        [Map("[InputData]")]         
        public string Inputdata { get; set; }
        
        [Map("[Creator]")]         
        public string Creator { get; set; }
        
        [Map("[Priority]")]         
        public int Priority { get; set; }
        
        [Map("[LastUpdatedTime]")]         
        public DateTimeOffset Lastupdatedtime { get; set; }
    }
}
