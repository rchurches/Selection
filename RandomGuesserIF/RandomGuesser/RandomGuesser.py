import random
numbans = random.randint(1,100) 
print(numbans)
print("Guess what number I am? ")
numberguess=int(input())


if numberguess==numbans:
    print(" Well done")
else:
    print("Oh No you didn't")
