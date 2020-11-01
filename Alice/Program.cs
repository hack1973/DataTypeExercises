using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {  
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string lowerSentence = sentence.ToLower();
            string searchTerm;
            string lowerSearchTerm;
            Boolean isFound;
            int index;
            string newSentence;


            Console.WriteLine("What word you like to search for in the first sentence of the 'Alice in Wonderland' book:");
            searchTerm = Console.ReadLine();

            Console.WriteLine("\nThe first sentence of 'Alice in Wonderland' book is:");
            Console.WriteLine(sentence);

            lowerSearchTerm = searchTerm.ToLower();
            isFound = lowerSentence.Contains(lowerSearchTerm);
            index = lowerSentence.IndexOf(lowerSearchTerm);

            Console.WriteLine("\nWas the search term '" + searchTerm + "' found in the first sentence of the book(True or False): " + isFound);
            if (isFound)
            {                
                Console.WriteLine("The index of the search term '" + searchTerm + "' in the sentence is: " + index);
                Console.WriteLine("The length of the search term '" + searchTerm + "' is: " + searchTerm.Length);

                string sentence0;
                string sentence1;
                sentence1 = sentence.Substring(index + searchTerm.Length, sentence.Length - (index + searchTerm.Length));
                Console.WriteLine("\nThe new sentence with the search term removed is:");

                if (index == 0)
                {
                    Console.WriteLine(sentence1);//
                }
                else
                {
                    sentence0 = sentence.Substring(0, index).Trim();
                    Console.WriteLine(sentence0 + sentence1);
                }
            }
            
            
            


            


        }
    }
}
