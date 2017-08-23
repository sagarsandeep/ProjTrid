using System;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;


namespace TRID.StepDefinitions
{
    [Binding]
    public class CardsValidationSteps : TridTest
    {
        private static string Url => ConfigurationManager.AppSettings["url"];
        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public double ValueDifference;
        public static string CardsFailure = "";


        #region Given
       
        [Given(@"user is at TRID application homepage")]
        public void GivenUserIsAtTridApplicationHomepage()
        {
            UIActions.WindowMaximize();
            UIActions.GoToUrl(Url);
            UIActions.WebDriverWait(StartNewLoanText, 60, "StartNewLoanText");
            UIActions.Click(ResetButton);
        }           

        [Given(@"user have closing disclosure data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveClosingDisclosureDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
            ProjActions.GetSheetName(sheetName);
            //ProjActions.CreateCsvCardsHeaderFile();
        }

        [Given(@"user have Mortgage Insurance data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveMortgageInsuranceDataFromExcelSheetForTheScenarioMortgageInsurance(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have variable loan data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveVariableLoanDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Prepaid Charges data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHavePrepaidChargesDataFromExcelSheetPrepaidChargesForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Escrow data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveEscrowDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
            ProjActions.GetSheetName(sheetName);
        }

        [Given(@"user have Export data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveExportDataFromExcelSheetExportForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Escrow Grid data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveEscrowGridDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }


        #endregion


        #region When

        [When(@"user navigate to Loan Inputs Page")]
        public void WhenUserNavigateToLoanInputsPage()
        {
            UIActions.Click(LoanInputsLink);
            UIActions.WebDriverWait(LoanDetailsText, 60, "LoanDetailsText");
        }

        [When(@"user navigate to Amortization Page")]
        public void WhenUserNavigateToAmortizationPage()
        {
            UIActions.Click(AmortizationLink);
            UIActions.WebDriverWait(AmortizationPaymentScheduleText, 60, "AmortizationPaymentScheduleText");
        }

        [When(@"user selects Calculation Method")]
        public void WhenUserSelectsCalculationMethodInClosingDisclosurePage()
        {
            LoanInputRadioButtonVariable();
            UIActions.WebDriverWait(CalculationMethod, 60, "CalculationMethod");
            UIActions.Click(CalculationMethod);         
        }

        [When(@"user selects loan type")]
        public void WhenUserSelectsLoanTypeInClosingDisclosurePage()
        {
            LoanInputRadioButtonVariable();
            UIActions.Click(LoanType);

            if (TridVariable.LoanType.Equals("Variable"))
            {
                UIActions.Clear(FirstTermChange);
                UIActions.GiveInput(FirstTermChange, TridVariable.FirstTermChange);

                UIActions.Clear(SubsequentTermChange);
                UIActions.GiveInput(SubsequentTermChange, TridVariable.SubsequentTermChange);

                UIActions.Clear(DnRateCapFirstAdjustment);
                UIActions.GiveInput(DnRateCapFirstAdjustment, TridVariable.DnRateCapFirstAdjustment);

                UIActions.Clear(DnRateCapSubseqAdjustment);
                UIActions.GiveInput(DnRateCapSubseqAdjustment, TridVariable.DnRateCapsubsequentAdjustment);

                UIActions.Clear(UpRateCapFirstAdjustment);
                UIActions.GiveInput(UpRateCapFirstAdjustment, TridVariable.UpRateCapFirstAdjustment);

                UIActions.Clear(UpRateCapSubseqAdjustment);
                UIActions.GiveInput(UpRateCapSubseqAdjustment, TridVariable.UpRateCapsubsequentAdjustment);

                UIActions.Clear(FloorRate);
                UIActions.GiveInput(FloorRate, TridVariable.FloorRate);

                UIActions.Clear(MaxRateEver);
                UIActions.GiveInput(MaxRateEver, TridVariable.MaxRateEver);

                UIActions.Clear(Index);
                UIActions.GiveInput(Index, TridVariable.Index);

                UIActions.Clear(Margin);
                UIActions.GiveInput(Margin, TridVariable.Margin);

                UIActions.Clear(RoundingFactor);
                UIActions.GiveInput(RoundingFactor, TridVariable.RoundingFactor);
            }
        }

        [When(@"user selects Frequency of Payments")]
        public void WhenUserSelectsFrequencyOfPaymentsInClosingDisclosurePage()
        {
            LoanInputRadioButtonVariable();
            UIActions.ScrollUp();
            UIActions.Click(FrequencyOfPayments);
        }

        [When(@"user selects Loan Term")]
        public void WhenUserSelectsLoanTermInClosingDisclosurePage()
        {
            LoanInputRadioButtonVariable();
            UIActions.Click(LoanTerm);
        }

        [When(@"user selects Repayment Term Type")]
        public void WhenUserSelectsRepaymentTermTypeInClosingDisclosurePage()
        {
            LoanInputRadioButtonVariable();
            UIActions.Click(RepaymentTermType);
        }

        [When(@"user enters Loan detail input values for computation")]
        public void WhenUserEntersLoanDetailInputValuesForComputationforClosingDisclosurepage()
        {
            UIActions.Clear(DateOfLoan);
            UIActions.GiveInput(DateOfLoan, ProjActions.GetDate(TridVariable.DateOfLoan));

            UIActions.Clear(DateOfInterestBegins);
            UIActions.GiveInput(DateOfInterestBegins, ProjActions.GetDate(TridVariable.DateInterestBeginToAccrue));

            UIActions.Clear(DateOfFirstPayment);
            UIActions.GiveInput(DateOfFirstPayment, ProjActions.GetDate(TridVariable.DateOfFirstPayment));

            UIActions.Clear(NumberOfMonthsOrDaysInUnitPeriodValue);
            UIActions.GiveInput(NumberOfMonthsOrDaysInUnitPeriodValue, TridVariable.NumberOfMthsOrDaysInUnitPeriod);

            UIActions.Clear(AmortizationPeriodMonthsValue);
            UIActions.GiveInput(AmortizationPeriodMonthsValue, TridVariable.AmortizationPeriodMonths);

            UIActions.Clear(NumberOfPayments);
            UIActions.GiveInput(NumberOfPayments, TridVariable.NumberOfPayments);          

            UIActions.Clear(RateOfInterest);
            UIActions.GiveInput(RateOfInterest, TridVariable.RateOfInterest);

            UIActions.Clear(LoanAmountOrCommitmentAmount);
            UIActions.GiveInput(LoanAmountOrCommitmentAmount, TridVariable.LoanAmountOrCommitmentAmount);

            UIActions.Clear(PrincipalAndInterestPayment);
            UIActions.GiveInput(PrincipalAndInterestPayment, TridVariable.PrincipalAndInterestPayment);

            LoanInputRadioButtonVariable();
            UIActions.Click(DailyInterestPaidatClosing);         
        }

        [When(@"User selects Product Type")]
        public void WhenUserSelectsProductType()
        {
            LoanInputRadioButtonVariable();
            UIActions.ScrollUp();
            UIActions.Click(ProductType);

            if (TridVariable.ProductType.Equals("Variable Rate"))
            {
                UIActions.Clear(FirstTermChange);
                UIActions.GiveInput(FirstTermChange, TridVariable.FirstTermChange);

                UIActions.Clear(SubsequentTermChange);
                UIActions.GiveInput(SubsequentTermChange, TridVariable.SubsequentTermChange);

                UIActions.Clear(DnRateCapFirstAdjustment);
                UIActions.GiveInput(DnRateCapFirstAdjustment, TridVariable.DnRateCapFirstAdjustment);

                UIActions.Clear(DnRateCapSubseqAdjustment);
                UIActions.GiveInput(DnRateCapSubseqAdjustment, TridVariable.DnRateCapsubsequentAdjustment);

                UIActions.Clear(UpRateCapFirstAdjustment);
                UIActions.GiveInput(UpRateCapFirstAdjustment, TridVariable.UpRateCapFirstAdjustment);

                UIActions.Clear(UpRateCapSubseqAdjustment);
                UIActions.GiveInput(UpRateCapSubseqAdjustment, TridVariable.UpRateCapsubsequentAdjustment);

                UIActions.Clear(FloorRate);
                UIActions.GiveInput(FloorRate, TridVariable.FloorRate);

                UIActions.Clear(MaxRateEver);
                UIActions.GiveInput(MaxRateEver, TridVariable.MaxRateEver);

                UIActions.Clear(Index);
                UIActions.GiveInput(Index, TridVariable.Index);

                UIActions.Clear(Margin);
                UIActions.GiveInput(Margin, TridVariable.Margin);

                UIActions.Clear(RoundingFactor);
                UIActions.GiveInput(RoundingFactor, TridVariable.RoundingFactor);
            }
        }

        [When(@"user enters all input values for Prepaid Charges")]
        public void WhenUserEntersAllInputValuesForPrepaidCharges()
        {       
            UIActions.Clear(OriginationChargePoints);
            UIActions.GiveInput(OriginationChargePoints, TridVariable.OriginationChargePoints);

            UIActions.Clear(OriginationChargeOther1);
            UIActions.GiveInput(OriginationChargeOther1, TridVariable.OriginationChargeOther1);

            UIActions.Clear(OriginationChargeOther2);
            UIActions.GiveInput(OriginationChargeOther2, TridVariable.OriginationChargeOther2);

            UIActions.Clear(OriginationChargeOther3);
            UIActions.GiveInput(OriginationChargeOther3, TridVariable.OriginationChargeOther3);

            UIActions.Clear(Courier);
            UIActions.GiveInput(Courier, TridVariable.Courier);

            UIActions.Clear(Flood);
            UIActions.GiveInput(Flood, TridVariable.Flood);

            UIActions.Clear(FHAUSDA);
            UIActions.GiveInput(FHAUSDA, TridVariable.FHAUSDA);

            UIActions.Clear(TaxServicing);
            UIActions.GiveInput(TaxServicing, TridVariable.TaxServicing);

            UIActions.Clear(UpfrontPMIVAGuarantee);
            UIActions.GiveInput(UpfrontPMIVAGuarantee, TridVariable.UpfrontPMIVAGuarantee);

            UIActions.Clear(SectionBOther1);
            UIActions.GiveInput(SectionBOther1, TridVariable.SectionBOther1);

            UIActions.Clear(SectionBOther2);
            UIActions.GiveInput(SectionBOther2, TridVariable.SectionBOther2);

            UIActions.Clear(TitleClosingProtectionLetter);
            UIActions.GiveInput(TitleClosingProtectionLetter, TridVariable.TitleClosingProtectionLetter);

            UIActions.Clear(TitleClosingSettlement);
            UIActions.GiveInput(TitleClosingSettlement, TridVariable.TitleClosingSettlement);

            UIActions.Clear(TitleCourierOverNight);
            UIActions.GiveInput(TitleCourierOverNight, TridVariable.TitleCourierOverNight);

            UIActions.Clear(TitleWire);
            UIActions.GiveInput(TitleWire, TridVariable.TitleWire);

            UIActions.Clear(TitleOther1);
            UIActions.GiveInput(TitleOther1, TridVariable.TitleOther1);
       
            UIActions.Clear(TitleOther2);
            UIActions.GiveInput(TitleOther2, TridVariable.TitleOther2);
 
            UIActions.Clear(SectionCOther1);
            UIActions.GiveInput(SectionCOther1, TridVariable.SectionCOther1);

            UIActions.Clear(SectionCOther2);
            UIActions.GiveInput(SectionCOther2, TridVariable.SectionCOther2);

            UIActions.Clear(PrepaidDailyInterest);
            UIActions.GiveInput(PrepaidDailyInterest, TridVariable.PrepaidDailyInterest);

            UIActions.Clear(TotalMiInSectionFPrepaids);
            UIActions.GiveInput(TotalMiInSectionFPrepaids, TridVariable.TotalMiInSectionFPrepaids);

            UIActions.Clear(TotalMiInSectionGEscrow);
            UIActions.GiveInput(TotalMiInSectionGEscrow, TridVariable.TotalMiInSectionGEscrow);

            UIActions.Clear(TotalLoanCostsSumABC);
            UIActions.GiveInput(TotalLoanCostsSumABC, TridVariable.LoanCostsSumABC);
        }

        [When(@"user enters input value for prepaid custom fields")]
        public void WhenUserEntersInputValueForPrepaidCustomFields()
        {
            ProjActions.AddPrepaidCustomValues();
        }

        [When(@"user navigates to MI Inputs and Results Page")]
        public void WhenUserNavigatesToMiInputsAndResultsPage()
        {
            UIActions.Click(MiInputsResultsLink);
            UIActions.WebDriverWait(AddPmiRateText, 60, "MiInputsAndResults");
        }

        [When(@"user enters pmi rate values")]
        public void WhenUserEntersPmiRateValues()
        {
            ProjActions.AddPmiRateValues();
            ProjActions.PmiRatesGridValidation();
        }

        [When(@"user enters other pmi input values")]
        public void WhenUserEntersOtherPmiInputValues()
        {
            if (TridVariable.FirstAddNumber != "")
            {
                MiRadioButtonVariable();
                UIActions.Click(FrequencyOfDisbursement);

                UIActions.Clear(LowerOfCostOrAppraisal);
                UIActions.GiveInput(LowerOfCostOrAppraisal, TridVariable.LowerOfCostOfAppraisal);

                UIActions.Clear(DateOfFirstMonthlyPmiDisbursement);
                UIActions.GiveInput(DateOfFirstMonthlyPmiDisbursement,
                ProjActions.GetDate(TridVariable.DateOfFirstMonthlyPmiDisbursement));
            }

            MiRadioButtonVariable();
            UIActions.Click(PmiorMipTerminationCriteria);

            UIActions.Clear(PmiorMipTerminationValue);
            UIActions.GiveInput(PmiorMipTerminationValue, TridVariable.PmiorMipTerminationValue);
        }

        [When(@"user enters FHA/USDA Loan Details")]
        public void WhenUserEntersFHAOrUSDALoanDetails()
        {
            UIActions.Clear(BaseLoanAmount);
            UIActions.GiveInput(BaseLoanAmount, TridVariable.BaseLoanAmount);

            UIActions.Clear(UpfrontLoanFactor);
            UIActions.GiveInput(UpfrontLoanFactor, TridVariable.UpfrontLoanFactor);

            UIActions.Clear(AnnualMip);
            UIActions.GiveInput(AnnualMip, TridVariable.AnnualMip);

            MiRadioButtonVariable();
            UIActions.Click(UpfrontMipFinanced);
        }

        [When(@"user enters disclosed input values for Mortgage Insurance")]
        public void WhenUserEntersDisclosedInputValuesForMortgageInsurance()
        {
            UIActions.Clear(DisclosedPmiTerminalDate);
            UIActions.GiveInput(DisclosedPmiTerminalDate, ProjActions.GetDate(TridVariable.DisclosedPmiTerminationDate));

            UIActions.Clear(DisclosedPmiCancelDate);
            UIActions.GiveInput(DisclosedPmiCancelDate, ProjActions.GetDate(TridVariable.DisclosedPmiCancelDate));

            UIActions.Clear(DisclosedUpfrontMip);
            UIActions.GiveInput(DisclosedUpfrontMip, TridVariable.DisclosedUpfrontMip);

            UIActions.Click(ReCalculateButton);
            Thread.Sleep(1000);
        }



        [When(@"user enters Escrow Grid Input values")]
        public void WhenUserEntersEscrowGridInputValues()
        {
            ProjActions.AddEscrowGridValues();
        }


        [When(@"user navigates to Disclosure Inputs Page")]
        public void WhenUserNavigatesToDisclosureInputsPage()
        {
            UIActions.Click(CdInputsLink);
            UIActions.WebDriverWait(DisclosedValuesText, 60, "DisclosedValuesText");
        }

        [When(@"user enters disclosed input values for Closing Disclosure Loan Terms & Projected Payments")]
        public void WhenUserEntersDisclosedInputValuesForClosingDisclosureLoanTermsProjectedPayments()
        {
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, TridVariable.DisclosedMonthlyPrincipalAndInterest);

            UIActions.Clear(DisclosedMortgageInsurance);
            UIActions.GiveInput(DisclosedMortgageInsurance, TridVariable.DisclosedMortgageInsurance);

            UIActions.Clear(DisclosedPeriodEscrowPayment);
            UIActions.GiveInput(DisclosedPeriodEscrowPayment, TridVariable.DisclosedPeriodEscrowPayment);

            UIActions.Clear(DisclosedEstimatedTotalMonthlyPayment);
            UIActions.GiveInput(DisclosedEstimatedTotalMonthlyPayment, TridVariable.DisclosedEstimatedTotalMonthlyPayment);

            UIActions.Clear(DisclosedDifferentFinalBalloonPayment);
            UIActions.GiveInput(DisclosedDifferentFinalBalloonPayment, TridVariable.DisclosedFinalOrBalloonPayment);
        }
      

        [When(@"user enters disclosed input values for Closing Disclosure Loan Calculations")]
        public void WhenUserEntersDisclosedInputValuesForClosingDisclosureLoanCalculations()
        {
            UIActions.Clear(DisclosedTotalOfPayments);
            UIActions.GiveInput(DisclosedTotalOfPayments, TridVariable.DisclosedTotalOfPayment);

            UIActions.Clear(DisclosedFinanceCharge);
            UIActions.GiveInput(DisclosedFinanceCharge, TridVariable.DisclosedFinanceCharge);

            UIActions.Clear(DisclosedAmountFinanced);
            UIActions.GiveInput(DisclosedAmountFinanced, TridVariable.DisclosedAmountFinanced);

            UIActions.Clear(DisclosedApr);
            UIActions.GiveInput(DisclosedApr, TridVariable.DisclosedApr);

            UIActions.Clear(DisclosedTip);
            UIActions.GiveInput(DisclosedTip, TridVariable.DisclosedTip);

            UIActions.Clear(DsclosedEstTaxesInsAndAssessments);
            UIActions.GiveInput(DsclosedEstTaxesInsAndAssessments, TridVariable.DisclosedEstimatedTaxesInsuranceAssessments);

        }
       
        [When(@"user enters disclosed input values for Property Cost and Escrow")]
        public void WhenUserEntersDisclosedInputValuesForPropertyCostAndEscrow()
        {
            UIActions.Clear(DsclEscrowedPropertyCostsOverYear1);
            UIActions.GiveInput(DsclEscrowedPropertyCostsOverYear1, TridVariable.DsclEscrowedPropertyCostsOverYearOne);

            UIActions.Clear(DisclosedNonEscrowPropertyOverYear1);
            UIActions.GiveInput(DisclosedNonEscrowPropertyOverYear1, TridVariable.DisclosedNonEscrowPropertyOverYearOne);

            UIActions.Clear(DisclosedInitialEscrowPayment);
            UIActions.GiveInput(DisclosedInitialEscrowPayment, TridVariable.DisclosedInitialEscrowPayment);

          
        }

        [When(@"user enters disclsoed input values for Loan Estimate - Comparisons")]
        public void WhenUserEntersDisclsoedInputValuesForLoanEstimate_Comparisons()
        {
            UIActions.Clear(DisclosedIn5Years);
            UIActions.GiveInput(DisclosedIn5Years, TridVariable.DiscLosedIn5Years);

            UIActions.Clear(DisclosedIn5YearsPrincipal);
            UIActions.GiveInput(DisclosedIn5YearsPrincipal, TridVariable.DiscLosedIn5YearsPrincipal);

            UIActions.Clear(DisclosedApr);
            UIActions.GiveInput(DisclosedApr, TridVariable.DisclosedApr);

            UIActions.Clear(DisclosedTip);
            UIActions.GiveInput(DisclosedTip, TridVariable.DisclosedTip);

            UIActions.Click(LoanEstimationButton);
            Thread.Sleep(1000);
        }

        [When(@"user navigates to Export Page")]
        public void WhenUserNavigatesToExportPage()
        {
            UIActions.Click(ExportLink);
            UIActions.WebDriverWait(ExportLoanInformationText, 60, "ExportLoanInformationText");
        }

        [When(@"user enters all input values for Export Page")]
        public void WhenUserEntersAllInputValuesForExportPage()
        {
            UIActions.Clear(LoanTitle);
            UIActions.GiveInput(LoanTitle, TridVariable.ScenarioNo);

            UIActions.Clear(LoanIdNumber);
            UIActions.GiveInput(LoanIdNumber, TridVariable.LoanIdNumber);

            UIActions.Clear(BorrowersNames);
            UIActions.GiveInput(BorrowersNames, TridVariable.BorrowersNames);

            UIActions.Clear(NameOfLender);
            UIActions.GiveInput(NameOfLender, TridVariable.NameOfLender);

            UIActions.Clear(PreparedBy);
            UIActions.GiveInput(PreparedBy, TridVariable.PreparedBy);

            UIActions.Clear(OriginalCreditor);
            UIActions.GiveInput(OriginalCreditor, TridVariable.OriginalCreditor);

            ExportRadioButtonVariable();
            UIActions.Click(LoanSecuredBy);

            ExportRadioButtonVariable();
            UIActions.Click(Export);
        }

        [When(@"user clicks on Export button to generate JSON file")]
        public void WhenUserClicksOnExportButtonToGenerateJsonFile()
        {
            var filePath = DriverSetup.DownloadDirectory + TridVariable.ScenarioNo + ".json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            UIActions.WebDriverWait(ExportButton,60, "ExportButton");
            UIActions.Click(ExportButton);
            Thread.Sleep(3000);
        }


        [When(@"user upload json file for the scenario")]
        public void WhenUserUploadJsonFileForTheScenario()
        {
            ProjActions.UploadJsonFile();
        }

        [When(@"user navigates to Loan Estimate Cards Page")]
        public void WhenUserNavigatesToLoanEstimateCardsPage()
        {
            UIActions.Click(LeInputsAndResultsLink);
            UIActions.WebDriverWait(LoanEstimateIn5YearsText, 60, "LoanEstimateIn5YearsText");
        }

        #endregion


        #region Then

        [Then(@"user navigates to Closing Disclosure Cards Page")]
        public void ThenUserNavigatesToClosingDisclosureCardsPage()
        {
            UIActions.Click(CdResultsLink);
            UIActions.WebDriverWait(PrincipalAndInterestLabelText, 60, "PrincipalAndInterestLabelText");
        }

        [Then(@"user navigates to MI Inputs and Results Page")]
        public void ThenUserNavigatesToMIInputsAndResultsPage()
        {
            UIActions.Click(MiInputsResultsLink);
            UIActions.WebDriverWait(MiInputsResultsLink, 60, "MiInputsAndResults");
        }

        [Then(@"user navigates to Loan Estimate Cards Page")]
        public void ThenUserNavigatesToLoanEstimateCardsPage()
        {
            UIActions.Click(LeInputsAndResultsLink);
            UIActions.WebDriverWait(LoanEstimateIn5YearsText, 60, "LoanEstimateIn5YearsText");
        }


        [Then(@"updated/computed Principal and Interest value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrincipalAndInterestValueShouldDisplayOnClosingDisclosure()
        {         
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(PiComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrincipalAndInt), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedMonthlyPrincipalAndInterest), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");
                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VariancePrincipalAndInt);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PrincipalAndInt || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Mortgage Insurance value should display on Closing Disclosure")]
        public void ThenUpdatedComputedMortgageInsuranceValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(MiComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.MortgageInsurance), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedMortgageInsurance), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceMortgageInsurance);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| MortgageInsurance || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Estimated Total Monthly Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedTotalMonthlyPaymentValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedTotalMonthlyPayment), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedEstimatedTotalMonthlyPayment), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedTotalMonthlyPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| EstimatedTotalMonthlyPayment || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed APR value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(AprComputedValue)), 3);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Apr), 3);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedApr), 3);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceApr);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| APR || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"APRWIN info value should display on Closing Disclosure")]
        public void ThenAprwinInfoValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AprWin), 4);
                var actualInfoValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AprWinInfoValue)), 4);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue,
                    "Apr Info value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualIfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| APRWIN || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }


        [Then(@"updated/computed Balloon Amount value should display on Closing Disclosure")]
        public void ThenUpdatedComputedBalloonAmountValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(BaComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.DifferentFinalOrBalloonPayment), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedFinalOrBalloonPayment), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceDifferentFinalOrBalloonPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| BalloonAmount || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Total of Payments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(TopComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.TotalOfPayments), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedTotalOfPayment), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceTotalOfPayments);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TotalOfPayments || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Finance Charge value should display on Closing Disclosure")]
        public void ThenUpdatedComputedFinanceChargeValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(FcComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.FinanceCharge), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedFinanceCharge), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceFinanceCharge);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| FinanceCharge || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Amount Financed value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(AfComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.AmountFinanced), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedAmountFinanced), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceAmountFinanced);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AmountFinanced || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed TIP value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(TipComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Tip), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedTip), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceTip);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TIP || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(
            @"updated/computed Escrowed Prop Costs Over Year 1 from consummation date value should display on Closing Disclosure"
        )]
        public void
            ThenUpdatedComputedEscrowedPropCostsOverYear1FromConsummationDateValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11ComputedValue)), 2);
                var expectedCValue =
                    Math.Round(Convert.ToDouble(TridVariable.EscrowedPropCostsOverYear1FromConsummationDate), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11DisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DsclEscrowedPropertyCostsOverYearOne), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue =
                    Convert.ToDouble(TridVariable.VarianceEscrowedPropCostsOverYear1FromConsummationDate);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11VarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| EscrowPropertyOver1Year11Months || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(
            @"updated/computed Escrowed Property Costs Over Year 1 from date of 1st loan payment value should display on Closing Disclosure"
        )]
        public void
            ThenUpdatedComputedEscrowedPropertyCostsOverYear1FromDateOf1StLoanPaymentValueShouldDisplayOnClosingDisclosure
            ()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12ComputedValue)), 2);
                var expectedCValue =
                    Math.Round(Convert.ToDouble(TridVariable.EscrowedPropertyCostsOverYear1FromDateOf1stLoanPayment), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12DisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DsclEscrowedPropertyCostsOverYearOne), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue =
                    Convert.ToDouble(TridVariable.VarianceEscrowedPropertyCostsOverYear1FromDateOf1StLoanPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12VarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| EscrowPropertyOver1Year12Months || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }


        [Then(@"updated/computed Initial Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedInitialEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(IepComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.InitialEscrowPayment), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedInitialEscrowPayment), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceInitialEscrowPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InitialEscrowPayment || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }


        [Then(@"updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedNonEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.NonEscrowPropertyOverYear1), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedNonEscrowPropertyOverYearOne), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceNonEscrowPropertyOverYear1);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| NonEscrowPropertyOverOneYear || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Estimated Escrow value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedEscrowValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(EeComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedEscrow), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EeDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedPeriodEscrowPayment), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedEscrow);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EeVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| EstimatedEscrow || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedTaxesInsuranceAssessmentsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedTaxesInsuranceAssessments), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaDisclosureValue));
                var expectedDValue =
                    Math.Round(Convert.ToDouble(TridVariable.DisclosedEstimatedTaxesInsuranceAssessments), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedTaxesInsuranceAssessments);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| EstimatedTaxesInsuranceAssessments || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }


        [Then(@"updated/computed in 5 Years value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsValueShouldDisplayOnLoanEstimate()
        {
            try
            {
                var actualCValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YComputedValue));
                var expectedCValue = Convert.ToDouble(TridVariable.In5Years);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DiscLosedIn5Years), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5Years);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| In5Years || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed in 5 Years principal value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsPrincipalValueShouldDisplayOnLoanEstimate()
        {
            try
            {
                var actualCValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpComputedValue));
                var expectedCValue = Convert.ToDouble(TridVariable.In5YearsPrincipal);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DiscLosedIn5YearsPrincipal), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5YearsPrincipal);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| In5YearsPrincipal || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }


        //MI Cards

        [Then(@"updated/computed Scheduled PMI Termination Date value should display on Closing Disclosure")]
        public void ThenUpdatedComputedScheduledPmiTerminationDateValueShouldDisplayOnClosingDisclosure()
        {
            if (TridVariable.ScheduledPmiTerminationDate.Equals("N/A"))
                ScheduledPmiTerminationDateNotApplicableValidation();
            else
                try
                {
                    var actualCValue = ProjActions.GetDatePart(SptdComputedValue);
                    var expectedCValue =
                        Convert.ToDateTime(ProjActions.GetDate(TridVariable.ScheduledPmiTerminationDate));
                    ValueDifference = (expectedCValue - actualCValue).TotalDays;
                    Assert.AreEqual(expectedCValue, actualCValue,
                        "Computed value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                    Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                    Console.WriteLine("============================================================");

                    var actualDValue = ProjActions.GetDatePart(SptdDisclosureValue);
                    var expectedDValue =
                        Convert.ToDateTime(ProjActions.GetDate(TridVariable.DisclosedPmiTerminationDate));
                    ValueDifference = (expectedDValue - actualDValue).TotalDays;
                    Assert.AreEqual(expectedDValue, actualDValue,
                        "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                    Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                    Console.WriteLine("============================================================");

                    ValueDifference = (actualDValue - actualCValue).TotalDays;
                    Assert.AreEqual(actualDValue, actualCValue,
                        "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                    var expectedVValue = Convert.ToDouble(TridVariable.VarianceScheduledPmiTerminationDate);
                    var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(SptdVarianceValue));
                    ValueDifference = expectedVValue - actualVValue;
                    Assert.AreEqual(expectedVValue, actualVValue,
                        "Variance does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                    Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                    Console.WriteLine("============================================================");
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| ScheduledPMITerminationDate || : " + e +
                                    " \n ====================================================================================\n";
                }
        }

        public static void ScheduledPmiTerminationDateNotApplicableValidation()
        {
            try
            {
                var actualCValue = UIActions.GetText(SptdComputedValue);
                var expectedCValue = "(C): " + TridVariable.ScheduledPmiTerminationDate;
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = UIActions.GetText(SptdDisclosureValue);
                var expectedDValue = "(D): " + TridVariable.DisclosedPmiTerminationDate;

                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = "(V): N/A Days";
                var actualVValue = UIActions.GetText(SptdVarianceValue);

                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(expectedVValue);
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile("Error: not N/A");
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| ScheduledPmiTerminationDate || : " + e +
                                " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Cancel Date value should display on Closing Disclosure")]
        public void ThenUpdatedComputedCancelDateValueShouldDisplayOnClosingDisclosure()
        {
            if (TridVariable.PmiCancelDate.Equals("N/A"))
                PmiCancelDateNotApplicableValidation();
            else
                try
                {
                    var actualCValue = ProjActions.GetDatePart(PcdComputedValue);
                    var expectedCValue = Convert.ToDateTime(ProjActions.GetDate(TridVariable.PmiCancelDate));
                    ValueDifference = (expectedCValue - actualCValue).TotalDays;
                    Assert.AreEqual(expectedCValue, actualCValue,
                        "Computed value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                    Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                    Console.WriteLine("============================================================");

                    var actualDValue = ProjActions.GetDatePart(PcdDisclosureValue);
                    var expectedDValue = Convert.ToDateTime(ProjActions.GetDate(TridVariable.PmiCancelDate));
                    ValueDifference = (expectedDValue - actualDValue).TotalDays;
                    Assert.AreEqual(expectedDValue, actualDValue,
                        "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                    Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                    Console.WriteLine("============================================================");

                    ValueDifference = (actualDValue - actualCValue).TotalDays;
                    Assert.AreEqual(actualDValue, actualCValue,
                        "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                    var expectedVValue = Convert.ToDouble(TridVariable.VariancePmiCancelDate);
                    var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcdVarianceValue));
                    ValueDifference = expectedVValue - actualVValue;
                    Assert.AreEqual(expectedVValue, actualVValue,
                        "Variance does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                    Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                    Console.WriteLine("============================================================");
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PmiCancelDate || : " + e +
                                    " \n ====================================================================================\n";
                }
        }

        public static void PmiCancelDateNotApplicableValidation()
        {
            try
            {
                var actualCValue = UIActions.GetText(PcdComputedValue);
                var expectedCValue = "(C): " + TridVariable.PmiCancelDate;
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = UIActions.GetText(PcdDisclosureValue);
                var expectedDValue = "(D): " + TridVariable.PmiCancelDate;

                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = "(V): N/A Days";
                var actualVValue = UIActions.GetText(PcdVarianceValue);

                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(expectedVValue);
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile("Error: not N/A");
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PmiCancelDate || : " + e +
                                " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Upfront MIP values value should display on Closing Disclosure")]
        public void ThenUpdatedComputedUpfrontMipValuesValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(UfmComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.UpfrontMip), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(UfmDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.UpfrontMip), 2);
                ValueDifference = Math.Abs(expectedDValue - actualDValue);
                Assert.AreEqual(expectedDValue, actualDValue,
                    "Disclosed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                Console.WriteLine("============================================================");
                ValueDifference = Math.Abs(actualCValue - actualDValue);
                Assert.AreEqual(actualDValue, actualCValue,
                    "Disclosed value does not match with computed value with the difference of {0}", ValueDifference);

                var expectedVValue = Convert.ToDouble(TridVariable.UpfrontMip);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(UfmVarianceValue));
                ValueDifference = Math.Abs(actualVValue - expectedVValue);
                Assert.AreEqual(expectedVValue, actualVValue,
                    "Variance does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :{0}", expectedVValue);
                Console.WriteLine("ActualVarianceValue :{0}", actualVValue);
                Console.WriteLine("============================================================");
                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                if (ValueDifference >= 0.1)
                {
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| UpfrontMip || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }

    #endregion


    [AfterTestRun]
        public static void TearDown()
        {
            UIActions.Quit();
            if (!TestCaseStatus)
            {
                Console.WriteLine("##########################################################");
                Console.WriteLine("##########################################################");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("Scenario Number : {0}", TridVariable.ScenarioNo);
                Console.WriteLine("The total number of cards Failue: {0}", TestFailureCount);
                Console.WriteLine("Name of cards Failed: {0}", CardsFailure);
                Console.WriteLine("====================================================================================");
                Console.WriteLine("##########################################################");
                Console.WriteLine("##########################################################");
                throw new Exception("Test Case failed");
            }
        }
    }
}
