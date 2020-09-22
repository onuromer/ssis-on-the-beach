using RepoDb.Attributes;
using System;

namespace Ssiws.Core.Entities 
{
    [Map("[internal].[operation_os_sys_info]")]
    public class OperationOsSysInfo
    {
        [Map("[info_id]")]
        public long InfoId { get; set; }
        [Map("[operation_id]")]
        public long OperationId { get; set; }
        [Map("[total_physical_memory_kb]")]
        public long TotalPhysicalMemoryKb { get; set; }
        [Map("[available_physical_memory_kb]")]
        public long? AvailablePhysicalMemoryKb { get; set; }
        [Map("[total_page_file_kb]")]
        public long? TotalPageFileKb { get; set; }
        [Map("[available_page_file_kb]")]
        public long AvailablePageFileKb { get; set; }
        [Map("[cpu_count]")]
        public int CpuCount { get; set; }
    }
}
