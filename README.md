# OptionsHelper
Visualize your options trading contracts, such as calls and puts. 

# Problem Statement

Depending on your brokerage, you may not be able to easily see all the information you need about your past/current options trades. These trades may include covered calls and cash secured puts that you've sold and are still open. If you buy to close before the expiration date, then your brokerage website/app may show a new line item under your activities, so you may not be able to easily link your trades on the same contract or determine how much money you actually made.

# Proposed Solution

The OptionsHelper web app attempts to bridge that gap described in the above problem statement, by automatically linking trades and providing additional insights into the data you can export from your brokerage account, e.g. a csv file from your Fidelity account. 

# Brokerage Data

Your brokerage data may typically look like this:

|   |   |   |
|---|---|---|
| 01/02/2099  | YOU SOLD OPENING TRANSACTION CALL (SYM123) SOMECOMPANY123 FEB 28 99 $310 (100 SHS) (Cash)  | $543.21  |
|   |  ... |   |
|   |  ... |   |
| 02/01/2099  | YOU BOUGHT CLOSING TRANSACTION CALL (SYM123) SOMECOMPANY123 FEB 28 99 $310 (100 SHS) (Cash) | $32.10 |
|   |   |   |

It would be up to you, to associate these two separate transactions and figure out how much money you made.

# Temporary Workaround

As a temporary workaround, I've created a manual spreadsheet with the following fields:

- Symbol, e.g. SYM123
- Qty, e.g. 1
- Item, e.g. FEB 28 99 $310, where $310 is the strike price following the exp date
- Type, e.g. Put or Call
- Opened $$, e.g. $543.21, price to sell option during Sell to Open transaction
- Dt Opened, i.e. date of Sell to Open transaction
- Closed $$, $32.10, price to buy option, during Buy to Close transaction
- Exp Dt, i.e. expiration date
- Dt Closed, i.e. date of Buy to Close transaction
- P/L, e.g. $543.21 - $32.10 = $511.11, i.e. net profit (or loss)
- Profit %, e.g. percentage profit made, usually 100% if expired on exp date, but I try to keep 80% or higher profits when buying to close
- Days, e.g. 30 days, # of days that contract remained open (from open date to either exp date or buyback date)
- Called $$, i.e. strike price at which shares were called away (100 shares sold) at exp date
- Assigned $$, i.e. strike price at which shares were assigned (100 shares bought) at exp date

I also have other calculated values in my spreadsheet:
- monthly total of options sold
- monthly total of options bought back early before expiration
- net profit for the month (gets revised when bought back at less than 100% price)

This allows me to create charts for any of the above numbers.

# OptionsHelper Goals

The goal of this project is to automate the creation of the spreadsheet in a more user-friendly database-backed Web UI with auto-generated charts.




