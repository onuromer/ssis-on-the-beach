using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[packages]")]    
    [ControllerDetails("api/SSISDB/Packages")]    
    public class Packages
    {
        [Key]
        [Map("[package_id]")]         
        public long PackageId { get; set; }
        
        [Map("[project_version_lsn]")]         
        public long ProjectVersionLsn { get; set; }
        
        [Map("[name]")]         
        public string Name { get; set; }
        
        [Map("[package_guid]")]         
        public Guid PackageGuid { get; set; }
        
        [Map("[description]")]         
        public string Description { get; set; }
        
        [Map("[package_format_version]")]         
        public int PackageFormatVersion { get; set; }
        
        [Map("[version_major]")]         
        public int VersionMajor { get; set; }
        
        [Map("[version_minor]")]         
        public int VersionMinor { get; set; }
        
        [Map("[version_build]")]         
        public int VersionBuild { get; set; }
        
        [Map("[version_comments]")]         
        public string VersionComments { get; set; }
        
        [Map("[version_guid]")]         
        public Guid VersionGuid { get; set; }
        
        [Map("[project_id]")]         
        public long ProjectId { get; set; }
        
        [Map("[entry_point]")]         
        public bool EntryPoint { get; set; }
        
        [Map("[validation_status]")]         
        public string ValidationStatus { get; set; }
        
        [Map("[last_validation_time]")]         
        public DateTimeOffset? LastValidationTime { get; set; }
        
        [Map("[package_data]")]         
        public string PackageData { get; set; }
    }
}
