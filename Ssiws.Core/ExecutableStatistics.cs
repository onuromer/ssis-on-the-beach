using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[executable_statistics]")]
    public class ExecutableStatistics
    {
        [Map("[statistics_id]")]
        public long StatisticsId { get; set; }
        [Map("[execution_id]")]
        public long ExecutionId { get; set; }
        [Map("[executable_id]")]
        public long ExecutableId { get; set; }
        [Map("[execution_path]")]
        public string ExecutionPath { get; set; }
        [Map("[start_time]")]
        public DateTimeOffset? StartTime { get; set; }
        [Map("[end_time]")]
        public DateTimeOffset? EndTime { get; set; }
        [Map("[execution_hierarchy]")]
        public string ExecutionHierarchy { get; set; }
        [Map("[execution_duration]")]
        public int? ExecutionDuration { get; set; }
        [Map("[execution_result]")]
        public short? ExecutionResult { get; set; }
        [Map("[execution_value]")]
        public object ExecutionValue { get; set; }
    }
}
