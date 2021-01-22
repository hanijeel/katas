loop_on = true
mailbox = []
message_ID = 0

while loop_on == true do
    puts "Welcome to the message box! Choose what you want to do: \n  (S)ave a message, (R)etrieve a message, (V)iew all messages, or (E)xit \n"
    answer = gets.chomp.upcase

    if answer == "S"
        puts "Enter a message you want to leave."
        message = gets.chomp
        puts "Your message is stored as message ID #{message_ID}."
        mailbox << message #same as mailbox[message_ID] = message
        message_ID += 1

    elsif answer == "R"
        puts "What is the ID of the message you want to retrieve?"
        answer = gets.chomp.to_i

        puts "Your message is: #{answer}."

    elsif answer == "V"
        puts "Here are all the existing messages: "
        mailbox.count.times do |i|
            puts "Message ID #{i} : #{mailbox[i]}"
        end

    elsif answer == "E"
        puts "Good Bye!"
        loop_on = false

    else
        puts "You did not choose a valid option. Try again?"

    end
end