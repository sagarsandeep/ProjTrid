using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;

namespace TRID.StepDefinitions
{
    [Binding]
    public class EscrowInfoCardsValidationSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public static double ValueDifference;
        public static string CardsFailure = "";

        #region Given

        [Given(@"user have Escrow Info data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveEscrowInfoDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
            ProjActions.GetSheetName(sheetName);
            //ProjActions.CreateCsvCardsHeaderFile();
        }

        #endregion


        #region Then

        [Then(@"user navigates to Escrow Trial Balance Page")]
        public void WhenUserNavigatesToEscrowEscrowTrialBalancePage()
        {
            UIActions.Click(EscrowTrialBalanceLink);
            UIActions.WebDriverWait(EscrowInfoInsuranceLabelText, 60, "Escrow Info Insurance Label Text");
        }

        [Then(@"updated/computed Insurance Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.InsInitialDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsInitialDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsInitialDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Insurance Initial Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InsuranceInitialDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.InsInitialDeposit = "";
        }

        [Then(@"updated/computed Insurance Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedInsurancePeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.InsPeriodDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsPeriodDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsPeriodDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Insurance Period Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InsurancePeriodDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.InsPeriodDeposit = "";
        }

        [Then(@"updated/computed Insurance Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.InsLowBalance != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsLowBalance), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsLowBalance)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Insurance Low Balance value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InsuranceLowBalance || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.InsLowBalance = "";
        }

        [Then(@"updated/computed Insurance Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceCushionValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.InsCushion != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsCushion), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsCushion)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Insurance Cushion value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InsuranceCushion || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.InsCushion = "";
        }

        [Then(@"updated/computed Insurance Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.InsTotalAnnualDisbursed != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsTotalAnnualDisbursed), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsTotalAnnualDisbursed)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Insurance Total Annual Disbursed value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InsuranceTotalAnnualDisbursed || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.InsTotalAnnualDisbursed = "";
        }

        [Then(@"updated/computed Tax Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.TaxInitialDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxInitialDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxInitialDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Tax Initial Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TaxInitialDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.TaxInitialDeposit = "";
        }

        [
            Then(@"updated/computed Tax Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxPeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.TaxPeriodDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxPeriodDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxPeriodDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Tax Period Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TaxPeriodDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.TaxPeriodDeposit = "";
        }

        [
            Then(@"updated/computed Tax Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.TaxLowBalance != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxLowBalance), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxLowBalance)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Tax Low Balance value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TaxLowBalance || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.TaxLowBalance = "";
        }

        [Then(@"updated/computed Tax Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxCushionValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.TaxCushion != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxCushion), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxCushion)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Tax Cushion value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TaxCushion || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.TaxCushion = "";
        }

        [
            Then(@"updated/computed Tax Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.TaxTotalAnnualDisbursed != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxTotalAnnualDisbursed), 2);
                    var actualInfoValue =
                        Math.Round(
                            ProjActions.GetNumericValueFromString(UIActions.GetText(TaxTotalAnnualDisbursed)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Tax Total Annual Disbursed value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TaxTotalAnnualDisbursed || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.TaxTotalAnnualDisbursed = "";
        }

        [
            Then(@"updated/computed PMI Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.PmiInitialDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiInitialDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiInitialDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "PMI Initial Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PMIInitialDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.PmiInitialDeposit = "";
        }

        [Then(@"updated/computed PMI Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiPeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.PmiPeriodDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiPeriodDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiPeriodDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "PMI Period Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PMIPeriodDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.PmiPeriodDeposit = "";
        }

        [Then(@"updated/computed PMI Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.PmiLowBalance != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiLowBalance), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiLowBalance)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "PMI Low Balance value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PMILowBalance || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.PmiLowBalance = "";
        }

        [Then(@"updated/computed PMI Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiCushionValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.PmiCushion != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiCushion), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiCushion)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "PMI Cushion value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PMICushion || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.PmiCushion = "";
        }

        [Then(@"updated/computed PMI Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.PmiTotalAnnualDisbursed != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiTotalAnnualDisbursed), 2);
                    var actualInfoValue =
                        Math.Round(
                            ProjActions.GetNumericValueFromString(UIActions.GetText(PmiTotalAnnualDisbursed)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "PMI Total Annual Disbursed value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PMITotalAnnualDisbursed || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.PmiTotalAnnualDisbursed = "";
        }

        [Then(@"updated/computed Other1 Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1InitialDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other1InitialDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1InitialDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1InitialDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other1 Initial Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other1InitialDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other1InitialDeposit = "";
        }

        [Then(@"updated/computed Other1 Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1PeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other1PeriodDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1PeriodDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1PeriodDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other1 Period Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other1PeriodDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other1PeriodDeposit = "";
        }

        [
            Then(@"updated/computed Other1 Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1LowBalanceValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other1LowBalance != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1LowBalance), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1LowBalance)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other1 Low Balance value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other1LowBalance || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other1LowBalance = "";
        }

        [
            Then(@"updated/computed Other1 Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1CushionValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other1Cushion != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1Cushion), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1Cushion)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other1 Cushion value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other1Cushion || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other1Cushion = "";
        }

        [Then(@"updated/computed Other1 Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1TotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other1TotalAnnualDisbursed != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1TotalAnnualDisbursed), 2);
                    var actualInfoValue =
                        Math.Round(
                            ProjActions.GetNumericValueFromString(UIActions.GetText(Other1TotalAnnualDisbursed)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other1 Total Annual Disbursed value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other1TotalAnnualDisbursed || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other1TotalAnnualDisbursed = "";
        }

        [Then(@"updated/computed Other2 Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2InitialDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other2InitialDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2InitialDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2InitialDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other2 Initial Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other2InitialDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other2InitialDeposit = "";
        }

        [Then(@"updated/computed Other2 Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2PeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other2PeriodDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2PeriodDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2PeriodDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other2 Period Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other2PeriodDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other2PeriodDeposit = "";
        }

        [Then(@"updated/computed Other2 Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2LowBalanceValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other2LowBalance != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2LowBalance), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2LowBalance)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other2 Low Balance value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other2LowBalance || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other2LowBalance = "";
        }

        [Then(@"updated/computed Other2 Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2CushionValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other2Cushion != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2Cushion), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2Cushion)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other2 Cushion value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other2Cushion || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other2Cushion = "";
        }

        [Then(@"updated/computed Other2 Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2TotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.Other2TotalAnnualDisbursed != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2TotalAnnualDisbursed), 2);
                    var actualInfoValue =
                        Math.Round(
                            ProjActions.GetNumericValueFromString(UIActions.GetText(Other2TotalAnnualDisbursed)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Other2 Total Annual Disbursed value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| Other2TotalAnnualDisbursed || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.Other2TotalAnnualDisbursed = "";
        }

        [Then(@"updated/computed Aggregate Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.AggregateInitialDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateInitialDeposit), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateInitialDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Aggregate Initial Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AggregateInitialDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.AggregateInitialDeposit = "";
        }

        [Then(@"updated/computed Aggregate Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregatePeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.AggregatePeriodDeposit != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregatePeriodDeposit), 2);
                    var actualInfoValue =
                        Math.Round(
                            ProjActions.GetNumericValueFromString(UIActions.GetText(AggregatePeriodDeposit)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Aggregate Period Deposit value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AggregatePeriodDeposit || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.AggregatePeriodDeposit = "";
        }

        [Then(@"updated/computed Aggregate Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.AggregateLowBalance != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateLowBalance), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateLowBalance)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Aggregate Low Balance value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AggregateLowBalance || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.AggregateLowBalance = "";
        }

        [
            Then(@"updated/computed Aggregate Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateCushionValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.AggregateCushion != "")
                try
                {
                    var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateCushion), 2);
                    var actualInfoValue =
                        Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateCushion)), 2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Aggregate Cushion value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AggregateCushion || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.AggregateCushion = "";
        }

        [
            Then(@"updated/computed Aggregate Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            if (TridVariable.AggregateTotalAnnualDisbursed != "")
                try
                {
                    var expectedInfoValue = Math.Round(
                        Convert.ToDouble(TridVariable.AggregateTotalAnnualDisbursed), 2);
                    var actualInfoValue =
                        Math.Round(
                            ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateTotalAnnualDisbursed)),
                            2);
                    ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                    Assert.AreEqual(expectedInfoValue, actualInfoValue,
                        "Aggregate Total Annual Disbursed value does not match as expected with the difference of {0}",
                        ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                    Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                    Console.WriteLine("============================================================");

                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| AggregateTotalAnnualDisbursed || : " + e +
                                    " \n ====================================================================================\n";
                }
            else
                ProjActions.CreateCsvFile("");
            TridVariable.AggregateTotalAnnualDisbursed = "";
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
