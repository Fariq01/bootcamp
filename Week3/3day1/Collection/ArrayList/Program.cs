using System;
using System.Collections;
using ArrListC;

class Program
{
    static void Main()
    {
        Fruits fruits1 = new();
        // ArrListClass[] fruitsss = {fruits};

        Console.Write("Masukan jumlah buah yg akan diinputkan : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Masukan buah : ");
            string input = Console.ReadLine();
            fruits1.addFruits(input);
        }


        Console.Write("Masukan buah yang akan dibuang : ");
        string delete = Console.ReadLine();
        fruits1.deleteFruits(delete);
        fruits1.show();
    }
}


