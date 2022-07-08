# This program will charge customers the appropriate price
# based on the weight of the consumed food
# Written by Tristan Rogers 2021

# define constant variables
T_ONE_WEIGHT = 2.0
T_TWO_WEIGHT = 3.5
T_THREE_WEIGHT = 7.0
TIER_ONE = 17.99
TIER_TWO = 24.99
TIER_THREE = 31.99
TIER_FOUR = 49.99
SALES_TAX = 0.0615

# Prompt for customer name
custname = input("Please enter the customer name: ")

# Prompt the number of pounds eaten
lbseaten = int(input("Please enter the weight of the food consumed in pounds: "))

# Calculate the total based on prices using if loops

if lbseaten < T_ONE_WEIGHT:
    price = TIER_ONE
elif (T_ONE_WEIGHT < lbseaten <= T_TWO_WEIGHT):
    price = TIER_TWO
elif (T_TWO_WEIGHT < lbseaten <= T_THREE_WEIGHT):
    price = TIER_THREE
elif (lbseaten > T_FOUR_WEIGHT):
    price = TIER_FOUR

# Display results
tax = price * SALES_TAX
total = price + tax

print ("Customer name : ", custname)
print ("Subtotal :", price)
print ("Tax : ", round(tax,2))
print ("Total : ", round(total,2))
print ("Have a great day!")