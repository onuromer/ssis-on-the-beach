using RepoDb.Attributes;
using System;

namespace Ssiws.Core 
{
    [Map("[internal].[worker_agents]")]
    public class WorkerAgents
    {
        [Map("[WorkerAgentId]")]
        public Guid Workeragentid { get; set; }
        [Map("[DisplayName]")]
        public string Displayname { get; set; }
        [Map("[Description]")]
        public string Description { get; set; }
        [Map("[MachineName]")]
        public string Machinename { get; set; }
        [Map("[Tags]")]
        public string Tags { get; set; }
        [Map("[UserAccount]")]
        public string Useraccount { get; set; }
        [Map("[IsEnabled]")]
        public bool Isenabled { get; set; }
        [Map("[LastOnlineTime]")]
        public DateTimeOffset Lastonlinetime { get; set; }
    }
}
