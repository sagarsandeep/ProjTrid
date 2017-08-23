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
                    UIActions.Clear(AddBeginPmtNumber);
                    UIActions.GiveInput(AddBeginPmtNumber, firstAddBeginPeriod);

                    var firstAddEndPeriod = TridVariable.FirstAddEndPeriod;
                    UIActions.Clear(AddEndPmtNumber);
                    UIActions.GiveInput(AddEndPmtNumber, firstAddEndPeriod);

                    var firstAddPmiRate = TridVariable.FirstAddPmiRate;
                    UIActions.Clear(AddPmiRate);
                    UIActions.GiveInput(AddPmiRate, firstAddPmiRate);

                    UIActions.Click(AddButton);

                    var secondAddNumber = TridVariable.SecondAddNumber;
                    UIActions.Clear(AddNumber);
                    UIActions.GiveInput(AddNumber, secondAddNumber);

                    var secondAddBeginPeriod = TridVariable.SecondAddBeginPeriod;
                    UIActions.Clear(AddBeginPmtNumber);
                    UIActions.GiveInput(AddBeginPmtNumber, secondAddBeginPeriod);

                    var secondAddEndPeriod = TridVariable.SecondAddEndPeriod;
                    UIActions.Clear(AddEndPmtNumber);
                    UIActions.GiveInput(AddEndPmtNumber, secondAddEndPeriod);

                    var secondAddPmiRate = TridVariable.SecondAddPmiRate;
                    UIActions.Clear(AddPmiRate);
                    UIActions.GiveInput(AddPmiRate, secondAddPmiRate);

                    UIActions.Click(AddButton);

                    var thirdAddNumber = TridVariable.ThirdAddNumber;
                    UIActions.Clear(AddNumber);
                    UIActions.GiveInput(AddNumber, thirdAddNumber);

                    var thirdAddBeginPeriod = TridVariable.ThirdAddBeginPeriod;
                    UIActions.Clear(AddBeginPmtNumber);
                    UIActions.GiveInput(AddBeginPmtNumber, thirdAddBeginPeriod);

                    var thirdAddEndPeriod = TridVariable.ThirdAddEndPeriod;
                    UIActions.Clear(AddEndPmtNumber);
                    UIActions.GiveInput(AddEndPmtNumber, thirdAddEndPeriod);

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
            if (TridVariable.EscrowDisbursmentGridInputs1.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs1["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed1);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs1["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }

            //Row 2
            if (TridVariable.EscrowDisbursmentGridInputs2.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs2["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed2);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs2["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }

            //Row 3
            if (TridVariable.EscrowDisbursmentGridInputs3.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs3["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed3);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs3["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }

            //Row 4
            if (TridVariable.EscrowDisbursmentGridInputs4.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs4["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed4);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs4["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }

            //Row 5
            if (TridVariable.EscrowDisbursmentGridInputs5.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs5["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed5);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs5["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }


            //Row 6
            if (TridVariable.EscrowDisbursmentGridInputs6.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs6["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed6);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs6["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }

            //Row 7
            if (TridVariable.EscrowDisbursmentGridInputs7.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs7["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed7);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs7["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }

            //Row 8
            if (TridVariable.EscrowDisbursmentGridInputs8.Any())
            {
                UIActions.Clear(PropertyCostType);
                UIActions.GiveInput(PropertyCostType,
                    TridVariable.EscrowDisbursmentGridInputs8["EscrowDisbursmentType"]);

                LoanInputRadioButtonVariable();
                UIActions.Click(IsEscrowed8);

                UIActions.Clear(EscrowCushion);
                UIActions.GiveInput(EscrowCushion, TridVariable.EscrowDisbursmentGridInputs8["EscrowCushion"]);

                UIActions.Click(EscrowDisbursmentsAddButton);
            }


            //Row 1
            if (TridVariable.EscrowInstallementGridInputs1.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs1["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs1["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs1["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs1["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }

            //Row 2
            if (TridVariable.EscrowInstallementGridInputs2.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs2["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs2["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs2["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs2["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }

            //Row 3
            if (TridVariable.EscrowInstallementGridInputs3.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs3["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs3["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs3["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs3["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }


            //Row 4            
            if (TridVariable.EscrowInstallementGridInputs4.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs4["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs4["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs4["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs4["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }


            //Row 5
            if (TridVariable.EscrowInstallementGridInputs5.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs5["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs5["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs5["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs5["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }


            //Row 6
            if (TridVariable.EscrowInstallementGridInputs6.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs6["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs6["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs6["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs6["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }


            //Row 7
            if (TridVariable.EscrowInstallementGridInputs7.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber, TridVariable.EscrowInstallementGridInputs7["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount, TridVariable.EscrowInstallementGridInputs7["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs7["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs7["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }


            //Row 8
            if (TridVariable.EscrowInstallementGridInputs8.Any())
            {
                UIActions.Clear(EscrowInstallmentNumber);
                UIActions.GiveInput(EscrowInstallmentNumber,
                    TridVariable.EscrowInstallementGridInputs8["Number"]);

                UIActions.Clear(EscrowInstallmentAmount);
                UIActions.GiveInput(EscrowInstallmentAmount,
                    TridVariable.EscrowInstallementGridInputs8["Amount"]);

                UIActions.Clear(EscrowInstallmentDatePaidOrDisbursed);
                UIActions.GiveInput(EscrowInstallmentDatePaidOrDisbursed,
                    TridVariable.EscrowInstallementGridInputs8["DatePaid/Disbursed"]);

                UIActions.Clear(EscrowInstallmentDisbursmentType);
                UIActions.GiveInput(EscrowInstallmentDisbursmentType,
                    TridVariable.EscrowInstallementGridInputs8["EscrowDisbursmentType"]);

                Thread.Sleep(250);
                UIActions.Click(EscrowDisbursmentTypeAutoSuggestion);
                UIActions.Click(EscrowInstallmentAddButton);
            }
        }
    }
}

