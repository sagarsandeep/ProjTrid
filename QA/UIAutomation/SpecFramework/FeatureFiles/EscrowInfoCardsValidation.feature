Feature: EscrowInfoCardsValidation

Scenario Outline: Giving inputs from Excel file and validating Escrow Info cards value on Escrow Info page
Given user is at TRID application homepage
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <RowNumber>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <RowNumber>
	And user have variable loan data from excel sheet <aSheetName> for the scenario <aRowNumber>
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <RowNumber>
	And user have Export data from excel sheet <eSheetName> for the scenario <RowNumber>
	And user have Escrow Grid data from excel sheet <egSheetName> for the scenario <RowNumber>
	And user have Escrow Info data from excel sheet <eiSheetName> for the scenario <RowNumber>
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
Then user navigates to Escrow Trial Balance Page
	And updated/computed Insurance Initial Deposit value should display on Escrow Info
	And updated/computed Insurance Period Deposit value should display on Escrow Info
	And updated/computed Insurance Low Balance value should display on Escrow Info
	And updated/computed Insurance Cushion value should display on Escrow Info
	And updated/computed Insurance Total Annual Disbursed value should display on Escrow Info
	And updated/computed Tax Initial Deposit value should display on Escrow Info
	And updated/computed Tax Period Deposit value should display on Escrow Info
	And updated/computed Tax Low Balance value should display on Escrow Info
	And updated/computed Tax Cushion value should display on Escrow Info
	And updated/computed Tax Total Annual Disbursed value should display on Escrow Info
	And updated/computed PMI Initial Deposit value should display on Escrow Info
	And updated/computed PMI Period Deposit value should display on Escrow Info
	And updated/computed PMI Low Balance value should display on Escrow Info
	And updated/computed PMI Cushion value should display on Escrow Info
	And updated/computed PMI Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other1 Initial Deposit value should display on Escrow Info
	And updated/computed Other1 Period Deposit value should display on Escrow Info
	And updated/computed Other1 Low Balance value should display on Escrow Info
	And updated/computed Other1 Cushion value should display on Escrow Info
	And updated/computed Other1 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other2 Initial Deposit value should display on Escrow Info
	And updated/computed Other2 Period Deposit value should display on Escrow Info
	And updated/computed Other2 Low Balance value should display on Escrow Info
	And updated/computed Other2 Cushion value should display on Escrow Info
	And updated/computed Other2 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Aggregate Initial Deposit value should display on Escrow Info
	And updated/computed Aggregate Period Deposit value should display on Escrow Info
	And updated/computed Aggregate Low Balance value should display on Escrow Info
	And updated/computed Aggregate Cushion value should display on Escrow Info
	And updated/computed Aggregate Total Annual Disbursed value should display on Escrow Info
Examples:
	| ScenarioNo | RowNumber | pcSheetName    | miSheetName       | cdSheetName       | aRowNumber | aSheetName | eSheetName | egSheetName | eiSheetName |
	| 001        | 2         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 002        | 3         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 003        | 4         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 004        | 5         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 006        | 6         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 007        | 7         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 008        | 8         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 009        | 9         | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 011        | 10        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 012        | 11        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 013        | 12        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 014        | 13        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 016        | 14        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 017        | 15        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 019        | 16        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 020        | 17        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 021        | 18        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 022        | 19        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 023        | 20        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 024        | 21        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 025        | 22        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 026        | 23        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 040        | 25        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 041        | 26        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 042        | 27        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 043        | 28        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 044        | 29        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 045        | 30        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 046        | 31        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 047        | 32        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 048        | 33        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 050        | 36        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 051        | 37        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 052        | 38        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 053        | 39        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 054        | 40        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 055        | 41        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 056        | 42        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 057        | 43        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 070        | 56        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 071        | 57        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 072        | 58        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 073        | 59        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 074        | 60        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 075        | 61        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 076        | 62        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 077        | 63        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 090        | 76        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 091        | 77        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 092        | 78        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 093        | 79        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 094        | 80        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 095        | 81        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 096        | 82        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 097        | 83        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 110        | 96        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 111        | 97        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 112        | 98        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 113        | 99        | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 114        | 100       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 115        | 101       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 116        | 102       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 117        | 103       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 1          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 138        | 124       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 2          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 139        | 125       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 3          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 140        | 126       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 4          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 141        | 127       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 5          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 142        | 128       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 6          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 143        | 129       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 7          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 144        | 130       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 8          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 145        | 131       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 9          | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 146        | 132       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 10         | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 147        | 133       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 11         | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 150        | 136       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 12         | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |
	| 151        | 137       | PrepaidCharges | MortgageInsurance | ClosingDisclosure | 13         | ARMTerms   | Export     | EscrowGrid  | EscrowInfo  |


Scenario Outline: Uploading JSON file and validating Escrow Info cards value on Escrow Info page
Given user is at TRID application homepage
	And user have Escrow Info data from excel sheet <eiSheetName> for the scenario <RowNumber>
When user upload json file for the scenario
Then user navigates to Escrow Trial Balance Page
	And updated/computed Insurance Initial Deposit value should display on Escrow Info
	And updated/computed Insurance Period Deposit value should display on Escrow Info
	And updated/computed Insurance Low Balance value should display on Escrow Info
	And updated/computed Insurance Cushion value should display on Escrow Info
	And updated/computed Insurance Total Annual Disbursed value should display on Escrow Info
	And updated/computed Tax Initial Deposit value should display on Escrow Info
	And updated/computed Tax Period Deposit value should display on Escrow Info
	And updated/computed Tax Low Balance value should display on Escrow Info
	And updated/computed Tax Cushion value should display on Escrow Info
	And updated/computed Tax Total Annual Disbursed value should display on Escrow Info
	And updated/computed PMI Initial Deposit value should display on Escrow Info
	And updated/computed PMI Period Deposit value should display on Escrow Info
	And updated/computed PMI Low Balance value should display on Escrow Info
	And updated/computed PMI Cushion value should display on Escrow Info
	And updated/computed PMI Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other1 Initial Deposit value should display on Escrow Info
	And updated/computed Other1 Period Deposit value should display on Escrow Info
	And updated/computed Other1 Low Balance value should display on Escrow Info
	And updated/computed Other1 Cushion value should display on Escrow Info
	And updated/computed Other1 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Other2 Initial Deposit value should display on Escrow Info
	And updated/computed Other2 Period Deposit value should display on Escrow Info
	And updated/computed Other2 Low Balance value should display on Escrow Info
	And updated/computed Other2 Cushion value should display on Escrow Info
	And updated/computed Other2 Total Annual Disbursed value should display on Escrow Info
	And updated/computed Aggregate Initial Deposit value should display on Escrow Info
	And updated/computed Aggregate Period Deposit value should display on Escrow Info
	And updated/computed Aggregate Low Balance value should display on Escrow Info
	And updated/computed Aggregate Cushion value should display on Escrow Info
	And updated/computed Aggregate Total Annual Disbursed value should display on Escrow Info
Examples:
	| ScenarioNo | RowNumber | eiSheetName |
	| 001        | 2         | EscrowInfo  |
	| 002        | 3         | EscrowInfo  |
	| 003        | 4         | EscrowInfo  |
	| 004        | 5         | EscrowInfo  |
	| 006        | 6         | EscrowInfo  |
	| 007        | 7         | EscrowInfo  |
	| 008        | 8         | EscrowInfo  |
	| 009        | 9         | EscrowInfo  |
	| 011        | 10        | EscrowInfo  |
	| 012        | 11        | EscrowInfo  |
	| 013        | 12        | EscrowInfo  |
	| 014        | 13        | EscrowInfo  |
	| 016        | 14        | EscrowInfo  |
	| 017        | 15        | EscrowInfo  |
	| 019        | 16        | EscrowInfo  |
	| 020        | 17        | EscrowInfo  |
	| 021        | 18        | EscrowInfo  |
	| 022        | 19        | EscrowInfo  |
	| 023        | 20        | EscrowInfo  |
	| 024        | 21        | EscrowInfo  |
	| 025        | 22        | EscrowInfo  |
	| 026        | 23        | EscrowInfo  |
	| 040        | 25        | EscrowInfo  |
	| 041        | 26        | EscrowInfo  |
	| 042        | 27        | EscrowInfo  |
	| 043        | 28        | EscrowInfo  |
	| 044        | 29        | EscrowInfo  |
	| 045        | 30        | EscrowInfo  |
	| 046        | 31        | EscrowInfo  |
	| 047        | 32        | EscrowInfo  |
	| 048        | 33        | EscrowInfo  |
	| 050        | 36        | EscrowInfo  |
	| 051        | 37        | EscrowInfo  |
	| 052        | 38        | EscrowInfo  |
	| 053        | 39        | EscrowInfo  |
	| 054        | 40        | EscrowInfo  |
	| 055        | 41        | EscrowInfo  |
	| 056        | 42        | EscrowInfo  |
	| 057        | 43        | EscrowInfo  |
	| 070        | 56        | EscrowInfo  |
	| 071        | 57        | EscrowInfo  |
	| 072        | 58        | EscrowInfo  |
	| 073        | 59        | EscrowInfo  |
	| 074        | 60        | EscrowInfo  |
	| 075        | 61        | EscrowInfo  |
	| 076        | 62        | EscrowInfo  |
	| 077        | 63        | EscrowInfo  |
	| 090        | 76        | EscrowInfo  |
	| 091        | 77        | EscrowInfo  |
	| 092        | 78        | EscrowInfo  |
	| 093        | 79        | EscrowInfo  |
	| 094        | 80        | EscrowInfo  |
	| 095        | 81        | EscrowInfo  |
	| 096        | 82        | EscrowInfo  |
	| 097        | 83        | EscrowInfo  |
	| 110        | 96        | EscrowInfo  |
	| 111        | 97        | EscrowInfo  |
	| 112        | 98        | EscrowInfo  |
	| 113        | 99        | EscrowInfo  |
	| 114        | 100       | EscrowInfo  |
	| 115        | 101       | EscrowInfo  |
	| 116        | 102       | EscrowInfo  |
	| 117        | 103       | EscrowInfo  |
	| 138        | 124       | EscrowInfo  |
	| 139        | 125       | EscrowInfo  |
	| 140        | 126       | EscrowInfo  |
	| 141        | 127       | EscrowInfo  |
	| 142        | 128       | EscrowInfo  |
	| 143        | 129       | EscrowInfo  |
	| 144        | 130       | EscrowInfo  |
	| 145        | 131       | EscrowInfo  |
	| 146        | 132       | EscrowInfo  |
	| 147        | 133       | EscrowInfo  |
	| 150        | 136       | EscrowInfo  |
	| 151        | 137       | EscrowInfo  |