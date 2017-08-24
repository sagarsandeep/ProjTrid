using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class DisclosureInputsUiElements : ClosingDisclosureCardsUiElements
    {       
        public static By DisclosedValuesText = By.XPath("//div[@id='DisclosureInput']/md-toolbar");

        //Closing Disclosure Loan Terms & Projected Payments
        public static By DisclosedMonthlyPrincipalandInterest = By.XPath("//div[@title='Discl Monthly Principal & Interest']//input");
        public static By DisclosedMortgageInsurance = By.XPath("//div[@title='Discl Mortgage Insurance']//input");
        public static By DisclosedPeriodEscrowPayment = By.XPath("//div[@title='Discl Period Escrow Payment']//input");
        public static By DisclosedEstimatedTotalMonthlyPayment = By.XPath("//div[@title='Discl Estimated Total Monthly Payment']//input");
        public static By DisclosedDifferentFinalBalloonPayment = By.XPath("//div[@title='Dscl Different Final/Balloon Payment']//input");
        public static By DsclosedEstTaxesInsAndAssessments = By.XPath("//div[@title='Discl Est Taxes Ins & Assessments']//input");

        //Property Cost and Escrow
        public static By DsclEscrowedPropertyCostsOverYear1 = By.XPath("//div[@title='Discl Escrowed Property Costs Over Year 1']//input");
        public static By DisclosedNonEscrowPropertyOverYear1 = By.XPath("//div[@title='Discl Non Escrow Property Cost Over One Year']//input");
        public static By DisclosedInitialEscrowPayment = By.XPath("//div[@title='Discl Initial Escrow Payment']//input");

        //Closing Disclosure Loan Calculations
        public static By DisclosedTotalOfPayments = By.XPath("//div[@title='Discl Total Of Payments']//input");
        public static By DisclosedFinanceCharge = By.XPath("//div[@title='Discl Finance Charge']//input");
        public static By DisclosedAmountFinanced = By.XPath("//div[@title='Discl Amount Financed']//input");
        public static By DisclosedApr = By.XPath("//div[@title='Disclosed APR']//input");
        public static By DisclosedTip = By.XPath("//div[@title='Discl Total Interest Percentage']//input");

        //Loan Estimate - Comparisons
        public static By DisclosedIn5Years = By.XPath("//div[@title='Discl In 5 Years, Principal, Interest, Mortgage Insurance, and Loan Costs']//input");
        public static By DisclosedIn5YearsPrincipal = By.XPath("//div[@title='Disclosed In 5 Years Principal']//input");
        public static By LoanEstimationButton = By.XPath("//div[@id='DisclosureInputForLoanEstimation']//button");

    }
}
