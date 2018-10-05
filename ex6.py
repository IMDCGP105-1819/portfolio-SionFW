#I use int(input) due to the input being a string, as a string I am unable to use it in mathmatical processes
user_age = int(input("What is your age? "))

if user_age > 23:
    print("Wow, thats older than Nsync")
else:
    print("Hippity hoppity, not as old as my property")

user_height = int(input("What is your height(cm)? "))

if user_height > 3000:
        print("Wow thats so tall,", user_height, "That's taller than the max digging depth of the Bagger 288!")
else:
    print("Not even close to the maximum digging depth of the Bagger 288!")

#This takes the inputed weight and calculates the amount of the user needed to match the weight of the set value.
user_weight = int(input("What is your weight?(lbs) "))

final_weight = 281 / user_weight
print("It'll take", final_weight, "of you to match the weight of Sonic the Hedgehog's, Doctor Eggman!")

user_hair = input("What colour is your hair? ")

print(user_hair, "is a good colour?")

user_eyes = input("What colour is your eyes? ")

print(user_eyes, "eyes?")
