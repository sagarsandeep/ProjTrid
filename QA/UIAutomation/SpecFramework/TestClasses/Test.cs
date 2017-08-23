using OpenQA.Selenium.Support.UI;
using SpecFramework.BaseClasses;
using SpecFramework.Config;
using SpecFramework.GlobalParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFramework.TestClasses
{
    public class Test : PageBase
    {
        public Test()
        {
            Console.WriteLine("Inside Test initialize");
            ObjectRepo.Config = new AppConfigReader();
            ObjectRepo.ds = new DriverSetup();
            ObjectRepo.driver = ObjectRepo.ds.InitDriver(ObjectRepo.driver, ObjectRepo.Config);
            ObjectRepo.wait = new WebDriverWait(ObjectRepo.driver, TimeSpan.FromSeconds(30));
        }
    }
}
