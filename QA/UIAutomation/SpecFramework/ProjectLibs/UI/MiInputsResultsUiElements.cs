using System.Linq;
using OpenQA.Selenium;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class MiInputsResultsUiElements: LoanInputsUiElements
    {

        public static By AddPmiRateText = By.XPath("//div[@id='MortgageInput']/md-toolbar");

        public static void MiRadioButtonVariable()
        {
            FrequencyOfDisbursement = By.XPath("//div[@title='Frequency Of Disbursement']//md-radio-button[@aria-label='" + TridVariable.FrequencyOfDisbursement + "']");
            PmiorMipTerminationCriteria = By.XPath("//div[@title='PMI/MIP Termination Criteria']//md-radio-button[@aria-label='" + TridVariable.PmiorMipTerminationCriteria + "']");
            UpfrontMipFinanced = By.XPath("//div[@title='Upfront MIP Financed?']//md-radio-button[@aria-label='" + TridVariable.UpfrontMipFinanced + "']");
        }
        //Mortgage Insurance (PMI) or Add -PMI Rate
        public static By AddNumber = By.XPath("//md-input-container[@title='Number']//input");
        public static By AddBeginPmtNumber = By.XPath("//md-input-container[@title='Begin Pmt #']//input");
        public static By AddEndPmtNumber = By.XPath("//md-input-container[@title='End Pmt #']//input");
        public static By AddPmiRate = By.XPath("//md-input-container[@title='PMI Rate(%)']//input");
        public static By AddButton = By.XPath("//div[@id='MortgageInput']//button");
        public static By PmiRatesGridRowsCount = By.XPath("//section[@id='MortgageGrid']//tbody/tr");

        //Other PMI Inputs
        public static By FrequencyOfDisbursement;
        public static By DateOfFirstMonthlyPmiDisbursement = By.XPath("//div[@title='Date Of First PMI Disbursement']//input");
        public static By LowerOfCostOrAppraisal = By.XPath("//md-input-container[@title='Lower Of Cost Or Appraisal']//input");
        public static By PmiOrMipTermination = By.XPath("//md-input-container[@title='PMI/MIP Termination Value']//input");

        //FHA/USDA Loan Details Base Loan Amount
        public static By BaseLoanAmount = By.XPath("//md-input-container[@title='Base Loan Amount']//input");
        public static By UpforntLoanFactor = By.XPath("//md-input-container[@title='Upfornt Loan Factor']//input");
        public static By AnnualMip = By.XPath("//md-input-container[@title='Annual MIP']//input");
        public static By UpFrontMipFinanced;

        //Closing Disclosure Loan Terms & Projected Payments-PMI
        public static By DisclosedPmiTerminalDate = By.XPath("//md-input-container[@title='Discl PMI Termination Date (78%)']//input");
        public static By DisclosedPmiCancelDate = By.XPath("//md-input-container[@title='Discl PMI Cancel Date (80%)']//input");
        public static By DisclosedUpfrontMip = By.XPath("//md-input-container[@title='Discl Upfront MIP']//input");
        public static By ReCalculateButton = By.XPath("//div[@id='DisclosureInputPMI']//button");

        //Scheduled PMI Termination Date 
        public static By SptdComputedValue = By.XPath("//div[@id='PMITermDateInfoBox']//p[1]");
        public static By SptdDisclosureValue = By.XPath("//div[@id='PMITermDateInfoBox']//p[2]");
        public static By SptdVarianceValue = By.XPath("//div[@id='PMITermDateInfoBox']//p[3]");

        //Scheduled Cancel Date for PMI Termination
        public static By PcdComputedValue = By.XPath("//div[@id='CancelDate']//p[1]");
        public static By PcdDisclosureValue = By.XPath("//div[@id='CancelDate']//p[2]");
        public static By PcdVarianceValue = By.XPath("//div[@id='CancelDate']//p[3]");

        //Scheduled UpFrontMip for PMI Termination
        public static By UfmComputedValue = By.XPath("//div[@id='UpfrontMipCard']//p[1]");
        public static By UfmDisclosureValue = By.XPath("//div[@id='UpfrontMipCard']//p[2]");
        public static By UfmVarianceValue = By.XPath("//div[@id='UpfrontMipCard']//p[3]");

        //Add Note
        public static By Date = By.XPath("//md-input-container[@title='Date']//input");
        public static By Note = By.XPath("//md-input-container[@title='Note']//input");
        public static By By = By.XPath("//md-input-container[@title='By']//input");
        public static By Add = By.XPath("//div[@id='Add']//button");


    }
}
