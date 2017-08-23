using System;
using System.Configuration;
using TRID.Config.configkeys;
using TRID.Config.enumfolder;
using TRID.Config.Interfaces;

namespace TRID.Config
{
    public class AppConfigReader : Iconfig

    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings["browser"];
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetUrl()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.url);
        }

      
    }
}
