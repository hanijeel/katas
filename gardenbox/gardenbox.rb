puts "What is the width of your garden box?"
width = gets.to_i
puts "The length?"
length = gets.to_i
area = width * length
puts "The area of the box is #{area}."
puts "The perimeter of the box is #{2 * (width + length)}."

puts "Which one of carrot, corn or beet do you plan to plant?"
answer = gets.downcase
if answer.include?"carrot"
    puts "You can have #{(area * 16) / 16} carrots in your garden box."
end
if answer.include?"corn"
    puts "You can have #{(area * 3) / 16} corns in your garden box."
end
if answer.include?"beet"
    puts "You can have #{(area * 9) / 16} beets in your garden box."
end