# This program contains the last names of players in an esports team that starts
# with the letter R, stores the names in a list, and performs various list processes.
# 
# The team name is Royal Never Give Up, a chinese esports team that has won over 
# 1.2 million dollars in prize money from competitive Dota 2 (A popular MOBA) events.
# MOBA stands for Multiplayer Online Battle Arena, where two teams of 5 compete over objectives.
#
# Written by Tristan Rogers 2021

# Creating the list
RnguRoster = ['Sun', 'Zhong', 'Chong', 'Xie', 'Zhenxiong'] 

print("Team Royal Never Give Up Dota 2 Roster")
# Prints the lsit with a dash seperator
print(*RnguRoster, sep = " - ")
print("Team RNGU welcomes their newest member, Zootopia!")
# Appends the list with additional name Zootopia
RnguRoster.append("Zootopia")
print(*RnguRoster, sep =  " - ")
# Sorts the list in reverse alphabetical order 
RnguRoster.sort(reverse=True)
print(*RnguRoster, sep = " - ")
# Removes the team member in position 2 of the Sorted list
RnguRoster.pop(1)
print(*RnguRoster, sep = " - ")
