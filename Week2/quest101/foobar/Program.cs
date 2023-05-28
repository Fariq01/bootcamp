
using dictiClass;


// int angka = Convert.ToInt32(Console.ReadLine());

dictionaryClass dict1 = new dictionaryClass();

// string hasil = dict1.calculate(angka);

// string checkSingle = dict1.checkSingleNumber(angka);

// Console.WriteLine(hasil);


string angka = Console.ReadLine();
string checkSMultiple =  dict1.checkSMultipleNumber(angka);

Console.Write(checkSMultiple);
