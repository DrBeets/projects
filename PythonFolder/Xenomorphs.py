##
# This program will ask the user for the kilopgram weights of three different
# xenomorphs. It will then calculate the average for the three.
# Written by Tristan Rogers

#Friendly greeting to start the program
print("Hello Ridley! I hope you are having a great time.\n")

#Promts the user to enter three xenomorph weights
xenomorph1 = int(input("Please enter the weight of the first xenomorph in kg: "))
xenomorph2 = int(input("Please enter the weight of the second xenomorph in kg: "))
xenomorph3 = int(input("Please enter the weight of the third xenomorph in kg: "))
print("\n")
#Calculate the average of the xenomorph weights
average = (xenomorph1 + xenomorph2 + xenomorph3) / 3
print("Calculating, one moment please...\n")

#Displays the information entered to the user
print("You have entered", xenomorph1, xenomorph2, xenomorph3, ", as the weights.")

#Displays the average weight and a farewell message
print("The average weight of the xenomorphs is: ", round(average,2), "kg.\n")
print("Have a great day, and remember; \"Don't make bad calls!\"")
