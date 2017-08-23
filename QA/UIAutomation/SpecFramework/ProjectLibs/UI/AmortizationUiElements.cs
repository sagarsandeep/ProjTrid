using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class AmortizationUiElements : EscrowInfoCardsUiElements
    {
        public static By PaymentScheduleAprLabelText = By.XPath("//section[@id='PaymentScheduleOutputAPR']//md-toolbar/div");
        public static By PaymentStreamNumber;
        public static By PaymentScheduleNumberOfPayments;
        public static By PaymentAmount;
        public static By PaymentSchedulePrincipalandInterestPayment;
        public static By PaymentSchedulePmiPayment;
        public static By InsEscrowedAmount;
        public static By TaxEscrowedAmount;

        public static void PaymentScheduleGridElements(int rowIndex)
        {
            PaymentStreamNumber = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex+ "]/td[1]//span");
            PaymentScheduleNumberOfPayments = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex + "]/td[2]//span");
            PaymentAmount = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex + "]/td[3]//span");
            PaymentSchedulePrincipalandInterestPayment = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex + "]/td[4]//span");
            PaymentSchedulePmiPayment = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex + "]/td[5]//span");
            InsEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex + "]/td[6]//span");
            TaxEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tr[" + rowIndex + "]/td[7]//span");
        }

    }
}
