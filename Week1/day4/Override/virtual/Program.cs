/////////// Polymorph : OVERLOAD & OVERRIDE

using animalClass;
using birdClass;
using tigerClass;
//OVERLOAD



static class Program {

	static void Main() 
    {
        // buat object class tiger dari animal

        // animal tiger2 = new tiger(4, "surface");
        // tiger2.dataOfAnimal();

        tiger tiger1 = new tiger(4, 4);
        tiger1.dataOfTiger();

        

        Console.WriteLine();

        bird bird1 = new bird("long", "long");
        bird1.dataOfAnimal(4, "sky");



        //contoh 'new' method dari parent class


        // tiger1.walk();

        //membuat object parent class di assign child class
        animal animal1 = new tiger(3,4);

        // menggunakan new, method yg akan dipanggil yg dari parent class
        animal1.walk();

        // menggunakan override, method akan yg dipanggil yg dari child class
        animal1.sleep();

        
    }
}