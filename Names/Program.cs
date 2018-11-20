using System;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[] {"Gianluca", "Nicoletta", "Andrea", "Luca", "Federico", "Fabio", "Matteo", "Alessio", "Stefano", "Cristian","Valerio","Francesco"};
            String[] empty = new string[] {"","","","","","","","","","","",""};

            Random random = new Random();

            /*for(int i=0; i<names.Length; ++i) {
                Console.WriteLine(names);
            } */
        int flag = 0;
        int rand;
            while (flag < names.Length) {
                rand = random.Next(0,11);
                if(empty[rand] == "") {
                    empty[rand]=names[flag];
                    ++flag;
                } 
            }
            for(int i=0; i<names.Length; ++i) {
                Console.Write(empty[i]+" e "+empty[i+1]);
                ++i;
            }  
        }
    }
}