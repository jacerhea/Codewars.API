using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    [DataContract]
    public class Session
    {
        [DataMember(Name = "projectId")]
        public string ProjectId { get; set; }

        [DataMember(Name = "solutionId")]
        public string SolutionId { get; set; }

        [DataMember(Name = "setup")]
        public string Setup { get; set; }

        [DataMember(Name = "exampleFixture")]
        public string ExampleFixture { get; set; }

        [DataMember(Name = "code")]
        public object Code { get; set; }
    }

    [DataContract]
    public class TrainingSessionResponse
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "author")]
        public string Author { get; set; }

        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        [DataMember(Name = "averageCompletion")]
        public double AverageCompletion { get; set; }

        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }

        [DataMember(Name = "session")]
        public Session Session { get; set; }
    }
}
