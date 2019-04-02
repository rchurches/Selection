import random
numbans = random.randint(1,100) 
print(numbans)
print("Guess what number I am? ")
numberguess=int(input())
count=int(1)

while numberguess != numbans:
    count +=1
    print("Try again!!")
    if numberguess<numbans:
        print("Guess what number I am? Hint, I am Bigger than " + str(numberguess))
        numberguess=int(input())  
    else:
        print("Guess what number I am? Hint, I am Smaller than " + str(numberguess))
        numberguess=int(input()) 
print(" Well done number of tries = " + str(count))