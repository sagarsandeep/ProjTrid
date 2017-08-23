Feature: AmortizationValidation

Scenario Outline: Giving inputs from Excel file and validating Payment Schedule values on Amortization page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Export data from excel sheet <eSheetName> for the scenario <RowNumber>
	And user have Escrow Grid data from excel sheet <egSheetName> for the scenario <RowNumber>
	And user have Payment Schedule data from excel sheet <psSheetName> for the scenario <RowNumber>
When user navigate to Loan Inputs Page
    And user enters Loan detail input values for computation
	And User selects Product Type
	And user selects loan type
	And user selects Calculation Method
	And user selects Frequency of Payments
	And user selects Loan Term
	And user selects Repayment Term Type
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
Then user navigates to Amortization Page
	And updated/computed Payment Stream Number value should display on Payment Schedule Grid
	And updated/computed Number of Payments value should display on Payment Schedule Grid
	And updated/computed Payment Amount value should display on Payment Schedule Grid
	And updated/computed Principal and Interest Payment value should display on Payment Schedule Grid
	And updated/computed PMI Payment value should display on Payment Schedule Grid
	#And updated/computed Ins Escrowed Amount value should display on Payment Schedule Grid
	#And updated/computed Tax Escrowed Amount value should display on Payment Schedule Grid
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | eSheetName | egSheetName | psSheetName     |
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 020        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 021        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 022        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 023        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 024        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 025        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 026        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 040        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 041        | 26        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 042        | 27        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 043        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 044        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 045        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 046        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 047        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 048        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 050        | 36        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 051        | 37        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 052        | 38        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 053        | 39        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 054        | 40        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 055        | 41        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 056        | 42        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 057        | 43        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 070        | 56        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 071        | 57        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 072        | 58        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 073        | 59        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 074        | 60        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 075        | 61        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 076        | 62        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 077        | 63        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 090        | 76        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 091        | 77        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 092        | 78        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 093        | 79        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 094        | 80        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 095        | 81        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 096        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 097        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 110        | 96        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 111        | 97        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 112        | 98        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 113        | 99        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 114        | 100       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 115        | 101       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 116        | 102       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 117        | 103       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 138        | 124       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 139        | 125       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 140        | 126       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 141        | 127       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 142        | 128       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 6          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 143        | 129       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 7          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 144        | 130       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 8          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 145        | 131       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 9          | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 146        | 132       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 10         | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 147        | 133       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 11         | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 150        | 136       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 12         | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |
	| 151        | 137       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 13         | ARMTerms   | Export     | EscrowGrid  | PaymentSchedule |


Scenario Outline: Uploading JSON file and validating Payment Schedule values on Amortization page
Given user is at TRID application homepage
	And user have Payment Schedule data from excel sheet <psSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
Then user navigates to Amortization Page
	And updated/computed Payment Stream Number value should display on Payment Schedule Grid
	And updated/computed Number of Payments value should display on Payment Schedule Grid
	And updated/computed Payment Amount value should display on Payment Schedule Grid
	And updated/computed Principal and Interest Payment value should display on Payment Schedule Grid
	And updated/computed PMI Payment value should display on Payment Schedule Grid
	#And updated/computed Ins Escrowed Amount value should display on Payment Schedule Grid
	#And updated/computed Tax Escrowed Amount value should display on Payment Schedule Grid
Examples:
	| ScenarioNo | RowNumber | psSheetName     |
	| 001        | 2         | PaymentSchedule |
	| 002        | 3         | PaymentSchedule |
	| 003        | 4         | PaymentSchedule |
	| 004        | 5         | PaymentSchedule |
	| 006        | 6         | PaymentSchedule |
	| 007        | 7         | PaymentSchedule |
	| 008        | 8         | PaymentSchedule |
	| 009        | 9         | PaymentSchedule |
	| 011        | 10        | PaymentSchedule |
	| 012        | 11        | PaymentSchedule |
	| 013        | 12        | PaymentSchedule |
	| 014        | 13        | PaymentSchedule |
	| 016        | 14        | PaymentSchedule |
	| 017        | 15        | PaymentSchedule |
	| 019        | 16        | PaymentSchedule |
	| 020        | 17        | PaymentSchedule |
	| 021        | 18        | PaymentSchedule |
	| 022        | 19        | PaymentSchedule |
	| 023        | 20        | PaymentSchedule |
	| 024        | 21        | PaymentSchedule |
	| 025        | 22        | PaymentSchedule |
	| 026        | 23        | PaymentSchedule |
	| 040        | 25        | PaymentSchedule |
	| 041        | 26        | PaymentSchedule |
	| 042        | 27        | PaymentSchedule |
	| 043        | 28        | PaymentSchedule |
	| 044        | 29        | PaymentSchedule |
	| 045        | 30        | PaymentSchedule |
	| 046        | 31        | PaymentSchedule |
	| 047        | 32        | PaymentSchedule |
	| 048        | 33        | PaymentSchedule |
	| 050        | 36        | PaymentSchedule |
	| 051        | 37        | PaymentSchedule |
	| 052        | 38        | PaymentSchedule |
	| 053        | 39        | PaymentSchedule |
	| 054        | 40        | PaymentSchedule |
	| 055        | 41        | PaymentSchedule |
	| 056        | 42        | PaymentSchedule |
	| 057        | 43        | PaymentSchedule |
	| 070        | 56        | PaymentSchedule |
	| 071        | 57        | PaymentSchedule |
	| 072        | 58        | PaymentSchedule |
	| 073        | 59        | PaymentSchedule |
	| 074        | 60        | PaymentSchedule |
	| 075        | 61        | PaymentSchedule |
	| 076        | 62        | PaymentSchedule |
	| 077        | 63        | PaymentSchedule |
	| 090        | 76        | PaymentSchedule |
	| 091        | 77        | PaymentSchedule |
	| 092        | 78        | PaymentSchedule |
	| 093        | 79        | PaymentSchedule |
	| 094        | 80        | PaymentSchedule |
	| 095        | 81        | PaymentSchedule |
	| 096        | 82        | PaymentSchedule |
	| 097        | 83        | PaymentSchedule |
	| 110        | 96        | PaymentSchedule |
	| 111        | 97        | PaymentSchedule |
	| 112        | 98        | PaymentSchedule |
	| 113        | 99        | PaymentSchedule |
	| 114        | 100       | PaymentSchedule |
	| 115        | 101       | PaymentSchedule |
	| 116        | 102       | PaymentSchedule |
	| 117        | 103       | PaymentSchedule |
	| 138        | 124       | PaymentSchedule |
	| 139        | 125       | PaymentSchedule |
	| 140        | 126       | PaymentSchedule |
	| 141        | 127       | PaymentSchedule |
	| 142        | 128       | PaymentSchedule |
	| 143        | 129       | PaymentSchedule |
	| 144        | 130       | PaymentSchedule |
	| 145        | 131       | PaymentSchedule |
	| 146        | 132       | PaymentSchedule |
	| 147        | 133       | PaymentSchedule |
	| 150        | 136       | PaymentSchedule |
	| 151        | 137       | PaymentSchedule |
