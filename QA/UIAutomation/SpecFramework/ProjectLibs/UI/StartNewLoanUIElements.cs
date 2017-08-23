using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class StartNewLoanUiElements : MiInputsResultsUiElements
    {
        public static By StartNewLoanText = By.XPath("//div[@id='StartNewLoan']/md-toolbar");
        public static By ResetButton = By.XPath("//div[@id='StartNewLoan']//button");
        public static By BrowseButton = By.XPath("//section[@id='RestoreViewParametersFromFile']//input");
        public static By UploadButton = By.XPath("//section[@id='RestoreViewParametersFromFile']//button");
    }
}
