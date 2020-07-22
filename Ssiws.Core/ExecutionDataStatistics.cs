using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[execution_data_statistics]")]
    public class ExecutionDataStatistics
    {
        [Map("[data_stats_id]")]
        public long DataStatsId { get; set; }
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
        [Map("[dataflow_path_id_string]")]
        public string DataflowPathIdString { get; set; }
        [Map("[dataflow_path_name]")]
        public string DataflowPathName { get; set; }
        [Map("[source_component_name]")]
        public string SourceComponentName { get; set; }
        [Map("[destination_component_name]")]
        public string DestinationComponentName { get; set; }
        [Map("[rows_sent]")]
        public long? RowsSent { get; set; }
        [Map("[created_time]")]
        public DateTimeOffset? CreatedTime { get; set; }
        [Map("[execution_path]")]
        public string ExecutionPath { get; set; }
    }
}
