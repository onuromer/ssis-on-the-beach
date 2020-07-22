using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[tasks_history]")]
    public class TasksHistory
    {
        [Map("[TaskId]")]
        public Guid Taskid { get; set; }
        [Map("[JobId]")]
        public Guid? Jobid { get; set; }
        [Map("[TaskType]")]
        public int Tasktype { get; set; }
        [Map("[InputData]")]
        public string Inputdata { get; set; }
        [Map("[MaxExecutedCount]")]
        public int Maxexecutedcount { get; set; }
        [Map("[ExecutedCount]")]
        public int Executedcount { get; set; }
        [Map("[Status]")]
        public int Status { get; set; }
        [Map("[IsCritical]")]
        public bool? Iscritical { get; set; }
        [Map("[Priority]")]
        public int Priority { get; set; }
        [Map("[ReadyForDispatchTime]")]
        public DateTimeOffset? Readyfordispatchtime { get; set; }
        [Map("[LastUpdatedTime]")]
        public DateTimeOffset Lastupdatedtime { get; set; }
        [Map("[CreatedTime]")]
        public DateTimeOffset Createdtime { get; set; }
        [Map("[WorkerAgentId]")]
        public Guid? Workeragentid { get; set; }
        [Map("[ExpiredTime]")]
        public DateTimeOffset? Expiredtime { get; set; }
        [Map("[CreateWorkerAgentId]")]
        public Guid? Createworkeragentid { get; set; }
        [Map("[IsCancelled]")]
        public bool? Iscancelled { get; set; }
        [Map("[LastPickupTime]")]
        public DateTimeOffset? Lastpickuptime { get; set; }
    }
}
