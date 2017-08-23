using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class LoanEstimateCardsUiElements : ExportInputUiElements
    {
        public static By LoanEstimateIn5YearsText = By.XPath("//div[@id='InfoBoxIn5Years']//p[1]");

        //In 5 years
        public static By I5YComputedValue = By.XPath("//div[@id='InfoBoxIn5Years']//p[1]");
        public static By I5YDisclosureValue = By.XPath("//div[@id='InfoBoxIn5Years']//p[2]");
        public static By I5YVarianceValue = By.XPath("//div[@id='InfoBoxIn5Years']//p[3]");

        //In 5 Years Principal
        public static By I5YpComputedValue = By.XPath("//div[@id='InfoBoxIn5YearsPrincipal']//p[1]");
        public static By I5YpDisclosureValue = By.XPath("//div[@id='InfoBoxIn5YearsPrincipal']//p[2]");
        public static By I5YpVarianceValue = By.XPath("//div[@id='InfoBoxIn5YearsPrincipal']//p[3]");
    }
}
