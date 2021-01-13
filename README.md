# Lab02-ATM

**Author**: David Dicken
**Version**: 1.4.0 

## Overview
This program allows a user to either withdraw, deposit, or view their balance. As deposits and withdraws are made the balance will
update accordingly.

## Walk Through
* When you fire up this app you will be greeted with a greeting and a small menu of the options that you have. 
* Enter 1, 2, 3 for the option that you would like. You can press any other key to view your balance. 
* If you chose to deposit or withdraw you will be asked what amount you would like to deposit or withdraw. 
* If you attempt to withdraw more money then you have in your account you will get a message letting you 
  know that you do not have the funds for that transaction.
* And if you attempt to withdraw or deposit a negative number or enter anything other then a number you will 
  recieve an approriate message and tghe transaction will be canceled.
* Lastly after a transaction the program will ask you if you would like to do another transaction. Enter either y or n
  it is not case sensitive. N will exit the program and Y will allow you to make another transaction.

## Example
Hello, how may I help you today:
Press 1 for Deposit
Press 2 for Withdraw
Press 3 to Exit
Any other key to View Balance
1
Amount to Deposit:
1000
Your balance is: 1000

Would you like another transaction? Y/N

## Architecture
This app was built with Visual Studio using C#.

## Change Log
01-12-2021 Built out test.
01-12-2021 Built out Depost, Withdraw, and view balance methods.
01-12-2021 Added try catches where conversions are happening.
01-12-2021 Completed Read Me