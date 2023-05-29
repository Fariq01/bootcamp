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
            fruits1.AddFruits(input);
        }

        Console.Write("Update Buah : ");
        string oldFruit = Console.ReadLine();
        string newFruit = Console.ReadLine();
        fruits1.UpdateFruits(oldFruit, newFruit);


        Console.Write("Masukan buah yang akan dibuang : ");
        string delete = Console.ReadLine();
        fruits1.DeleteFruits(delete);

        Console.WriteLine("List Buah : ");
        List<string> listAllFruits = fruits1.GetFruits();
        foreach(string i in listAllFruits )
        {
            Console.WriteLine(i);
        }
    }
}


