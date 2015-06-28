using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    [DataContract]
    public class Session
    {
        /// <summary>
        /// This ID value will be needed when submitting a solution.
        /// </summary>
        [DataMember(Name = "projectId")]
        public string ProjectId { get; set; }

        /// <summary>
        /// This ID value will be needed when submitting a solution.
        /// </summary>
        [DataMember(Name = "solutionId")]
        public string SolutionId { get; set; }

        /// <summary>
        /// This is the initial solution code that is given to a user.
        /// </summary>
        [DataMember(Name = "setup")]
        public string Setup { get; set; }

        /// <summary>
        /// This is the example test cases that are initially given to a user.
        /// </summary>
        [DataMember(Name = "exampleFixture")]
        public string ExampleFixture { get; set; }

        /// <summary>
        /// If the user is continuing a previous started solution, this value will represent their previous work.
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }
    }
}