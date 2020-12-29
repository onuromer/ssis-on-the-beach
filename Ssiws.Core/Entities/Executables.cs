using RepoDb.Attributes;
using System;
using Ssiws.Core.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[executables]")]    
    [ControllerDetails("api/SSISDB/Executables")]    
    public class Executables
    {
        [Key]
        [Map("[executable_id]")]         
        public long ExecutableId { get; set; }
        
        [Map("[project_id]")]         
        public long ProjectId { get; set; }
        
        [Map("[project_version_lsn]")]         
        public long ProjectVersionLsn { get; set; }
        
        [Map("[package_name]")]         
        public string PackageName { get; set; }
        
        [Map("[package_location_type]")]         
        public string PackageLocationType { get; set; }
        
        [Map("[package_path_full]")]         
        public string PackagePathFull { get; set; }
        
        [Map("[executable_name]")]         
        public string ExecutableName { get; set; }
        
        [Map("[executable_guid]")]         
        public string ExecutableGuid { get; set; }
        
        [Map("[package_path]")]         
        public string PackagePath { get; set; }
    }
}
