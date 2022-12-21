using System;
//using File;
using System.Security.Cryptography;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Что вы хотите сделать? 1 - закодировать файл, 2 - декодировать файл");
string choose = Console.ReadLine();
if (choose == "1")
{
    byte[] data = File.ReadAllBytes("C:/Users/User/Desktop/Мои файлы/Лекции/2 курс/Основы кибербеза/Практические работы/Пр2/En-de(code)/file.txt").ToArray();

    int l = data.Length;
    byte key = Convert.ToByte(l);
    byte[] encLen = new byte[l];
    for (int i = 0; i < l; i++)
    {
        encLen[i] = (byte)(data[i] ^ l);
    }
    File.WriteAllBytes("C:/Users/User/Desktop/Мои файлы/Лекции/2 курс/Основы кибербеза/Практические работы/Пр2/En-de(code)/file.dat", encLen);
}
else
{
    byte[] data = File.ReadAllBytes("C:/Users/User/Desktop/Мои файлы/Лекции/2 курс/Основы кибербеза/Практические работы/Пр2/En-de(code)/file.dat").ToArray();
    int l = data.Length;
    byte key = Convert.ToByte(l);
    byte[] encLen = new byte[l];
    for (int i = 0; i < l; i++)
    {
        encLen[i] = (byte)(data[i] ^ l);
    }
    File.WriteAllBytes("C:/Users/User/Desktop/Мои файлы/Лекции/2 курс/Основы кибербеза/Практические работы/Пр2/En-de(code)/file.txt", encLen);
}