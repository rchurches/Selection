import random
numbans = random.randint(1,100) 
print(numbans)
print("Guess what number I am? ")
numberguess=int(input())
count=int(1)

while numberguess != numbans:
    count +=1
    print("Try again!!")
    print("Guess what number I am? ")
    numberguess=int(input())  
print(" Well done number of tries = " + str(count))