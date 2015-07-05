using System.Runtime.Serialization;

namespace Codewars.API
{
    /// <summary>
    /// The types of actions that the api notify a client of.
    /// </summary>
    [DataContract]
    public enum ActionType
    {
        /// <summary>
        /// The user’s rank has been upgraded. Could be a global rank, or a language rank
        /// </summary>
        [EnumMember(Value = "rank_upgraded")]
        RankUpgraded,

        /// <summary>
        /// The user’s honor has changed (usually in a positive direction)
        /// </summary>
        [EnumMember(Value = "honor_changed")]
        HonorChanged
    }

    /// <summary>
    /// An event that the given users' rank has changed.
    /// </summary>
    [DataContract]
    public class UserHonor
    {
        /// <summary>
        /// The user's id.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The users new honor rank.
        /// </summary>
        [DataMember(Name = "honor")]
        public int Honor { get; set; }

        /// <summary>
        /// Delta of the honor rank.
        /// </summary>
        [DataMember(Name = "honor_delta")]
        public int HonorDelta { get; set; }
    }
}