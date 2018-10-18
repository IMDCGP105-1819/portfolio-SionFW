low = int(input("Please input a low number! "))
high = int(input("Pleae input a  high number!"))


for number in range(low,high):
    number += 1
    if (number%5 == 0):
        print("Buzz")

    elif (number&3 == 0):
        print("Fizz")

    elif (number%3 == 0 and number%5 == 0):
        print("FizzBuzz")
    else:
        print (number)
