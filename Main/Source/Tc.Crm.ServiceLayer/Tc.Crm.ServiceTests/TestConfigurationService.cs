﻿using System.Configuration;
using System.IO;
using Tc.Crm.Service.Services;

namespace Tc.Crm.ServiceTests
{
    public class TestConfigurationService : IConfigurationService
    {
        public bool CorrectSignaure;

        

        public string GetIssuedAtTimeExpiryInSeconds()
        {
            return ConfigurationManager.AppSettings[Service.Constants.Configuration.AppSettings.IssuedAtTimeExpiryInSeconds];
        }

        public string GetPublicKey()
        {
            if (CorrectSignaure)
            {
                var fileName = ConfigurationManager.AppSettings["privateKeyFileName"];
                return File.ReadAllText(fileName);
            }
            else
            {
                var fileName = ConfigurationManager.AppSettings["privateKeyFileNameWrong"];
                return File.ReadAllText(fileName);
            }
        }

        public string GetSecretKey()
        {
            return ConfigurationManager.AppSettings[Service.Constants.Configuration.AppSettings.JsonWebTokenSecret];
        }
    }
}
