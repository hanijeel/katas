# Solution1 (by Kim)
# braille_hash ={"a" => "⠁ ", "b" => "⠃ ", "c" => "⠉ ", "d" => "⠙ ", "e" => "⠑ ","f"=>"⠋ ", "the rest" => "⠛⠓⠊⠚⠅⠇⠍⠝⠕⠏⠟⠗⠎⠞⠥⠧⠺⠭⠽⠵"}

# puts "Enter a message to be translated into braille:"
# user_input = gets.chomp.downcase
# (0..user_input.length).each do |letter|
#     print braille_hash[user_input[letter]]
# end


# Solution2 (by James)

# b_top = {"a" => "O. ", "b" => "O. ", "c" => "OO ", "d" => "OO ", "e" => "O. ", "f" => "OO ", "g" => "OO ", "h" => "O. ", "i" => ".O ", "j" => ".O ", "k" => "O. ", "l" => "O. ", "m" => "OO ", "n" => "OO ", "o" => "O. ", "p" => "OO ", "q" => "OO ", "r" => "O. ", "s" => ".O ", "t" => ".O ", "u" => "O. ", "v" => "O. ", "w" => ".O ", "x" => "OO ", "y" => "OO ", "z" => "O. ", "." => ".. ", "," => ".. ", "?" => ".. ", "!" => ".. ", "'" => ".. ", "-" => ".. ", "#" => ".O ", "0" => ".O ", "1" => "O. ", "2" => "O. ", "3" => "OO ", "4" => "OO ", "5" => "O. ", "6" => "OO ", "7" => "OO ", "8" => "O. ", "9" => ".O ", " " => "  "}
# b_mid = {"a" => ".. ", "b" => "O. ", "c" => ".. ", "d" => ".O ", "e" => ".O ", "f" => "O. ", "g" => "OO ", "h" => "OO ", "i" => "O. ", "j" => "OO ", "k" => ".. ", "l" => "O. ", "m" => ".. ", "n" => ".O ", "o" => ".O ", "p" => "O. ", "q" => "OO ", "r" => "OO ", "s" => "O. ", "t" => "OO ", "u" => ".. ", "v" => "O. ", "w" => "OO ", "x" => ".. ", "y" => ".O ", "z" => ".O ", "." => "OO ", "," => "O. ", "?" => "O. ", "!" => "OO ", "'" => ".. ", "-" => ".. ", "#" => ".O ", "0" => "OO ", "1" => ".. ", "2" => "O. ", "3" => ".. ", "4" => ".O ", "5" => ".O ", "6" => "O. ", "7" => "OO ", "8" => "OO ", "9" => "O. ", " " => "  "}
# b_bot = {"a" => ".. ", "b" => ".. ", "c" => ".. ", "d" => ".. ", "e" => ".. ", "f" => ".. ", "g" => ".. ", "h" => ".. ", "i" => ".. ", "j" => ".. ", "k" => "O. ", "l" => "O. ", "m" => "O. ", "n" => "O. ", "o" => "O. ", "p" => "O. ", "q" => "O. ", "r" => "O. ", "s" => "O. ", "t" => "O. ", "u" => "OO ", "v" => "OO ", "w" => ".O ", "x" => "OO ", "y" => "OO ", "z" => "OO ", "." => ".O ", "," => ".. ", "?" => "OO ", "!" => "O. ", "'" => "O. ", "-" => "OO ", "#" => "OO ", "0" => ".. ", "1" => ".. ", "2" => ".. ", "3" => ".. ", "4" => ".. ", "5" => ".. ", "6" => ".. ", "7" => ".. ", "8" => ".. ", "9" => ".. ", " " => "  "}  

# puts "Enter a message to be translated into braille:"
# user_input = gets.chomp.downcase
# puts "Your message in braille is: "

# (0..user_input.length).each do |letter|
#     print b_top[user_input[letter]]
# end
# print "\n"
# (0..user_input.length).each do |letter|
#     print b_mid[user_input[letter]]
# end
# print "\n"
# (0..user_input.length).each do |letter|
#     print b_bot[user_input[letter]]
# end


#Solution3
b_hash = {"a"=> "*-----", "b" => "*-*---", "c" => "**----", "d" => "**-*--", "e" => "*--*--", "f" => "***---", "g" => "****--", "h" => "*-**--", "i" => "-**---", "j" => "-***--", "k" => "*----*-", "l" => "*-*-*-", "m" => "**--*-", "n" => "**-**-", "o" => "*--**-", "p" => "***-*-", "q" => "*****-", "r" => "*-***-", "s" => "-**-*-", "t" => "-****-", "u" => "*---**", "v" => "*-*-**", "w" => "-***-*", "x" => "**--**", "y" => "**-***", "z" => "*--***", " " => "      "}

puts "Enter a message to be translated into braille (only accepts alphabet and spaces)"
input = gets.chomp.downcase

puts "Your message in braille is: "
input.each_char do |letter|
    print (b_hash[letter])[0..1] + " "
end
print "\n"
input.each_char do |letter|
    print (b_hash[letter])[2..3] + " "
end
print "\n"
input.each_char do |letter|
    print (b_hash[letter])[4..5] + " "
end
