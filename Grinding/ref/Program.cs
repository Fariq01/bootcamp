using refClass;

static class program
{
    static void Main()
    {
        //// gk pake ref tetep nilainya karena pake object yg tipenya reference
        // string juga bakal kek gitu

        // person person1 = new();
        // Console.WriteLine(person1.umur + " " + person1.nama);

        // person1.identity(person1);
        // Console.WriteLine(person1.umur + " " + person1.nama);

        // person person2 = new();
        // Console.WriteLine(person2.umur + " " + person2.nama);

        // person1.identity2(ref person2);
        // Console.WriteLine(person2.umur + " " + person2.nama);

        int umur = 20;
        Console.WriteLine(umur);
        identitas(umur);
        Console.WriteLine(umur);

        identitas2(ref umur);
        Console.WriteLine(umur);
        
    }

    static void identitas(int umur)
    {
        umur = 100;
    }

    static void identitas2(ref int umur)
    {
        umur = 100;
    }
}