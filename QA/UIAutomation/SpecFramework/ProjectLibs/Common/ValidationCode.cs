using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TRID.ActionClasses;

namespace TRID.ProjectLibs.Common
{
    class ValidationCode
    {
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public double ValueDifference;
        public static string CardsFailure = "";
        public void NumericValueCardsValidation(string cardName, By actualComputedValue, string expectedComputedValue, By actualDisclosedValue, string expectedDisclosedValue, By actualVarianceValue, string expectedVarianceValue)
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(actualComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(expectedComputedValue), 2);
                ValueDifference = Math.Abs(expectedCValue - actualCValue);
                Assert.AreEqual(expectedCValue, actualCValue,
                    "Computed value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(actualDisclosedValue));
                var expectedDValue = Math.Round(Convert.ToDouble(expectedDisclosedValue), 2);
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

                var expectedVValue = Convert.ToDouble(expectedVarianceValue);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(actualVarianceValue));
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
                    CardsFailure += "|| "+ cardName + " || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }


        public void DateValueCardsValidation(string cardName, By actualComputedValue, string expectedComputedValue, By actualDisclosedValue, string expectedDisclosedValue, By actualVarianceValue, string expectedVarianceValue)
        {
            if (TridVariable.ScheduledPmiTerminationDate.Equals("N/A"))
            {
                try
                {
                    var actualCValue = UIActions.GetText(actualComputedValue);
                    var expectedCValue = "(C): " + expectedComputedValue;
                    Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                    Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                    Console.WriteLine("============================================================");

                    var actualDValue = UIActions.GetText(actualDisclosedValue);
                    var expectedDValue = "(D): " + expectedDisclosedValue;

                    Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected");

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedDisclosedValue :{0}", expectedDValue);
                    Console.WriteLine("ActualDisclosedValue :{0}", actualDValue);
                    Console.WriteLine("============================================================");

                    var expectedVValue = "(V): N/A Days";
                    var actualVValue = UIActions.GetText(actualVarianceValue);

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
                    CardsFailure += "|| " + cardName + " || : " + e +
                                    " \n ====================================================================================\n";
                }
            }               
            else
            {
                try
                {
                    var actualCValue = ProjActions.GetDatePart(actualComputedValue);
                    var expectedCValue =
                        Convert.ToDateTime(ProjActions.GetDate(expectedComputedValue));
                    ValueDifference = (expectedCValue - actualCValue).TotalDays;
                    Assert.AreEqual(expectedCValue, actualCValue,
                        "Computed value does not match as expected with the difference of {0}", ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedComputedValue :{0}", expectedCValue);
                    Console.WriteLine("ActualComputedValue :{0}", actualCValue);
                    Console.WriteLine("============================================================");

                    var actualDValue = ProjActions.GetDatePart(actualDisclosedValue);
                    var expectedDValue =
                        Convert.ToDateTime(ProjActions.GetDate(expectedDisclosedValue));
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

                    var expectedVValue = Convert.ToDouble(expectedVarianceValue);
                    var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(actualVarianceValue));
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
                    CardsFailure += "|| " + cardName + " || : " + e +
                                    " \n ====================================================================================\n";
                }
            }
        }     
    }
}


//ValidationCode validationCode = new ValidationCode();
//validationCode.NumericValueCardsValidation("PrincipalAndInt", PiComputedValue, TridVariable.PrincipalAndInt, PiDisclosureValue, TridVariable.DisclosedMonthlyPrincipalAndInterest, PiVarianceValue, TridVariable.VariancePrincipalAndInt);
