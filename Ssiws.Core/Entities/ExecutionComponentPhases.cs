using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[execution_component_phases]")]
    public class ExecutionComponentPhases
    {
        [Map("[phase_stats_id]")]
        public long PhaseStatsId { get; set; }
        [Map("[execution_id]")]
        public long ExecutionId { get; set; }
        [Map("[package_name]")]
        public string PackageName { get; set; }
        [Map("[package_location_type]")]
        public string PackageLocationType { get; set; }
        [Map("[package_path_full]")]
        public string PackagePathFull { get; set; }
        [Map("[task_name]")]
        public string TaskName { get; set; }
        [Map("[subcomponent_name]")]
        public string SubcomponentName { get; set; }
        [Map("[phase]")]
        public string Phase { get; set; }
        [Map("[is_start]")]
        public bool? IsStart { get; set; }
        [Map("[phase_time]")]
        public DateTimeOffset? PhaseTime { get; set; }
        [Map("[execution_path]")]
        public string ExecutionPath { get; set; }
        [Map("[sequence_id]")]
        public int? SequenceId { get; set; }
    }
}
