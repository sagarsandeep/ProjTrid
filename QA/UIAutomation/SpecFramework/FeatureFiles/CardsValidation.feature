Feature: CardsValidation

Scenario Outline: Giving inputs from Excel file and validating cards value on Closing Disclosure page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
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
	And user navigates to Export Page
	And user enters all input values for Export Page
	And user clicks on Export button to generate JSON file
Then user navigates to Closing Disclosure Cards Page
	And updated/computed Principal and Interest value should display on Closing Disclosure
	And updated/computed Mortgage Insurance value should display on Closing Disclosure
	And updated/computed Estimated Total Monthly Payment value should display on Closing Disclosure
	And updated/computed APR value should display on Closing Disclosure
	And APRWIN info value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed Amount Financed value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	And updated/computed Escrowed Prop Costs Over Year 1 from consummation date value should display on Closing Disclosure
	And updated/computed Escrowed Property Costs Over Year 1 from date of 1st loan payment value should display on Closing Disclosure
	And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	And updated/computed Estimated Escrow value should display on Closing Disclosure
	And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
	And user navigates to MI Inputs and Results Page
	And updated/computed Scheduled PMI Termination Date value should display on Closing Disclosure
	And updated/computed Cancel Date value should display on Closing Disclosure
	And updated/computed Upfront MIP values value should display on Closing Disclosure
	And user navigates to Loan Estimate Cards Page
	And updated/computed in 5 Years value should display on Loan Estimate
	And updated/computed in 5 Years principal value should display on Loan Estimate
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | eSheetName | egSheetName |
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 020        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 021        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 022        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 023        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 024        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 025        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 026        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 040        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 041        | 26        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 042        | 27        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 043        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 044        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 045        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 046        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 047        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 048        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 050        | 36        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 051        | 37        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 052        | 38        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 053        | 39        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 054        | 40        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 055        | 41        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 056        | 42        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 057        | 43        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 070        | 56        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 071        | 57        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 072        | 58        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 073        | 59        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 074        | 60        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 075        | 61        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 076        | 62        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 077        | 63        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 090        | 76        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 091        | 77        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 092        | 78        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 093        | 79        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 094        | 80        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 095        | 81        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 096        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 097        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 110        | 96        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 111        | 97        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 112        | 98        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 113        | 99        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 114        | 100       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 115        | 101       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 116        | 102       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 117        | 103       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  |
	| 138        | 124       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARMTerms   | Export     | EscrowGrid  |
	| 139        | 125       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARMTerms   | Export     | EscrowGrid  |
	| 140        | 126       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARMTerms   | Export     | EscrowGrid  |
	| 141        | 127       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARMTerms   | Export     | EscrowGrid  |
	| 142        | 128       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 6          | ARMTerms   | Export     | EscrowGrid  |
	| 143        | 129       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 7          | ARMTerms   | Export     | EscrowGrid  |
	| 144        | 130       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 8          | ARMTerms   | Export     | EscrowGrid  |
	| 145        | 131       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 9          | ARMTerms   | Export     | EscrowGrid  |
	| 146        | 132       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 10         | ARMTerms   | Export     | EscrowGrid  |
	| 147        | 133       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 11         | ARMTerms   | Export     | EscrowGrid  |
	| 150        | 136       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 12         | ARMTerms   | Export     | EscrowGrid  | 
	| 151        | 137       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 13         | ARMTerms   | Export     | EscrowGrid  | 



Scenario Outline: Uploading JSON file and Validating cards value on Closing Disclosure page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
Then user navigates to Closing Disclosure Cards Page
	And updated/computed Principal and Interest value should display on Closing Disclosure
	And updated/computed Mortgage Insurance value should display on Closing Disclosure
	And updated/computed Estimated Total Monthly Payment value should display on Closing Disclosure
	And updated/computed APR value should display on Closing Disclosure
	And APRWIN info value should display on Closing Disclosure
	And updated/computed Balloon Amount value should display on Closing Disclosure
	And updated/computed Total of Payments value should display on Closing Disclosure
	And updated/computed Finance Charge value should display on Closing Disclosure
	And updated/computed Amount Financed value should display on Closing Disclosure
	And updated/computed TIP value should display on Closing Disclosure
	And updated/computed Escrowed Prop Costs Over Year 1 from consummation date value should display on Closing Disclosure
	And updated/computed Escrowed Property Costs Over Year 1 from date of 1st loan payment value should display on Closing Disclosure
	And updated/computed Initial Escrow Payment value should display on Closing Disclosure
	And updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure
	And updated/computed Estimated Escrow value should display on Closing Disclosure
	And updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure
	And user navigates to MI Inputs and Results Page
	And updated/computed Scheduled PMI Termination Date value should display on Closing Disclosure
	And updated/computed Cancel Date value should display on Closing Disclosure
	And updated/computed Upfront MIP values value should display on Closing Disclosure
	And user navigates to Loan Estimate Cards Page
	And updated/computed in 5 Years value should display on Loan Estimate
	And updated/computed in 5 Years principal value should display on Loan Estimate
Examples:
	| ScenarioNo | RowNumber | cdSheetName       |
	| 001        | 2         | ClosingDisclosure |
	| 002        | 3         | ClosingDisclosure |
	| 003        | 4         | ClosingDisclosure |
	| 004        | 5         | ClosingDisclosure |
	| 006        | 6         | ClosingDisclosure |
	| 007        | 7         | ClosingDisclosure |
	| 008        | 8         | ClosingDisclosure |
	| 009        | 9         | ClosingDisclosure |
	| 011        | 10        | ClosingDisclosure |
	| 012        | 11        | ClosingDisclosure |
	| 013        | 12        | ClosingDisclosure |
	| 014        | 13        | ClosingDisclosure |
	| 016        | 14        | ClosingDisclosure |
	| 017        | 15        | ClosingDisclosure |
	| 019        | 16        | ClosingDisclosure |
	| 020        | 17        | ClosingDisclosure |
	| 021        | 18        | ClosingDisclosure |
	| 022        | 19        | ClosingDisclosure |
	| 023        | 20        | ClosingDisclosure |
	| 024        | 21        | ClosingDisclosure |
	| 025        | 22        | ClosingDisclosure |
	| 026        | 23        | ClosingDisclosure |
	| 040        | 25        | ClosingDisclosure |
	| 041        | 26        | ClosingDisclosure |
	| 042        | 27        | ClosingDisclosure |
	| 043        | 28        | ClosingDisclosure |
	| 044        | 29        | ClosingDisclosure |
	| 045        | 30        | ClosingDisclosure |
	| 046        | 31        | ClosingDisclosure |
	| 047        | 32        | ClosingDisclosure |
	| 048        | 33        | ClosingDisclosure |
	| 050        | 36        | ClosingDisclosure |
	| 051        | 37        | ClosingDisclosure |
	| 052        | 38        | ClosingDisclosure |
	| 053        | 39        | ClosingDisclosure |
	| 054        | 40        | ClosingDisclosure |
	| 055        | 41        | ClosingDisclosure |
	| 056        | 42        | ClosingDisclosure |
	| 057        | 43        | ClosingDisclosure |
	| 070        | 56        | ClosingDisclosure |
	| 071        | 57        | ClosingDisclosure |
	| 072        | 58        | ClosingDisclosure |
	| 073        | 59        | ClosingDisclosure |
	| 074        | 60        | ClosingDisclosure |
	| 075        | 61        | ClosingDisclosure |
	| 076        | 62        | ClosingDisclosure |
	| 077        | 63        | ClosingDisclosure |
	| 090        | 76        | ClosingDisclosure |
	| 091        | 77        | ClosingDisclosure |
	| 092        | 78        | ClosingDisclosure |
	| 093        | 79        | ClosingDisclosure |
	| 094        | 80        | ClosingDisclosure |
	| 095        | 81        | ClosingDisclosure |
	| 096        | 82        | ClosingDisclosure |
	| 097        | 83        | ClosingDisclosure |
	| 110        | 96        | ClosingDisclosure |
	| 111        | 97        | ClosingDisclosure |
	| 112        | 98        | ClosingDisclosure |
	| 113        | 99        | ClosingDisclosure |
	| 114        | 100       | ClosingDisclosure |
	| 115        | 101       | ClosingDisclosure |
	| 116        | 102       | ClosingDisclosure |
	| 117        | 103       | ClosingDisclosure |
	| 138        | 124       | ClosingDisclosure |
	| 139        | 125       | ClosingDisclosure |
	| 140        | 126       | ClosingDisclosure |
	| 141        | 127       | ClosingDisclosure |
	| 142        | 128       | ClosingDisclosure |
	| 143        | 129       | ClosingDisclosure |
	| 144        | 130       | ClosingDisclosure |
	| 145        | 131       | ClosingDisclosure |
	| 146        | 132       | ClosingDisclosure |
	| 147        | 133       | ClosingDisclosure |
	| 150        | 136       | ClosingDisclosure |
	| 151        | 137       | ClosingDisclosure |
