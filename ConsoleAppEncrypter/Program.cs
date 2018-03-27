using System;

namespace ConsoleAppEncrypter
{
    class TextEncripted
    {
        static void Main()
        {
            bool debug = true;

            string newText = Encrypter.Encrypt("xyz");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);

            if (debug)
                Console.ReadLine();
        }
    }
}

