# MasterMind_Project

## C# Console application that is a simpler version of the game MasterMind.

### Tools : Microsoft Visual Studio 2019.

### Project Description: 

It is a C# console application that is a simple version of Mastermind. The computer will randomly generate a number. The randomly generated number shall be four (4) digits in length, with each digit between the numbers 1 and 6. Which won't be known to the player and player will be asked to enter a combination of 4 - digit number. After the player enters a combination, a minus (-) sign will be printed for every digit that is correct but in the wrong position, and a plus (+) sign will be printed for every digit that is both correct and in the correct position. Nothing should be printed for incorrect digits. The player has ten (10) attempts to guess the number correctly before receiving a message that they have lost.

### Implementation Process:
#### Total time comsumed: 6 hours.

1) The very first step was to list out the variables required.
2) Preparing the Pseudo code for programming the application.
3) Naive Approach : At first to check if the logic is working correctly, I built a naive approach in which I hard-coded the      values and checked if the program is working correctly.
4) Pros: A little more flexible and dynamic than the current one. 
   Cons: Use of nested for loops, resulting in the time-complexity of O(n^2).
5) Final Approach : In this all the hard-coded values were removed and used loops to generate values and print the required      results.
6) Eliminated the nested for loops, resulting in a better time-complexity.
7) Testing: Used different inputs, tested with multiple values to see if the application is wokring correctly.

### Flow of the application.
![Application flow](https://github.com/arkishshah/MasterMind_Project/blob/master/App-Flow.png)




