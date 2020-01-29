using Converter.Models;
using System;
using System.Linq;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // string unicodeString = "This string contains the unicode character Pi (\u03a0)";

            Console.WriteLine("****************************ASCII to Binary************************");

            Console.WriteLine("Enter Your Name Please:");
            String HexaCoding = Console.ReadLine();



            BinaryConverter binaryConverter = new BinaryConverter();
            string binaryValue = binaryConverter.ConvertTo(HexaCoding);
            Console.WriteLine($"{HexaCoding} as Binary: {binaryValue}");

            Console.WriteLine("****************************Binary to ASCII************************");

            Console.WriteLine("Enter binary version of your name");
            String binary = Console.ReadLine();
            Console.WriteLine($"{binary} from Binary to ASCII: {binaryConverter.ConvertBinaryToString(binary)}");




            Console.WriteLine("****************************ASCII to Hexa Decimal************************");

            Console.WriteLine("This is for Hexa.../n Enter Your Name Please:");
            String hexaCoding = Console.ReadLine();

            HexadecimalConverter hexadecimalConverter = new HexadecimalConverter();
            string hexValue = hexadecimalConverter.ConvertTo(HexaCoding);
            Console.WriteLine($"{HexaCoding} as Hexa: {hexValue}");


            Console.WriteLine("****************************Hexa Decimal to ASCII************************");
            Console.WriteLine("Enter Hexa Decimal version of your name");
            String hexa = Console.ReadLine();
            Console.WriteLine($"{hexa} from Hexa Decimal to ASCII: {hexadecimalConverter.ConveryFromHexToASCII(hexa)}");





            int[] cipher = new[] { 1, 1, 2, 3, 5, 8, 13 }; //Fibonacci Sequence
            string cipherasString = String.Join(",", cipher.Select(x => x.ToString())); //FOr display

            int encryptionDepth = 20;

            Encrypter encrypter = new Encrypter(HexaCoding, cipher, encryptionDepth);



            Console.WriteLine("****************************ASCII to Base64************************");
            Console.WriteLine($"Base64 encoded {HexaCoding} {encrypter.Base64}");

            Console.WriteLine("****************************Base64 to ASCII************************");
            string base64toPlainText = Encrypter.Base64ToString(encrypter.Base64);
            Console.WriteLine($"Base64 decoded {encrypter.Base64} {base64toPlainText}");



            //Single Level Encrytion
            //string nameEncryptWithCipher = Encrypter.EncryptWithCipher(HexaCoding, cipher);
            //Console.WriteLine($"Encrypted once using the cipher {{{cipherasString}}} {nameEncryptWithCipher}");

            //string nameDecryptWithCipher = Encrypter.DecryptWithCipher(nameEncryptWithCipher, cipher);
            //Console.WriteLine($"Decrypted once using the cipher {{{cipherasString}}} {nameDecryptWithCipher}");

            //Deep Encrytion with encryptionDepth 20
            string nameDeepEncryptWithCipher = Encrypter.DeepEncryptWithCipher(HexaCoding, cipher, encryptionDepth);
            Console.WriteLine($"Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepEncryptWithCipher}");

            string nameDeepDecryptWithCipher = Encrypter.DeepDecryptWithCipher(nameDeepEncryptWithCipher, cipher, encryptionDepth);
            Console.WriteLine($"Deep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepDecryptWithCipher}");


        }
    }
}
