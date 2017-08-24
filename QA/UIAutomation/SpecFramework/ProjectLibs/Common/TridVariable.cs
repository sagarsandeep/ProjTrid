using System;
using System.Collections.Generic;
using TechTalk.SpecRun.Helper;
using TRID.ActionClasses;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.Common
{
    public class TridVariable
    {
        #region Assiging Variables 

        public static string ScenarioNo = "";
        public static string CalculationMethod = "";
        public static string LoanType = "";
        public static string FrequencyOfPayments = "";
        public static string LoanTerm = "";
        public static string AdvanceType = "";
        public static string RepaymentTermType = "";
        public static string AmortizationPeriodMonths = "";
        public static string NumberOfMthsOrDaysInUnitPeriod = "";
        public static string NumberOfPayments = "";
        public static string UpfrontLoanFactor = "";
        public static string RateOfInterest = "";
        public static string LoanAmountOrCommitmentAmount = "";
        public static string BaseLoanAmount = "";
        public static string AnnualMip = "";
        public static string UpfrontMipFinanced = "";
        public static string DateOfLoan = "";
        public static string DateInterestBeginToAccrue = "";
        public static string DateOfFirstPayment = "";
        public static string PrincipalAndInterestPayment = "";
        public static string DailyInterestPaidAtClosing = "";
        public static string DropOffCriteria = "";
        public static string DropOffCriteriaValue = "";
        public static string LoanDetailsEstimatedEscrow = "";
        public static string DisclosedMonthlyPrincipalAndInterest = "";
        public static string DisclosedMortgageInsurance = "";
        public static string DisclosedEstimatedTotalMonthlyPayment = "";
        public static string DisclosedEstimatedEscrow = "";
        public static string DisclosedFinalOrBalloonPayment = "";
        public static string DisclosedTotalOfPayment = "";
        public static string DifferentFinalOrBalloonPayment = "";
        public static string EscrowedPropCostsOverYear1FromConsummationDate = "";
        public static string EscrowedPropertyCostsOverYear1FromDateOf1stLoanPayment = "";
        public static string NonEscrowPropertyOverYear1 = "";
        public static string InitialEscrowPayment = "";
        public static string PrincipalAndInt = "";
        public static string MortgageInsurance = "";
        public static string EstimatedTotalMonthlyPayment = "";
        public static string EstimatedEscrow = "";
        public static string FinanceCharge = "";
        public static string AmountFinanced = "";
        public static string Apr = "";
        public static string AprWin = "";
        public static string Tip = "";
        public static string EstimatedTaxesInsuranceAssessments = "";
        public static string ScheduledPmiTerminationDate = "";
        public static string PmiCancelDate = "";
        public static string UpfrontMip = "";
        public static string DiscLosedIn5Years = "";
        public static string DiscLosedIn5YearsPrincipal = "";
        public static string DisclosedApr = "";
        public static string DisclosedTip = "";
        public static string DisclosedPmiTerminationDate = "";
        public static string DisclosedPmiCancelDate = "";
        public static string DisclosedUpfrontMip = "";
        public static string In5Years = "";
        public static string In5YearsPrincipal = "";
        public static string FirstAddNumber = "";
        public static string FirstAddBeginPeriod = "";
        public static string FirstAddEndPeriod = "";
        public static string FirstAddPmiRate = "";
        public static string SecondAddNumber = "";
        public static string SecondAddBeginPeriod = "";
        public static string SecondAddEndPeriod = "";
        public static string SecondAddPmiRate = "";
        public static string ThirdAddNumber = "";
        public static string ThirdAddBeginPeriod = "";
        public static string ThirdAddEndPeriod = "";
        public static string ThirdAddPmiRate = "";
        public static string FrequencyOfDisbursement = "";
        public static string LowerOfCostOfAppraisal = "";
        public static string DateOfFirstMonthlyPmiDisbursement = "";
        public static string OriginationChargePoints = "";
        public static string OriginationChargeOther1 = "";
        public static string OriginationChargeOther2 = "";
        public static string OriginationChargeOther3 = "";
        public static string Courier = "";
        public static string Flood = "";
        public static string FHAUSDA= "";
        public static string TaxServicing= "";
        public static string UpfrontPMIVAGuarantee= "";
        public static string SectionBOther1= "";
        public static string SectionBOther2= "";
        public static string TitleClosingProtectionLetter= "";
        public static string TitleClosingSettlement= "";
        public static string TitleCourierOverNight= "";
        public static string TitleWire= "";
        public static string TitleOther1= "";
        public static string TitleOther2= "";
        public static string SectionCOther1= "";
        public static string SectionCOther2 = "";
        public static string PrepaidDailyInterest= "";
        public static string TotalMiInSectionFPrepaids= "";
        public static string TotalMiInSectionGEscrow= "";
        public static string LoanCostsSumABC= "";
        public static string PrepaidCustomFieldsNumber = "";
        public static string PrepaidCustomFieldsCustomName= "";
        public static string PrepaidCustomFieldsCustomValue= ""; 
        public static string DisclosedFinanceCharge = "";
        public static string DisclosedAmountFinanced ="";
        public static string LoanIdNumber = "";
        public static string BorrowersNames = "";
        public static string PreparedBy = "";
        public static string NameOfLender = "";
        public static string OriginalCreditor = "";
        public static string LoanSecruredBy = "";
        public static string Export = "";
        public static string DsclEscrowedPropertyCostsOverYearOne =	"";
        public static string DisclosedNonEscrowPropertyOverYearOne	=	"";
        public static string DisclosedInitialEscrowPayment	=	"";
        public static string DisclosedPeriodEscrowPayment	=	"";
        public static string DisclosedEstimatedTaxesInsuranceAssessments =	"";
        public static string InsuranceInfoAdjustmentBalance	=	"";
        public static string InsuranceInfoMinimumAmount	=	"";
        public static string InsuranceInfoCushionAmount	=	"";
        public static string InsuranceTotalInfoPeriodInsuranceAmount	=	"";
        public static string InsuranceTotalInfoInputInsuranceAmount	=	"";
        public static string TaxInfoAdjustmentBalance	=	"";
        public static string TaxInfoMinimumAmount	=	"";
        public static string TaxInfoCushionAmounts	=	"";
        public static string TaxTotalInfoPeriodTaxAmount	=	"";
        public static string TaxTotalInfoInputTaxAmount	=	"";
        public static string PmiInfoAdjustmentBalance	=	"";
        public static string PmiInfoMinimumAmount	=	"";
        public static string PmInfoCushionAmount	=	"";
        public static string PmiTotalInfoPeriodOmiAmount	=	"";
        public static string PmiTotalInfoInputTaxAmount	=	"";
        public static string AggregateInfoAdjustmentBalance	=	"";
        public static string AggregateInfoMinimumAmount	=	"";
        public static string AggregateInfoCushionAmount	=	"";
        public static string AggregateTotalInfoAgregatePayment	=	"";
        public static string AggregateTotalInfoAggregateDeposit	=	"";
        public static string TotalOfPayments = "";
        public static string FirstTermChange = "";
        public static string SubsequentTermChange = "";
        public static string DnRateCapFirstAdjustment = "";
        public static string DnRateCapsubsequentAdjustment = "";
        public static string UpRateCapFirstAdjustment = "";
        public static string UpRateCapsubsequentAdjustment = "";
        public static string FloorRate = "";
        public static string MaxRateEver = "";
        public static string Index = "";
        public static string Margin = "";
        public static string RoundingFactor = "";
        public static string VariancePrincipalAndInt = "";
        public static string VarianceMortgageInsurance = "";
        public static string VarianceEstimatedTotalMonthlyPayment = "";
        public static string VarianceFinanceCharge = "";
        public static string VarianceAmountFinanced = "";
        public static string VarianceApr = "";
        public static string VarianceTip = "";
        public static string VarianceIn5Years = "";
        public static string VarianceIn5YearsPrincipal = "";
        public static string VarianceDifferentFinalOrBalloonPayment = "";
        public static string VarianceEscrowedPropCostsOverYear1FromConsummationDate = "";
        public static string VarianceEscrowedPropertyCostsOverYear1FromDateOf1StLoanPayment = "";
        public static string VarianceNonEscrowPropertyOverYear1 = "";
        public static string VarianceInitialEscrowPayment = "";
        public static string VarianceEstimatedEscrow = "";
        public static string VarianceEstimatedTaxesInsuranceAssessments = "";
        public static string VarianceScheduledPmiTerminationDate = "";
        public static string VariancePmiCancelDate = "";
        public static string VarianceUpfrontMip = "";
        public static string VarianceTotalOfPayments = "";
        public static List<string> PaymentStreamNo = new List<string>();
        public static List<string> PaymentScheduleNumberOfPayments = new List<string>();
        public static List<string> PaymentAmount = new List<string>();
        public static List<string> PaymentSchedulePrincipalandInterestPayment = new List<string>();
        public static List<string> PaymentSchedulePmiPayement = new List<string>();
        public static List<string> InsEscrowedAmount = new List<string>();
        public static List<string> TaxEscrowedAmount = new List<string>();
        public static List<string> AbcPaymentStreamNo = new List<string>();
        public static List<string> AbcPaymentScheduleNumberOfPayments = new List<string>();
        public static List<string> AbcPaymentAmount = new List<string>();
        public static List<string> AbcPaymentSchedulePrincipalAndInterestPayment = new List<string>();
        public static List<string> AbcPaymentSchedulePmiPayment = new List<string>();
        public static List<string> AbcInsEscrowedAmount = new List<string>();
        public static List<string> AbcTaxEscrowedAmount = new List<string>();
        public static List<string> AwcPaymentStreamNo = new List<string>();
        public static List<string> AwcPaymentScheduleNumberOfPayments = new List<string>();
        public static List<string> AwcPaymentAmount = new List<string>();
        public static List<string> AwcPaymentSchedulePeriodPayment = new List<string>();
        public static List<string> AwcPaymentSchedulePeriodPmi = new List<string>();
        public static List<string> AwcInsEscrowedAmount = new List<string>();
        public static List<string> AwcTaxEscrowedAmount = new List<string>();
        public static string InsInitialDeposit = "";
        public static string InsPeriodDeposit = "";
        public static string InsLowBalance = "";
        public static string InsCushion = "";
        public static string InsTotalAnnualDisbursed = "";
        public static string TaxInitialDeposit = "";
        public static string TaxPeriodDeposit = "";
        public static string TaxLowBalance = "";
        public static string TaxCushion = "";
        public static string TaxTotalAnnualDisbursed = "";
        public static string PmiInitialDeposit = "";
        public static string PmiPeriodDeposit = "";
        public static string PmiLowBalance = "";
        public static string PmiCushion = "";
        public static string PmiTotalAnnualDisbursed = "";
        public static string Other1InitialDeposit = "";
        public static string Other1PeriodDeposit = "";
        public static string Other1LowBalance = "";
        public static string Other1Cushion = "";
        public static string Other1TotalAnnualDisbursed = "";
        public static string Other2InitialDeposit = "";
        public static string Other2PeriodDeposit = "";
        public static string Other2LowBalance = "";
        public static string Other2Cushion = "";
        public static string Other2TotalAnnualDisbursed = "";
        public static string AggregateInitialDeposit = "";
        public static string AggregatePeriodDeposit = "";
        public static string AggregateLowBalance = "";
        public static string AggregateCushion = "";
        public static string AggregateTotalAnnualDisbursed = "";      

        public static int NumberOfRowCounts = 0;
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs1 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs2 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs3 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs4 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs5 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs6 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs7 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostsGridInputs8 = new Dictionary<string, string>();

        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs1 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs2 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs3 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs4 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs5 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs6 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs7 = new Dictionary<string, string>();
        public static Dictionary<string, string> EscrowPropertyCostInstallmentsGridInputs8 = new Dictionary<string, string>();


        #endregion

        public void GetVariableNameAndSetValues(int row, int col, string stringValue, string sheetName)
        {
            #region Closing Disclosure

            if (sheetName == "ClosingDisclosure")
            {
                if (col == 1 ) ScenarioNo = stringValue;
                if (col == 4 ) LoanType = stringValue;
                if (col == 5 ) CalculationMethod = stringValue;              
                if (col == 6 ) FrequencyOfPayments = stringValue;
                if (col == 7 ) NumberOfMthsOrDaysInUnitPeriod = stringValue;
                if (col == 8 ) LoanTerm = stringValue;
                if (col == 9 ) AmortizationPeriodMonths = stringValue;
                if (col == 10) NumberOfPayments = stringValue;
                if (col == 11) AdvanceType = stringValue;
                if (col == 12) RepaymentTermType = stringValue;
                if (col == 13) RateOfInterest = stringValue;
                if (col == 14) LoanAmountOrCommitmentAmount = stringValue;                                        
                if (col == 15) DateOfLoan = stringValue;
                if (col == 16) DateInterestBeginToAccrue = stringValue;
                if (col == 17) DateOfFirstPayment = stringValue;
                if (col == 18) PrincipalAndInterestPayment = stringValue;
                if (col == 19) DailyInterestPaidAtClosing = stringValue;
                if (col == 20) BaseLoanAmount = stringValue;
                if (col == 21) UpfrontLoanFactor = stringValue;
                if (col == 22) AnnualMip = stringValue;
                if (col == 23) UpfrontMipFinanced = stringValue;
                if (col == 24) DisclosedMonthlyPrincipalAndInterest = stringValue;
                if (col == 25) DisclosedMortgageInsurance = stringValue;
                if (col == 27) DisclosedPeriodEscrowPayment = stringValue;
                if (col == 28) DisclosedEstimatedTotalMonthlyPayment = stringValue;
                if (col == 29) DisclosedFinalOrBalloonPayment = stringValue;
                if (col == 30) DisclosedEstimatedTaxesInsuranceAssessments = stringValue;
                if (col == 31) DsclEscrowedPropertyCostsOverYearOne = stringValue;
                if (col == 32) DisclosedNonEscrowPropertyOverYearOne = stringValue;
                if (col == 33) DisclosedInitialEscrowPayment = stringValue;
                if (col == 34) DisclosedTotalOfPayment = stringValue;
                if (col == 35) DisclosedFinanceCharge = stringValue;
                if (col == 36) DisclosedAmountFinanced = stringValue;
                if (col == 37) DisclosedApr = stringValue;
                if (col == 38) DisclosedTip = stringValue;
                if (col == 39) DisclosedPmiTerminationDate = stringValue;
                if (col == 40) DisclosedPmiCancelDate = stringValue;
                if (col == 41) DisclosedUpfrontMip = stringValue;
                if (col == 42) DiscLosedIn5Years = stringValue;
                if (col == 43) DiscLosedIn5YearsPrincipal = stringValue;              
                if (col == 44) PrincipalAndInt = stringValue;
                if (col == 45) MortgageInsurance = stringValue;
                if (col == 46) EstimatedTotalMonthlyPayment = stringValue;
                if (col == 47) Apr = stringValue;
                if (col == 48) AprWin = stringValue;
                if (col == 49) DifferentFinalOrBalloonPayment = stringValue;
                if (col == 50) TotalOfPayments = stringValue;
                if (col == 51) FinanceCharge = stringValue;
                if (col == 52) AmountFinanced = stringValue;
                if (col == 53) Tip = stringValue;
                if (col == 54) EscrowedPropCostsOverYear1FromConsummationDate = stringValue;
                if (col == 55) EscrowedPropertyCostsOverYear1FromDateOf1stLoanPayment = stringValue;
                if (col == 56) InitialEscrowPayment = stringValue;
                if (col == 57) NonEscrowPropertyOverYear1 = stringValue;
                if (col == 58) EstimatedEscrow = stringValue;
                if (col == 59) EstimatedTaxesInsuranceAssessments = stringValue;
                if (col == 60) ScheduledPmiTerminationDate = stringValue;
                if (col == 61) PmiCancelDate = stringValue;
                if (col == 62) UpfrontMip = stringValue;
                if (col == 63) In5Years = stringValue;
                if (col == 64) In5YearsPrincipal = stringValue;
                if (col == 65) VariancePrincipalAndInt = stringValue;
                if (col == 66) VarianceMortgageInsurance = stringValue;
                if (col == 67) VarianceEstimatedTotalMonthlyPayment = stringValue;
                if (col == 68) VarianceApr = stringValue;
                if (col == 69) VarianceDifferentFinalOrBalloonPayment = stringValue;
                if (col == 70) VarianceTotalOfPayments = stringValue;
                if (col == 71) VarianceFinanceCharge = stringValue;
                if (col == 72) VarianceAmountFinanced = stringValue;
                if (col == 73) VarianceTip = stringValue;
                if (col == 74) VarianceEscrowedPropCostsOverYear1FromConsummationDate = stringValue;
                if (col == 75) VarianceEscrowedPropertyCostsOverYear1FromDateOf1StLoanPayment = stringValue;
                if (col == 76) VarianceInitialEscrowPayment = stringValue;
                if (col == 77) VarianceNonEscrowPropertyOverYear1 = stringValue;
                if (col == 78) VarianceEstimatedEscrow = stringValue;
                if (col == 79) VarianceEstimatedTaxesInsuranceAssessments = stringValue;
                if (col == 80) VarianceScheduledPmiTerminationDate = stringValue;
                if (col == 81) VariancePmiCancelDate = stringValue;
                if (col == 82) VarianceUpfrontMip = stringValue;
                if (col == 83) VarianceIn5Years = stringValue;
                if (col == 84) VarianceIn5YearsPrincipal = stringValue;
            }

            #endregion

            #region Prepaid Charges

            if (sheetName == "PrepaidCharges")
            {
                if (col == 4) OriginationChargePoints = stringValue;
                if (col == 5) OriginationChargeOther1 = stringValue;
                if (col == 6) OriginationChargeOther2 = stringValue;
                if (col == 7) OriginationChargeOther3 = stringValue;
                if (col == 8) Courier = stringValue;
                if (col == 9) Flood = stringValue;
                if (col == 10) FHAUSDA= stringValue;
                if (col == 11) TaxServicing= stringValue;
                if (col == 12) UpfrontPMIVAGuarantee= stringValue;
                if (col == 13) SectionBOther1= stringValue;
                if (col == 14) SectionBOther2= stringValue;
                if (col == 15) TitleClosingProtectionLetter= stringValue;
                if (col == 16) TitleClosingSettlement= stringValue;
                if (col == 17) TitleCourierOverNight= stringValue;
                if (col == 18) TitleWire= stringValue;
                if (col == 19) TitleOther1= stringValue;
                if (col == 20) TitleOther2= stringValue;
                if (col == 21) SectionCOther1= stringValue;
                if (col == 22) SectionCOther2 = stringValue;
                if (col == 23) PrepaidDailyInterest= stringValue;
                if (col == 24) TotalMiInSectionFPrepaids= stringValue;
                if (col == 25) TotalMiInSectionGEscrow= stringValue;            
                if (col == 26) PrepaidCustomFieldsNumber = stringValue;
                if (col == 27) PrepaidCustomFieldsCustomName = stringValue;
                if (col == 28) PrepaidCustomFieldsCustomValue = stringValue;
                if (col == 29) LoanCostsSumABC = stringValue;
            }              

            #endregion

            #region Mortgage Insurance

            if (sheetName == "MortgageInsurance")
            {               
                if (col == 2)
                {
                    var splitString = stringValue.Split(',');
                    FirstAddNumber = splitString[0];
                    FirstAddBeginPeriod = splitString[1];
                    FirstAddEndPeriod = splitString[2];
                    FirstAddPmiRate = splitString[3];
                }
                if (col == 3)
                {
                    var splitString = stringValue.Split(',');
                    SecondAddNumber = splitString[0];
                    SecondAddBeginPeriod = splitString[1];
                    SecondAddEndPeriod = splitString[2];
                    SecondAddPmiRate = splitString[3];
                }
                if (col == 4)
                {
                    var splitString = stringValue.Split(',');
                    ThirdAddNumber = splitString[0];
                    ThirdAddBeginPeriod = splitString[1];
                    ThirdAddEndPeriod = splitString[2];
                    ThirdAddPmiRate = splitString[3];
                }         

                if (col == 5) FrequencyOfDisbursement = stringValue;
                if (col == 6) DateOfFirstMonthlyPmiDisbursement = stringValue;
                if (col == 7) LowerOfCostOfAppraisal = stringValue;            
                if (col == 8) DropOffCriteria = stringValue;
                if (col == 9) DropOffCriteriaValue = stringValue;
            }              
                           
            #endregion

            #region Export

            if (sheetName == "Export")
            {
                if (col == 2) LoanIdNumber = stringValue;
                if (col == 3) BorrowersNames = stringValue;
                if (col == 4) PreparedBy = stringValue;
                if (col == 5) NameOfLender = stringValue;
                if (col == 6) OriginalCreditor = stringValue;
                if (col == 7) LoanSecruredBy = stringValue;
                if (col == 8) Export = stringValue;
            }

            #endregion

            #region ARM Terms

            if (sheetName == "ARMTerms")
            {
                if (col == 3)  FirstTermChange = stringValue;
                if (col == 4)  SubsequentTermChange = stringValue;
                if (col == 5)  DnRateCapFirstAdjustment = stringValue;
                if (col == 6)  DnRateCapsubsequentAdjustment = stringValue;
                if (col == 7)  UpRateCapFirstAdjustment = stringValue;
                if (col == 8)  UpRateCapsubsequentAdjustment = stringValue;
                if (col == 9)  FloorRate = stringValue;
                if (col == 10) MaxRateEver = stringValue;
                if (col == 11) Index = stringValue;
                if (col == 12) Margin = stringValue;
                if (col == 13) RoundingFactor = stringValue;
            }

            #endregion

            #region Payment Schedule

            if (sheetName == "PaymentSchedule")
            {
                if (col == 1) ScenarioNo = stringValue;
                if (col == 2)
                {
                    PaymentStreamNo = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentStreamNo.Add(rowValue);
                }

                if (col == 3)
                {
                    PaymentScheduleNumberOfPayments = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentScheduleNumberOfPayments.Add(rowValue);
                }
                if (col == 4)
                {
                    PaymentAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentAmount.Add(rowValue);
                }
                if (col == 5)
                {
                    PaymentSchedulePrincipalandInterestPayment = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentSchedulePrincipalandInterestPayment.Add(rowValue);
                }
                if (col == 6)
                {
                    PaymentSchedulePmiPayement = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentSchedulePmiPayement.Add(rowValue);
                }
                if (col == 7)
                {
                    InsEscrowedAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        InsEscrowedAmount.Add(rowValue);
                }
                if (col == 8)
                {
                    TaxEscrowedAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        TaxEscrowedAmount.Add(rowValue);
                }
            }

            #endregion       

            #region Escrow Info

            if (sheetName == "EscrowInfo")
            {
                if (col == 1) ScenarioNo = stringValue;
                if (col == 2) InsInitialDeposit = stringValue;
                if (col == 3) InsPeriodDeposit = stringValue;
                if (col == 4) InsLowBalance = stringValue;
                if (col == 5) InsCushion = stringValue;
                if (col == 6) InsTotalAnnualDisbursed = stringValue;
                if (col == 7) TaxInitialDeposit = stringValue;
                if (col == 8) TaxPeriodDeposit = stringValue;
                if (col == 9) TaxLowBalance = stringValue;
                if (col == 10) TaxCushion = stringValue;
                if (col == 11) TaxTotalAnnualDisbursed = stringValue;
                if (col == 12) PmiInitialDeposit = stringValue;
                if (col == 13) PmiPeriodDeposit = stringValue;
                if (col == 14) PmiLowBalance = stringValue;
                if (col == 15) PmiCushion = stringValue;
                if (col == 16) PmiTotalAnnualDisbursed = stringValue;
                if (col == 17) Other1InitialDeposit = stringValue;
                if (col == 18) Other1PeriodDeposit = stringValue;
                if (col == 19) Other1LowBalance = stringValue;
                if (col == 20) Other1Cushion = stringValue;
                if (col == 21) Other1TotalAnnualDisbursed = stringValue;
                if (col == 22) Other2InitialDeposit = stringValue;
                if (col == 23) Other2PeriodDeposit = stringValue;
                if (col == 24) Other2LowBalance = stringValue;
                if (col == 25) Other2Cushion = stringValue;
                if (col == 26) Other2TotalAnnualDisbursed = stringValue;
                if (col == 27) AggregateInitialDeposit = stringValue;
                if (col == 28) AggregatePeriodDeposit = stringValue;
                if (col == 29) AggregateLowBalance = stringValue;
                if (col == 30) AggregateCushion = stringValue;
                if (col == 32) AggregateTotalAnnualDisbursed = stringValue;
            }

            #endregion
            
            #region New Escrow Development

            if (sheetName == "EscrowGrid")
            {
                if (col == 2)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs1.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs1.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs1.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 3)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs2.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs2.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs2.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 4)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs3.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs3.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs3.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 5)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs4.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs4.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs4.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 6)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs5.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs5.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs5.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 7)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs6.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs6.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs6.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 8)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs7.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs7.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs7.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 9)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostsGridInputs8.Add("PropertyCostType", splitString[0]);
                        EscrowPropertyCostsGridInputs8.Add("Escrowed", splitString[1]);
                        EscrowPropertyCostsGridInputs8.Add("Cushion", splitString[2]);
                        NumberOfRowCounts += 1;
                    }


                if (col == 10)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs1.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs1.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs1.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs1.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs1.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 11)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs2.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs2.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs2.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs2.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs2.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 12)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs3.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs3.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs3.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs3.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs3.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 13)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs4.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs4.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs4.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs4.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs4.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 14)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs5.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs5.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs5.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs5.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs5.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 15)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs6.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs6.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs6.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs6.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs6.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 16)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs7.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs7.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs7.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs7.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs7.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }

                if (col == 17)
                    if (stringValue != "")
                    {
                        var splitString = stringValue.Split(',');
                        EscrowPropertyCostInstallmentsGridInputs8.Add("Number", splitString[0]);
                        EscrowPropertyCostInstallmentsGridInputs8.Add("Amount", splitString[1]);
                        EscrowPropertyCostInstallmentsGridInputs8.Add("DatePaid/Disbursed", splitString[2]);
                        EscrowPropertyCostInstallmentsGridInputs8.Add("PropertyCostType", splitString[3]);
                        EscrowPropertyCostInstallmentsGridInputs8.Add("VoluntaryContribution", splitString[4]);
                        NumberOfRowCounts += 1;
                    }
            }

            #endregion

            #region Arm Best Case

            if (sheetName == "ARMBestCase")
            {
                if (col == 1) ScenarioNo = stringValue;
                if (col == 2)
                {
                    AbcPaymentStreamNo = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcPaymentStreamNo.Add(rowValue);
                }

                if (col == 3)
                {
                    AbcPaymentScheduleNumberOfPayments = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcPaymentScheduleNumberOfPayments.Add(rowValue);
                }
                if (col == 4)
                {
                    AbcPaymentAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcPaymentAmount.Add(rowValue);
                }
                if (col == 5)
                {
                    AbcPaymentSchedulePrincipalAndInterestPayment = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcPaymentSchedulePrincipalAndInterestPayment.Add(rowValue);
                }
                if (col == 6)
                {
                    AbcPaymentSchedulePmiPayment = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcPaymentSchedulePmiPayment.Add(rowValue);
                }
                if (col == 7)
                {
                    AbcInsEscrowedAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcInsEscrowedAmount.Add(rowValue);
                }
                if (col == 8)
                {
                    AbcTaxEscrowedAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AbcTaxEscrowedAmount.Add(rowValue);
                }
            }

            #endregion

            #region Arm Worst Case

            if (sheetName == "ARMWorstCase")
            {
                if (col == 1) ScenarioNo = stringValue;
                if (col == 2)
                {
                    AwcPaymentStreamNo = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcPaymentStreamNo.Add(rowValue);
                }

                if (col == 3)
                {
                    AwcPaymentScheduleNumberOfPayments = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcPaymentScheduleNumberOfPayments.Add(rowValue);
                }
                if (col == 4)
                {
                    AwcPaymentAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcPaymentAmount.Add(rowValue);
                }
                if (col == 5)
                {
                    AwcPaymentSchedulePeriodPayment = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcPaymentSchedulePeriodPayment.Add(rowValue);
                }
                if (col == 6)
                {
                    AwcPaymentSchedulePeriodPmi = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcPaymentSchedulePeriodPmi.Add(rowValue);
                }
                if (col == 7)
                {
                    AwcInsEscrowedAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcInsEscrowedAmount.Add(rowValue);
                }
                if (col == 8)
                {
                    AwcTaxEscrowedAmount = new List<string>();
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        AwcTaxEscrowedAmount.Add(rowValue);
                }
            }

            #endregion

        }
    }
}