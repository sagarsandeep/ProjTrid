using TechTalk.SpecFlow;
using TRID.GlobalParam;

namespace TRID.HookFiles
{
    [Binding]
    public sealed class General
    {
   
        [AfterScenario("api" , "excel", "table")]
        public void AfterScenario()
        {
            if (ObjectRepo.Driver != null)
            {
                ObjectRepo.Driver.Close();
                ObjectRepo.Driver.Quit();
            }
        }
    }
}
