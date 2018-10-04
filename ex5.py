bottle = 99
while bottle > 0:
    print(bottle, "bottles of beer on the wall", bottle, "of beer, take one down, pass it around,", bottle, "bottles of beer on the wall")
    bottle = bottle-1

    if bottle == 0:
        print("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall...")
