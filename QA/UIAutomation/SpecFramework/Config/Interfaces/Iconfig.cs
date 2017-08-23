using TRID.Config.enumfolder;

namespace TRID.Config.Interfaces
{
    interface Iconfig
    {
        BrowserType GetBrowser();
        string GetUrl();
    }
}
