using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TRID.CommonUtils;
using TRID.Config.Interfaces;

namespace TRID.GlobalParam
{
    class ObjectRepo  
    {
        public static Iconfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
        public static DriverSetup SetDriver { get; set; }
        public static WebDriverWait Wait { get; set; }
    }
}
