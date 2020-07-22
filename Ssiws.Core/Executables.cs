using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[executables]")]
    public class Executables
    {
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
