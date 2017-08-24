using OpenQA.Selenium;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class ExportInputUiElements : AmortizationUiElements
    {
        #region Export
   
        public static By ExportLoanInformationText = By.XPath("//div[@id='LoanAccountInformationInput']/md-toolbar/div");

        public static By LoanTitle = By.XPath("//div[@title='Loan Title']//input");
        public static By LoanIdNumber = By.XPath("//div[@title='Loan Id Number']//input");
        public static By BorrowersNames = By.XPath("//div[@title='Borrowers Name']//input");
        public static By NameOfLender = By.XPath("//div[@title='Name Of Lender']//input");
        public static By PreparedBy = By.XPath("//div[@title='Prepared By']//input");
        public static By OriginalCreditor = By.XPath("//div[@title='Original Creditor']//input");
        public static By LoanSecuredBy;
        public static By Export;
        public static void ExportRadioButtonVariable()
        {
            LoanSecuredBy = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanSecruredBy + "']");
            Export = By.XPath("//md-radio-button[@aria-label='" + TridVariable.Export + "']");
        }
        public static By ExportToPdfButton = By.XPath("//div[@id='LoanAccountInformationInput']//div[9]//button");
        public static By ExportButton = By.XPath("//div[@id='BackupViewParamsToFile']//button");

        #endregion
    }
}
