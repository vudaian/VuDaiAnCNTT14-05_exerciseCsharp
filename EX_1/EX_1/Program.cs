using System;
namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ky tu can kiem tra: ");
            char check = (char)Console.Read();
            if ((check >= 97 && check <= 122) || (check >= 65 && check <= 90))
            {
                Console.WriteLine($"{check} la chu cai");
            }
            else Console.WriteLine($"{check} khong la chu cai");
        }
    }
}
