using System.Linq;
using OpenQA.Selenium;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class LoanInputsUiElements : DisclosureInputsUiElements
    {
        public static By LoanDetailsText = By.XPath("//div[@id='LoanInformationInput']/md-toolbar");

        //Loan Information
        public static By CalculationMethod;
        public static By LoanType;
        public static By FrequencyOfPayments;
        public static By LoanTerm;
        public static By RepaymentTermType;
        public static By OddDaysSelect;
        public static By UpfrontMipFinanced;
        public static By PmiorMipTerminationCriteria;
        public static void LoanInputRadioButtonVariable()
        {
            CalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
            LoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
            FrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
            LoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
            RepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
<<<<<<< HEAD
            DailyInterestPaidatClosing = By.XPath("//div[@title='Daily Interest Paid at Closing?']//md-radio-button[@aria-label='" + TridVariable.DailyInterestPaidAtClosing + "']");           
=======
            OddDaysSelect = By.XPath("//div[@title='Daily Interest Paid at Closing?']//md-radio-button[@aria-label='" + TridVariable.DailyInterestPaidAtClosing + "']");
            if (TridVariable.EscrowDisbursmentGridInputs1.Any())
                IsEscrowed1 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs1["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs2.Any())
                IsEscrowed2 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs2["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs3.Any())
                IsEscrowed3 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs3["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs4.Any())
                IsEscrowed4 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs4["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs5.Any())
                IsEscrowed5 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs5["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs6.Any())
                IsEscrowed6 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs6["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs7.Any())
                IsEscrowed7 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs7["IsEscrowed"] + "']");
            if (TridVariable.EscrowDisbursmentGridInputs8.Any())
                IsEscrowed8 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowDisbursmentGridInputs8["IsEscrowed"] + "']");
>>>>>>> fd8bca05ce759aa17d616f8dfd3e270e45c179c2
        }
        public static By NumberOfMonthsOrDaysInUnitPeriodValue = By.XPath("//div[@title='# of mths/days in unit period']//input");
        public static By AmortizationPeriodMonthsValue = By.XPath("//div[@title='Amortization Period - Months']//input");
        public static By NumberOfPayments = By.XPath("//div[@title='Number Of Payments']//input");
        public static By LoanAmountOrCommitmentAmount = By.XPath("//div[@title='Loan Amount / Commitment Amount']//input");
        public static By UpfrontLoanFactor = By.XPath("//div[@title='Upfornt Loan Factor']//input");
        public static By LoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        public static By RateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        public static By AnnualMip = By.XPath("//div[@title='Annual MIP']//input");
        public static By DateOfLoan = By.XPath("//div[@title='Date of loan']//input");
        public static By DateOfInterestBegins = By.XPath("//div[@title='Date Interest Begins To Accrue']//input");


        public static By DateOfFirstPayment = By.XPath("//div[@title='Date Of First Payment']//input");


        public static By PrincipalAndInterestPayment = By.XPath("//div[@title='Principal & Interest Payment']//input");
        public static By LoanCostsForDisclosure = By.XPath("//div[@title='Loan Costs For Disclosure(Sum of Section A, B, C )']//input");
        public static By PmiorMipTerminationValue = By.XPath("//div[@title='PMI/MIP Termination Value']//input");

        //Varibale Loan Details
        public static By FirstTermChange = By.XPath("//div[@title='First Term Change']//input");
        public static By SubsequentTermChange = By.XPath("//div[@title='Subsequent Term Change']//input");
        public static By DnRateCapFirstAdjustment = By.XPath("//div[@title='DN Rate Cap First Adjustment']//input");
        public static By DnRateCapSubseqAdjustment = By.XPath("//div[@title='DN Rate Caps Subseq Adjustment']//input");
        public static By UpRateCapFirstAdjustment = By.XPath("//div[@title='UP Rate Cap First Adjustment']//input");
        public static By UpRateCapSubseqAdjustment = By.XPath("//div[@title='UP Rate Caps Subseq Adjustment']//input");
        public static By FloorRate = By.XPath("//div[@title='Floor Rate']//input");
        public static By MaxRateEver = By.XPath("//div[@title='Max Rate Ever']//input");
        public static By Index = By.XPath("//div[@title='Index']//input");
        public static By Margin = By.XPath("//div[@title='Margin']//input");
        public static By RoundingFactor = By.XPath("//div[@title='Rounding Factor']//input");  

        //Escrow
<<<<<<< HEAD
        public static By PropertyCostType = By.XPath("//md-input-container[@title='Property Cost Type (tax, insurance, etc.)']//input");
        public static By Escrowed1;
        public static By Escrowed2;
        public static By Escrowed3;
        public static By Escrowed4;
        public static By Escrowed5;
        public static By Escrowed6;
        public static By Escrowed7;
        public static By Escrowed8;
        public static By VoluntaryContribution1;
        public static By VoluntaryContribution2;
        public static By VoluntaryContribution3;
        public static By VoluntaryContribution4;
        public static By VoluntaryContribution5;
        public static By VoluntaryContribution6;
        public static By VoluntaryContribution7;
        public static By VoluntaryContribution8;

        public static void EscrowRadioButtonVariable()
        {
            if (TridVariable.EscrowPropertyCostsGridInputs1.Any())
                Escrowed1 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs1["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs2.Any())
                Escrowed2 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs2["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs3.Any())
                Escrowed3 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs3["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs4.Any())
                Escrowed4 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs4["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs5.Any())
                Escrowed5 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs5["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs6.Any())
                Escrowed6 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs6["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs7.Any())
                Escrowed7 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs7["Escrowed"] + "']");
            if (TridVariable.EscrowPropertyCostsGridInputs8.Any())
                Escrowed8 = By.XPath("//div[@title='Escrowed?']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostsGridInputs8["Escrowed"] + "']");

            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs1.Any())
                VoluntaryContribution1 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs1["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs2.Any())
                VoluntaryContribution2 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs2["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs3.Any())                                                                                          
                VoluntaryContribution3 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs3["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs4.Any())                                                                                          
                VoluntaryContribution4 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs4["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs5.Any())                                                                                          
                VoluntaryContribution5 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs5["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs6.Any())                                                                                          
                VoluntaryContribution6 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs6["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs7.Any())                                                                                          
                VoluntaryContribution7 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs7["VoluntaryContribution"] + "']");
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs8.Any())                                                                                          
                VoluntaryContribution8 = By.XPath("//div[@title='Voluntary Contribution']//md-radio-button[@aria-label='" + TridVariable.EscrowPropertyCostInstallmentsGridInputs8["VoluntaryContribution"] + "']");
        }

        public static By Cushion = By.XPath("//md-input-container[@title='Escrow Cushion']//input");
        public static By EscrowPropertyCostsAddButton = By.XPath("//div[@id='EscrowInformationInput']//button");
=======
        public static By PropertyCostType = By.XPath("//div[@title='Property Cost Type (tax, insurance, etc.)']//input");
        public static By IsEscrowed1;
        public static By IsEscrowed2;
        public static By IsEscrowed3;
        public static By IsEscrowed4;
        public static By IsEscrowed5;
        public static By IsEscrowed6;
        public static By IsEscrowed7;
        public static By IsEscrowed8;
        public static By EscrowCushion = By.XPath("//div[@title='Escrow Cushion']//input");
        public static By EscrowDisbursmentsAddButton = By.XPath("//div[@id='EscrowInformationInput']//button");
>>>>>>> fd8bca05ce759aa17d616f8dfd3e270e45c179c2
        public static By EscrowDisbursmentsGridEscrowDisbursmentType;
        public static By EscrowDisbursmentsGridIsEscrowed;
        public static By EscrowDisbursmentsGridEscrowCushion;
       
        public static void EscrowDisbursementsGrid(int rowIndex)
        {
            EscrowDisbursmentsGridEscrowDisbursmentType = By.XPath("//section[@id='EscrowInformationGrid']//tr[" + rowIndex + "]/td[1]");
            EscrowDisbursmentsGridIsEscrowed = By.XPath("//section[@id='EscrowInformationGrid']//tr[" + rowIndex + "]/td[2]");
            EscrowDisbursmentsGridEscrowCushion = By.XPath("//section[@id='EscrowInformationGrid']//tr[" + rowIndex + "]/td[3]");        
        }

<<<<<<< HEAD
        public static By EscrowPropertyCostInstallmentNumber = By.XPath("//div[@id='EscrowDisbursementInputs']//md-input-container[@title='Number']//input");
        public static By EscrowPropertyCostInstallmentAmount = By.XPath("//div[@id='EscrowDisbursementInputs']//md-input-container[@title='Amount']//input");
        public static By EscrowPropertyCostInstallmentDatePaidOrDisbursed = By.XPath("//div[@title='Date Paid / Disbursed']//input");
        public static By EscrowPropertyCostInstallmentPropertyCostType = By.XPath("//div[@title='']//input");
        public static By EscrowDisbursmentTypeAutoSuggestion = By.XPath("//div[@title='']//input/following-sibling::ul//strong");
        public static By EscrowPropertyCostInstallmentAddButton = By.XPath("//div[@id='EscrowDisbursementInputs']//wipfli-button/button");
=======
        public static By EscrowInstallmentNumber = By.XPath("//div[@id='EscrowDisbursementInputs']//div[@title='Number']//input");
        public static By EscrowInstallmentAmount = By.XPath("//div[@id='EscrowDisbursementInputs']//div[@title='Amount']//input");
        public static By EscrowInstallmentDatePaidOrDisbursed = By.XPath("//div[@title='Date Paid / Disbursed']//input");
        public static By EscrowInstallmentDisbursmentType = By.XPath("//div[@title='']//input");

        public static By EscrowDisbursmentTypeAutoSuggestion = By.XPath("//div[@title='']//input/following-sibling::ul//strong");
        public static By EscrowInstallmentAddButton = By.XPath("//div[@id='EscrowDisbursementInputs']//wipfli-button/button");

>>>>>>> fd8bca05ce759aa17d616f8dfd3e270e45c179c2
        public static By EscrowInstallmentGridEscrowNumber;
        public static By EscrowInstallmentGridEscrowDisbursmentType;    
        public static By EscrowInstallmentGridDate;
        public static By EscrowInstallmentGridAmount;
        public static void EscrowInstallmentGrid(int rowIndex)
        {
            EscrowInstallmentGridEscrowNumber = By.XPath("//section[@id='EscrowDisbursementGrid']//tr[" + rowIndex + "]/td[1]");
            EscrowInstallmentGridEscrowDisbursmentType = By.XPath("//section[@id='EscrowDisbursementGrid']//tr[" + rowIndex + "]/td[2]");
            EscrowInstallmentGridDate = By.XPath("//section[@id='EscrowDisbursementGrid']//tr[" + rowIndex + "]/td[3]");
            EscrowInstallmentGridAmount = By.XPath("//section[@id='EscrowDisbursementGrid']//tr[" + rowIndex + "]/td[4]");
        }


        //Prepaid Charges
        public static By OriginationChargePoints = By.XPath("//div[@title='Orig Charge - Points']//input");
        public static By OriginationChargeOther1 = By.XPath("//div[@title='Origination Charge Other 1']//input");
        public static By OriginationChargeOther2 = By.XPath("//div[@title='Origination Charge Other 2']//input");
        public static By OriginationChargeOther3 = By.XPath("//div[@title='Origination Charge Other 3']//input");
        public static By Courier = By.XPath("//div[@title='Courier']//input");
        public static By Flood = By.XPath("//div[@title='Flood']//input");
        public static By FHAUSDA = By.XPath("//div[@title='FHA/USDA']//input");
        public static By TaxServicing = By.XPath("//div[@title='Tax Servicing']//input");
        public static By UpfrontPMIVAGuarantee = By.XPath("//div[@title='Upfront PMI/VA Guarantee']//input");
        public static By SectionBOther1 = By.XPath("//div[@title='Section B - Other 1']//input");
        public static By SectionBOther2 = By.XPath("//div[@title='Section B - Other 2']//input");
        public static By TitleClosingProtectionLetter = By.XPath("//div[@title='Title - Closing protection letter']//input");
        public static By TitleClosingSettlement = By.XPath("//div[@title=' Title – Closing/Settlement']//input");
        public static By TitleCourierOverNight = By.XPath("//div[@title='Title – Courier/Overnight']//input");
        public static By TitleWire = By.XPath("//div[@title='Title - Wire']//input");
        public static By TitleOther1 = By.XPath("//div[@title='Title – Other 1']//input");
        public static By TitleOther2 = By.XPath("//div[@title='Title – Other 2']//input");
        public static By SectionCOther1 = By.XPath("//div[@title='Section C - Other 1']//input");
        public static By SectionCOther2 = By.XPath("//div[@title='Section C - Other 2']//input");
        public static By PrepaidDailyInterest = By.XPath("//div[@title='Prepaid Daily Interest']//input");
        public static By TotalMiInSectionFPrepaids = By.XPath("//div[@title='Total MI In Section F (Prepaids)']//input");
        public static By TotalMiInSectionGEscrow = By.XPath("//div[@title='Total MI In Section G (Escrow)']//input");
        public static By TotalLoanCostsSumABC = By.XPath("//div[@title='Total Loan Costs (A + B + C)']//input");
        public static By CustomNumber = By.XPath("//div[@id='PrepaidChargeGridInput']//div[@title='Number']//input");
        public static By CustomName = By.XPath("//div[@title='Custom Name']//input");
        public static By CustomValue = By.XPath("//div[@title='Custom Value']//input");
        public static By CustomFieldAddButton = By.XPath("//div[@id='PrepaidChargeGridInput']//button");
        public static By PrepaidChargeCustomGridCount = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr");
        public static By PrepaidChargeGridCustomName = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[1]//span");
        public static By PrepaidChargeGridCustomValue = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[2]//span");

    }
}
