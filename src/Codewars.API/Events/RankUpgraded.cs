using System.Runtime.Serialization;

namespace Codewars.API
{
    /// <summary>
    /// The user’s rank has been upgraded. Could be a global rank, or a language rank
    /// </summary>
    [DataContract]
    public class RankUpgraded : IEvent
    {
        /// <summary>
        /// The Type of event that occurred.
        /// </summary>
        [DataMember(Name = "action")]
        public ActionType Action { get; set; }

        /// <summary>
        /// The users rank change.
        /// </summary>
        [DataMember(Name = "user")]
        public UserRank User { get; set; }
    }

    /// <summary>
    /// The users change in rank.
    /// </summary>
    [DataContract]
    public class UserRank
    {
        /// <summary>
        /// The user's id.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Delta of the rank change.
        /// </summary>
        [DataMember(Name = "rank")]
        public int Rank { get; set; }
    }
}
