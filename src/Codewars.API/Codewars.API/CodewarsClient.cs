using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Codewars.API.Responses;

namespace Codewars.API
{
    /// <summary>
    /// Simplifies access to the complete mango api.
    /// </summary>
    public class CodewarsClient
    {
        private readonly HttpClient _client;
        private static readonly JsonMediaTypeFormatter JsonFormatter = new JsonMediaTypeFormatter();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodewarsClient"/> class.
        /// </summary>
        /// <param name="apiUri">The API URI of the Mango server.</param>
        /// <exception cref="System.ArgumentNullException">apiUri</exception>
        public CodewarsClient(string apiKey)
        {
            if (apiKey == null) throw new ArgumentNullException("apiKey");
            _client = new HttpClient { BaseAddress = new Uri("https://www.codewars.com/api/v1/") };
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);
        }

        public async Task<GetUserResponse> GetUser(string userName)
        {
            var response = await _client.GetAsync("users" + string.Format("/{0}", userName));
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<GetUserResponse>();
            return responseResult;
        }

        public async Task<GetCodeChallenge> GetCodeChallenge(string userNameOrSlug)
        {
            var response = await _client.GetAsync("code-challenges" + string.Format("/{0}", userNameOrSlug));
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<GetCodeChallenge>();
            return responseResult;
        }

        public async Task<GetCodeChallenge> BeginNextTrainingSession(string language)
        {
            var response = await _client.PostAsync("code-challenges" + string.Format("/{0}", userNameOrSlug));
            response.EnsureSuccessStatusCode();
            var responseResult = await response.Content.ReadAsAsync<GetCodeChallenge>();
            return responseResult;
        }
    }
}
