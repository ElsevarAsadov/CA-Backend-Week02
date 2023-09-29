
using System;

class Program
{
    static void Main()
    {
        //2. 1 soz verilir. Bu sozu tersine ceviren alqoritm yazin. (Ters => sreT)

        string word = "word";
        char[] letters = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            letters[i] = word[word.Length - 1 - i];
            //also possible.
            //Console.Write(word[word.Length-1-i]);
        }

        for (int i = 0; i < letters.Length; i++)
        {
            Console.Write(letters[i]);
        }


    }
}

