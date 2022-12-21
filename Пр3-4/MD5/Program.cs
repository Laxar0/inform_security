using System;
using System.Text;
using System.Security.Cryptography;
Console.WriteLine("Hello, World!");


static byte[] ComputeMD5(byte[] data)
{
    using (var md5 = MD5.Create())
    {
        return md5.ComputeHash(data);
    }
}

static byte[] ComputeSHA256(byte[] data)
{
    using (var sha256 = SHA256.Create())
    {
        return sha256.ComputeHash(data);
    }
}

static byte[] ComputeSHA384(byte[] data)
{
    using (var sha384 = SHA384.Create())
    {
        return sha384.ComputeHash(data);
    }
}


static byte[] ComputeSHA512(byte[] data)
{
    using (var sha512 = SHA512.Create())
    {
        return sha512.ComputeHash(data);
    }
}


static byte[] enc (string data)
{
    return Encoding.UTF8.GetBytes(data);
}

string strForHash = "12345678";
Console.WriteLine(Convert.ToBase64String(ComputeMD5(enc(strForHash))));
Console.WriteLine(Convert.ToBase64String(ComputeSHA256(enc(strForHash))));
Console.WriteLine(Convert.ToBase64String(ComputeSHA384(enc(strForHash))));
Console.WriteLine(Convert.ToBase64String(ComputeSHA512(enc(strForHash))));

Console.Write("Введіть логін: ");
string login = Console.ReadLine();
Console.Write("Введіть пароль: ");
string password = Console.ReadLine();

string data = password + login[0] + login[1] + login[2];

byte[] coded = ComputeMD5(enc(data));
byte[] coded1 = ComputeMD5(enc(password));

Console.WriteLine(Convert.ToBase64String(coded));