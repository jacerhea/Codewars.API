using System.Runtime.Serialization;

namespace Codewars.API.Responses
{
    /// <summary>
    ///  A deferred message id (dmid) which will be used to poll for the response. Polling must be used to retrieve the response.
    /// </summary>
    [DataContract]
    public class AttemptSolutionResponse
    {
        /// <summary>
        /// Submission was successfully received
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Id of the Deferred message
        /// </summary>
        [DataMember(Name = "dmid")]
        public string DmId { get; set; }
    }
}
