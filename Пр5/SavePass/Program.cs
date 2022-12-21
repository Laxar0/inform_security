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

static byte[] enc(string data)
{
    return Encoding.UTF8.GetBytes(data);
}

Console.Write("Введіть логін: ");
string login = Console.ReadLine();
Console.Write("Введіть пароль: ");
string password = Console.ReadLine();

string data = password + login[0] + login[1] + login[2];

byte[] coded = ComputeMD5(enc(data));
byte[] coded1 = ComputeMD5(enc(password));

Console.WriteLine(Convert.ToBase64String(coded));
Console.WriteLine(Convert.ToBase64String(coded1));

byte[] forWrite = enc(login + " " + Convert.ToBase64String(coded));

File.WriteAllBytes("C:/Users/User/Desktop/Мои файлы/Лекции/2 курс/Основы кибербеза/Практические работы/Пр5/SavePass/file.dat", forWrite);