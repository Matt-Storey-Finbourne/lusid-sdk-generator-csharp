using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Finbourne.Sdk.Extensions.Tests.Unit
{
    [TestFixture]
    public class ApiConfigurationTest
    {
        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_TokenUrl_Returns_True()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.TokenUrl = String.Empty;
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_TokenUrl_Returns_Correct_String()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.TokenUrl = String.Empty;
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(1), "GetMissingConfig list contains one item");
            Assert.That(missingList[0], Is.EqualTo(nameof(config.TokenUrl)), "GetMissingConfig list string correct");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_Username_Returns_True()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.Username = String.Empty;
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_Username_Returns_Correct_String()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.Username = String.Empty;
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(1), "GetMissingConfig list contains one item");
            Assert.That(missingList[0], Is.EqualTo(nameof(config.Username)), "GetMissingConfig list string correct");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_Password_Returns_True()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.Password = String.Empty;
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_Password_Returns_Correct_String()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.Password = String.Empty;
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(1), "GetMissingConfig list contains one item");
            Assert.That(missingList[0], Is.EqualTo(nameof(config.Password)), "GetMissingConfig list string correct");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_ClientId_Returns_True()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.ClientId = String.Empty;
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_ClientId_Returns_Correct_String()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.ClientId = String.Empty;
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(1), "GetMissingConfig list contains one item");
            Assert.That(missingList[0], Is.EqualTo(nameof(config.ClientId)), "GetMissingConfig list string correct");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_ClientSecret_Returns_True()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.ClientSecret = String.Empty;
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_ClientSecret_Returns_Correct_String()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.ClientSecret = String.Empty;
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(1), "GetMissingConfig list contains one item");
            Assert.That(missingList[0], Is.EqualTo(nameof(config.ClientSecret)), "GetMissingConfig list string correct");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_BaseUrl_Returns_True()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.BaseUrl = String.Empty;
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_BaseUrl_Returns_Correct_String()
        {
            ApiConfiguration config = GetApiConfiguration();
            config.BaseUrl = String.Empty;
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(1), "GetMissingConfig list contains one item");
            Assert.That(missingList[0], Is.EqualTo("TO_BE_REPLACED_LOWERUrl"), "GetMissingConfig list string correct");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Missing_Multiple_Properties_Returns_True()
        {
            ApiConfiguration config = new ApiConfiguration();
            Assert.IsTrue(config.HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Missing_Multiple_Properties_Returns_Correct_Strings()
        {
            ApiConfiguration config = new ApiConfiguration();
            List<string> missingList = config.GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(6), "GetMissingConfig list contains six items");
        }

        [Test]
        public void ApiConfiguration_HasMissingConfig_Valid_Config_Returns_False()
        {
            Assert.IsFalse(GetApiConfiguration().HasMissingConfig());
        }

        [Test]
        public void ApiConfiguration_MissingConfig_Valid_Config_Returns_Empty_List()
        {
            List<string> missingList = GetApiConfiguration().GetMissingConfig();
            Assert.That(missingList.Count, Is.EqualTo(0), "MissingConfig list contains no items");
        }

        private ApiConfiguration GetApiConfiguration()
        {
            return new ApiConfiguration()
            {
                BaseUrl = "https://sub-domain.lusid.com/api",
                ApplicationName = "Test application",
                ClientId = "name-surname",
                ClientSecret = "client-secret",
                Password = "client-password",
                TokenUrl = "https://lusid-sub-domain.lusid.com/oauth2/abcdefg/v1/token",
                Username = "name-surname@company.com"
            };
        }
    }
}
