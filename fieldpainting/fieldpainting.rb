puts "What is the radius of the circle?"
r = gets.chomp.to_i
area = r * r * Math::PI

valid = true
while valid == true do
    puts "What color of paint do you want? Choose one of red, blue, green or yellow."
    color = gets.chomp.downcase

    if color == "red"
        numOfBuckets = (area / 100).ceil
        cost = numOfBuckets * 25
        valid = false
    elsif color == "blue"
        numOfBuckets = (area/120).ceil
        cost = numOfBuckets * 28
        valid = false
    elsif color == "green"
        numOfBuckets = (area/90).ceil
        cost = numOfBuckets * 33
        valid = false
    elsif color == "yellow"
        numOfBuckets = (area/70).ceil
        cost = numOfBuckets * 22
        valid = false
    else 
        puts "You didn't choose a valid color. Try again?"
    end

end

puts "You will need #{numOfBuckets} buckets of #{color} paint."
puts "Your total cost is $#{cost}." 