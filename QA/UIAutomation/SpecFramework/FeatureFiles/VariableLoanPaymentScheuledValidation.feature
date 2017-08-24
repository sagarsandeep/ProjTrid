Feature: VariableLoanPaymentScheuledValidation

Scenario Outline: Giving inputs from Excel file and validating Payment Schedule Best Case on Arms page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have ARM Best Case variable loan data from excel sheet <abcSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Export data from excel sheet <eSheetName> for the scenario <RowNumber>
	And user have Escrow Grid data from excel sheet <egSheetName> for the scenario <RowNumber>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And user enters Loan detail input values for computation	
	And user enters Escrow Grid Input values
	And user enters all input values for Prepaid Charges
	And user enters input value for prepaid custom fields
	And user navigates to MI Inputs and Results Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters FHA/USDA Loan Details
	And user enters disclosed input values for Mortgage Insurance
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for Closing Disclosure Loan Terms & Projected Payments
	And user enters disclosed input values for Closing Disclosure Loan Calculations
	And user enters disclosed input values for Property Cost and Escrow
	And user navigates to Loan Estimate Cards Page
	And user enters disclsoed input values for Loan Estimate - Comparisons
	#And user navigates to Export Page
	#And user enters all input values for Export Page
	#And user clicks on Export button to generate JSON file
Then user navigates to ARM Page
	And updated/computed Payment Stream Number value should display on ARM Best Case
	And updated/computed Number of Payments value should display on ARM Best Case
	And updated/computed Payment Amount value should display on ARM Best Case
	And updated/computed Principal and Interest Payment value should display on ARM Best Case
	And updated/computed PMI Payment value should display on ARM Best Case
	#And updated/computed Ins Escrowed Amount value should display on ARM Best Case
	#And updated/computed Tax Escrowed Amount value should display on ARM Best Case
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | abcSheetName | eSheetName | egSheetName |
	| 138        | 124       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 139        | 125       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 140        | 126       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 141        | 127       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 142        | 128       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 6          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 143        | 129       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 7          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 144        | 130       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 8          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 145        | 131       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 9          | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 146        | 132       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 10         | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |
	| 147        | 133       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 11         | ARMTerms   | ARMBestCase  | Export     | EscrowGrid  |




Scenario Outline: Giving inputs from Excel file and validating Payment Schedule Worst Case on Arms page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have ARM Worst Case variable loan data from excel sheet <awcSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Export data from excel sheet <eSheetName> for the scenario <RowNumber>
	And user have Escrow Grid data from excel sheet <egSheetName> for the scenario <RowNumber>
When user navigate to Loan Inputs Page
	And user selects Calculation Method
	And user selects loan type
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
    And user enters Loan detail input values for computation	
	And user enters Escrow Grid Input values
	And user enters all input values for Prepaid Charges
	And user enters input value for prepaid custom fields
	And user navigates to MI Inputs and Results Page
	And user enters pmi rate values
	And user enters other pmi input values
	And user enters FHA/USDA Loan Details
	And user enters disclosed input values for Mortgage Insurance
	And user navigates to Disclosure Inputs Page
	And user enters disclosed input values for Closing Disclosure Loan Terms & Projected Payments
	And user enters disclosed input values for Closing Disclosure Loan Calculations
	And user enters disclosed input values for Property Cost and Escrow
	And user navigates to Loan Estimate Cards Page
	And user enters disclsoed input values for Loan Estimate - Comparisons
	#And user navigates to Export Page
	#And user enters all input values for Export Page
	#And user clicks on Export button to generate JSON file
Then user navigates to ARM Page
	And updated/computed Payment Stream Number value should display on ARM Worst Case
	And updated/computed Number of Payments value should display on ARM Worst Case
	And updated/computed Payment Amount value should display on ARM Worst Case
	And updated/computed Period Payment value should display on ARM Worst Case
	And updated/computed Period PMI value should display on ARM Worst Case
	#And updated/computed Ins Escrowed Amount value should display on ARM Worst Case
	#And updated/computed Tax Escrowed Amount value should display on ARM Worst Case
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | awcSheetName | eSheetName | egSheetName |
	| 138        | 124       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 139        | 125       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 140        | 126       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 141        | 127       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 142        | 128       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 6          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 143        | 129       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 7          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 144        | 130       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 8          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 145        | 131       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 9          | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 146        | 132       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 10         | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |
	| 147        | 133       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 11         | ARMTerms   | ARMWorstCase | Export     | EscrowGrid  |


Scenario Outline: Uploading JSON file and validating Payment Schedule Best Case on Arms page
Given user is at TRID application homepage
	And user have ARM Best Case variable loan data from excel sheet <abcSheetName> for the scenario <aRowNumber>
When user upload json file for the scenario
Then user navigates to ARM Page
	And updated/computed Payment Stream Number value should display on ARM Best Case
	And updated/computed Number of Payments value should display on ARM Best Case
	And updated/computed Payment Amount value should display on ARM Best Case
	And updated/computed Principal and Interest Payment value should display on ARM Best Case
	And updated/computed PMI Payment value should display on ARM Best Case
	#And updated/computed Ins Escrowed Amount value should display on ARM Best Case
	#And updated/computed Tax Escrowed Amount value should display on ARM Best Case
Examples:
	| ScenarioNo | aRowNumber | abcSheetName |
	| 138        | 2          | ARMBestCase  |
	| 139        | 3          | ARMBestCase  |
	| 140        | 4          | ARMBestCase  |
	| 141        | 5          | ARMBestCase  |
	| 142        | 6          | ARMBestCase  |
	| 143        | 7          | ARMBestCase  |
	| 144        | 8          | ARMBestCase  |
	| 145        | 9          | ARMBestCase  |
	| 146        | 10         | ARMBestCase  |
	| 147        | 11         | ARMBestCase  |


Scenario Outline: Uploading JSON file and validating Payment Schedule Worst Case on Arms page
Given user is at TRID application homepage
	And user have ARM Worst Case variable loan data from excel sheet <awcSheetName> for the scenario <aRowNumber>
When user upload json file for the scenario
Then user navigates to ARM Page
	And updated/computed Payment Stream Number value should display on ARM Worst Case
	And updated/computed Number of Payments value should display on ARM Worst Case
	And updated/computed Payment Amount value should display on ARM Worst Case
	And updated/computed Period Payment value should display on ARM Worst Case
	And updated/computed Period PMI value should display on ARM Worst Case
	#And updated/computed Ins Escrowed Amount value should display on ARM Worst Case
	#And updated/computed Tax Escrowed Amount value should display on ARM Worst Case
	Examples:
	| ScenarioNo | aRowNumber | awcSheetName |
	| 138        | 2          | ARMWorstCase |
	| 139        | 3          | ARMWorstCase |
	| 140        | 4          | ARMWorstCase |
	| 141        | 5          | ARMWorstCase |
	| 142        | 6          | ARMWorstCase |
	| 143        | 7          | ARMWorstCase |
	| 144        | 8          | ARMWorstCase |
	| 145        | 9          | ARMWorstCase |
	| 146        | 10         | ARMWorstCase |
	| 147        | 11         | ARMWorstCase |