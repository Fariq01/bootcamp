﻿/////////// Polymorph : OVERLOAD & OVERRIDE

using birdClass;
using animalClass;
using tigerClass;
//OVERLOAD



class Program {

	static void Main() 
    {
        // buat object class tiger dari animal

        // animal tiger2 = new tiger(4, "surface");
        // tiger2.dataOfAnimal();

        tiger tiger1 = new tiger(4, 4);
        tiger1.dataOfTiger();

        bird bird1 = new bird("long", "long");
        bird1.dataOfAnimal(4, "sky");
        
    }
}