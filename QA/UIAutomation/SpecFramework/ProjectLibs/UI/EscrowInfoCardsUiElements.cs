using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class EscrowInfoCardsUiElements : VariableArmUIElements
    {
        public static By EscrowInfoInsuranceLabelText = By.Id("EscrowInfo");

        //Insurance
        public static By InsInitialDeposit = By.XPath("//td[div[div[span[text()='Insurance']]]]/following-sibling::td[1]//span");
        public static By InsPeriodDeposit = By.XPath("//td[div[div[span[text()='Insurance']]]]/following-sibling::td[2]//span");
        public static By InsLowBalance = By.XPath("//td[div[div[span[text()='Insurance']]]]/following-sibling::td[3]//span");
        public static By InsCushion = By.XPath("//td[div[div[span[text()='Insurance']]]]/following-sibling::td[4]//span");
        public static By InsTotalAnnualDisbursed = By.XPath("//td[div[div[span[text()='Insurance']]]]/following-sibling::td[5]//span");

        //Tax
        public static By TaxInitialDeposit = By.XPath("//td[div[div[span[text()='Tax']]]]/following-sibling::td[1]//span");
        public static By TaxPeriodDeposit = By.XPath("//td[div[div[span[text()='Tax']]]]/following-sibling::td[2]//span");
        public static By TaxLowBalance = By.XPath("//td[div[div[span[text()='Tax']]]]/following-sibling::td[3]//span");
        public static By TaxCushion = By.XPath("//td[div[div[span[text()='Tax']]]]/following-sibling::td[4]//span");
        public static By TaxTotalAnnualDisbursed = By.XPath("//td[div[div[span[text()='Tax']]]]/following-sibling::td[5]//span");

        //PMI
        public static By PmiInitialDeposit = By.XPath("//section[@id='EscrowPMIInfo']//td[1]//span");
        public static By PmiPeriodDeposit = By.XPath("//section[@id='EscrowPMIInfo']//td[2]//span");
        public static By PmiLowBalance = By.XPath("//section[@id='EscrowPMIInfo']//td[3]//span");
        public static By PmiCushion = By.XPath("//section[@id='EscrowPMIInfo']//td[4]//span");
        public static By PmiTotalAnnualDisbursed = By.XPath("//section[@id='EscrowPMIInfo']//td[5]//span");

        //Other1
        public static By Other1InitialDeposit = By.XPath("//td[div[div[span[text()='Other1']]]]/following-sibling::td[1]//span");
        public static By Other1PeriodDeposit = By.XPath("//td[div[div[span[text()='Other1']]]]/following-sibling::td[2]//span");
        public static By Other1LowBalance = By.XPath("//td[div[div[span[text()='Other1']]]]/following-sibling::td[3]//span");
        public static By Other1Cushion = By.XPath("//td[div[div[span[text()='Other1']]]]/following-sibling::td[4]//span");
        public static By Other1TotalAnnualDisbursed = By.XPath("//td[div[div[span[text()='Other1']]]]/following-sibling::td[5]//span");

        //Other2
        public static By Other2InitialDeposit = By.XPath("//td[div[div[span[text()='Other2']]]]/following-sibling::td[1]//span");
        public static By Other2PeriodDeposit = By.XPath("//td[div[div[span[text()='Other2']]]]/following-sibling::td[2]//span");
        public static By Other2LowBalance = By.XPath("//td[div[div[span[text()='Other2']]]]/following-sibling::td[3]//span");
        public static By Other2Cushion = By.XPath("//td[div[div[span[text()='Other2']]]]/following-sibling::td[4]//span");
        public static By Other2TotalAnnualDisbursed = By.XPath("//td[div[div[span[text()='Other2']]]]/following-sibling::td[5]//span");

        //Aggregate
        public static By AggregateInitialDeposit = By.XPath("//section[@id='EscrowAggregateInfo']//td[1]//span");
        public static By AggregatePeriodDeposit = By.XPath("//section[@id='EscrowAggregateInfo']//td[2]//span");
        public static By AggregateLowBalance = By.XPath("//section[@id='EscrowAggregateInfo']//td[3]//span");
        public static By AggregateCushion = By.XPath("//section[@id='EscrowAggregateInfo']//td[4]//span");
        public static By AggregateTotalAnnualDisbursed = By.XPath("//section[@id='EscrowAggregateInfo']//td[5]//span");
    }
}
