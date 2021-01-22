w = int(input("What is the width of your garden box?\n"))
l = int(input("What is the length of your garden box?\n"))
a = w * l

print(f"Your garden box has a perimeter of {2 * (w + l)} and an area of {a}.")

print(f"You can have {(a * 16) // 16} carrots, {(a * 3) // 16} corns, or {(a * 9) // 16} beets in your gardenbox.")