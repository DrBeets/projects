# This program will read a file and perform actions to the contents
# Written by Tristan Rogers 2021

# When removing the punctuation, I was unsure if the punctuation in the conjunction words needed to be taken out
# i.e ( Didn't, I'm) so I left them in. 

inputFile = open("C:\\Python2021\\cr.txt", "r")
total = 0
count = 0
average = 0.0
for line in inputFile :
    line = line.rstrip()
    wordList = line.split()
    
    for word in wordList :
        word = word.strip("\"'.,?!")
        wordLength = len(word)
        total += wordLength
        count += 1
average = total / count
        
print("The total word count is:" , count)
print("The total length of all the words is:" , total)
print("The average word length is: %.2f" % average)
