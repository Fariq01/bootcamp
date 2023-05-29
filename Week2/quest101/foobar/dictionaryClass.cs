using System;
using System.Collections.Generic;
namespace dictiClass;

    public class dictionaryClass
    {
        public Dictionary<int, string> kamus = new Dictionary<int, string>
        {
            {3,  "foo"},
            {5,  "bar"},
            {7,  "soy"},
        };

        public void addDictionary(int angka, string value)
        {
            kamus.Add(angka, value);
        }

        public void deleteDictionary(int angka)
        {
            if(kamus.ContainsKey(angka))
            {
               kamus.Remove(angka);
               Console.WriteLine(kamus[angka] + " has been removed ");
            
            }else
            {
                Console.WriteLine(angka + " is not in the dictioanry ");
            }
       
        }

        public void updateDictionary(int angka, string value)
        {

            string earlyValue = "";
            string lastValue = "";

            if(kamus.ContainsKey(angka))
            {
                    earlyValue = kamus[angka];

                    kamus[angka] = value;
                    lastValue = kamus[angka];

                    Console.WriteLine(earlyValue + " from " + angka + " has been changed to " + lastValue);
            }else
            {
                Console.WriteLine(angka + " is not in the dictionary");
            }
            
        }

        public void checkAllDictionary()
        {

            string listDicti = "";

            foreach(var kvp in kamus)
            {
                listDicti += "key : " + kvp.Key + " value : " + kvp.Value + ", ";
              
            }
           
            Console.WriteLine(listDicti);

        }
    

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

                }
                else
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
