using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class TridHeaderUiElements : StartNewLoanUiElements
    {
        public static By StartNewLoanLink = By.LinkText("Start New Loan");
        public static By LoanInputsLink = By.LinkText("Loan Inputs");
        public static By MiInputsResultsLink = By.LinkText("MI Inputs & Results");
        public static By CdInputsLink = By.LinkText("CD Inputs");
        public static By LeInputsAndResultsLink = By.LinkText("LE Inputs & Results");
        public static By CdResultsLink = By.LinkText("CD Results");
        public static By EscrowLink = By.LinkText("Escrow");
        public static By AmortizationLink = By.LinkText("Amortization");
        public static By EscrowTrialBalanceLink = By.LinkText("Escrow Trial Balance");
        public static By VariableAmortizationLink = By.LinkText("Variable Amortization");
        public static By ExportLink = By.LinkText("Export");
        public static By EscrowGrid = By.LinkText("EscrowGrid");
        public static By VariableArm = By.LinkText("ARM");

 
        public static By AmortizationPaymentScheduleText = By.XPath("//section[@id='PaymentScheduleOutput']//md-toolbar/div");
    }
}
