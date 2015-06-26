using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.API.IntegrationTests
{
    [TestClass]
    public class ValidRequests
    {
        public static string APIKey = "TNxxpDS7tUxk3cFozSGT";

        [TestMethod]
        public void GetUserTest()
        {
            var client = new CodewarsClient(APIKey);
            var response = client.GetUser("jacerhea");
            var userResponse = response.Result;
        }

        [TestMethod]
        public void GetCodeChallengeTest()
        {
            var client = new CodewarsClient(APIKey);
            var response = client.GetCodeChallenge("valid-braces");
            var codeChallenge = response.Result;
        }
    }
}
