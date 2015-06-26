using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    [DataContract]
    public class Overall
    {
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }
    }

    [DataContract]
    public class Javascript
    {
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }
    }

    [DataContract]
    public class Ruby
    {
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }
    }

    [DataContract]
    public class Coffeescript
    {
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }
    }

    [DataContract]
    public class Languages
    {
        [DataMember(Name = "javascript")]
        public Javascript Javascript { get; set; }

        [DataMember(Name = "ruby")]
        public Ruby Ruby { get; set; }

        [DataMember(Name = "coffeescript")]
        public Coffeescript Coffeescript { get; set; }
    }

    [DataContract]
    public class Ranks
    {
        [DataMember(Name = "overall")]
        public Overall Overall { get; set; }

        [DataMember(Name = "languages")]
        public Languages Languages { get; set; }
    }

    [DataContract]
    public class CodeChallenges
    {
        [DataMember(Name = "totalAuthored")]
        public int TotalAuthored { get; set; }

        [DataMember(Name = "totalCompleted")]
        public int TotalCompleted { get; set; }
    }

    [DataContract]
    public class GetUserResponse
    {
        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "honor ")]
        public int Honor { get; set; }

        [DataMember(Name = "clan")]
        public string Clan { get; set; }

        [DataMember(Name = "leaderboardPosition")]
        public int? LeaderboardPosition { get; set; }

        [DataMember(Name = "skills")]
        public List<string> Skills { get; set; }

        [DataMember(Name = "ranks")]
        public Ranks Ranks { get; set; }

        [DataMember(Name = "codechallenges")]
        public CodeChallenges CodeChallenges { get; set; }
    }
}