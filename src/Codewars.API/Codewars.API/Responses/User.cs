using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    /// <summary>
    /// Information about a specific user.
    /// </summary>
    [DataContract]
    public class User
    {
        /// <summary>
        /// User name.
        /// </summary>
        [DataMember(Name = "username")]
        public string UserName { get; set; }

        /// <summary>
        /// Display name of the user.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Honor achieved
        /// </summary>
        [DataMember(Name = "honor ")]
        public int Honor { get; set; }

        /// <summary>
        /// The users clan
        /// </summary>
        [DataMember(Name = "clan")]
        public string Clan { get; set; }

        /// <summary>
        /// Position in the leaderboard
        /// </summary>
        [DataMember(Name = "leaderboardPosition")]
        public int? LeaderboardPosition { get; set; }

        /// <summary>
        /// Skills per the users profile
        /// </summary>
        [DataMember(Name = "skills")]
        public List<string> Skills { get; set; }

        /// <summary>
        /// Ranks achieved
        /// </summary>
        [DataMember(Name = "ranks")]
        public Ranks Ranks { get; set; }

        /// <summary>
        /// Code challeges participated in.
        /// </summary>
        [DataMember(Name = "codechallenges")]
        public CodeChallenges CodeChallenges { get; set; }
    }

    /// <summary>
    /// Rank information
    /// </summary>
    [DataContract]
    public class RankInformation
    {
        /// <summary>
        /// Users' rank value
        /// </summary>
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Name of the achieved rank
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Color of the achieved Rank.
        /// </summary>
        [DataMember(Name = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Score value.
        /// </summary>
        [DataMember(Name = "score")]
        public int Score { get; set; }
    }

    /// <summary>
    /// Ranks per language
    /// </summary>
    [DataContract]
    public class LanguagesRank
    {
        /// <summary>
        /// Rank in JavaScript
        /// </summary>
        [DataMember(Name = "javascript")]
        public RankInformation Javascript { get; set; }

        /// <summary>
        /// Rank in Ruby
        /// </summary>
        [DataMember(Name = "ruby")]
        public RankInformation Ruby { get; set; }

        /// <summary>
        /// Rank in coffeescript
        /// </summary>
        [DataMember(Name = "coffeescript")]
        public RankInformation Coffeescript { get; set; }
    }

    /// <summary>
    /// User Ranks across variou
    /// </summary>
    [DataContract]
    public class Ranks
    {
        [DataMember(Name = "overall")]
        public RankInformation Overall { get; set; }

        [DataMember(Name = "languages")]
        public LanguagesRank Languages { get; set; }
    }

    /// <summary>
    /// Total challenges authored and completed by user.
    /// </summary>
    [DataContract]
    public class CodeChallenges
    {
        /// <summary>
        /// Total challenges authored by user.
        /// </summary>
        [DataMember(Name = "totalAuthored")]
        public int TotalAuthored { get; set; }

        /// <summary>
        /// Total challenges completed.
        /// </summary>
        [DataMember(Name = "totalCompleted")]
        public int TotalCompleted { get; set; }
    }
}