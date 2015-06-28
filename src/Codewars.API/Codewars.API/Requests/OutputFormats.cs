using System.Runtime.Serialization;

namespace Codewars.API.Requests
{
    /// <summary>
    /// The output format to be used. By default, html is used. raw can also be specified.
    /// </summary>
    [DataContract]
    public enum OutputFormats
    {
        /// <summary>
        /// Html format
        /// </summary>
        [EnumMemberAttribute(Value = "html")]
        Html,

        /// <summary>
        /// raw format
        /// </summary>
        [EnumMemberAttribute(Value = "raw")]
        Raw
    }
}
