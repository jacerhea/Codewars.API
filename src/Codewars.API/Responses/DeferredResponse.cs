using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API
{
    [DataContract]
    public class DeferredResponse
    {
        /// <summary>
        /// The request was succussful.
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// The unique identifier of the deferred message.
        /// </summary>
        [DataMember(Name = "dmid")]
        public string DmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
