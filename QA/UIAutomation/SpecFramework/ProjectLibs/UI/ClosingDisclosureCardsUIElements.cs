using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class ClosingDisclosureCardsUiElements : LoanEstimateCardsUiElements
    {
        public static By PrincipalAndInterestLabelText = By.XPath("//div[@id='PrincipalAndInterest']/md-toolbar/div");

        //Princpal & Interest
        public static By PiComputedValue = By.XPath("//div[@id='PrincipalAndInterest']//p[1]");
        public static By PiDisclosureValue = By.XPath("//div[@id='PrincipalAndInterest']//p[2]");
        public static By PiVarianceValue = By.XPath("//div[@id='PrincipalAndInterest']//p[3]");

        //Estimated Taxes, Insurance & Assessments
        public static By EtiaComputedValue = By.XPath("//div[@id='EstimatedTaxesInsuranceAssessments']//p[1]");
        public static By EtiaDisclosureValue = By.XPath("//div[@id='EstimatedTaxesInsuranceAssessments']//p[2]");
        public static By EtiaVarianceValue = By.XPath("//div[@id='EstimatedTaxesInsuranceAssessments']//p[3]");

        //Initial Escrow Pymt 
        public static By IepComputedValue = By.XPath("//div[@id='InitialEscrowPayment']//p[1]");
        public static By IepDisclosureValue = By.XPath("//div[@id='InitialEscrowPayment']//p[2]");
        public static By IepVarianceValue = By.XPath("//div[@id='InitialEscrowPayment']//p[3]");

        //APR
        public static By AprComputedValue = By.XPath("//div[@id='APRInfoBox']//p[1]");
        public static By AprDisclosureValue = By.XPath("//div[@id='APRInfoBox']//p[2]");
        public static By AprVarianceValue = By.XPath("//div[@id='APRInfoBox']//p[3]");

        //Mortgage Insurance
        public static By MiComputedValue = By.XPath("//div[@id='PMI']//p[1]");
        public static By MiDisclosureValue = By.XPath("//div[@id='PMI']//p[2]");
        public static By MiVarianceValue = By.XPath("//div[@id='PMI']//p[3]");

        //Escrowed Prop Costs Over Year 1 from consummation date
        public static By E1O11ComputedValue = By.XPath("//div[@id='EscrowPrptOverOneYear']//p[1]");
        public static By E1O11DisclosureValue = By.XPath("//div[@id='EscrowPrptOverOneYear']//p[2]");
        public static By E1O11VarianceValue = By.XPath("//div[@id='EscrowPrptOverOneYear']//p[3]");

        //Total Of Pymts 
        public static By TopComputedValue = By.XPath("//div[@id='TotalOfPayments']//p[1]");
        public static By TopDisclosureValue = By.XPath("//div[@id='TotalOfPayments']//p[2]");
        public static By TopVarianceValue = By.XPath("//div[@id='TotalOfPayments']//p[3]");

        //APR WIN
        public static By AprWinInfoValue = By.XPath("//div[@id='APRWIN']//span");

        //Estimated Escrow
        public static By EeComputedValue = By.XPath("//div[@id='EstimatedEscrow']//p[1]");
        public static By EeDisclosureValue = By.XPath("//div[@id='EstimatedEscrow']//p[2]");
        public static By EeVarianceValue = By.XPath("//div[@id='EstimatedEscrow']//p[3]");

        //Escrowed Property Costs Over Year 1 from date of 1st loan payment
        public static By E1O12ComputedValue = By.XPath("//div[@id='EscrowPropertyCostOverOneYear12Months']//p[1]");
        public static By E1O12DisclosureValue = By.XPath("//div[@id='EscrowPropertyCostOverOneYear12Months']//p[2]");
        public static By E1O12VarianceValue = By.XPath("//div[@id='EscrowPropertyCostOverOneYear12Months']//p[3]");

        //Finance Charge
        public static By FcComputedValue = By.XPath("//div[@id='FinanceCharge']//p[1]");
        public static By FcDisclosureValue = By.XPath("//div[@id='FinanceCharge']//p[2]");
        public static By FcVarianceValue = By.XPath("//div[@id='FinanceCharge']//p[3]");

        //Tip
        public static By TipComputedValue = By.XPath("//div[@id='InfoBoxTIP']//p[1]");
        public static By TipDisclosureValue = By.XPath("//div[@id='InfoBoxTIP']//p[2]");
        public static By TipVarianceValue = By.XPath("//div[@id='InfoBoxTIP']//p[3]");

        //Estimated Total Monthly Payment 
        public static By EtmpComputedValue = By.XPath("//div[@id='TotalMonthlyPmt']//p[1]");
        public static By EtmpDisclosureValue = By.XPath("//div[@id='TotalMonthlyPmt']//p[2]");
        public static By EtmpVarianceValue = By.XPath("//div[@id='TotalMonthlyPmt']//p[3]");

        //Non-Escrowed Prop Costs Over Year 1
        public static By Neo1YComputedValue = By.XPath("//div[@id='NonEscrowPrptOverOneYear']//p[1]");
        public static By Neo1YDisclosureValue = By.XPath("//div[@id='NonEscrowPrptOverOneYear']//p[2]");
        public static By Neo1YVarianceValue = By.XPath("//div[@id='NonEscrowPrptOverOneYear']//p[3]");

        //Amount Financed
        public static By AfComputedValue = By.XPath("//div[@id='AmountFinanced']//p[1]");
        public static By AfDisclosureValue = By.XPath("//div[@id='AmountFinanced']//p[2]");
        public static By AfVarianceValue = By.XPath("//div[@id='AmountFinanced']//p[3]");

        //Balloon Amount
        public static By BaComputedValue = By.XPath("//div[@id='BallonAmount']//p[1]");
        public static By BaDisclosureValue = By.XPath("//div[@id='BallonAmount']//p[2]");
        public static By BaVarianceValue = By.XPath("//div[@id='BallonAmount']//p[3]");
    }
}
