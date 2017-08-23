using System;
using System.Configuration;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;

namespace TRID.StepDefinitions
{
    [Binding]
    public class VariableLoanPaymentScheuledValidationSteps : TridTest
    {

        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public static double ValueDifference;
        public static double TotalValueDifference;
        public static string CardsFailure = "";

        #region Given
        
        [Given(@"user have ARM Best Case variable loan data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveARMBestCaseVariableLoanDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
            ProjActions.GetSheetName(sheetName);
        }

        [Given(@"user have ARM Worst Case variable loan data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveARMWorstCaseVariableLoanDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
            ProjActions.GetSheetName(sheetName);
        }

        #endregion

        #region Then


        [Then(@"user navigates to ARM Page")]
        public void ThenUserNavigatesToARMPage()
        {
            UIActions.Click(VariableArm);
            UIActions.WebDriverWait(PaymentScheduleOutputBestLabelText, 60, "VariableArm");
        }


        [Then(@"updated/computed Payment Stream Number value should display on ARM Best Case")]
        public void ThenUpdatedComputedPaymentStreamNumberValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcPaymentStreamNo.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcPaymentStreamNumber)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcPaymentStreamNo[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue,
                        "Actual value does not match as expected for the row {0} with the difference of {1}",
                        rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcPaymentStreamNo[" + (rowIndex + 1) + "] || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed Number of Payments value should display on ARM Best Case")]
        public void ThenUpdatedComputedNumberOfPaymentsValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcPaymentScheduleNumberOfPayments.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcPaymentScheduleNumberOfPayments)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcPaymentScheduleNumberOfPayments[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcPaymentScheduleNumberOfPayments[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }
        
        [Then(@"updated/computed Payment Amount value should display on ARM Best Case")]
        public void ThenUpdatedComputedPaymentAmountValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcPaymentAmount.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcPaymentAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcPaymentAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcPaymentAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }
        
        [Then(@"updated/computed Principal and Interest Payment value should display on ARM Best Case")]
        public void ThenUpdatedComputedPeriodPaymentValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcPaymentSchedulePrincipalAndInterestPayment.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcPaymentSchedulePrincipalAndInterestPayment)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcPaymentSchedulePrincipalAndInterestPayment[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcPaymentSchedulePrincipalAndInterestPayment[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed PMI Payment value should display on ARM Best Case")]
        public void ThenUpdatedComputedPmiPaymentValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcPaymentSchedulePmiPayment.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcPaymentSchedulePmiPayment)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcPaymentSchedulePmiPayment[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcPaymentSchedulePmiPayment[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }


        [Then(@"updated/computed Ins Escrowed Amount value should display on ARM Best Case")]
        public void ThenUpdatedComputedInsEscrowedAmountValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcInsEscrowedAmount.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcInsEscrowedAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcInsEscrowedAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcInsEscrowedAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }
        
        [Then(@"updated/computed Tax Escrowed Amount value should display on ARM Best Case")]
        public void ThenUpdatedComputedTaxEscrowedAmountValueShouldDisplayOnArmBestCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AbcTaxEscrowedAmount.Count-1; rowIndex++)
            {
                AbcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AbcTaxEscrowedAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AbcTaxEscrowedAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AbcTaxEscrowedAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }



        //=====================

        [Then(@"updated/computed Payment Stream Number value should display on ARM Worst Case")]
        public void ThenUpdatedComputedPaymentStreamNumberValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcPaymentStreamNo.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcPaymentStreamNumber)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcPaymentStreamNo[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue,
                        "Actual value does not match as expected for the row {0} with the difference of {1}",
                        rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcPaymentStreamNo[" + (rowIndex + 1) + "] || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed Number of Payments value should display on ARM Worst Case")]
        public void ThenUpdatedComputedNumberOfPaymentsValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcPaymentScheduleNumberOfPayments.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcPaymentScheduleNumberOfPayments)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcPaymentScheduleNumberOfPayments[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcPaymentScheduleNumberOfPayments[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed Payment Amount value should display on ARM Worst Case")]
        public void ThenUpdatedComputedPaymentAmountValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcPaymentAmount.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcPaymentAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcPaymentAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcPaymentAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed Principal and Interest Payment value should display on ARM Worst Case")]
        public void ThenUpdatedComputePrincipalAndInterestPaymentValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcPaymentSchedulePeriodPayment.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcPaymentSchedulePeriodPayment)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcPaymentSchedulePeriodPayment[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcPaymentSchedulePeriodPayment[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed PMI Payment value should display on ARM Worst Case")]
        public void ThenUpdatedComputedPeriodPmiValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcPaymentSchedulePeriodPmi.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcPaymentSchedulePeriodPmi)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcPaymentSchedulePeriodPmi[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcPaymentSchedulePeriodPmi[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed Ins Escrowed Amount value should display on ARM Worst Case")]
        public void ThenUpdatedComputedInsEscrowedAmountValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcInsEscrowedAmount.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcInsEscrowedAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcInsEscrowedAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcInsEscrowedAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
        }

        [Then(@"updated/computed Tax Escrowed Amount value should display on ARM Worst Case")]
        public void ThenUpdatedComputedTaxEscrowedAmountValueShouldDisplayOnArmWorstCase()
        {
            TotalValueDifference = 0;
            for (var rowIndex = 0; rowIndex < TridVariable.AwcTaxEscrowedAmount.Count-1; rowIndex++)
            {
                AwcPaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AwcTaxEscrowedAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AwcTaxEscrowedAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    TotalValueDifference = 1;
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AwcTaxEscrowedAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
            ProjActions.CreateCsvFile(TotalValueDifference == 0 ? "Matched" : "Not Matched");
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
