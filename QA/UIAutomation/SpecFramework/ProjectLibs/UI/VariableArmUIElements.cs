using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class VariableArmUIElements : PageBase
    {
        public static By PaymentScheduleOutputBestLabelText = By.XPath("//section[@id='PaymentScheduleOutputBest']//md-toolbar/div");

        public static By AbcPaymentStreamNumber;
        public static By AbcPaymentScheduleNumberOfPayments;
        public static By AbcPaymentAmount;
        public static By AbcPaymentSchedulePrincipalAndInterestPayment;
        public static By AbcPaymentSchedulePmiPayment;
        public static By AbcInsEscrowedAmount;
        public static By AbcTaxEscrowedAmount;

        public static By AwcPaymentStreamNumber;
        public static By AwcPaymentScheduleNumberOfPayments;
        public static By AwcPaymentAmount;
        public static By AwcPaymentSchedulePeriodPayment;
        public static By AwcPaymentSchedulePeriodPmi;
        public static By AwcInsEscrowedAmount;
        public static By AwcTaxEscrowedAmount;

        public static void AbcPaymentScheduleGridElements(int rowIndex)
        {
            AbcPaymentStreamNumber = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[1]//span");
            AbcPaymentScheduleNumberOfPayments = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[2]//span");
            AbcPaymentAmount = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[3]//span");
            AbcPaymentSchedulePrincipalAndInterestPayment = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[4]//span");
            AbcPaymentSchedulePmiPayment = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[5]//span");
            AbcInsEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[6]//span");
            AbcTaxEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutputBest']//tr[" + rowIndex + "]/td[7]//span");
        }

        public static void AwcPaymentScheduleGridElements(int rowIndex)
        {
            AwcPaymentStreamNumber = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[1]//span");
            AwcPaymentScheduleNumberOfPayments = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[2]//span");
            AwcPaymentAmount = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[3]//span");
            AwcPaymentSchedulePeriodPayment = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[4]//span");
            AwcPaymentSchedulePeriodPmi = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[5]//span");
            AwcInsEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[6]//span");
            AwcTaxEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutputWorst']//tr[" + rowIndex + "]/td[7]//span");
        }
    }
}
