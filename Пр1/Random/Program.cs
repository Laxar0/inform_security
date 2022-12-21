// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;
Console.WriteLine("Hello, World!");
Random random = new Random(124);
Console.WriteLine(random.Next(1, 100));
Console.WriteLine(random.Next(1, 100));
Console.WriteLine(random.Next(1, 100));
Console.WriteLine(random.Next(1, 100));
Console.WriteLine(random.Next(1, 100));
Console.WriteLine(random.Next(1, 100));
Console.WriteLine(random.Next(1, 100));



Console.WriteLine("\n\n\n\n");



var NumberGenerator = new RNGCryptoServiceProvider();
byte[] randomNumber = new byte[4];

for (int i = 0; i < 10; i++)
{
    NumberGenerator.GetBytes(randomNumber);
    int value = BitConverter.ToInt32(randomNumber, 0);
    Console.WriteLine(value);
}
