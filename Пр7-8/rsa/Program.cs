using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

string Main(string toEncrypt)
    {
        var publicKey = System.IO.File.ReadAllText("./publick_key.xml");
        var privateKey = System.IO.File.ReadAllText("./privat_key.xml");
        var testData = Encoding.UTF8.GetBytes(toEncrypt);

        using (var rsa = new RSACryptoServiceProvider(1024))
        {

            try
            {
                rsa.FromXmlString(publicKey);
                var encryptedData = rsa.Encrypt(testData, true);
                var base64Encrypted = Convert.ToBase64String(encryptedData);
                rsa.PersistKeyInCsp = false;
                return base64Encrypted;
            }
            finally
            {
                Console.WriteLine(' ');
            }
        }
    }

string Decryption(string toDecrypt)
{
    var publicKey = System.IO.File.ReadAllText("./publick_key.xml");
    var privateKey = System.IO.File.ReadAllText("./privat_key.xml");
    var testData = Encoding.UTF8.GetBytes(toDecrypt);

    using (var rsa = new RSACryptoServiceProvider(1024))
    {

        try
        {
            rsa.FromXmlString(privateKey);
            var resultBytes = Convert.FromBase64String(toDecrypt);
            var decryptedBytes = rsa.Decrypt(resultBytes, true);
            var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
            Debug.WriteLine(decryptedData);
            rsa.PersistKeyInCsp = false;
            return decryptedData;
        }
        finally
        {
            Console.WriteLine(' ');
        }
    }
}



string enc = "Text to encrypt";
var dec = Main(enc);
Console.WriteLine(Main(enc));
Console.WriteLine(Decryption(dec));