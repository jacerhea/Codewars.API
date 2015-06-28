using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    [DataContract]
    public class DeferredResponse
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "dmid")]
        public string DmId { get; set; }

        [DataMember(Name = "valid")]
        public bool Valid { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        [DataMember(Name = "output")]
        public List<string> Output { get; set; }

        [DataMember(Name = "wall_time")]
        public int WallTime { get; set; }
    }
}
