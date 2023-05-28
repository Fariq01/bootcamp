using System;
using System.Collections.Generic;
namespace ver0Class;

    public class ver0
    {
        Dictionary<int, string> kamus = new Dictionary<int, string>
        {
            {3,  "foo"},
            {5,  "bar"},
            {7,  "soy"},
        };

        public string DictionaryMethod(int angka, Dictionary<int, string> kamus)
        {

            string hasil = "";

            foreach (var kvp in kamus)
            {
                if(angka % kvp.Key == 0)
                {
                    hasil += kvp.Value;
                }
              
            }

              
            if(string.IsNullOrEmpty(hasil))
            {
                hasil = angka.ToString();
            }

            return hasil;
        }



        public string checkSingleNumber(int angka)
        {
       
            string output = "";
            string hasil = "";

            foreach (var kvp in kamus)
            {
                if(angka % kvp.Key == 0)
                {
                    hasil = kvp.Value;
                    output = angka + " is in the dictionary, " + hasil;
                }
               
            }

            if(hasil == "")
            {
                hasil = angka + " is not in the dictionary";
                Console.Write(hasil);
            }

            return hasil;

        }

        public string checkSMultipleNumber(string angka)
        {
            string hasil = "";
            string[] angkaArr = angka.Split(new char[] {' ', ','});
          

            foreach(string i in angkaArr)
            {
                    int angkaInt = Convert.ToInt32(i);
            
                    foreach(var kvp in kamus)
                    {
                        if(angkaInt % kvp.Key == 0)
                        {
                            hasil += angkaInt + " is in the dictionary, " + kvp.Value;
                   
                        }
                    }
            }

            // Console.Write(hasil);

            return hasil;

        }

        public string calculate(int angka)
        {
            string hasil = "";
            for(int i = 1; i <= angka; i++)
            {

                hasil += DictionaryMethod(i, kamus);

                if(i < angka)
                {
                    hasil += ", ";
                } 
              
            }

            return hasil;
        }




    }
