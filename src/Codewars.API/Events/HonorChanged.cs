using System.Runtime.Serialization;

namespace Codewars.API
{
    /// <summary>
    /// The user’s rank has been upgraded. Could be a global rank, or a language rank
    /// </summary>
    [DataContract]
    public class HonorChanged : IEvent
    {
        /// <summary>
        /// The type of event that occurred.
        /// </summary>
        [DataMember(Name = "action")]
        public ActionType Action { get; set; }
    }
}