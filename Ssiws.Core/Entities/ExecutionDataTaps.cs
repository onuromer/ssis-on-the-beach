using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[execution_data_taps]")]
    public class ExecutionDataTaps
    {
        [Map("[data_tap_id]")]
        public long DataTapId { get; set; }
        [Map("[execution_id]")]
        public long ExecutionId { get; set; }
        [Map("[package_path]")]
        public string PackagePath { get; set; }
        [Map("[dataflow_path_id_string]")]
        public string DataflowPathIdString { get; set; }
        [Map("[dataflow_task_guid]")]
        public Guid? DataflowTaskGuid { get; set; }
        [Map("[max_rows]")]
        public int? MaxRows { get; set; }
        [Map("[filename]")]
        public string Filename { get; set; }
    }
}
