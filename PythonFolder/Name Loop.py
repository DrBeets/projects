# This program is designed to take the length of a hardcoded name
# and prompt the user for numbers equaling the length of the name
# The program will then output the total number of numbers entered,
# the total of the numbers, the average of the numbers, and the
# largest and smallest numbers entered.
# Written by Tristan Rogers 2021

# Define constants
F_NAME = "Tristan"
L_NAME = "Rogers"
# Calculation for the amount of numbers needed
LENGTH = len(F_NAME) + len(L_NAME)

# Variables for the loop
num1 = 0
count = 0
numBig = 0
numSmall = 0
numTotal = 0
# Introduction and user input prompt
print("Hello " + F_NAME, L_NAME)
print("Please enter", LENGTH, "numbers.")

# First number entered becomes the biggest and smallest first
numSmall = int(input("Enter a number:"))
count = count + 1
numBig = numSmall
numTotal = numTotal + numSmall

# Loop to create numbers
while count < LENGTH:
    count = count + 1    
    num1= int(input("Enter a number:"))
    numTotal = numTotal + num1 
    if num1 > numBig:
        numBig = num1
    elif num1 < numSmall:
        numSmall = num1
# output
print("Number of numbers entered:", count)
print("Total of the numbers entered:", numTotal)
numAvg = numTotal / LENGTH
print("Average of the numbers entered:", numAvg)
print("Largest number entered was:", numBig)
print("Smallest number entered was:", numSmall)
    
          
