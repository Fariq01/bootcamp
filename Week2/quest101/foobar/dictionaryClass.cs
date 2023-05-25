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

        public string calculate(int angka)
        {
            string hasil = "";
            for(int i = 1; i <= angka; i++)
            {
                hasil += DictionaryMethod(i, kamus);
            }

            return hasil;
        }


    }
