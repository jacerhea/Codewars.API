﻿using System;
using System.Linq;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.API.IntegrationTests
{
    [TestClass]
    public class ValidRequests
    {
        public static string APIKey = "Enter your API Key Here";

        [TestMethod]
        public void GetUserTest()
        {
            var client = new CodewarsClient(APIKey);
            var response = client.GetUser("jacerhea");
            var userResponse = response.Result;
            Assert.AreEqual("Monadic Software", userResponse.Clan);
            Assert.IsNotNull(userResponse.CodeChallenges);
            Assert.IsNotNull(userResponse.Ranks.Languages.Javascript);
            Assert.IsNull( userResponse.Ranks.Languages.Coffeescript);
            Assert.IsNull(userResponse.Ranks.Languages.Ruby);

        }

        [TestMethod]
        public void GetCodeChallengeTest()
        {
            var client = new CodewarsClient(APIKey);
            var response = client.GetCodeChallenge("valid-braces");
            var codeChallenge = response.Result;

            var responseById = client.GetCodeChallenge(codeChallenge.Id).Result;

            Assert.IsTrue(true);
            
        }

        [TestMethod]
        public void GetDeferredResponseTest()
        {
            try
            {
                var client = new CodewarsClient(APIKey);
                var response = client.GetDeferredResponse("this is a bad dmId");
                var codeChallenge = response.Result;
                Assert.Fail();
            }
            catch (AggregateException exception)
            {
                var innerException = (HttpRequestException)exception.InnerExceptions.First();
                Assert.IsTrue(true);
            }
        }
    }
}
