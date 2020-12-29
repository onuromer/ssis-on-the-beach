using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[executions]")]    
    [ControllerDetails("api/v1/Executions",typeof(long))]    
    public class Executions
    {
        [Key]
        [Map("[execution_id]")]         
        public long ExecutionId { get; set; }
        
        [Map("[folder_name]")]         
        public string FolderName { get; set; }
        
        [Map("[project_name]")]         
        public string ProjectName { get; set; }
        
        [Map("[package_name]")]         
        public string PackageName { get; set; }
        
        [Map("[reference_id]")]         
        public long? ReferenceId { get; set; }
        
        [Map("[reference_type]")]         
        public string ReferenceType { get; set; }
        
        [Map("[environment_folder_name]")]         
        public string EnvironmentFolderName { get; set; }
        
        [Map("[environment_name]")]         
        public string EnvironmentName { get; set; }
        
        [Map("[project_lsn]")]         
        public long? ProjectLsn { get; set; }
        
        [Map("[executed_as_sid]")]         
        public byte[] ExecutedAsSid { get; set; }
        
        [Map("[executed_as_name]")]         
        public string ExecutedAsName { get; set; }
        
        [Map("[use32bitruntime]")]         
        public bool Use32bitruntime { get; set; }
        
        [Map("[job_id]")]         
        public Guid? JobId { get; set; }
    }
}
