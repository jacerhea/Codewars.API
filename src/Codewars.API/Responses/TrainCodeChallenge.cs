using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Codewars.API
{
    /// <summary>
    /// Code challenge (kata)
    /// </summary>
    [DataContract]
    public class TrainCodeChallenge
    {
        /// <summary>
        /// Code challenge exists
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Name of the challenge
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Human readable keyword that uniquely identifies the challenge
        /// </summary>
        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Description of the challenge
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        //The display name of the user who authored the challenge
        [DataMember(Name = "author")]
        public string Author { get; set; }

        /// <summary>
        /// The rank of the challenge
        /// </summary>
        [DataMember(Name = "rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Percentage of users who have completed the challenge.
        /// </summary>
        [DataMember(Name = "averageCompletion")]
        public double AverageCompletion { get; set; }

        /// <summary>
        /// Meta data about the challenge
        /// </summary>
        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The session information for the user.
        /// </summary>
        [DataMember(Name = "session")]
        public Session Session { get; set; }
    }
}
