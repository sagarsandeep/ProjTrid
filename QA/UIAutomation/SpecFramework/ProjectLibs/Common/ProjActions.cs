using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecRun.Helper;
using TRID.ActionClasses;
using TRID.ProjectLibs.UI;

namespace TRID.ProjectLibs.Common
{
    class ProjActions : TridHeaderUiElements
    {
        private static string UploadFilePath => ConfigurationManager.AppSettings["UploadFilePath"];
        public static string CsvFilePath => ConfigurationManager.AppSettings["CsvFilePath"];

        public static void CreateCsvCardsHeaderFile()
        {
            StringBuilder CsvFile = new StringBuilder();
            string csvHeaderFilePath = CsvFilePath + @"\" + _getSheetName + @"\" + _getSheetName + "Header.csv";

            if (File.Exists(csvHeaderFilePath))
                File.Delete(csvHeaderFilePath);

            if (_getSheetName == "ClosingDisclosure")
            {              
                CsvFile.AppendLine(
                        "Scenario#,PrincipalAndInt,MortgageInsurance,EstimatedTotalMonthlyPayment," +
                        "APR,APRWIN,DifferentFinalOrBalloonPayment,TotalOfPayments,FinanceCharge," +
                        "AmountFinanced,TIP,EscrowedPropCostsOverYear1FromConsummationDate," +
                        "EscrowedPropertyCostsOverYear1FromDateOf1stLoanPayment,InitialEscrowPymt,NonEscrowPropertyOverYear1," +
                        "EstimatedEscrow,EstimatedTaxesInsuranceAndAssessments,ScheduledPMITerminationDate,PMICancelDate,UpFrontMIP," +
                        "In 5 years,In 5 Years Principal");
            }

            if (_getSheetName == "PaymentSchedule")
            {
                CsvFile.AppendLine(
                    "Scenario#,PaymentStreamNo,NumberOfPayments,PaymentAmount,PrincipalAndInterestPayment,PMIPayment");
                //,InsEscrowedAmount,TaxEscrowedAmt,EscrowOther1,EscrowOther2");
            }

            if (_getSheetName == "EscrowInfo")
            {
                CsvFile.AppendLine(
                        "Scenario#,InsInitialDeposit,InsPeriodDeposit,InsLowBalance,InsCushion,InsTotalAnnualDisbursed,TaxInitialDeposit,TaxPeriodDeposit,TaxLowBalance,TaxCushion," +
                        "TaxTotalAnnualDisbursed,PmiInitialDeposit,PmiPeriodDeposit,PmiLowBalance,PmiCushion,PmiTotalAnnualDisbursed,Other1InitialDeposit,Other1PeriodDeposit," +
                        "Other1LowBalance,Other1Cushion,Other1TotalAnnualDisbursed,Other2InitialDeposit,Other2PeriodDeposit,Other2LowBalance,Other2Cushion,Other2TotalAnnualDisbursed," +
                        "AggregateInitialDeposit,AggregatePeriodDeposit,AggregateLowBalance,AggregateCushion,AggregateTotalAnnualDisbursed");
            }

            File.AppendAllText(csvHeaderFilePath, CsvFile.ToString());         
        }

        public static void CreateCsvFile(string newColumnValue)
        {          
            string csvScenarioFilePath = CsvFilePath + @"\" + _getSheetName + @"\" + _getSheetName + "_"+ TridVariable.ScenarioNo + ".csv";
            if (File.Exists(csvScenarioFilePath))
            {
                List<string> lines = File.ReadAllLines(csvScenarioFilePath).ToList();
                lines[0] += "," + newColumnValue;
                File.WriteAllLines(csvScenarioFilePath, lines);
            }
            else
            {
                StringBuilder csvFile = new StringBuilder();
                string firstValues = $"{TridVariable.ScenarioNo},{newColumnValue}";
                csvFile.Append(firstValues);
                File.WriteAllText(csvScenarioFilePath, csvFile.ToString());
            }
        }

        public static void UploadJsonFile()
        {
            UIActions.Click(BrowseButton);
            Thread.Sleep(500);
            SendKeys.SendWait(UploadFilePath + TridVariable.ScenarioNo +".json");
            Thread.Sleep(500);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(500);
            UIActions.Click(UploadButton);
        }

        public static double GetNumericValueFromString(string inputString)
        {
            var result = Regex.Replace(inputString, @"[^0-9\.-]+", "");
            return Convert.ToDouble(result);
        }

        public static DateTime GetDatePart(By element)
        {
            var datePart = UIActions.GetText(element).Split(':')[1];
            return Convert.ToDateTime(Convert.ToDateTime(datePart).ToString("M/d/yyyy"));
        }

        public static string GetDate(string variable)
        {
            string date = "null";
            if (variable.IsNotNullOrEmpty())
            {
                date = variable.Equals("N/A") ? "N/A" : DateTime.FromOADate(Convert.ToDouble(variable)).ToString("M/d/yyyy");
            }
            return date;
        }

        public static void AddPmiRateValues()
        {
            var pmiRatesGridRowsCount = UIActions.Count(PmiRatesGridRowsCount);

            if (TridVariable.FirstAddNumber != "")
            {
                if (pmiRatesGridRowsCount == 0)
                {
                    var firstAddNumber = TridVariable.FirstAddNumber;
                    UIActions.Clear(AddNumber);
                    UIActions.GiveInput(AddNumber, firstAddNumber);

                    var firstAddBeginPeriod = TridVariable.FirstAddBeginPeriod;
                    UIActions.Clear(AddBeginPeriod);
                    UIActions.GiveInput(AddBeginPeriod, firstAddBeginPeriod);

                    var firstAddEndPeriod = TridVariable.FirstAddEndPeriod;
                    UIActions.Clear(AddEndPeriod);
                    UIActions.GiveInput(AddEndPeriod, firstAddEndPeriod);

                    var firstAddPmiRate = TridVariable.FirstAddPmiRate;
                    UIActions.Clear(AddPmiRate);
                    UIActions.GiveInput(AddPmiRate, firstAddPmiRate);

                    UIActions.Click(AddButton);

                    var secondAddNumber = TridVariable.SecondAddNumber;
                    UIActions.Clear(AddNumber);
                    UIActions.GiveInput(AddNumber, secondAddNumber);

                    var secondAddBeginPeriod = TridVariable.SecondAddBeginPeriod;
                    UIActions.Clear(AddBeginPeriod);
                    UIActions.GiveInput(AddBeginPeriod, secondAddBeginPeriod);

                    var secondAddEndPeriod = TridVariable.SecondAddEndPeriod;
                    UIActions.Clear(AddEndPeriod);
                    UIActions.GiveInput(AddEndPeriod, secondAddEndPeriod);

                    var secondAddPmiRate = TridVariable.SecondAddPmiRate;
                    UIActions.Clear(AddPmiRate);
                    UIActions.GiveInput(AddPmiRate, secondAddPmiRate);

                    UIActions.Click(AddButton);

                    var thirdAddNumber = TridVariable.ThirdAddNumber;
                    UIActions.Clear(AddNumber);
                    UIActions.GiveInput(AddNumber, thirdAddNumber);

                    var thirdAddBeginPeriod = TridVariable.ThirdAddBeginPeriod;
                    UIActions.Clear(AddBeginPeriod);
                    UIActions.GiveInput(AddBeginPeriod, thirdAddBeginPeriod);

                    var thirdAddEndPeriod = TridVariable.ThirdAddEndPeriod;
                    UIActions.Clear(AddEndPeriod);
                    UIActions.GiveInput(AddEndPeriod, thirdAddEndPeriod);

                    var thirdAddPmiRate = TridVariable.ThirdAddPmiRate;
                    UIActions.Clear(AddPmiRate);
                    UIActions.GiveInput(AddPmiRate, thirdAddPmiRate);

                    UIActions.Click(AddButton);
                }
                else
                {
                    PmiRatesGridValidation();
                }
            }
        }

        public static void PmiRatesGridValidation()
        {
            Thread.Sleep(250);
            if (TridVariable.FirstAddNumber != "")
            {
                var pmiRatesGridRowsCount = UIActions.Count(PmiRatesGridRowsCount);
                var numberOfPaymentArray = new[]
                {
                    TridVariable.FirstAddBeginPeriod,
                    TridVariable.SecondAddBeginPeriod,
                    TridVariable.ThirdAddBeginPeriod
                };
                Assert.AreEqual(3, pmiRatesGridRowsCount, "PMI Rates Grid entries are not as expected");

                for (var row = 1; row <= pmiRatesGridRowsCount; row++)
                {
                    var pmiRatesBeginPeriod =
                        UIActions.GetText(
                            By.XPath("//section[@id='MortgageGrid']//tbody/tr[" + row + "]/td[2]//span"));
                    Assert.True(numberOfPaymentArray.Contains(pmiRatesBeginPeriod),
                        "PMI Rates Begin Period values are not as expected");
                }
            }
        }

        public static void PmiRatesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.Count(PmiRatesGridRowsCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("PMI Grid is not empty");           
        }


        public static void AddPrepaidCustomValues()
        {
            if (TridVariable.PrepaidCustomFieldsCustomName != "")
            {
                if (TridVariable.PrepaidCustomFieldsCustomName != "0")
                {
                    UIActions.Clear(CustomNumber);
                    UIActions.GiveInput(CustomNumber, TridVariable.PrepaidCustomFieldsNumber);

                    UIActions.Clear(CustomName);
                    UIActions.GiveInput(CustomName, TridVariable.PrepaidCustomFieldsCustomName);

                    UIActions.Clear(CustomValue);
                    UIActions.GiveInput(CustomValue, TridVariable.PrepaidCustomFieldsCustomValue);

                    UIActions.Click(CustomFieldAddButton);
                }
            }
            else
                PrepaidChargeGridValidation();
        }

        public static void PrepaidChargeGridValidation()
        {

            if (TridVariable.PrepaidCustomFieldsCustomName != "")
                if (TridVariable.PrepaidCustomFieldsCustomName != "0")
                {
                    var prepaidChargeGridRowCount = UIActions.Count(PrepaidChargeCustomGridCount);
                    Assert.AreEqual(1, prepaidChargeGridRowCount,
                        "Prepaid Charge Custom Grid entries are not as expected");

                    var prepaidCustomName = TridVariable.PrepaidCustomFieldsCustomName;
                    var actualPrepaidCustomName = UIActions.GetText(PrepaidChargeGridCustomName);
                    Assert.AreEqual(prepaidCustomName, actualPrepaidCustomName,
                        "Prepaid Charge Custom Name is not as expected");

                    var prepaidCustomValue = TridVariable.PrepaidCustomFieldsCustomValue;
                    var actualPrepaidCustomValue = UIActions.GetText(PrepaidChargeGridCustomValue);
                    Assert.AreEqual(prepaidCustomValue, actualPrepaidCustomValue,
                        "Prepaid Charge Custom Value is not as expected");
                }
        }

        public static void PrepaidChargesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.GetText(PrepaidChargeCustomGridCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("Prepaid Charges Custom Grid is not empty");
        }

        private static string _getSheetName;
        public static void GetSheetName(string sheetName)
        {
            _getSheetName = sheetName;
        }

        public static void AddEscrowGridValues()
        {
            //Row 1
            if (TridVariable.EscrowPropertyCostsGridInputs1.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs1["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed1);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs1["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }

            //Row 2
            if (TridVariable.EscrowPropertyCostsGridInputs2.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs2["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed2);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs2["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }

            //Row 3
            if (TridVariable.EscrowPropertyCostsGridInputs3.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs3["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed3);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs3["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }

            //Row 4
            if (TridVariable.EscrowPropertyCostsGridInputs4.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs4["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed4);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs4["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }

            //Row 5
            if (TridVariable.EscrowPropertyCostsGridInputs5.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs5["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed5);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs5["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }


            //Row 6
            if (TridVariable.EscrowPropertyCostsGridInputs6.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs6["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed6);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs6["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }

            //Row 7
            if (TridVariable.EscrowPropertyCostsGridInputs7.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs7["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed7);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs7["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }

            //Row 8
            if (TridVariable.EscrowPropertyCostsGridInputs8.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowPropertyCostsGridInputs8["PropertyCostType"]);

                EscrowRadioButtonVariable();
                UIActions.Click(Escrowed8);

                UIActions.Clear(Cushion);
                UIActions.GiveInput(Cushion, TridVariable.EscrowPropertyCostsGridInputs8["Cushion"]);

                UIActions.Click(EscrowPropertyCostsAddButton);
            }


            //Row 1
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs1.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs1["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs1["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs1["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs1["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution1);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }

            //Row 2
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs2.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs2["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs2["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs2["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs2["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution2);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }

            //Row 3
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs3.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs3["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs3["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs3["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs3["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution3);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }


            //Row 4            
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs4.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs4["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs4["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs4["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs4["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution4);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }


            //Row 5
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs5.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs5["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs5["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs5["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs5["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution5);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }


            //Row 6
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs6.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs6["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs6["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs6["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs6["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution6);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }


            //Row 7
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs7.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber, TridVariable.EscrowPropertyCostInstallmentsGridInputs7["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount, TridVariable.EscrowPropertyCostInstallmentsGridInputs7["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs7["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs7["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution7);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }


            //Row 8
            if (TridVariable.EscrowPropertyCostInstallmentsGridInputs8.Any())
            {
                UIActions.Clear(EscrowPropertyCostInstallmentNumber);
                UIActions.GiveInput(EscrowPropertyCostInstallmentNumber,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs8["Number"]);

                UIActions.Clear(EscrowPropertyCostInstallmentAmount);
                UIActions.GiveInput(EscrowPropertyCostInstallmentAmount,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs8["Amount"]);

                UIActions.Clear(EscrowPropertyCostInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowPropertyCostInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs8["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowPropertyCostInstallmentPropertyCostType);
                UIActions.GiveInput(EscrowPropertyCostInstallmentPropertyCostType,
                    TridVariable.EscrowPropertyCostInstallmentsGridInputs8["PropertyCostType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);

                EscrowRadioButtonVariable();
                UIActions.Click(VoluntaryContribution8);

                UIActions.Click(EscrowPropertyCostInstallmentAddButton);
            }
        }
    }
}

