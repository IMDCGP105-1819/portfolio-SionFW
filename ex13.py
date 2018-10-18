from random import randint

Number = randint(0,101)
GuessAmount = 0
Correct = False

while not Correct:
    Input = int(input("Guess a number (0-100)"))
    GuessAmount += 1
    if Input > Number:
        print("Lower!")
    elif Input < Number:
        print("Higher!")
    elif Input == Number:
        print("Correct!")
        print(GuessAmount)
        Correct = True
