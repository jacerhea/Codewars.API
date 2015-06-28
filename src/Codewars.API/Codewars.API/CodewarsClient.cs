using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Codewars.API.Requests;
using Codewars.API.Responses;

namespace Codewars.API
{
    /// <summary>
    /// Simplifies access to the complete Codewars API.
    /// </summary>
    public class CodewarsClient
    {
        private readonly HttpClient _client;
        private static readonly JsonMediaTypeFormatter JsonFormatter = new JsonMediaTypeFormatter();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodewarsClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key given by codewars.</param>
        /// <exception cref="System.ArgumentNullException">apiUri</exception>
        public CodewarsClient(string apiKey)
        {
            if (apiKey == null) throw new ArgumentNullException("apiKey");
            _client = new HttpClient { BaseAddress = new Uri("https://www.codewars.com/api/v1/") };
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);
        }

        /// <summary>
        /// This endpoint returns information about a specific user.
        /// </summary>
        /// <param name="userName">Id or username</param>
        /// <returns>Task that will yield information about a specific user</returns>
        public async Task<User> GetUser(string userName)
        {
            var response = await _client.GetAsync("users" + string.Format("/{0}", userName));
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<User>();
            return responseResult;
        }

        /// <summary>
        /// This endpoint returns information about a specific code challenge (kata).
        /// </summary>
        /// <param name="userNameOrSlug"></param>
        /// <returns>Task that will yield information about a specific code challenge (kata)</returns>
        public async Task<CodeChallenge> GetCodeChallenge(string userNameOrSlug)
        {
            var response = await _client.GetAsync("code-challenges" + string.Format("/{0}", userNameOrSlug));
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<CodeChallenge>();
            return responseResult;
        }

        /// <summary>
        /// This endpoint begins a new training session for the next code challenge (kata) within your training queue.
        /// </summary>
        /// <param name="language">REQUIRED: The programming language you wish to train on</param>
        /// <param name="strategy">OPTIONAL: The strategy to use for choosing what the next code challenge should be.</param>
        /// <param name="peek">OPTIONAL: true if you only want to peek at the next item in your queue, without removing it from the queue or beginning a new training session.</param>
        /// <returns>Task that will yield the TrainCodeChallenge</returns>
        public async Task<TrainCodeChallenge> BeginNextTrainingSession(string language, StrategyTypes? strategy = null, bool peek = false)
        {
            if (language == null) { throw new ArgumentNullException("language"); }
            if (string.IsNullOrWhiteSpace(language)) { throw new ArgumentOutOfRangeException("language"); }
            var response = await _client.PostAsync(string.Format("code-challenges/{0}", language), new { language, strategy, peek }, JsonFormatter);
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<TrainCodeChallenge>();
            return responseResult;
        }

        /// <summary>
        /// This endpoint begins a new training session for the specified code challenge (kata)
        /// </summary>
        /// <param name="language">The programming language you wish to train on.</param>
        /// <returns>Task that will yield the TrainCodeChallenge</returns>
        public async Task<TrainCodeChallenge> BeginTrainingSession(LanguageTypes language)
        {
            var response = await _client.PostAsync(string.Format("code-challenges/{0}", language), new { language }, JsonFormatter);
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<TrainCodeChallenge>();
            return responseResult;
        }

        /// <summary>
        /// This endpoint is used to submit a solution to be validated by the code challenge author’s test cases. It will return a deferred message id (dmid) which will be used to poll for the response. Polling must be used to retrieve the response.
        /// </summary>
        /// <param name="projectId">This ID value will be needed when submitting a solution.</param>
        /// <param name="solutionId">This ID value will be needed when submitting a solution.</param>
        /// <param name="code">The code that you is being submitted</param>
        /// <param name="outputFormat">The output format to be used. By default, html is used. raw can also be specified.</param>
        /// <returns>Task that will yield the AttemptSolutionResponse</returns>
        public async Task<AttemptSolutionResponse> AttemptSolution(string projectId, string solutionId, string code, OutputFormats outputFormat = OutputFormats.Html)
        {
            var response = await _client.PostAsync(string.Format("code-challenges/projects/{0}/solutions/{1}/attempt", projectId, solutionId), new { projectId, solutionId }, JsonFormatter);
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<AttemptSolutionResponse>();
            return responseResult;
        }

        /// <summary>
        /// This endpoint is used to finalize the previously submitted solution. This endpoint will only return a success message if there has been a previously successful solution.
        /// </summary>
        /// <param name="projectId">This ID value will be needed when submitting a solution.</param>
        /// <param name="solutionId">This ID value will be needed when submitting a solution.</param>
        /// <returns>Task that will yield the TrainCodeChallenge.</returns>
        public async Task<TrainCodeChallenge> FinalizeSolution(string projectId, string solutionId)
        {
            var response = await _client.PostAsync(string.Format("code-challenges/projects/{0}/solutions/{1}/finalize", projectId, solutionId), new { projectId, solutionId }, JsonFormatter);
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<TrainCodeChallenge>();
            return responseResult;
        }

        /// <summary>
        /// This endpoint is used for polling for a deferred response. This is to be used in conjunction with the attempt endpoint.
        /// </summary>
        /// <param name="dmId"></param>
        /// <returns>Task that will yield the DeferredResponse</returns>
        public async Task<DeferredResponse> GetDeferredResponse(string dmId)
        {
            var response = await _client.GetAsync(string.Format("deferred/{0}", dmId));
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<DeferredResponse>();
            return responseResult;
        }
    }
}
