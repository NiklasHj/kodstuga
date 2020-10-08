﻿using System;

namespace ReverseRot2
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";
            //Läs in en  rad från användaren
            var input = Console.ReadLine();
            //2.Kontrollera kraven på input.
            //3.Separera talet från meddelandet.
            var words = input.Split(' ');
            var rotation = Convert.ToInt32(words[0]);
            var message = words[1];
            //4.Gå igenom alla bokstäver i meddelandet.

            var result = "";

            for (int i = 0; i < message.Length; i++)
            {
                //4a.Leta upp vardera tecken i Alfabetet
                var letter = message.ToCharArray()[i];
                var indexOfLetter = alphabet.IndexOf(letter);
                //4b.stega framåt i alfabetet så många steg som är angivet.
                var newIndex = indexOfLetter + rotation;
                if(newIndex > 27)
                {
                    newIndex = newIndex - 28;
                }
                var newLetter = alphabet.ToCharArray()[newIndex];
                //4c.Spara i ett resultat
                result += newLetter;
            }

            //5.Vänd på resultatet.
            var reverseWord = ReverseString(result);

            Console.WriteLine(reverseWord);
        }

        private static string ReverseString(string result)
        {
            var restulArr = result.ToCharArray();
            Array.Reverse(restulArr);
            return new string(restulArr);
        }
    }
}
