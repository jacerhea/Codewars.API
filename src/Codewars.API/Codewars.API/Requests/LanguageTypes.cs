using System.Runtime.Serialization;

namespace Codewars.API.Requests
{
    /// <summary>
    /// Codewars supports a number of languages, with more coming soon.
    /// </summary>
    [DataContract]
    public enum LanguageTypes
    {
        /// <summary>
        /// Ruby MRI 2.0.0 running within a Dockerized Ubuntu 14.04 container.
        /// </summary>
        [EnumMemberAttribute(Value = "ruby")]
        Ruby,

        /// <summary>
        /// Supported CoffeeScript version is 1.7.1 running on Node v0.10.29
        /// </summary>
        [EnumMemberAttribute(Value = "coffeescript")]
        CoffeeScript,

        /// <summary>
        /// JavaScript runs on Node v0.10.29 within a Dockerized Ubuntu 14.04 container. Harmony extensions have been enabled.
        /// </summary>
        [EnumMemberAttribute(Value = "javascript")]
        JavaScript,

        /// <summary>
        /// Python v2.7 runs within a Dockerized Ubuntu 14.04 container.
        /// </summary>
        [EnumMemberAttribute(Value = "python")]
        Python,

        /// <summary>
        /// The Glorious Glasgow Haskell Compilation System, version 7.6.3
        /// </summary>
        [EnumMemberAttribute(Value = "haskell")]
        Haskell,

        /// <summary>
        /// Codewars supports Oracle Java 1.8
        /// </summary>
        [EnumMemberAttribute(Value = "java")]
        Java,

        /// <summary>
        /// Codewars supports Clojure 1.6.0
        /// </summary>
        [EnumMemberAttribute(Value = "clojure")]
        Clojure
    }
}
