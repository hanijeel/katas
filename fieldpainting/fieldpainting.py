import math

rad = int(input("What is the radius of the circle?\n"))
area = rad * rad * (math.pi)

valid = True
while valid:
    color = input("What color of paint do you want? Choose one of red, blue, green or yellow.\n").lower()
    if color == 'red':
        num_buckets = math.ceil(area / 100)
        cost = num_buckets * 25
        valid = False
    elif color == 'blue':
        num_buckets = math.ceil(area / 120)
        cost = num_buckets * 28
        valid = False
    elif color == 'green':
        num_buckets = math.ceil(area / 90)
        cost = num_buckets * 33
        valid = False
    elif color == 'yellow':
        num_buckets = math.ceil(area / 70)
        cost = num_buckets * 22
        valid = False
    else:
        print("You didn't choose a valid color. Try again?\n")

print(f"You will need {int(num_buckets)} buckets of {color} paint.")
print(f"Your total cost is {cost} dollars.")