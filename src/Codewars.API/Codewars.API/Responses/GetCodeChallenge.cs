using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    [DataContract]
    public class Rank
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }
    }

    [DataContract]
    public class UserBasic
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }
    }

    [DataContract]
    public class GetCodeChallenge
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }

        [DataMember(Name = "approvedAt")]
        public DateTimeOffset ApprovedAt { get; set; }

        [DataMember(Name = "languages")]
        public List<string> Languages { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "rank")]
        public Rank Rank { get; set; }

        [DataMember(Name = "createdBy")]
        public UserBasic CreatedBy { get; set; }

        [DataMember(Name = "approvedBy")]
        public UserBasic ApprovedBy { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "totalAttempts")]
        public int TotalAttempts { get; set; }

        [DataMember(Name = "totalCompleted")]
        public int TotalCompleted { get; set; }

        [DataMember(Name = "totalStars")]
        public int TotalStars { get; set; }

        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }
    }
}