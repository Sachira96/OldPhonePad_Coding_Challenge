namespace OldPhonePad_Coding_Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Showing user the message to enter their input
            Console.WriteLine("Enter your character input: ");

            // Reading the user input
            string? input = Console.ReadLine();

            // Checking the user input has valid values or not
            if (!String.IsNullOrWhiteSpace(input))
            {
                // Calling the 'OldPhonePad' method to get the output values
                string output = OldPhonePad(input);

                // Checking whether the output has readable words or not
                if (String.IsNullOrWhiteSpace(output))
                {
                    // Loop the application until there is a readable output
                    Console.WriteLine("Empty or Unreadable Output. Please Try Again!");
                    Main(args);
                }
                else
                {
                    // Writing the ouput value in the Console
                    Console.WriteLine(output);
                }
            }

            // Wait until user press a keyboard button to close the application
            Console.ReadKey();
        }

        // Implementing the 'OldPhonePad' method
        public static String OldPhonePad(string input)
        {
            // Assigning the output variable
            string output = "";

            // Check whether the input is empty or not
            if (!String.IsNullOrWhiteSpace(input)) 
            {
                // Seperating the input by '#'(hashtag) character to get multiple lines
                foreach (string line in input.Split('#'))
                {
                    // Seperating the letters with the 1 second timer assuming 1 second timer comes as a ' '(space) character
                    foreach (string letters in line.Split(' '))
                    {
                        // Assiging the letter variable to check and get the right output value
                        string letter = "";

                        // Going through each character of the letters array to decode the output
                        for (int i = 0; i < letters.Length; i++)
                        {
                            // Check whether it is the first character or not
                            if (i == 0)
                            {
                                if (letters.Length > 1)
                                {
                                    // Check whether the character is a digit or not and ignore any other character
                                    if (Char.IsDigit(letters[i]))
                                    {
                                        // Assigning the first character of the letters array to letter string
                                        letter = letters[i].ToString();
                                    }
                                    // Check whether the character is '*'(star) to determine whether to delete the last character or not
                                    else if (letters[i] == '*')
                                    {
                                        // Assigng empty value to letter string to showcase backspace input
                                        letter = "";
                                    }
                                }
                                else
                                {
                                    // Check whether the character is a digit or not and ignore any other character
                                    if (Char.IsDigit(letters[i]))
                                    {
                                        // Assigning the first character of the letters array to letter string
                                        letter = letters[i].ToString();
                                    }
                                    // Check whether the character is '*'(star) to determine whether to delete the last character or not
                                    else if (letters[i] == '*')
                                    {
                                        // Assigng empty value to letter string to showcase backspace input
                                        letter = "";
                                    }

                                    // Updating output values with the Decoded letter or space by calling the 'DecodeLetterOutput' method
                                    output += DecodeLetterOutput(letter);
                                }
                            }
                            // Check whether it is the last character or not
                            else if (i == letters.Length - 1)
                            {
                                // Check whether the character is a digit or not and ignore any other character
                                if (Char.IsDigit(letters[i]))
                                {
                                    // Checking whether the letter string has values or not
                                    if (String.IsNullOrWhiteSpace(letter))
                                    {
                                        // Assigning the first character of the letters array to letter string
                                        letter = letters[i].ToString();
                                    }
                                    // Checking whether the letters character and the letter string has the same digits or not
                                    else if (letter[^1] == letters[i])
                                    {
                                        // Updating letter string with multiple clicks
                                        letter += letters[i].ToString();
                                    }
                                    else
                                    {
                                        // Updating output values with the Decoded letter or space by calling the 'DecodeLetterOutput' method
                                        output += DecodeLetterOutput(letter);

                                        // Assigning the new letters array character to letter string
                                        letter = letters[i].ToString();
                                    }
                                }
                                // Check whether the character is '*'(star) to determine whether to delete the last character or not
                                else if (letters[i] == '*')
                                {
                                    // Assigng empty value to letter string to showcase backspace input
                                    letter = "";
                                }

                                // Updating output values with the Decoded letter or space by calling the 'DecodeLetterOutput' method
                                output += DecodeLetterOutput(letter);
                            }
                            else
                            {
                                // Check whether the character is a digit or not and ignore any other character
                                if (Char.IsDigit(letters[i]))
                                {
                                    // Checking whether the letter string has values or not
                                    if (String.IsNullOrWhiteSpace(letter))
                                    {
                                        // Assigning the first character of the letters array to letter string
                                        letter = letters[i].ToString();
                                    }
                                    // Checking whether the letters character and the letter string has the same digits or not
                                    else if (letter[^1] == letters[i])
                                    {
                                        // Updating letter string with multiple clicks
                                        letter += letters[i].ToString();
                                    }
                                    else
                                    {
                                        // Updating output values with the Decoded letter or space by calling the 'DecodeLetterOutput' method
                                        output += DecodeLetterOutput(letter);

                                        // Assigning the new letters array character to letter string
                                        letter = letters[i].ToString();
                                    }
                                }
                                // Check whether the character is '*'(star) to determine whether to delete the last character or not
                                else if (letters[i] == '*')
                                {
                                    // Assigng empty value to letter string to showcase backspace input
                                    letter = "";
                                }
                            }
                        }
                    }
                }
            }

            // Returning the output variable
            return output;
        }

        // Implementing 'DecodeLetterOutput method to decode the input letter output
        private static String DecodeLetterOutput(string letter)
        {
            // Assigning output variable
            string output = "";

            // Checking the parameter letter has any values
            if (!String.IsNullOrWhiteSpace(letter)) 
            {
                // Checking what digit the parameter input has
                char digit = letter[0];

                // Below are the if else statements to determine how to decode the digits into readable letters and spaces
                if (digit == '0')
                {
                    for (int i = 0; i < letter.Length; i++) 
                    {
                        output += " ";
                    }
                }
                else if (digit == '1')
                {
                    if (letter.Length == 1)
                    {
                        output += "&";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "’";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "(";
                    }
                }
                else if (digit == '2')
                {
                    if (letter.Length == 1)
                    {
                        output += "A";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "B";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "C";
                    }
                }
                else if (digit == '3')
                {
                    if (letter.Length == 1)
                    {
                        output += "D";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "E";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "F";
                    }
                }
                else if (digit == '4')
                {
                    if (letter.Length == 1)
                    {
                        output += "G";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "H";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "I";
                    }
                }
                else if (digit == '5')
                {
                    if (letter.Length == 1)
                    {
                        output += "J";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "K";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "L";
                    }
                }
                else if (digit == '6')
                {
                    if (letter.Length == 1)
                    {
                        output += "M";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "N";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "O";
                    }
                }
                else if (digit == '7')
                {
                    if (letter.Length == 1)
                    {
                        output += "P";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "Q";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "R";
                    }
                    else if (letter.Length == 4)
                    {
                        output += "S";
                    }
                }
                else if (digit == '8')
                {
                    if (letter.Length == 1)
                    {
                        output += "T";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "U";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "V";
                    }
                }
                else if (digit == '9')
                {
                    if (letter.Length == 1)
                    {
                        output += "W";
                    }
                    else if (letter.Length == 2)
                    {
                        output += "X";
                    }
                    else if (letter.Length == 3)
                    {
                        output += "Y";
                    }
                    else if (letter.Length == 4)
                    {
                        output += "Z";
                    }
                }
            }

            // returning output variable
            return output;
        }
    }
}
