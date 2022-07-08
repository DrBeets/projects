# This program will create a dictionary from an existing list and allow the user to 
# see the per capita of the country if the corresponding key exists.
# Written by Tristan Rogers 2021


#Creates the dictionary from the list
d = {}
with open("C:\\Python2021\\percapita.txt") as f:
    for line in f:
        (key, val) = line.split()
        d[key] = val
# displays the dictionary
print(d)

# Reads user input and displays value for the key
v = input("(Case Sensitive) Please enter country name: ")
if v in d :
    print("The per capita of the selected country is", d[v])
else :
    print("This country is not in the Dictionary")
