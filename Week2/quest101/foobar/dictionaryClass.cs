using System;
using System.Collections.Generic;
namespace dictiClass;

    public class dictionaryClass
    {
        Dictionary<int, string> kamus = new Dictionary<int, string>
        {
            {3,  "foo"},
            {5,  "bar"},
            {7,  "soy"},
        };
    

        public string DictionaryMethod(int angka, Dictionary<int, string> kamus)
        {

            foreach (var kvp in kamus)
            {
                if(angka % kvp.Key == 0)
                {

                   return angka + " is in the dictionary, " + kvp.Value + " ";

                }
            }

            return angka + " is not in the dictionary";
        }

        public string DictionaryMethod(Dictionary<int, string> kamus, int angka)
        {
            string hasil = "";

            foreach(var kvp in kamus)
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
            string hasil = DictionaryMethod(angka, kamus);

            return hasil;
        }

        public string checkSMultipleNumber(string angka)
        {
            string[] angkaArr = angka.Split(new char[] {' ', ','});
          
            string output = "";

            foreach(string i in angkaArr)
            {
                int angkaInt = Convert.ToInt32(i);
                string hasil = DictionaryMethod(angkaInt, kamus);
                    
                if(hasil.Contains("is in the dictionary"))
                {
                    output += hasil;

                }else
                {
                    output += hasil;
                }  

                if(angkaInt < angkaArr.Length)
                {
                    output += ", ";
                }

            }

            return output;

        }

        public string calculate(int angka)
        {
            string hasil = "";
            for(int i = 1; i <= angka; i++)
            {

                hasil += DictionaryMethod(kamus, i);

                if(i < angka)
                {
                    hasil += ", ";
                } 
              
            }

            return hasil;
        }




    }
